namespace DormCalculator
{
    partial class MainForm
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
            this.dormLabel = new System.Windows.Forms.Label();
            this.mealPlanLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dormComboBox = new System.Windows.Forms.ComboBox();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dormLabel
            // 
            this.dormLabel.AutoSize = true;
            this.dormLabel.Location = new System.Drawing.Point(12, 31);
            this.dormLabel.Name = "dormLabel";
            this.dormLabel.Size = new System.Drawing.Size(35, 13);
            this.dormLabel.TabIndex = 0;
            this.dormLabel.Text = "Dorm:";
            this.dormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mealPlanLabel
            // 
            this.mealPlanLabel.AutoSize = true;
            this.mealPlanLabel.Location = new System.Drawing.Point(12, 85);
            this.mealPlanLabel.Name = "mealPlanLabel";
            this.mealPlanLabel.Size = new System.Drawing.Size(57, 13);
            this.mealPlanLabel.TabIndex = 1;
            this.mealPlanLabel.Text = "Meal Plan:";
            this.mealPlanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(56, 192);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(170, 192);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dormComboBox
            // 
            this.dormComboBox.FormattingEnabled = true;
            this.dormComboBox.Items.AddRange(new object[] {
            "Allen Hall",
            "Pike Hall",
            "Farthing Hall",
            "University Suites"});
            this.dormComboBox.Location = new System.Drawing.Point(90, 28);
            this.dormComboBox.Name = "dormComboBox";
            this.dormComboBox.Size = new System.Drawing.Size(155, 21);
            this.dormComboBox.TabIndex = 4;
            // 
            // mealComboBox
            // 
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Items.AddRange(new object[] {
            "7 meals per week",
            "14 meals per week",
            "Unlimited meals"});
            this.mealComboBox.Location = new System.Drawing.Point(90, 82);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(155, 21);
            this.mealComboBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 261);
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.dormComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mealPlanLabel);
            this.Controls.Add(this.dormLabel);
            this.Name = "MainForm";
            this.Text = "Dorm & Meal Plan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dormLabel;
        private System.Windows.Forms.Label mealPlanLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox dormComboBox;
        private System.Windows.Forms.ComboBox mealComboBox;
    }
}

