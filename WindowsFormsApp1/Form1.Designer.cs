
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOilAndLube = new System.Windows.Forms.GroupBox();
            this.checkBoxOilChange = new System.Windows.Forms.CheckBox();
            this.checkBoxLubeJob = new System.Windows.Forms.CheckBox();
            this.groupBoxFlushes = new System.Windows.Forms.GroupBox();
            this.checkBoxRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.checkBoxTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.checkBoxInspection = new System.Windows.Forms.CheckBox();
            this.checkBoxReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.checkBoxTireRotation = new System.Windows.Forms.CheckBox();
            this.groupBoxPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.labelParts = new System.Windows.Forms.Label();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.labelLabor = new System.Windows.Forms.Label();
            this.textBoxLabor = new System.Windows.Forms.TextBox();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.labelServiceAndLabor = new System.Windows.Forms.Label();
            this.labelServiceAndLaborDisplay = new System.Windows.Forms.Label();
            this.labelPartsSummary = new System.Windows.Forms.Label();
            this.labelPartsDisplay = new System.Windows.Forms.Label();
            this.labelTaxDisplay = new System.Windows.Forms.Label();
            this.labelTotalFeesDisplay = new System.Windows.Forms.Label();
            this.labelTaxSummary = new System.Windows.Forms.Label();
            this.labelTotalFeesSummary = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxOilAndLube.SuspendLayout();
            this.groupBoxFlushes.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
            this.groupBoxPartsAndLabor.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOilAndLube
            // 
            this.groupBoxOilAndLube.Controls.Add(this.checkBoxLubeJob);
            this.groupBoxOilAndLube.Controls.Add(this.checkBoxOilChange);
            this.groupBoxOilAndLube.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOilAndLube.Name = "groupBoxOilAndLube";
            this.groupBoxOilAndLube.Size = new System.Drawing.Size(163, 81);
            this.groupBoxOilAndLube.TabIndex = 0;
            this.groupBoxOilAndLube.TabStop = false;
            this.groupBoxOilAndLube.Text = "Oil and Lube";
            // 
            // checkBoxOilChange
            // 
            this.checkBoxOilChange.AutoSize = true;
            this.checkBoxOilChange.Location = new System.Drawing.Point(7, 20);
            this.checkBoxOilChange.Name = "checkBoxOilChange";
            this.checkBoxOilChange.Size = new System.Drawing.Size(120, 17);
            this.checkBoxOilChange.TabIndex = 0;
            this.checkBoxOilChange.Text = "Oil Change ($26.00)";
            this.checkBoxOilChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxLubeJob
            // 
            this.checkBoxLubeJob.AutoSize = true;
            this.checkBoxLubeJob.Location = new System.Drawing.Point(6, 43);
            this.checkBoxLubeJob.Name = "checkBoxLubeJob";
            this.checkBoxLubeJob.Size = new System.Drawing.Size(112, 17);
            this.checkBoxLubeJob.TabIndex = 1;
            this.checkBoxLubeJob.Text = "Lube Job ($18.00)";
            this.checkBoxLubeJob.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlushes
            // 
            this.groupBoxFlushes.Controls.Add(this.checkBoxTransmissionFlush);
            this.groupBoxFlushes.Controls.Add(this.checkBoxRadiatorFlush);
            this.groupBoxFlushes.Location = new System.Drawing.Point(194, 12);
            this.groupBoxFlushes.Name = "groupBoxFlushes";
            this.groupBoxFlushes.Size = new System.Drawing.Size(171, 81);
            this.groupBoxFlushes.TabIndex = 1;
            this.groupBoxFlushes.TabStop = false;
            this.groupBoxFlushes.Text = "Flushes";
            // 
            // checkBoxRadiatorFlush
            // 
            this.checkBoxRadiatorFlush.AutoSize = true;
            this.checkBoxRadiatorFlush.Location = new System.Drawing.Point(7, 20);
            this.checkBoxRadiatorFlush.Name = "checkBoxRadiatorFlush";
            this.checkBoxRadiatorFlush.Size = new System.Drawing.Size(136, 17);
            this.checkBoxRadiatorFlush.TabIndex = 0;
            this.checkBoxRadiatorFlush.Text = "Radiator Flush ($30.00)";
            this.checkBoxRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransmissionFlush
            // 
            this.checkBoxTransmissionFlush.AutoSize = true;
            this.checkBoxTransmissionFlush.Location = new System.Drawing.Point(7, 44);
            this.checkBoxTransmissionFlush.Name = "checkBoxTransmissionFlush";
            this.checkBoxTransmissionFlush.Size = new System.Drawing.Size(157, 17);
            this.checkBoxTransmissionFlush.TabIndex = 1;
            this.checkBoxTransmissionFlush.Text = "Transmission Flush ($80.00)";
            this.checkBoxTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Controls.Add(this.checkBoxTireRotation);
            this.groupBoxMisc.Controls.Add(this.checkBoxReplaceMuffler);
            this.groupBoxMisc.Controls.Add(this.checkBoxInspection);
            this.groupBoxMisc.Location = new System.Drawing.Point(12, 109);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(167, 100);
            this.groupBoxMisc.TabIndex = 2;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc";
            // 
            // checkBoxInspection
            // 
            this.checkBoxInspection.AutoSize = true;
            this.checkBoxInspection.Location = new System.Drawing.Point(7, 20);
            this.checkBoxInspection.Name = "checkBoxInspection";
            this.checkBoxInspection.Size = new System.Drawing.Size(117, 17);
            this.checkBoxInspection.TabIndex = 0;
            this.checkBoxInspection.Text = "Inspection ($15.00)";
            this.checkBoxInspection.UseVisualStyleBackColor = true;
            // 
            // checkBoxReplaceMuffler
            // 
            this.checkBoxReplaceMuffler.AutoSize = true;
            this.checkBoxReplaceMuffler.Location = new System.Drawing.Point(7, 44);
            this.checkBoxReplaceMuffler.Name = "checkBoxReplaceMuffler";
            this.checkBoxReplaceMuffler.Size = new System.Drawing.Size(149, 17);
            this.checkBoxReplaceMuffler.TabIndex = 1;
            this.checkBoxReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.checkBoxReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // checkBoxTireRotation
            // 
            this.checkBoxTireRotation.AutoSize = true;
            this.checkBoxTireRotation.Location = new System.Drawing.Point(7, 68);
            this.checkBoxTireRotation.Name = "checkBoxTireRotation";
            this.checkBoxTireRotation.Size = new System.Drawing.Size(129, 17);
            this.checkBoxTireRotation.TabIndex = 2;
            this.checkBoxTireRotation.Text = "Tire Rotation ($20.00)";
            this.checkBoxTireRotation.UseVisualStyleBackColor = true;
            // 
            // groupBoxPartsAndLabor
            // 
            this.groupBoxPartsAndLabor.Controls.Add(this.textBoxLabor);
            this.groupBoxPartsAndLabor.Controls.Add(this.labelLabor);
            this.groupBoxPartsAndLabor.Controls.Add(this.textBoxParts);
            this.groupBoxPartsAndLabor.Controls.Add(this.labelParts);
            this.groupBoxPartsAndLabor.Location = new System.Drawing.Point(194, 109);
            this.groupBoxPartsAndLabor.Name = "groupBoxPartsAndLabor";
            this.groupBoxPartsAndLabor.Size = new System.Drawing.Size(171, 100);
            this.groupBoxPartsAndLabor.TabIndex = 3;
            this.groupBoxPartsAndLabor.TabStop = false;
            this.groupBoxPartsAndLabor.Text = "Parts and Labor";
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Location = new System.Drawing.Point(26, 34);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(31, 13);
            this.labelParts.TabIndex = 0;
            this.labelParts.Text = "Parts";
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(63, 31);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(79, 20);
            this.textBoxParts.TabIndex = 1;
            // 
            // labelLabor
            // 
            this.labelLabor.AutoSize = true;
            this.labelLabor.Location = new System.Drawing.Point(8, 62);
            this.labelLabor.Name = "labelLabor";
            this.labelLabor.Size = new System.Drawing.Size(49, 13);
            this.labelLabor.TabIndex = 2;
            this.labelLabor.Text = "Labor ($)";
            // 
            // textBoxLabor
            // 
            this.textBoxLabor.Location = new System.Drawing.Point(63, 59);
            this.textBoxLabor.Name = "textBoxLabor";
            this.textBoxLabor.Size = new System.Drawing.Size(80, 20);
            this.textBoxLabor.TabIndex = 3;
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.labelTotalFeesSummary);
            this.groupBoxSummary.Controls.Add(this.labelTaxSummary);
            this.groupBoxSummary.Controls.Add(this.labelTotalFeesDisplay);
            this.groupBoxSummary.Controls.Add(this.labelTaxDisplay);
            this.groupBoxSummary.Controls.Add(this.labelPartsDisplay);
            this.groupBoxSummary.Controls.Add(this.labelPartsSummary);
            this.groupBoxSummary.Controls.Add(this.labelServiceAndLaborDisplay);
            this.groupBoxSummary.Controls.Add(this.labelServiceAndLabor);
            this.groupBoxSummary.Location = new System.Drawing.Point(12, 232);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(353, 155);
            this.groupBoxSummary.TabIndex = 4;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Summary";
            // 
            // labelServiceAndLabor
            // 
            this.labelServiceAndLabor.AutoSize = true;
            this.labelServiceAndLabor.Location = new System.Drawing.Point(7, 20);
            this.labelServiceAndLabor.Name = "labelServiceAndLabor";
            this.labelServiceAndLabor.Size = new System.Drawing.Size(94, 13);
            this.labelServiceAndLabor.TabIndex = 0;
            this.labelServiceAndLabor.Text = "Service and Labor";
            // 
            // labelServiceAndLaborDisplay
            // 
            this.labelServiceAndLaborDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelServiceAndLaborDisplay.Location = new System.Drawing.Point(107, 16);
            this.labelServiceAndLaborDisplay.Name = "labelServiceAndLaborDisplay";
            this.labelServiceAndLaborDisplay.Size = new System.Drawing.Size(100, 23);
            this.labelServiceAndLaborDisplay.TabIndex = 1;
            this.labelServiceAndLaborDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPartsSummary
            // 
            this.labelPartsSummary.AutoSize = true;
            this.labelPartsSummary.Location = new System.Drawing.Point(70, 55);
            this.labelPartsSummary.Name = "labelPartsSummary";
            this.labelPartsSummary.Size = new System.Drawing.Size(31, 13);
            this.labelPartsSummary.TabIndex = 2;
            this.labelPartsSummary.Text = "Parts";
            // 
            // labelPartsDisplay
            // 
            this.labelPartsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPartsDisplay.Location = new System.Drawing.Point(107, 50);
            this.labelPartsDisplay.Name = "labelPartsDisplay";
            this.labelPartsDisplay.Size = new System.Drawing.Size(100, 23);
            this.labelPartsDisplay.TabIndex = 3;
            this.labelPartsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaxDisplay
            // 
            this.labelTaxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTaxDisplay.Location = new System.Drawing.Point(107, 86);
            this.labelTaxDisplay.Name = "labelTaxDisplay";
            this.labelTaxDisplay.Size = new System.Drawing.Size(100, 23);
            this.labelTaxDisplay.TabIndex = 4;
            this.labelTaxDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalFeesDisplay
            // 
            this.labelTotalFeesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalFeesDisplay.Location = new System.Drawing.Point(107, 120);
            this.labelTotalFeesDisplay.Name = "labelTotalFeesDisplay";
            this.labelTotalFeesDisplay.Size = new System.Drawing.Size(100, 23);
            this.labelTotalFeesDisplay.TabIndex = 5;
            this.labelTotalFeesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaxSummary
            // 
            this.labelTaxSummary.AutoSize = true;
            this.labelTaxSummary.Location = new System.Drawing.Point(29, 96);
            this.labelTaxSummary.Name = "labelTaxSummary";
            this.labelTaxSummary.Size = new System.Drawing.Size(72, 13);
            this.labelTaxSummary.TabIndex = 6;
            this.labelTaxSummary.Text = "Tax (on parts)";
            // 
            // labelTotalFeesSummary
            // 
            this.labelTotalFeesSummary.AutoSize = true;
            this.labelTotalFeesSummary.Location = new System.Drawing.Point(44, 125);
            this.labelTotalFeesSummary.Name = "labelTotalFeesSummary";
            this.labelTotalFeesSummary.Size = new System.Drawing.Size(57, 13);
            this.labelTotalFeesSummary.TabIndex = 7;
            this.labelTotalFeesSummary.Text = "Total Fees";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(38, 392);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(133, 393);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(234, 393);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 427);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.groupBoxPartsAndLabor);
            this.Controls.Add(this.groupBoxMisc);
            this.Controls.Add(this.groupBoxFlushes);
            this.Controls.Add(this.groupBoxOilAndLube);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxOilAndLube.ResumeLayout(false);
            this.groupBoxOilAndLube.PerformLayout();
            this.groupBoxFlushes.ResumeLayout(false);
            this.groupBoxFlushes.PerformLayout();
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.groupBoxPartsAndLabor.ResumeLayout(false);
            this.groupBoxPartsAndLabor.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOilAndLube;
        private System.Windows.Forms.CheckBox checkBoxOilChange;
        private System.Windows.Forms.CheckBox checkBoxLubeJob;
        private System.Windows.Forms.GroupBox groupBoxFlushes;
        private System.Windows.Forms.CheckBox checkBoxRadiatorFlush;
        private System.Windows.Forms.CheckBox checkBoxTransmissionFlush;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.CheckBox checkBoxInspection;
        private System.Windows.Forms.CheckBox checkBoxReplaceMuffler;
        private System.Windows.Forms.CheckBox checkBoxTireRotation;
        private System.Windows.Forms.GroupBox groupBoxPartsAndLabor;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelLabor;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.TextBox textBoxLabor;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelTaxDisplay;
        private System.Windows.Forms.Label labelPartsDisplay;
        private System.Windows.Forms.Label labelPartsSummary;
        private System.Windows.Forms.Label labelServiceAndLaborDisplay;
        private System.Windows.Forms.Label labelServiceAndLabor;
        private System.Windows.Forms.Label labelTaxSummary;
        private System.Windows.Forms.Label labelTotalFeesDisplay;
        private System.Windows.Forms.Label labelTotalFeesSummary;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

