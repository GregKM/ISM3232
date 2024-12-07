namespace HeadsTails
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
            this.headsBox = new System.Windows.Forms.PictureBox();
            this.tailsBox = new System.Windows.Forms.PictureBox();
            this.headsButton = new System.Windows.Forms.Button();
            this.tailsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headsBox
            // 
            this.headsBox.Image = ((System.Drawing.Image)(resources.GetObject("headsBox.Image")));
            this.headsBox.Location = new System.Drawing.Point(78, 50);
            this.headsBox.Name = "headsBox";
            this.headsBox.Size = new System.Drawing.Size(100, 100);
            this.headsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headsBox.TabIndex = 0;
            this.headsBox.TabStop = false;
            this.headsBox.Visible = false;
            // 
            // tailsBox
            // 
            this.tailsBox.Image = ((System.Drawing.Image)(resources.GetObject("tailsBox.Image")));
            this.tailsBox.Location = new System.Drawing.Point(257, 50);
            this.tailsBox.Name = "tailsBox";
            this.tailsBox.Size = new System.Drawing.Size(100, 100);
            this.tailsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tailsBox.TabIndex = 1;
            this.tailsBox.TabStop = false;
            this.tailsBox.Visible = false;
            // 
            // headsButton
            // 
            this.headsButton.Location = new System.Drawing.Point(78, 200);
            this.headsButton.Name = "headsButton";
            this.headsButton.Size = new System.Drawing.Size(75, 49);
            this.headsButton.TabIndex = 2;
            this.headsButton.Text = "Show Heads";
            this.headsButton.UseVisualStyleBackColor = true;
            this.headsButton.Click += new System.EventHandler(this.headsButton_Click);
            // 
            // tailsButton
            // 
            this.tailsButton.Location = new System.Drawing.Point(182, 200);
            this.tailsButton.Name = "tailsButton";
            this.tailsButton.Size = new System.Drawing.Size(75, 49);
            this.tailsButton.TabIndex = 3;
            this.tailsButton.Text = "Show Tails";
            this.tailsButton.UseVisualStyleBackColor = true;
            this.tailsButton.Click += new System.EventHandler(this.tailsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(282, 200);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 49);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tailsButton);
            this.Controls.Add(this.headsButton);
            this.Controls.Add(this.tailsBox);
            this.Controls.Add(this.headsBox);
            this.Name = "Form1";
            this.Text = "Head or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headsBox;
        private System.Windows.Forms.PictureBox tailsBox;
        private System.Windows.Forms.Button headsButton;
        private System.Windows.Forms.Button tailsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

