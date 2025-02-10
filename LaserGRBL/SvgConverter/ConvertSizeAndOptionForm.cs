//Copyright (c) 2016-2021 Diego Settimi - https://github.com/arkypita/

// This program is free software; you can redistribute it and/or modify  it under the terms of the GPLv3 General Public License as published by  the Free Software Foundation; either version 3 of the License, or (at  your option) any later version.
// This program is distributed in the hope that it will be useful, but  WITHOUT ANY WARRANTY; without even the implied warranty of  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GPLv3  General Public License for more details.
// You should have received a copy of the GPLv3 General Public License  along with this program; if not, write to the Free Software  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307,  USA. using System;

using LaserGRBL.PSHelper;
using System;
using System.Drawing;
using System.Windows.Forms;
using LaserGRBL.RasterConverter;
using Svg;
using LaserGRBL.Icons;
using LaserGRBL.UserControls;

namespace LaserGRBL.SvgConverter
{
    /// <summary>
    /// Description of ConvertSizeAndOptionForm.
    /// </summary>
    public partial class SvgToGCodeForm : Form
    {
        GrblCore mCore;
        bool supportPWM = Settings.GetObject("Support Hardware PWM", true);

        public ComboboxItem[] LaserOptions = new ComboboxItem[] { new ComboboxItem("M3 - Constant Power", "M3"), new ComboboxItem("M4 - Dynamic Power", "M4") };

        public ComboboxItem[] FilterOptions = Array.ConvertAll(
            (ColorFilter[])Enum.GetValues(typeof(ColorFilter)),
            ColorFilterToItem
            );

        private static ComboboxItem ColorFilterToItem(ColorFilter filter)
        {
            return new ComboboxItem(filter.ToString(), filter);
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public ComboboxItem(string text, object value)
            { Text = text; Value = value; }

            public override string ToString()
            {
                return Text;
            }
        }

        internal static void CreateAndShowDialog(GrblCore core, string filename, bool append)
        {
            using (SvgToGCodeForm f = new SvgToGCodeForm(core, filename, append))
            {
                f.ShowDialogForm();
                if (f.DialogResult == DialogResult.OK)
                {
                    Settings.SetObject("GrayScaleConversion.VectorizeOptions.XSpeed", f.IIBorderTracingX.CurrentValue);
                    Settings.SetObject("GrayScaleConversion.VectorizeOptions.YSpeed", f.IIBorderTracingY.CurrentValue);
                    Settings.SetObject("GrayScaleConversion.Gcode.LaserOptions.PowerMaxX", f.IIMaxPowerX.CurrentValue);
                    Settings.SetObject("GrayScaleConversion.Gcode.LaserOptions.PowerMaxY", f.IIMaxPowerY.CurrentValue);
                    Settings.SetObject("GrayScaleConversion.Gcode.LaserOptions.LaserOn", (f.CBLaserON.SelectedItem as ComboboxItem).Value);

                    var selectedFilter = (ColorFilter)Enum.Parse(typeof(ColorFilter), (f.CBFilter.SelectedItem as ComboboxItem).Value.ToString());

                    core.LoadedFile.LoadImportedSVG(filename, append, core, selectedFilter);
                }
            }
        }

        private SvgToGCodeForm(GrblCore core, string filename, bool append)
        {
            InitializeComponent();
            ThemeMgr.SetTheme(this);
            IconsMgr.PrepareButton(BtnCreate, "mdi-checkbox-marked");
            IconsMgr.PrepareButton(BtnCancel, "mdi-close-box");
            IconsMgr.PrepareButton(BtnOnOffInfo, "mdi-information-slab-box", new Size(16, 16));
            IconsMgr.PrepareButton(BtnModulationInfo, "mdi-information-slab-box", new Size(16, 16));
            IconsMgr.PrepareButton(BtnPSHelper, "mdi-information-slab-box", new Size(16, 16));
            IconsMgr.PrepareButton(BtnColorFilter, "mdi-information-slab-box", new Size(16, 16));
            mCore = core;

            BackColor = ColorScheme.FormBackColor;
            GbLaser.ForeColor = GbSpeed.ForeColor = ForeColor = ColorScheme.FormForeColor;
            BtnCancel.BackColor = BtnCreate.BackColor = ColorScheme.FormButtonsColor;

            LblSmaxY.Visible = IIMaxPowerX.Visible = IIMaxPowerY.Visible = BtnModulationInfo.Visible = supportPWM;
            AssignMinMaxLimit();

            CBLaserON.Items.Add(LaserOptions[0]);
            CBLaserON.Items.Add(LaserOptions[1]);

            foreach (var filterOption in FilterOptions)
            {
                CBFilter.Items.Add(filterOption);
            }
        }

