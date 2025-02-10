/*
 * Created by SharpDevelop.
 * User: Diego
 * Date: 15/01/2017
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LaserGRBL.SvgConverter
{
	partial class SvgToGCodeForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private LaserGRBL.UserControls.GrblGroupBox GbSpeed;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Label LblBorderTracing;
		private LaserGRBL.UserControls.NumericInput.IntegerInputRanged IIBorderTracingY;
		private LaserGRBL.UserControls.GrblGroupBox GbLaser;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Label LblSmaxY;
		private LaserGRBL.UserControls.NumericInput.IntegerInputRanged IIMaxPowerY;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private LaserGRBL.UserControls.GrblButton BtnCreate;
		private LaserGRBL.UserControls.GrblButton BtnCancel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SvgToGCodeForm));
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.GbSpeed = new LaserGRBL.UserControls.GrblGroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.IIBorderTracingX = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.LblBorderTracing = new System.Windows.Forms.Label();
            this.LblBorderTracingmm = new System.Windows.Forms.Label();
            this.IIBorderTracingY = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.BtnPSHelper = new LaserGRBL.UserControls.ImageButton();
            this.GbLaser = new LaserGRBL.UserControls.GrblGroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSmaxX = new System.Windows.Forms.Label();
            this.BtnOnOffInfo = new LaserGRBL.UserControls.ImageButton();
            this.LblMaxPerc = new System.Windows.Forms.Label();
            this.IIMaxPowerX = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.LblSmaxY = new System.Windows.Forms.Label();
            this.IIMaxPowerY = new LaserGRBL.UserControls.NumericInput.IntegerInputRanged();
            this.label18 = new System.Windows.Forms.Label();
            this.CBLaserON = new LaserGRBL.UserControls.FlatComboBox();
            this.BtnModulationInfo = new LaserGRBL.UserControls.ImageButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancel = new LaserGRBL.UserControls.GrblButton();
            this.BtnCreate = new LaserGRBL.UserControls.GrblButton();
            this.gbFilter = new LaserGRBL.UserControls.GrblGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFilter = new System.Windows.Forms.Label();
            this.CBFilter = new LaserGRBL.UserControls.FlatComboBox();
            this.BtnColorFilter = new LaserGRBL.UserControls.ImageButton();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel9.SuspendLayout();
            this.GbSpeed.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.GbLaser.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.GbSpeed, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.GbLaser, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel1, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.gbFilter, 0, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // GbSpeed
            // 
            resources.ApplyResources(this.GbSpeed, "GbSpeed");
            this.GbSpeed.Controls.Add(this.tableLayoutPanel6);
            this.GbSpeed.Name = "GbSpeed";
            this.GbSpeed.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.IIBorderTracingX, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.LblBorderTracing, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.LblBorderTracingmm, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.IIBorderTracingY, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.BtnPSHelper, 5, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // IIBorderTracingX
            // 
            resources.ApplyResources(this.IIBorderTracingX, "IIBorderTracingX");
            this.IIBorderTracingX.CurrentValue = 1000;
            this.IIBorderTracingX.ForcedText = null;
            this.IIBorderTracingX.ForceMinMax = false;
            this.IIBorderTracingX.MaxValue = 4000;
            this.IIBorderTracingX.MinValue = 1;
            this.IIBorderTracingX.Name = "IIBorderTracingX";
            // 
            // LblBorderTracing
            // 
            resources.ApplyResources(this.LblBorderTracing, "LblBorderTracing");
            this.LblBorderTracing.Name = "LblBorderTracing";
            // 
            // LblBorderTracingmm
            // 
            resources.ApplyResources(this.LblBorderTracingmm, "LblBorderTracingmm");
            this.LblBorderTracingmm.Name = "LblBorderTracingmm";
            // 
            // IIBorderTracingY
            // 
            resources.ApplyResources(this.IIBorderTracingY, "IIBorderTracingY");
            this.IIBorderTracingY.CurrentValue = 1000;
            this.IIBorderTracingY.ForcedText = null;
            this.IIBorderTracingY.ForceMinMax = false;
            this.IIBorderTracingY.MaxValue = 4000;
            this.IIBorderTracingY.MinValue = 1;
            this.IIBorderTracingY.Name = "IIBorderTracingY";
            this.IIBorderTracingY.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.IIBorderTracingCurrentValueChanged);
            // 
            // BtnPSHelper
            // 
            this.BtnPSHelper.AltImage = null;
            resources.ApplyResources(this.BtnPSHelper, "BtnPSHelper");
            this.BtnPSHelper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPSHelper.Caption = null;
            this.BtnPSHelper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPSHelper.Image = ((System.Drawing.Image)(resources.GetObject("BtnPSHelper.Image")));
            this.BtnPSHelper.Name = "BtnPSHelper";
            this.BtnPSHelper.RoundedBorders = false;
            this.BtnPSHelper.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnPSHelper, resources.GetString("BtnPSHelper.ToolTip"));
            this.BtnPSHelper.UseAltImage = false;
            this.BtnPSHelper.Click += new System.EventHandler(this.BtnPSHelper_Click);
            // 
            // GbLaser
            // 
            resources.ApplyResources(this.GbLaser, "GbLaser");
            this.GbLaser.Controls.Add(this.tableLayoutPanel7);
            this.GbLaser.Name = "GbLaser";
            this.GbLaser.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.LblSmaxX, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.BtnOnOffInfo, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.LblMaxPerc, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.IIMaxPowerX, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.LblSmaxY, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.IIMaxPowerY, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.CBLaserON, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.BtnModulationInfo, 5, 1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // LblSmaxX
            // 
            resources.ApplyResources(this.LblSmaxX, "LblSmaxX");
            this.LblSmaxX.Name = "LblSmaxX";
            // 
            // BtnOnOffInfo
            // 
            this.BtnOnOffInfo.AltImage = null;
            resources.ApplyResources(this.BtnOnOffInfo, "BtnOnOffInfo");
            this.BtnOnOffInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnOnOffInfo.Caption = null;
            this.BtnOnOffInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOnOffInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnOnOffInfo.Image")));
            this.BtnOnOffInfo.Name = "BtnOnOffInfo";
            this.BtnOnOffInfo.RoundedBorders = false;
            this.BtnOnOffInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnOnOffInfo, resources.GetString("BtnOnOffInfo.ToolTip"));
            this.BtnOnOffInfo.UseAltImage = false;
            this.BtnOnOffInfo.Click += new System.EventHandler(this.BtnOnOffInfo_Click);
            // 
            // LblMaxPerc
            // 
            resources.ApplyResources(this.LblMaxPerc, "LblMaxPerc");
            this.LblMaxPerc.Name = "LblMaxPerc";
            // 
            // IIMaxPowerX
            // 
            resources.ApplyResources(this.IIMaxPowerX, "IIMaxPowerX");
            this.IIMaxPowerX.CurrentValue = 1000;
            this.IIMaxPowerX.ForcedText = null;
            this.IIMaxPowerX.ForceMinMax = false;
            this.IIMaxPowerX.MaxValue = 1000;
            this.IIMaxPowerX.MinValue = 1;
            this.IIMaxPowerX.Name = "IIMaxPowerX";
            this.IIMaxPowerX.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.IIMaxPowerCurrentValueChanged);
            // 
            // LblSmaxY
            // 
            resources.ApplyResources(this.LblSmaxY, "LblSmaxY");
            this.LblSmaxY.Name = "LblSmaxY";
            // 
            // IIMaxPowerY
            // 
            resources.ApplyResources(this.IIMaxPowerY, "IIMaxPowerY");
            this.IIMaxPowerY.CurrentValue = 1000;
            this.IIMaxPowerY.ForcedText = null;
            this.IIMaxPowerY.ForceMinMax = false;
            this.IIMaxPowerY.MaxValue = 1000;
            this.IIMaxPowerY.MinValue = 1;
            this.IIMaxPowerY.Name = "IIMaxPowerY";
            this.IIMaxPowerY.CurrentValueChanged += new LaserGRBL.UserControls.NumericInput.IntegerInputBase.CurrentValueChangedEventHandler(this.IIMaxPowerCurrentValueChanged);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // CBLaserON
            // 
            resources.ApplyResources(this.CBLaserON, "CBLaserON");
            this.CBLaserON.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel7.SetColumnSpan(this.CBLaserON, 3);
            this.CBLaserON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLaserON.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CBLaserON.FormattingEnabled = true;
            this.CBLaserON.Name = "CBLaserON";
            this.CBLaserON.SelectedIndexChanged += new System.EventHandler(this.CBLaserON_SelectedIndexChanged);
            // 
            // BtnModulationInfo
            // 
            this.BtnModulationInfo.AltImage = null;
            resources.ApplyResources(this.BtnModulationInfo, "BtnModulationInfo");
            this.BtnModulationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnModulationInfo.Caption = null;
            this.BtnModulationInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModulationInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnModulationInfo.Image")));
            this.BtnModulationInfo.Name = "BtnModulationInfo";
            this.BtnModulationInfo.RoundedBorders = false;
            this.BtnModulationInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnModulationInfo, resources.GetString("BtnModulationInfo.ToolTip"));
            this.BtnModulationInfo.UseAltImage = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.BtnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCreate, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            resources.ApplyResources(this.BtnCreate, "BtnCreate");
            this.BtnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // gbFilter
            // 
            resources.ApplyResources(this.gbFilter, "gbFilter");
            this.gbFilter.Controls.Add(this.tableLayoutPanel2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.labelFilter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CBFilter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnColorFilter, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // labelFilter
            // 
            resources.ApplyResources(this.labelFilter, "labelFilter");
            this.labelFilter.Name = "labelFilter";
            // 
            // CBFilter
            // 
            resources.ApplyResources(this.CBFilter, "CBFilter");
            this.CBFilter.BackColor = System.Drawing.Color.White;
            this.CBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilter.DropDownWidth = 195;
            this.CBFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Name = "CBFilter";
            // 
            // BtnColorFilter
            // 
            this.BtnColorFilter.AltImage = null;
            resources.ApplyResources(this.BtnColorFilter, "BtnColorFilter");
            this.BtnColorFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnColorFilter.Caption = null;
            this.BtnColorFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorFilter.Image = ((System.Drawing.Image)(resources.GetObject("BtnColorFilter.Image")));
            this.BtnColorFilter.Name = "BtnColorFilter";
            this.BtnColorFilter.RoundedBorders = false;
            this.BtnColorFilter.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnColorFilter, resources.GetString("BtnColorFilter.ToolTip"));
            this.BtnColorFilter.UseAltImage = false;
            this.BtnColorFilter.Click += new System.EventHandler(this.BtnColorFilter_Click);
            // 
            // TT
            // 
            this.TT.AutoPopDelay = 10000;
            this.TT.InitialDelay = 500;
            this.TT.ReshowDelay = 100;
            // 
            // SvgToGCodeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.Controls.Add(this.tableLayoutPanel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SvgToGCodeForm";
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.GbSpeed.ResumeLayout(false);
            this.GbSpeed.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.GbLaser.ResumeLayout(false);
            this.GbLaser.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private LaserGRBL.UserControls.FlatComboBox CBFilter;

		private System.Windows.Forms.Label labelFilter;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		private LaserGRBL.UserControls.GrblGroupBox gbFilter;
		private LaserGRBL.UserControls.ImageButton BtnOnOffInfo;
		private LaserGRBL.UserControls.FlatComboBox CBLaserON;
		private System.Windows.Forms.ToolTip TT;
		private System.Windows.Forms.Label LblBorderTracingmm;
		private LaserGRBL.UserControls.ImageButton BtnPSHelper;
		private System.Windows.Forms.Label LblMaxPerc;
		private UserControls.ImageButton BtnColorFilter;
        private System.Windows.Forms.Label label1;
        private UserControls.NumericInput.IntegerInputRanged IIBorderTracingX;
        private UserControls.NumericInput.IntegerInputRanged IIMaxPowerX;
        private System.Windows.Forms.Label LblSmaxX;
        private UserControls.ImageButton BtnModulationInfo;
    }
}
