
namespace MusicDirectory
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.adminCheckBox.Location = new System.Drawing.Point(433, 318);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adminCheckBox.Size = new System.Drawing.Size(133, 21);
            this.adminCheckBox.TabIndex = 0;
            this.adminCheckBox.Text = "Администратор\r\n";
            this.adminCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminCheckBox.UseVisualStyleBackColor = false;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(397, 372);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(198, 58);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Создать пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(397, 176);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(198, 22);
            this.loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(397, 226);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(198, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // repasswordTextBox
            // 
            this.repasswordTextBox.Location = new System.Drawing.Point(397, 272);
            this.repasswordTextBox.Name = "repasswordTextBox";
            this.repasswordTextBox.Size = new System.Drawing.Size(198, 22);
            this.repasswordTextBox.TabIndex = 4;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.repasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.adminCheckBox);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox repasswordTextBox;
    }
}