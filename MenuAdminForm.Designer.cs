
namespace MusicDirectory
{
    partial class MenuAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdminForm));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.addPerformerButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.performerComboBox = new System.Windows.Forms.ComboBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.yearRecTextBox = new System.Windows.Forms.TextBox();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reloadTrackButton = new System.Windows.Forms.Button();
            this.trackDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reloadUsersButton = new System.Windows.Forms.Button();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.adminTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.tabPage1);
            this.adminTabControl.Controls.Add(this.tabPage2);
            this.adminTabControl.Controls.Add(this.tabPage3);
            this.adminTabControl.Location = new System.Drawing.Point(-3, -1);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(949, 502);
            this.adminTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.addAlbumButton);
            this.tabPage1.Controls.Add(this.addGenreButton);
            this.tabPage1.Controls.Add(this.addPerformerButton);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.albumComboBox);
            this.tabPage1.Controls.Add(this.genreComboBox);
            this.tabPage1.Controls.Add(this.performerComboBox);
            this.tabPage1.Controls.Add(this.numTextBox);
            this.tabPage1.Controls.Add(this.durationTextBox);
            this.tabPage1.Controls.Add(this.yearRecTextBox);
            this.tabPage1.Controls.Add(this.addTrackButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить трек";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(216, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Альбом:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(241, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Жанр:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(116, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Номер в альбоме:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(145, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Длительность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(160, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Исполнитель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(167, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Дата записи:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(136, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название трека:";
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAlbumButton.Location = new System.Drawing.Point(621, 218);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(180, 46);
            this.addAlbumButton.TabIndex = 21;
            this.addAlbumButton.Text = "Добавить альбом";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGenreButton.Location = new System.Drawing.Point(621, 327);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(180, 46);
            this.addGenreButton.TabIndex = 20;
            this.addGenreButton.Text = "Добавить жанр";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addPerformerButton
            // 
            this.addPerformerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPerformerButton.Location = new System.Drawing.Point(621, 109);
            this.addPerformerButton.Name = "addPerformerButton";
            this.addPerformerButton.Size = new System.Drawing.Size(180, 56);
            this.addPerformerButton.TabIndex = 19;
            this.addPerformerButton.Text = "Добавить исполнителя";
            this.addPerformerButton.UseVisualStyleBackColor = true;
            this.addPerformerButton.Click += new System.EventHandler(this.addPerformerButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(359, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 30);
            this.nameTextBox.TabIndex = 18;
            // 
            // albumComboBox
            // 
            this.albumComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.Location = new System.Drawing.Point(359, 224);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(228, 33);
            this.albumComboBox.TabIndex = 17;
            // 
            // genreComboBox
            // 
            this.genreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(359, 333);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(228, 33);
            this.genreComboBox.TabIndex = 16;
            // 
            // performerComboBox
            // 
            this.performerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performerComboBox.FormattingEnabled = true;
            this.performerComboBox.Location = new System.Drawing.Point(359, 120);
            this.performerComboBox.Name = "performerComboBox";
            this.performerComboBox.Size = new System.Drawing.Size(228, 33);
            this.performerComboBox.TabIndex = 15;
            // 
            // numTextBox
            // 
            this.numTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTextBox.Location = new System.Drawing.Point(359, 276);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(228, 30);
            this.numTextBox.TabIndex = 14;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationTextBox.Location = new System.Drawing.Point(359, 176);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(228, 30);
            this.durationTextBox.TabIndex = 13;
            // 
            // yearRecTextBox
            // 
            this.yearRecTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearRecTextBox.Location = new System.Drawing.Point(359, 70);
            this.yearRecTextBox.Name = "yearRecTextBox";
            this.yearRecTextBox.Size = new System.Drawing.Size(228, 30);
            this.yearRecTextBox.TabIndex = 12;
            // 
            // addTrackButton
            // 
            this.addTrackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTrackButton.Location = new System.Drawing.Point(404, 380);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(153, 68);
            this.addTrackButton.TabIndex = 0;
            this.addTrackButton.Text = "Добавить песню\r\n";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reloadTrackButton);
            this.tabPage2.Controls.Add(this.trackDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Управление треками";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reloadTrackButton
            // 
            this.reloadTrackButton.Location = new System.Drawing.Point(848, 444);
            this.reloadTrackButton.Name = "reloadTrackButton";
            this.reloadTrackButton.Size = new System.Drawing.Size(90, 23);
            this.reloadTrackButton.TabIndex = 1;
            this.reloadTrackButton.Text = "Обновить";
            this.reloadTrackButton.UseVisualStyleBackColor = true;
            this.reloadTrackButton.Click += new System.EventHandler(this.reloadTrackButton_Click);
            // 
            // trackDataGridView
            // 
            this.trackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trackDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackDataGridView.Location = new System.Drawing.Point(3, 3);
            this.trackDataGridView.Name = "trackDataGridView";
            this.trackDataGridView.RowHeadersWidth = 51;
            this.trackDataGridView.RowTemplate.Height = 24;
            this.trackDataGridView.Size = new System.Drawing.Size(935, 467);
            this.trackDataGridView.TabIndex = 0;
            this.trackDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trackDataGridView_CellContentClick);
            this.trackDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.trackDataGridView_CellValueChanged);
            this.trackDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.trackDataGridView_EditingControlShowing);
            this.trackDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.trackDataGridView_UserAddedRow);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reloadUsersButton);
            this.tabPage3.Controls.Add(this.usersDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(941, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Управление пользователями";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reloadUsersButton
            // 
            this.reloadUsersButton.Location = new System.Drawing.Point(849, 444);
            this.reloadUsersButton.Name = "reloadUsersButton";
            this.reloadUsersButton.Size = new System.Drawing.Size(89, 26);
            this.reloadUsersButton.TabIndex = 1;
            this.reloadUsersButton.Text = "Обновить";
            this.reloadUsersButton.UseVisualStyleBackColor = true;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(935, 467);
            this.usersDataGridView.TabIndex = 0;
            // 
            // MenuAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.adminTabControl);
            this.Name = "MenuAdminForm";
            this.Text = "Меню администратора";
            this.Load += new System.EventHandler(this.MenuAdminForm_Load);
            this.adminTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button addPerformerButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox albumComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox performerComboBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox yearRecTextBox;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView trackDataGridView;
        private System.Windows.Forms.Button reloadTrackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button reloadUsersButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
    }
}