        private void AssignMinMaxLimit()
        {
            IIBorderTracingX.MaxValue = (int)GrblCore.Configuration.MaxRateX;
            IIBorderTracingY.MaxValue = (int)GrblCore.Configuration.MaxRateX;
            IIMaxPowerX.MaxValue = (int)GrblCore.Configuration.MaxPWM;
            IIMaxPowerY.MaxValue = (int)GrblCore.Configuration.MaxPWM;
        }

        public void ShowDialogForm()
        {
            IIBorderTracingX.CurrentValue = Settings.GetObject("GrayScaleConversion.VectorizeOptions.XSpeed", 1000);
            IIBorderTracingY.CurrentValue = Settings.GetObject("GrayScaleConversion.VectorizeOptions.YSpeed", 1000);

            string LaserOn = Settings.GetObject("GrayScaleConversion.Gcode.LaserOptions.LaserOn", "M3");

            if (LaserOn == "M3" || !GrblCore.Configuration.LaserMode)
                CBLaserON.SelectedItem = LaserOptions[0];
            else
                CBLaserON.SelectedItem = LaserOptions[1];

            CBFilter.SelectedItem = FilterOptions[0];

            string LaserOff = "M5"; //Settings.GetObject("GrayScaleConversion.Gcode.LaserOptions.LaserOff", "M5");

            IIMaxPowerX.CurrentValue = Settings.GetObject("GrayScaleConversion.Gcode.LaserOptions.PowerMaxX", (int)GrblCore.Configuration.MaxPWM);
            IIMaxPowerY.CurrentValue = Settings.GetObject("GrayScaleConversion.Gcode.LaserOptions.PowerMaxY", (int)GrblCore.Configuration.MaxPWM);

            IIBorderTracingX.Visible = IIBorderTracingY.Visible = LblBorderTracing.Visible = LblBorderTracingmm.Visible = true;

            RefreshPerc();

            ShowDialog(FormsHelper.MainForm);
        }


        void IIBorderTracingCurrentValueChanged(object sender, int OldValue, int NewValue, bool ByUser)
        {
            //IP.BorderSpeed = NewValue;
        }


        void IIMaxPowerCurrentValueChanged(object sender, int OldValue, int NewValue, bool ByUser)
        {
            RefreshPerc();
        }

        private void RefreshPerc()
        {
            decimal maxpwm = GrblCore.Configuration != null ? GrblCore.Configuration.MaxPWM : -1;

            if (maxpwm > 0)
            {
                LblMaxPerc.Text = (IIMaxPowerX.CurrentValue / GrblCore.Configuration.MaxPWM).ToString("P1")
                    + " / " + (IIMaxPowerY.CurrentValue / GrblCore.Configuration.MaxPWM).ToString("P1");
            }
            else
            {
                LblMaxPerc.Text = "";
            }
        }

        private void BtnOnOffInfo_Click(object sender, EventArgs e)
        { Tools.Utils.OpenLink(@"https://lasergrbl.com/usage/raster-image-import/target-image-size-and-laser-options/#laser-modes"); }

        private void BtnModulationInfo_Click(object sender, EventArgs e)
        { Tools.Utils.OpenLink(@"https://lasergrbl.com/usage/raster-image-import/target-image-size-and-laser-options/#power-modulation"); }

        private void CBLaserON_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem mode = CBLaserON.SelectedItem as ComboboxItem;

            if (mode != null)
            {
                if (!GrblCore.Configuration.LaserMode && (mode.Value as string) == "M4")
                    MessageBox.Show(Strings.WarnWrongLaserMode, Strings.WarnWrongLaserModeTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);//warning!!
            }

        }



        private void BtnPSHelper_Click(object sender, EventArgs e)
        {
            MaterialDB.MaterialsRow row = PSHelperForm.CreateAndShowDialog(this);
            if (row != null)
            {
                if (IIBorderTracingX.Visible)
                    IIBorderTracingX.CurrentValue = row.Speed;
                if (IIBorderTracingY.Visible)
                    IIBorderTracingY.CurrentValue = row.Speed;
                //if (IILinearFilling.Visible)
                //	IILinearFilling.CurrentValue = row.Speed;

                IIMaxPowerX.CurrentValue = IIMaxPowerX.MaxValue * row.Power / 100;
                IIMaxPowerY.CurrentValue = IIMaxPowerY.MaxValue * row.Power / 100;
            }
        }
        private void BtnColorFilter_Click(object sender, EventArgs e)
        { Tools.Utils.OpenLink(@"https://lasergrbl.com/usage/raster-image-import/target-image-size-and-laser-options/#color-filter"); }
        //private void IISizeW_OnTheFlyValueChanged(object sender, int OldValue, int NewValue, bool ByUser)
        //{
        //	if (ByUser)
        //		IISizeH.CurrentValue = IP.WidthToHeight(NewValue);
        //}

        //private void IISizeH_OnTheFlyValueChanged(object sender, int OldValue, int NewValue, bool ByUser)
        //{
        //	if (ByUser) IISizeW.CurrentValue = IP.HeightToWidht(NewValue);
        //}
    }
}
