namespace CalorieCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bananaBox = new System.Windows.Forms.PictureBox();
            this.appleBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.pearBox = new System.Windows.Forms.PictureBox();
            this.calorieTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bananaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Calories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bananaBox
            // 
            this.bananaBox.Image = ((System.Drawing.Image)(resources.GetObject("bananaBox.Image")));
            this.bananaBox.Location = new System.Drawing.Point(13, 25);
            this.bananaBox.Name = "bananaBox";
            this.bananaBox.Size = new System.Drawing.Size(100, 113);
            this.bananaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bananaBox.TabIndex = 1;
            this.bananaBox.TabStop = false;
            this.bananaBox.Click += new System.EventHandler(this.bananaBox_Click);
            // 
            // appleBox
            // 
            this.appleBox.Image = ((System.Drawing.Image)(resources.GetObject("appleBox.Image")));
            this.appleBox.Location = new System.Drawing.Point(119, 25);
            this.appleBox.Name = "appleBox";
            this.appleBox.Size = new System.Drawing.Size(100, 113);
            this.appleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appleBox.TabIndex = 2;
            this.appleBox.TabStop = false;
            this.appleBox.Click += new System.EventHandler(this.appleBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.Image = ((System.Drawing.Image)(resources.GetObject("orangeBox.Image")));
            this.orangeBox.Location = new System.Drawing.Point(13, 144);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(100, 110);
            this.orangeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orangeBox.TabIndex = 3;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.orangeBox_Click);
            // 
            // pearBox
            // 
            this.pearBox.Image = ((System.Drawing.Image)(resources.GetObject("pearBox.Image")));
            this.pearBox.Location = new System.Drawing.Point(119, 144);
            this.pearBox.Name = "pearBox";
            this.pearBox.Size = new System.Drawing.Size(100, 110);
            this.pearBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pearBox.TabIndex = 4;
            this.pearBox.TabStop = false;
            this.pearBox.Click += new System.EventHandler(this.pearBox_Click);
            // 
            // calorieTextBox
            // 
            this.calorieTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calorieTextBox.Location = new System.Drawing.Point(260, 41);
            this.calorieTextBox.Name = "calorieTextBox";
            this.calorieTextBox.Size = new System.Drawing.Size(68, 13);
            this.calorieTextBox.TabIndex = 5;
            this.calorieTextBox.Text = "0";
            this.calorieTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(260, 231);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(260, 202);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 276);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calorieTextBox);
            this.Controls.Add(this.pearBox);
            this.Controls.Add(this.orangeBox);
            this.Controls.Add(this.appleBox);
            this.Controls.Add(this.bananaBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bananaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bananaBox;
        private System.Windows.Forms.PictureBox appleBox;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.PictureBox pearBox;
        private System.Windows.Forms.TextBox calorieTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
    }
}

