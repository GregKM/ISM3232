namespace MoneyConverter
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
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.mexicoPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mexicoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a country below";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // francePictureBox
            // 
            this.francePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("francePictureBox.Image")));
            this.francePictureBox.Location = new System.Drawing.Point(13, 40);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(100, 50);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePictureBox.TabIndex = 1;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // mexicoPictureBox
            // 
            this.mexicoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mexicoPictureBox.Image")));
            this.mexicoPictureBox.Location = new System.Drawing.Point(171, 40);
            this.mexicoPictureBox.Name = "mexicoPictureBox";
            this.mexicoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.mexicoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mexicoPictureBox.TabIndex = 2;
            this.mexicoPictureBox.TabStop = false;
            this.mexicoPictureBox.Click += new System.EventHandler(this.mexicoPictureBox_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "The equivalent of $100 in this currency is:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currencyLabel
            // 
            this.currencyLabel.Location = new System.Drawing.Point(221, 97);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(59, 23);
            this.currencyLabel.TabIndex = 4;
            this.currencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mexicoPictureBox);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Money Converter";
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mexicoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.PictureBox mexicoPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currencyLabel;
    }
}

