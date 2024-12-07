namespace ProjectLab3
{
    partial class ServiceForm
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
            this.petOwnerGroupBox = new System.Windows.Forms.GroupBox();
            this.petGroupBox = new System.Windows.Forms.GroupBox();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.ownerPhoneLabel = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.petBirthLabel = new System.Windows.Forms.Label();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            this.fleaRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.shampooCheckBox = new System.Windows.Forms.CheckBox();
            this.fleaRemovalPriceLabel = new System.Windows.Forms.Label();
            this.shampooPriceLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.dogRadioButton = new System.Windows.Forms.RadioButton();
            this.catRadioButton = new System.Windows.Forms.RadioButton();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.petDOBTextBox = new System.Windows.Forms.TextBox();
            this.petOwnerGroupBox.SuspendLayout();
            this.petGroupBox.SuspendLayout();
            this.servicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // petOwnerGroupBox
            // 
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneTextBox);
            this.petOwnerGroupBox.Controls.Add(this.ownerNameTextBox);
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneLabel);
            this.petOwnerGroupBox.Controls.Add(this.ownerNameLabel);
            this.petOwnerGroupBox.Location = new System.Drawing.Point(13, 13);
            this.petOwnerGroupBox.Name = "petOwnerGroupBox";
            this.petOwnerGroupBox.Size = new System.Drawing.Size(359, 100);
            this.petOwnerGroupBox.TabIndex = 0;
            this.petOwnerGroupBox.TabStop = false;
            this.petOwnerGroupBox.Text = "Pet Owner";
            // 
            // petGroupBox
            // 
            this.petGroupBox.Controls.Add(this.petDOBTextBox);
            this.petGroupBox.Controls.Add(this.petNameTextBox);
            this.petGroupBox.Controls.Add(this.catRadioButton);
            this.petGroupBox.Controls.Add(this.dogRadioButton);
            this.petGroupBox.Controls.Add(this.petTypeLabel);
            this.petGroupBox.Controls.Add(this.petBirthLabel);
            this.petGroupBox.Controls.Add(this.petNameLabel);
            this.petGroupBox.Location = new System.Drawing.Point(13, 120);
            this.petGroupBox.Name = "petGroupBox";
            this.petGroupBox.Size = new System.Drawing.Size(359, 144);
            this.petGroupBox.TabIndex = 1;
            this.petGroupBox.TabStop = false;
            this.petGroupBox.Text = "Pet";
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.priceLabel);
            this.servicesGroupBox.Controls.Add(this.shampooPriceLabel);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalPriceLabel);
            this.servicesGroupBox.Controls.Add(this.shampooCheckBox);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalCheckBox);
            this.servicesGroupBox.Controls.Add(this.totalFeeLabel);
            this.servicesGroupBox.Location = new System.Drawing.Point(13, 270);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(359, 100);
            this.servicesGroupBox.TabIndex = 2;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Services";
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(13, 376);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 3;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(161, 376);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(297, 376);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Location = new System.Drawing.Point(7, 20);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(72, 13);
            this.ownerNameLabel.TabIndex = 0;
            this.ownerNameLabel.Text = "Owner Name:";
            // 
            // ownerPhoneLabel
            // 
            this.ownerPhoneLabel.AutoSize = true;
            this.ownerPhoneLabel.Location = new System.Drawing.Point(7, 56);
            this.ownerPhoneLabel.Name = "ownerPhoneLabel";
            this.ownerPhoneLabel.Size = new System.Drawing.Size(75, 13);
            this.ownerPhoneLabel.TabIndex = 1;
            this.ownerPhoneLabel.Text = "Owner Phone:";
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(10, 20);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(57, 13);
            this.petNameLabel.TabIndex = 0;
            this.petNameLabel.Text = "Pet Name:";
            // 
            // petBirthLabel
            // 
            this.petBirthLabel.AutoSize = true;
            this.petBirthLabel.Location = new System.Drawing.Point(10, 61);
            this.petBirthLabel.Name = "petBirthLabel";
            this.petBirthLabel.Size = new System.Drawing.Size(88, 13);
            this.petBirthLabel.TabIndex = 1;
            this.petBirthLabel.Text = "Pet Date of Birth:";
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.AutoSize = true;
            this.petTypeLabel.Location = new System.Drawing.Point(10, 101);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.petTypeLabel.TabIndex = 2;
            this.petTypeLabel.Text = "Pet Type:";
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.AutoSize = true;
            this.totalFeeLabel.Location = new System.Drawing.Point(145, 70);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(55, 13);
            this.totalFeeLabel.TabIndex = 1;
            this.totalFeeLabel.Text = "Total Fee:";
            // 
            // fleaRemovalCheckBox
            // 
            this.fleaRemovalCheckBox.AutoSize = true;
            this.fleaRemovalCheckBox.Location = new System.Drawing.Point(13, 19);
            this.fleaRemovalCheckBox.Name = "fleaRemovalCheckBox";
            this.fleaRemovalCheckBox.Size = new System.Drawing.Size(91, 17);
            this.fleaRemovalCheckBox.TabIndex = 3;
            this.fleaRemovalCheckBox.Text = "Flea Removal";
            this.fleaRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // shampooCheckBox
            // 
            this.shampooCheckBox.AutoSize = true;
            this.shampooCheckBox.Location = new System.Drawing.Point(200, 19);
            this.shampooCheckBox.Name = "shampooCheckBox";
            this.shampooCheckBox.Size = new System.Drawing.Size(71, 17);
            this.shampooCheckBox.TabIndex = 4;
            this.shampooCheckBox.Text = "Shampoo";
            this.shampooCheckBox.UseVisualStyleBackColor = true;
            // 
            // fleaRemovalPriceLabel
            // 
            this.fleaRemovalPriceLabel.AutoSize = true;
            this.fleaRemovalPriceLabel.Location = new System.Drawing.Point(111, 19);
            this.fleaRemovalPriceLabel.Name = "fleaRemovalPriceLabel";
            this.fleaRemovalPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.fleaRemovalPriceLabel.TabIndex = 5;
            this.fleaRemovalPriceLabel.Text = "$5.00";
            // 
            // shampooPriceLabel
            // 
            this.shampooPriceLabel.AutoSize = true;
            this.shampooPriceLabel.Location = new System.Drawing.Point(287, 19);
            this.shampooPriceLabel.Name = "shampooPriceLabel";
            this.shampooPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.shampooPriceLabel.TabIndex = 6;
            this.shampooPriceLabel.Text = "$4.00";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(206, 70);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 13);
            this.priceLabel.TabIndex = 7;
            // 
            // dogRadioButton
            // 
            this.dogRadioButton.AutoSize = true;
            this.dogRadioButton.Location = new System.Drawing.Point(104, 97);
            this.dogRadioButton.Name = "dogRadioButton";
            this.dogRadioButton.Size = new System.Drawing.Size(43, 17);
            this.dogRadioButton.TabIndex = 3;
            this.dogRadioButton.TabStop = true;
            this.dogRadioButton.Text = "dog";
            this.dogRadioButton.UseVisualStyleBackColor = true;
            // 
            // catRadioButton
            // 
            this.catRadioButton.AutoSize = true;
            this.catRadioButton.Location = new System.Drawing.Point(166, 97);
            this.catRadioButton.Name = "catRadioButton";
            this.catRadioButton.Size = new System.Drawing.Size(40, 17);
            this.catRadioButton.TabIndex = 4;
            this.catRadioButton.TabStop = true;
            this.catRadioButton.Text = "cat";
            this.catRadioButton.UseVisualStyleBackColor = true;
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(104, 17);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerNameTextBox.TabIndex = 2;
            // 
            // ownerPhoneTextBox
            // 
            this.ownerPhoneTextBox.Location = new System.Drawing.Point(104, 53);
            this.ownerPhoneTextBox.Name = "ownerPhoneTextBox";
            this.ownerPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerPhoneTextBox.TabIndex = 3;
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(104, 17);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.petNameTextBox.TabIndex = 5;
            // 
            // petDOBTextBox
            // 
            this.petDOBTextBox.Location = new System.Drawing.Point(104, 58);
            this.petDOBTextBox.Name = "petDOBTextBox";
            this.petDOBTextBox.Size = new System.Drawing.Size(100, 20);
            this.petDOBTextBox.TabIndex = 6;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.petGroupBox);
            this.Controls.Add(this.petOwnerGroupBox);
            this.Name = "ServiceForm";
            this.Text = "Pet Boutique Service Form";
            this.petOwnerGroupBox.ResumeLayout(false);
            this.petOwnerGroupBox.PerformLayout();
            this.petGroupBox.ResumeLayout(false);
            this.petGroupBox.PerformLayout();
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox petOwnerGroupBox;
        private System.Windows.Forms.TextBox ownerPhoneTextBox;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.Label ownerPhoneLabel;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.GroupBox petGroupBox;
        private System.Windows.Forms.TextBox petDOBTextBox;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.RadioButton catRadioButton;
        private System.Windows.Forms.RadioButton dogRadioButton;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.Label petBirthLabel;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.GroupBox servicesGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label shampooPriceLabel;
        private System.Windows.Forms.Label fleaRemovalPriceLabel;
        private System.Windows.Forms.CheckBox shampooCheckBox;
        private System.Windows.Forms.CheckBox fleaRemovalCheckBox;
        private System.Windows.Forms.Label totalFeeLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button quitButton;
    }
}

