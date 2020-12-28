
namespace MusicDirectory
{
    partial class GroupeTrackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupeTrackForm));
            this.label20 = new System.Windows.Forms.Label();
            this.trackGenreListBox = new System.Windows.Forms.ListBox();
            this.trackPerListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trackAlbumListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearSecondTextBox = new System.Windows.Forms.TextBox();
            this.yearFirstTextBox = new System.Windows.Forms.TextBox();
            this.groupeButton = new System.Windows.Forms.Button();
            this.groupeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(326, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 20);
            this.label20.TabIndex = 51;
            this.label20.Text = "Жанры:";
            // 
            // trackGenreListBox
            // 
            this.trackGenreListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackGenreListBox.FormattingEnabled = true;
            this.trackGenreListBox.ItemHeight = 20;
            this.trackGenreListBox.Location = new System.Drawing.Point(365, 47);
            this.trackGenreListBox.Name = "trackGenreListBox";
            this.trackGenreListBox.Size = new System.Drawing.Size(281, 244);
            this.trackGenreListBox.TabIndex = 50;
            // 
            // trackPerListView
            // 
            this.trackPerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.trackPerListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackPerListView.FullRowSelect = true;
            this.trackPerListView.HideSelection = false;
            this.trackPerListView.Location = new System.Drawing.Point(12, 47);
            this.trackPerListView.Name = "trackPerListView";
            this.trackPerListView.Size = new System.Drawing.Size(347, 244);
            this.trackPerListView.TabIndex = 49;
            this.trackPerListView.UseCompatibleStateImageBehavior = false;
            this.trackPerListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Номер исполнителя";
            this.columnHeader5.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Название исполнителя";
            this.columnHeader6.Width = 161;
            // 
            // trackAlbumListView
            // 
            this.trackAlbumListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.trackAlbumListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackAlbumListView.FullRowSelect = true;
            this.trackAlbumListView.HideSelection = false;
            this.trackAlbumListView.Location = new System.Drawing.Point(652, 47);
            this.trackAlbumListView.Name = "trackAlbumListView";
            this.trackAlbumListView.Size = new System.Drawing.Size(384, 244);
            this.trackAlbumListView.TabIndex = 48;
            this.trackAlbumListView.UseCompatibleStateImageBehavior = false;
            this.trackAlbumListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер альбома";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название альбома";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Год записи";
            this.columnHeader3.Width = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(567, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Альбомы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Исполнители:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(241, 317);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(118, 22);
            this.yearTextBox.TabIndex = 52;
            // 
            // yearSecondTextBox
            // 
            this.yearSecondTextBox.Location = new System.Drawing.Point(402, 390);
            this.yearSecondTextBox.Name = "yearSecondTextBox";
            this.yearSecondTextBox.Size = new System.Drawing.Size(118, 22);
            this.yearSecondTextBox.TabIndex = 53;
            // 
            // yearFirstTextBox
            // 
            this.yearFirstTextBox.Location = new System.Drawing.Point(241, 390);
            this.yearFirstTextBox.Name = "yearFirstTextBox";
            this.yearFirstTextBox.Size = new System.Drawing.Size(118, 22);
            this.yearFirstTextBox.TabIndex = 54;
            // 
            // groupeButton
            // 
            this.groupeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupeButton.Location = new System.Drawing.Point(791, 378);
            this.groupeButton.Name = "groupeButton";
            this.groupeButton.Size = new System.Drawing.Size(124, 34);
            this.groupeButton.TabIndex = 55;
            this.groupeButton.Text = "Применить";
            this.groupeButton.UseVisualStyleBackColor = true;
            this.groupeButton.Click += new System.EventHandler(this.groupeButton_Click);
            // 
            // groupeComboBox
            // 
            this.groupeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupeComboBox.FormattingEnabled = true;
            this.groupeComboBox.Items.AddRange(new object[] {
            "Исполнитель",
            "Жанр",
            "Альбом",
            "Год выпуска",
            "Период времени"});
            this.groupeComboBox.Location = new System.Drawing.Point(718, 315);
            this.groupeComboBox.Name = "groupeComboBox";
            this.groupeComboBox.Size = new System.Drawing.Size(261, 24);
            this.groupeComboBox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(237, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Год выпуска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(44, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Период выпуска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(398, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "До:";
            // 
            // GroupeTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupeComboBox);
            this.Controls.Add(this.groupeButton);
            this.Controls.Add(this.yearFirstTextBox);
            this.Controls.Add(this.yearSecondTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.trackGenreListBox);
            this.Controls.Add(this.trackPerListView);
            this.Controls.Add(this.trackAlbumListView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupeTrackForm";
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.GroupeTrackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox trackGenreListBox;
        private System.Windows.Forms.ListView trackPerListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView trackAlbumListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox yearSecondTextBox;
        private System.Windows.Forms.TextBox yearFirstTextBox;
        private System.Windows.Forms.Button groupeButton;
        private System.Windows.Forms.ComboBox groupeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}