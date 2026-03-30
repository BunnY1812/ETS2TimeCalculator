using System;
using System.Drawing;
using System.Windows.Forms;

namespace ETS2TimeCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.labelHours = new System.Windows.Forms.Label();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.panelMode = new System.Windows.Forms.Panel();
            this.radioETS2ToReal = new System.Windows.Forms.RadioButton();
            this.radioRealToETS2 = new System.Windows.Forms.RadioButton();
            this.checkBoxRealTime = new System.Windows.Forms.CheckBox();
            this.panelScale = new System.Windows.Forms.Panel();
            this.radioEU = new System.Windows.Forms.RadioButton();
            this.radioUK = new System.Windows.Forms.RadioButton();
            this.radioCities = new System.Windows.Forms.RadioButton();
            this.radioTruckersMP = new System.Windows.Forms.RadioButton();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.panelCustomScale = new System.Windows.Forms.Panel();
            this.labelCustomScaleInfo = new System.Windows.Forms.Label();
            this.numericCustomScale = new System.Windows.Forms.NumericUpDown();
            this.panelResult = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelRealTime = new System.Windows.Forms.Panel();
            this.panelRealTimeControls = new System.Windows.Forms.Panel();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelEndTimeCaption = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.labelResultCaption = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            this.panelMode.SuspendLayout();
            this.panelScale.SuspendLayout();
            this.panelCustomScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCustomScale)).BeginInit();
            this.panelResult.SuspendLayout();
            this.panelRealTime.SuspendLayout();
            this.panelRealTimeControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.labelTitle.Location = new System.Drawing.Point(20, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(480, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ETS2 TIME CALCULATOR";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.labelSubtitle.Location = new System.Drawing.Point(20, 65);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(480, 25);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Конвертер игрового времени Euro Truck Simulator 2";
            this.labelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelInput.Controls.Add(this.labelHours);
            this.panelInput.Controls.Add(this.numericHours);
            this.panelInput.Controls.Add(this.labelMinutes);
            this.panelInput.Controls.Add(this.numericMinutes);
            this.panelInput.Controls.Add(this.labelSeconds);
            this.panelInput.Controls.Add(this.numericSeconds);
            this.panelInput.Location = new System.Drawing.Point(20, 110);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(480, 100);
            this.panelInput.TabIndex = 2;
            // 
            // labelHours
            // 
            this.labelHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.labelHours.Location = new System.Drawing.Point(30, 15);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(120, 20);
            this.labelHours.TabIndex = 0;
            this.labelHours.Text = "ЧАСЫ";
            // 
            // numericHours
            // 
            this.numericHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.numericHours.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numericHours.ForeColor = System.Drawing.Color.White;
            this.numericHours.Location = new System.Drawing.Point(30, 38);
            this.numericHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(120, 32);
            this.numericHours.TabIndex = 1;
            this.numericHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericHours.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // labelMinutes
            // 
            this.labelMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelMinutes.Location = new System.Drawing.Point(180, 15);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(120, 20);
            this.labelMinutes.TabIndex = 2;
            this.labelMinutes.Text = "МИНУТЫ";
            // 
            // numericMinutes
            // 
            this.numericMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.numericMinutes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numericMinutes.ForeColor = System.Drawing.Color.White;
            this.numericMinutes.Location = new System.Drawing.Point(180, 38);
            this.numericMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(120, 32);
            this.numericMinutes.TabIndex = 3;
            this.numericMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericMinutes.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // labelSeconds
            // 
            this.labelSeconds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.labelSeconds.Location = new System.Drawing.Point(330, 15);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(120, 20);
            this.labelSeconds.TabIndex = 4;
            this.labelSeconds.Text = "СЕКУНДЫ";
            // 
            // numericSeconds
            // 
            this.numericSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.numericSeconds.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numericSeconds.ForeColor = System.Drawing.Color.White;
            this.numericSeconds.Location = new System.Drawing.Point(330, 38);
            this.numericSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericSeconds.Name = "numericSeconds";
            this.numericSeconds.Size = new System.Drawing.Size(120, 32);
            this.numericSeconds.TabIndex = 5;
            this.numericSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericSeconds.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // panelMode
            // 
            this.panelMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMode.Controls.Add(this.radioETS2ToReal);
            this.panelMode.Controls.Add(this.radioRealToETS2);
            this.panelMode.Controls.Add(this.checkBoxRealTime);
            this.panelMode.Location = new System.Drawing.Point(20, 225);
            this.panelMode.Name = "panelMode";
            this.panelMode.Size = new System.Drawing.Size(480, 80);
            this.panelMode.TabIndex = 3;
            // 
            // radioETS2ToReal
            // 
            this.radioETS2ToReal.BackColor = System.Drawing.Color.Transparent;
            this.radioETS2ToReal.Checked = true;
            this.radioETS2ToReal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radioETS2ToReal.ForeColor = System.Drawing.Color.White;
            this.radioETS2ToReal.Location = new System.Drawing.Point(30, 15);
            this.radioETS2ToReal.Name = "radioETS2ToReal";
            this.radioETS2ToReal.Size = new System.Drawing.Size(200, 30);
            this.radioETS2ToReal.TabIndex = 0;
            this.radioETS2ToReal.TabStop = true;
            this.radioETS2ToReal.Text = "ETS2 → РЕАЛЬНОЕ";
            this.radioETS2ToReal.UseVisualStyleBackColor = false;
            this.radioETS2ToReal.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // radioRealToETS2
            // 
            this.radioRealToETS2.BackColor = System.Drawing.Color.Transparent;
            this.radioRealToETS2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radioRealToETS2.ForeColor = System.Drawing.Color.White;
            this.radioRealToETS2.Location = new System.Drawing.Point(250, 15);
            this.radioRealToETS2.Name = "radioRealToETS2";
            this.radioRealToETS2.Size = new System.Drawing.Size(200, 30);
            this.radioRealToETS2.TabIndex = 1;
            this.radioRealToETS2.Text = "РЕАЛЬНОЕ → ETS2";
            this.radioRealToETS2.UseVisualStyleBackColor = false;
            this.radioRealToETS2.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // checkBoxRealTime
            // 
            this.checkBoxRealTime.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRealTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxRealTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.checkBoxRealTime.Location = new System.Drawing.Point(30, 50);
            this.checkBoxRealTime.Name = "checkBoxRealTime";
            this.checkBoxRealTime.Size = new System.Drawing.Size(400, 25);
            this.checkBoxRealTime.TabIndex = 2;
            this.checkBoxRealTime.Text = "Рассчитать реальное время окончания";
            this.checkBoxRealTime.UseVisualStyleBackColor = false;
            this.checkBoxRealTime.CheckedChanged += new System.EventHandler(this.CheckBoxRealTime_CheckedChanged);
            // 
            // panelScale
            // 
            this.panelScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelScale.Controls.Add(this.radioEU);
            this.panelScale.Controls.Add(this.radioUK);
            this.panelScale.Controls.Add(this.radioCities);
            this.panelScale.Controls.Add(this.radioTruckersMP);
            this.panelScale.Controls.Add(this.radioCustom);
            this.panelScale.Controls.Add(this.panelCustomScale);
            this.panelScale.Location = new System.Drawing.Point(20, 430);
            this.panelScale.Name = "panelScale";
            this.panelScale.Size = new System.Drawing.Size(480, 180);
            this.panelScale.TabIndex = 5;
            // 
            // radioEU
            // 
            this.radioEU.BackColor = System.Drawing.Color.Transparent;
            this.radioEU.Checked = true;
            this.radioEU.ForeColor = System.Drawing.Color.White;
            this.radioEU.Location = new System.Drawing.Point(20, 15);
            this.radioEU.Name = "radioEU";
            this.radioEU.Size = new System.Drawing.Size(220, 28);
            this.radioEU.TabIndex = 0;
            this.radioEU.TabStop = true;
            this.radioEU.Text = "Европа (не город): 1 сек → 19 сек";
            this.radioEU.UseVisualStyleBackColor = false;
            this.radioEU.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // radioUK
            // 
            this.radioUK.BackColor = System.Drawing.Color.Transparent;
            this.radioUK.ForeColor = System.Drawing.Color.White;
            this.radioUK.Location = new System.Drawing.Point(20, 48);
            this.radioUK.Name = "radioUK";
            this.radioUK.Size = new System.Drawing.Size(250, 28);
            this.radioUK.TabIndex = 1;
            this.radioUK.Text = "Великобритания (не город): 1 сек → 15 сек";
            this.radioUK.UseVisualStyleBackColor = false;
            this.radioUK.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // radioCities
            // 
            this.radioCities.BackColor = System.Drawing.Color.Transparent;
            this.radioCities.ForeColor = System.Drawing.Color.White;
            this.radioCities.Location = new System.Drawing.Point(20, 81);
            this.radioCities.Name = "radioCities";
            this.radioCities.Size = new System.Drawing.Size(250, 28);
            this.radioCities.TabIndex = 2;
            this.radioCities.Text = "Города, депо, стоянки: 1 сек → 3 сек";
            this.radioCities.UseVisualStyleBackColor = false;
            this.radioCities.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // radioTruckersMP
            // 
            this.radioTruckersMP.BackColor = System.Drawing.Color.Transparent;
            this.radioTruckersMP.ForeColor = System.Drawing.Color.White;
            this.radioTruckersMP.Location = new System.Drawing.Point(20, 114);
            this.radioTruckersMP.Name = "radioTruckersMP";
            this.radioTruckersMP.Size = new System.Drawing.Size(250, 28);
            this.radioTruckersMP.TabIndex = 3;
            this.radioTruckersMP.Text = "TruckersMP (мультиплеер): 1 сек → 6 сек";
            this.radioTruckersMP.UseVisualStyleBackColor = false;
            this.radioTruckersMP.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // radioCustom
            // 
            this.radioCustom.BackColor = System.Drawing.Color.Transparent;
            this.radioCustom.ForeColor = System.Drawing.Color.White;
            this.radioCustom.Location = new System.Drawing.Point(280, 15);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(120, 28);
            this.radioCustom.TabIndex = 4;
            this.radioCustom.Text = "Свой масштаб:";
            this.radioCustom.UseVisualStyleBackColor = false;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // panelCustomScale
            // 
            this.panelCustomScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelCustomScale.Controls.Add(this.labelCustomScaleInfo);
            this.panelCustomScale.Controls.Add(this.numericCustomScale);
            this.panelCustomScale.Location = new System.Drawing.Point(280, 45);
            this.panelCustomScale.Name = "panelCustomScale";
            this.panelCustomScale.Size = new System.Drawing.Size(180, 80);
            this.panelCustomScale.TabIndex = 5;
            // 
            // labelCustomScaleInfo
            // 
            this.labelCustomScaleInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomScaleInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelCustomScaleInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.labelCustomScaleInfo.Location = new System.Drawing.Point(20, 12);
            this.labelCustomScaleInfo.Name = "labelCustomScaleInfo";
            this.labelCustomScaleInfo.Size = new System.Drawing.Size(140, 20);
            this.labelCustomScaleInfo.TabIndex = 0;
            this.labelCustomScaleInfo.Text = "1 сек → X сек";
            this.labelCustomScaleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericCustomScale
            // 
            this.numericCustomScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.numericCustomScale.Enabled = false;
            this.numericCustomScale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numericCustomScale.ForeColor = System.Drawing.Color.White;
            this.numericCustomScale.Location = new System.Drawing.Point(30, 38);
            this.numericCustomScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCustomScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCustomScale.Name = "numericCustomScale";
            this.numericCustomScale.Size = new System.Drawing.Size(120, 25);
            this.numericCustomScale.TabIndex = 1;
            this.numericCustomScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericCustomScale.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericCustomScale.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelResult.Controls.Add(this.lblResult);
            this.panelResult.Location = new System.Drawing.Point(20, 655);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(480, 60);
            this.panelResult.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(480, 60);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0ч 00м 00с";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRealTime
            // 
            this.panelRealTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelRealTime.Controls.Add(this.panelRealTimeControls);
            this.panelRealTime.Location = new System.Drawing.Point(20, 315);
            this.panelRealTime.Name = "panelRealTime";
            this.panelRealTime.Size = new System.Drawing.Size(480, 100);
            this.panelRealTime.TabIndex = 4;
            // 
            // panelRealTimeControls
            // 
            this.panelRealTimeControls.BackColor = System.Drawing.Color.Transparent;
            this.panelRealTimeControls.Controls.Add(this.labelStartTime);
            this.panelRealTimeControls.Controls.Add(this.dateTimePickerStart);
            this.panelRealTimeControls.Controls.Add(this.labelEndTimeCaption);
            this.panelRealTimeControls.Controls.Add(this.lblEndTime);
            this.panelRealTimeControls.Location = new System.Drawing.Point(10, 10);
            this.panelRealTimeControls.Name = "panelRealTimeControls";
            this.panelRealTimeControls.Size = new System.Drawing.Size(460, 80);
            this.panelRealTimeControls.TabIndex = 0;
            // 
            // labelStartTime
            // 
            this.labelStartTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelStartTime.ForeColor = System.Drawing.Color.White;
            this.labelStartTime.Location = new System.Drawing.Point(10, 15);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(150, 25);
            this.labelStartTime.TabIndex = 0;
            this.labelStartTime.Text = "Время начала пути:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStart.Location = new System.Drawing.Point(170, 15);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(120, 25);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.DateTimePickerStart_ValueChanged);
            // 
            // labelEndTimeCaption
            // 
            this.labelEndTimeCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelEndTimeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.labelEndTimeCaption.Location = new System.Drawing.Point(10, 50);
            this.labelEndTimeCaption.Name = "labelEndTimeCaption";
            this.labelEndTimeCaption.Size = new System.Drawing.Size(150, 25);
            this.labelEndTimeCaption.TabIndex = 2;
            this.labelEndTimeCaption.Text = "Время окончания:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblEndTime.Location = new System.Drawing.Point(170, 48);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(250, 30);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "--:--:--";
            // 
            // labelResultCaption
            // 
            this.labelResultCaption.BackColor = System.Drawing.Color.Transparent;
            this.labelResultCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelResultCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.labelResultCaption.Location = new System.Drawing.Point(20, 630);
            this.labelResultCaption.Name = "labelResultCaption";
            this.labelResultCaption.Size = new System.Drawing.Size(480, 20);
            this.labelResultCaption.TabIndex = 6;
            this.labelResultCaption.Text = "РЕЗУЛЬТАТ КОНВЕРТАЦИИ";
            this.labelResultCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(518, 741);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelMode);
            this.Controls.Add(this.panelRealTime);
            this.Controls.Add(this.panelScale);
            this.Controls.Add(this.labelResultCaption);
            this.Controls.Add(this.panelResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETS2 Time Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            this.panelMode.ResumeLayout(false);
            this.panelScale.ResumeLayout(false);
            this.panelCustomScale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericCustomScale)).EndInit();
            this.panelResult.ResumeLayout(false);
            this.panelRealTime.ResumeLayout(false);
            this.panelRealTimeControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // === Поля формы ===
        private Label labelTitle;
        private Label labelSubtitle;

        private Panel panelInput;
        private Panel panelMode;
        private Panel panelScale;
        private Panel panelCustomScale;
        private Panel panelResult;
        private Panel panelRealTime;
        private Panel panelRealTimeControls;

        private Label labelHours;
        private NumericUpDown numericHours;
        private Label labelMinutes;
        private NumericUpDown numericMinutes;
        private Label labelSeconds;
        private NumericUpDown numericSeconds;

        private RadioButton radioETS2ToReal;
        private RadioButton radioRealToETS2;
        private CheckBox checkBoxRealTime;

        private Label labelStartTime;
        private DateTimePicker dateTimePickerStart;
        private Label labelEndTimeCaption;
        private Label lblEndTime;

        private RadioButton radioEU;
        private RadioButton radioUK;
        private RadioButton radioCities;
        private RadioButton radioTruckersMP;
        private RadioButton radioCustom;

        private NumericUpDown numericCustomScale;
        private Label labelCustomScaleInfo;

        private Label labelResultCaption;
        private Label lblResult;
    }
}