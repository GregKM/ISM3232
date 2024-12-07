namespace JoesAuto
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
            this.oilLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.transFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.partsLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalFeesTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.partsSummaryTextBox = new System.Windows.Forms.TextBox();
            this.servicesLaborTextBox = new System.Windows.Forms.TextBox();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsSummaryLabel = new System.Windows.Forms.Label();
            this.servicesLaborLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsLaborGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeGroupBox
            // 
            this.oilLubeGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.oilLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilLubeGroupBox.Location = new System.Drawing.Point(13, 13);
            this.oilLubeGroupBox.Name = "oilLubeGroupBox";
            this.oilLubeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.oilLubeGroupBox.TabIndex = 0;
            this.oilLubeGroupBox.TabStop = false;
            this.oilLubeGroupBox.Text = "Oil && Lube";
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(7, 44);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(97, 17);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube Job ($18)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            this.lubeJobCheckBox.CheckedChanged += new System.EventHandler(this.lubeJobCheckBox_CheckedChanged);
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(7, 20);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(105, 17);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change ($26)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            this.oilChangeCheckBox.CheckedChanged += new System.EventHandler(this.oilChangeCheckBox_CheckedChanged);
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(242, 14);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // transFlushCheckBox
            // 
            this.transFlushCheckBox.AutoSize = true;
            this.transFlushCheckBox.Location = new System.Drawing.Point(7, 44);
            this.transFlushCheckBox.Name = "transFlushCheckBox";
            this.transFlushCheckBox.Size = new System.Drawing.Size(142, 17);
            this.transFlushCheckBox.TabIndex = 1;
            this.transFlushCheckBox.Text = "Transmission Flush ($80)";
            this.transFlushCheckBox.UseVisualStyleBackColor = true;
            this.transFlushCheckBox.CheckedChanged += new System.EventHandler(this.transFlushCheckBox_CheckedChanged);
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(7, 20);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(121, 17);
            this.radiatorFlushCheckBox.TabIndex = 0;
            this.radiatorFlushCheckBox.Text = "Radiator Flush ($30)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            this.radiatorFlushCheckBox.CheckedChanged += new System.EventHandler(this.radiatorFlushCheckBox_CheckedChanged);
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.replaceMufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(13, 120);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(200, 100);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(7, 68);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(114, 17);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            this.tireRotationCheckBox.CheckedChanged += new System.EventHandler(this.tireRotationCheckBox_CheckedChanged);
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(7, 44);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(134, 17);
            this.replaceMufflerCheckBox.TabIndex = 1;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($100)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            this.replaceMufflerCheckBox.CheckedChanged += new System.EventHandler(this.replaceMufflerCheckBox_CheckedChanged);
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(7, 20);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(102, 17);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            this.inspectionCheckBox.CheckedChanged += new System.EventHandler(this.inspectionCheckBox_CheckedChanged);
            // 
            // partsLaborGroupBox
            // 
            this.partsLaborGroupBox.Controls.Add(this.laborTextBox);
            this.partsLaborGroupBox.Controls.Add(this.partsTextBox);
            this.partsLaborGroupBox.Controls.Add(this.label2);
            this.partsLaborGroupBox.Controls.Add(this.partsLabel);
            this.partsLaborGroupBox.Location = new System.Drawing.Point(242, 120);
            this.partsLaborGroupBox.Name = "partsLaborGroupBox";
            this.partsLaborGroupBox.Size = new System.Drawing.Size(200, 100);
            this.partsLaborGroupBox.TabIndex = 3;
            this.partsLaborGroupBox.TabStop = false;
            this.partsLaborGroupBox.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(61, 47);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(61, 17);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor ($)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(7, 20);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(31, 13);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts";
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalFeesTextBox);
            this.summaryGroupBox.Controls.Add(this.taxTextBox);
            this.summaryGroupBox.Controls.Add(this.partsSummaryTextBox);
            this.summaryGroupBox.Controls.Add(this.servicesLaborTextBox);
            this.summaryGroupBox.Controls.Add(this.totalFeesLabel);
            this.summaryGroupBox.Controls.Add(this.taxLabel);
            this.summaryGroupBox.Controls.Add(this.partsSummaryLabel);
            this.summaryGroupBox.Controls.Add(this.servicesLaborLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(13, 227);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(429, 138);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // totalFeesTextBox
            // 
            this.totalFeesTextBox.Location = new System.Drawing.Point(100, 99);
            this.totalFeesTextBox.Name = "totalFeesTextBox";
            this.totalFeesTextBox.ReadOnly = true;
            this.totalFeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalFeesTextBox.TabIndex = 7;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(100, 73);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxTextBox.TabIndex = 6;
            // 
            // partsSummaryTextBox
            // 
            this.partsSummaryTextBox.Location = new System.Drawing.Point(100, 47);
            this.partsSummaryTextBox.Name = "partsSummaryTextBox";
            this.partsSummaryTextBox.ReadOnly = true;
            this.partsSummaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsSummaryTextBox.TabIndex = 5;
            // 
            // servicesLaborTextBox
            // 
            this.servicesLaborTextBox.Location = new System.Drawing.Point(101, 21);
            this.servicesLaborTextBox.Name = "servicesLaborTextBox";
            this.servicesLaborTextBox.ReadOnly = true;
            this.servicesLaborTextBox.Size = new System.Drawing.Size(100, 20);
            this.servicesLaborTextBox.TabIndex = 4;
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Location = new System.Drawing.Point(8, 103);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(57, 13);
            this.totalFeesLabel.TabIndex = 3;
            this.totalFeesLabel.Text = "Total Fees";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(8, 77);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(72, 13);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "Tax (on parts)";
            // 
            // partsSummaryLabel
            // 
            this.partsSummaryLabel.AutoSize = true;
            this.partsSummaryLabel.Location = new System.Drawing.Point(8, 50);
            this.partsSummaryLabel.Name = "partsSummaryLabel";
            this.partsSummaryLabel.Size = new System.Drawing.Size(31, 13);
            this.partsSummaryLabel.TabIndex = 1;
            this.partsSummaryLabel.Text = "Parts";
            // 
            // servicesLaborLabel
            // 
            this.servicesLaborLabel.AutoSize = true;
            this.servicesLaborLabel.Location = new System.Drawing.Point(8, 23);
            this.servicesLaborLabel.Name = "servicesLaborLabel";
            this.servicesLaborLabel.Size = new System.Drawing.Size(87, 13);
            this.servicesLaborLabel.TabIndex = 0;
            this.servicesLaborLabel.Text = "Services && Labor";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(60, 386);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(205, 386);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(328, 386);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 440);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsLaborGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.oilLubeGroupBox.ResumeLayout(false);
            this.oilLubeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsLaborGroupBox.ResumeLayout(false);
            this.partsLaborGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsLaborGroupBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.TextBox totalFeesTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox partsSummaryTextBox;
        private System.Windows.Forms.TextBox servicesLaborTextBox;
        private System.Windows.Forms.Label totalFeesLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsSummaryLabel;
        private System.Windows.Forms.Label servicesLaborLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

