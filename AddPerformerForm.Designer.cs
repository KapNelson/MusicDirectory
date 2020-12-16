
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPerformerForm));
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addPerformerButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.musicianComboBox = new System.Windows.Forms.ComboBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.groupRadioButton = new System.Windows.Forms.RadioButton();
            this.soloRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addMusicianButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryTextBox.Location = new System.Drawing.Point(320, 114);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(181, 30);
            this.countryTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(319, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 30);
            this.nameTextBox.TabIndex = 14;
            // 
            // addPerformerButton
            // 
            this.addPerformerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPerformerButton.Location = new System.Drawing.Point(326, 336);
            this.addPerformerButton.Name = "addPerformerButton";
            this.addPerformerButton.Size = new System.Drawing.Size(168, 63);
            this.addPerformerButton.TabIndex = 13;
            this.addPerformerButton.Text = "Добавить исполнителя";
            this.addPerformerButton.UseVisualStyleBackColor = true;
            this.addPerformerButton.Click += new System.EventHandler(this.addPerformerButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.musicianComboBox);
            this.groupBox.Controls.Add(this.numTextBox);
            this.groupBox.Controls.Add(this.groupRadioButton);
            this.groupBox.Controls.Add(this.soloRadioButton);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox.Location = new System.Drawing.Point(320, 174);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(180, 145);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Тип исполнителя";
            // 
            // musicianComboBox
            // 
            this.musicianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musicianComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicianComboBox.FormattingEnabled = true;
            this.musicianComboBox.Location = new System.Drawing.Point(6, 60);
            this.musicianComboBox.Name = "musicianComboBox";
            this.musicianComboBox.Size = new System.Drawing.Size(168, 26);
            this.musicianComboBox.TabIndex = 3;
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(6, 117);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(168, 24);
            this.numTextBox.TabIndex = 2;
            // 
            // groupRadioButton
            // 
            this.groupRadioButton.AutoSize = true;
            this.groupRadioButton.Location = new System.Drawing.Point(6, 90);
            this.groupRadioButton.Name = "groupRadioButton";
            this.groupRadioButton.Size = new System.Drawing.Size(83, 22);
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
            this.soloRadioButton.Size = new System.Drawing.Size(100, 22);
            this.soloRadioButton.TabIndex = 0;
            this.soloRadioButton.TabStop = true;
            this.soloRadioButton.Text = "Сольный";
            this.soloRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название исполнителя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Страна исполнителя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(99, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "ФИО музыканта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(40, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Количество учасников:";
            // 
            // addMusicianButton
            // 
            this.addMusicianButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMusicianButton.Location = new System.Drawing.Point(576, 185);
            this.addMusicianButton.Name = "addMusicianButton";
            this.addMusicianButton.Size = new System.Drawing.Size(168, 63);
            this.addMusicianButton.TabIndex = 28;
            this.addMusicianButton.Text = "Добавить музыканта";
            this.addMusicianButton.UseVisualStyleBackColor = true;
            this.addMusicianButton.Click += new System.EventHandler(this.addMusicianButton_Click);
            // 
            // AddPerformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addMusicianButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addPerformerButton);
            this.Controls.Add(this.countryTextBox);
            this.Name = "AddPerformerForm";
            this.Text = "Добавить исполнителя";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addMusicianButton;
    }
}