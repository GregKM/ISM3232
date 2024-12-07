namespace DormCalculator
{
    partial class TotalForm
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(12, 53);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(76, 13);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total Charges:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(115, 50);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(120, 20);
            this.totalTextBox.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(93, 103);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 149);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Name = "TotalForm";
            this.Text = "TotalForm";
            this.Load += new System.EventHandler(this.TotalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}