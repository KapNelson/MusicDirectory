
namespace MusicDirectory
{
    partial class AddPerformerForm
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
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addPerformerButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.groupRadioButton = new System.Windows.Forms.RadioButton();
            this.soloRadioButton = new System.Windows.Forms.RadioButton();
            this.musicianComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(297, 146);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(181, 22);
            this.countryTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(297, 105);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 22);
            this.nameTextBox.TabIndex = 14;
            // 
            // addPerformerButton
            // 
            this.addPerformerButton.Location = new System.Drawing.Point(298, 350);
            this.addPerformerButton.Name = "addPerformerButton";
            this.addPerformerButton.Size = new System.Drawing.Size(180, 24);
            this.addPerformerButton.TabIndex = 13;
            this.addPerformerButton.Text = "Добавить исполнителя";
            this.addPerformerButton.UseVisualStyleBackColor = true;
            this.addPerformerButton.Click += new System.EventHandler(this.addPerformerButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.musicianComboBox);
            this.groupBox.Controls.Add(this.numTextBox);
            this.groupBox.Controls.Add(this.groupRadioButton);
            this.groupBox.Controls.Add(this.soloRadioButton);
            this.groupBox.Location = new System.Drawing.Point(298, 199);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(180, 145);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Тип исполнителя";
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(6, 117);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(168, 22);
            this.numTextBox.TabIndex = 2;
            // 
            // groupRadioButton
            // 
            this.groupRadioButton.AutoSize = true;
            this.groupRadioButton.Location = new System.Drawing.Point(6, 90);
            this.groupRadioButton.Name = "groupRadioButton";
            this.groupRadioButton.Size = new System.Drawing.Size(76, 21);
            this.groupRadioButton.TabIndex = 1;
            this.groupRadioButton.TabStop = true;
            this.groupRadioButton.Text = "Группа";
            this.groupRadioButton.UseVisualStyleBackColor = true;
            // 
            // soloRadioButton
            // 
            this.soloRadioButton.AutoSize = true;
            this.soloRadioButton.Location = new System.Drawing.Point(6, 33);
            this.soloRadioButton.Name = "soloRadioButton";
            this.soloRadioButton.Size = new System.Drawing.Size(87, 21);
            this.soloRadioButton.TabIndex = 0;
            this.soloRadioButton.TabStop = true;
            this.soloRadioButton.Text = "Сольный";
            this.soloRadioButton.UseVisualStyleBackColor = true;
            // 
            // musicianComboBox
            // 
            this.musicianComboBox.FormattingEnabled = true;
            this.musicianComboBox.Location = new System.Drawing.Point(6, 60);
            this.musicianComboBox.Name = "musicianComboBox";
            this.musicianComboBox.Size = new System.Drawing.Size(168, 24);
            this.musicianComboBox.TabIndex = 3;
            // 
            // AddPerformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addPerformerButton);
            this.Controls.Add(this.countryTextBox);
            this.Name = "AddPerformerForm";
            this.Text = "AddPerformerForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addPerformerButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton groupRadioButton;
        private System.Windows.Forms.RadioButton soloRadioButton;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.ComboBox musicianComboBox;
    }
}