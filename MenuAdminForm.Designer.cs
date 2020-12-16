
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.usersListView = new System.Windows.Forms.ListView();
            this.loginColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.yearRecTextBox = new System.Windows.Forms.TextBox();
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.performerComboBox = new System.Windows.Forms.ComboBox();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.albumListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearRecColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteAlbumButton = new System.Windows.Forms.Button();
            this.updateAlbumButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numAlbumTextBox = new System.Windows.Forms.TextBox();
            this.nameAlbumTextBox = new System.Windows.Forms.TextBox();
            this.yearRecAlbumTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.adminTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.deleteUserButton);
            this.tabPage3.Controls.Add(this.usersListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(941, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Управление пользователями";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUserButton.Location = new System.Drawing.Point(671, 395);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(195, 42);
            this.deleteUserButton.TabIndex = 1;
            this.deleteUserButton.Text = "Удалить пользователя";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // usersListView
            // 
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.loginColumn,
            this.passwordColumn,
            this.adminColumn});
            this.usersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListView.HideSelection = false;
            this.usersListView.Location = new System.Drawing.Point(11, 6);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(509, 451);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.Details;
            // 
            // loginColumn
            // 
            this.loginColumn.Text = "Логин";
            this.loginColumn.Width = 113;
            // 
            // passwordColumn
            // 
            this.passwordColumn.Text = "Пароль";
            this.passwordColumn.Width = 123;
            // 
            // adminColumn
            // 
            this.adminColumn.Text = "Администратор";
            this.adminColumn.Width = 151;
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
            this.tabPage1.Controls.Add(this.numTextBox);
            this.tabPage1.Controls.Add(this.durationTextBox);
            this.tabPage1.Controls.Add(this.yearRecTextBox);
            this.tabPage1.Controls.Add(this.albumComboBox);
            this.tabPage1.Controls.Add(this.genreComboBox);
            this.tabPage1.Controls.Add(this.performerComboBox);
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
            this.label7.Location = new System.Drawing.Point(258, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Жанр:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(133, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Номер в альбоме:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(233, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Альбом:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(98, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Продолжительность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(177, 123);
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
            this.label2.Location = new System.Drawing.Point(199, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Год записи:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(153, 29);
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
            // albumComboBox
            // 
            this.albumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.Location = new System.Drawing.Point(359, 224);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(228, 33);
            this.albumComboBox.TabIndex = 17;
            // 
            // genreComboBox
            // 
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(359, 333);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(228, 33);
            this.genreComboBox.TabIndex = 16;
            // 
            // performerComboBox
            // 
            this.performerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.performerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performerComboBox.FormattingEnabled = true;
            this.performerComboBox.Location = new System.Drawing.Point(359, 120);
            this.performerComboBox.Name = "performerComboBox";
            this.performerComboBox.Size = new System.Drawing.Size(228, 33);
            this.performerComboBox.TabIndex = 15;
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
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.numAlbumTextBox);
            this.tabPage2.Controls.Add(this.nameAlbumTextBox);
            this.tabPage2.Controls.Add(this.yearRecAlbumTextBox);
            this.tabPage2.Controls.Add(this.updateAlbumButton);
            this.tabPage2.Controls.Add(this.deleteAlbumButton);
            this.tabPage2.Controls.Add(this.albumListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 473);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Управление альбомами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // albumListView
            // 
            this.albumListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn,
            this.yearRecColumn,
            this.numColumn});
            this.albumListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumListView.FullRowSelect = true;
            this.albumListView.HideSelection = false;
            this.albumListView.Location = new System.Drawing.Point(420, 6);
            this.albumListView.Name = "albumListView";
            this.albumListView.Size = new System.Drawing.Size(509, 451);
            this.albumListView.TabIndex = 1;
            this.albumListView.UseCompatibleStateImageBehavior = false;
            this.albumListView.View = System.Windows.Forms.View.Details;
            this.albumListView.Click += new System.EventHandler(this.albumListView_Click);
            // 
            // idColumn
            // 
            this.idColumn.Text = "Номер альбома";
            this.idColumn.Width = 113;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Название альбома";
            this.nameColumn.Width = 123;
            // 
            // yearRecColumn
            // 
            this.yearRecColumn.Text = "Год записи";
            this.yearRecColumn.Width = 151;
            // 
            // numColumn
            // 
            this.numColumn.Text = "Кол-во треков";
            // 
            // deleteAlbumButton
            // 
            this.deleteAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAlbumButton.Location = new System.Drawing.Point(104, 411);
            this.deleteAlbumButton.Name = "deleteAlbumButton";
            this.deleteAlbumButton.Size = new System.Drawing.Size(180, 46);
            this.deleteAlbumButton.TabIndex = 22;
            this.deleteAlbumButton.Text = "Удалить альбом";
            this.deleteAlbumButton.UseVisualStyleBackColor = true;
            this.deleteAlbumButton.Click += new System.EventHandler(this.deleteAlbumButton_Click);
            // 
            // updateAlbumButton
            // 
            this.updateAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateAlbumButton.Location = new System.Drawing.Point(104, 334);
            this.updateAlbumButton.Name = "updateAlbumButton";
            this.updateAlbumButton.Size = new System.Drawing.Size(180, 46);
            this.updateAlbumButton.TabIndex = 23;
            this.updateAlbumButton.Text = "Обновить альбом";
            this.updateAlbumButton.UseVisualStyleBackColor = true;
            this.updateAlbumButton.Click += new System.EventHandler(this.updateAlbumButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Количиство треков:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(83, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Год записи:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(18, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Название альбома:";
            // 
            // numAlbumTextBox
            // 
            this.numAlbumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numAlbumTextBox.Location = new System.Drawing.Point(222, 218);
            this.numAlbumTextBox.Name = "numAlbumTextBox";
            this.numAlbumTextBox.Size = new System.Drawing.Size(181, 26);
            this.numAlbumTextBox.TabIndex = 26;
            // 
            // nameAlbumTextBox
            // 
            this.nameAlbumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAlbumTextBox.Location = new System.Drawing.Point(223, 123);
            this.nameAlbumTextBox.Name = "nameAlbumTextBox";
            this.nameAlbumTextBox.Size = new System.Drawing.Size(180, 26);
            this.nameAlbumTextBox.TabIndex = 28;
            // 
            // yearRecAlbumTextBox
            // 
            this.yearRecAlbumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearRecAlbumTextBox.Location = new System.Drawing.Point(222, 171);
            this.yearRecAlbumTextBox.Name = "yearRecAlbumTextBox";
            this.yearRecAlbumTextBox.Size = new System.Drawing.Size(181, 26);
            this.yearRecAlbumTextBox.TabIndex = 27;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.adminTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.ColumnHeader loginColumn;
        private System.Windows.Forms.ColumnHeader passwordColumn;
        private System.Windows.Forms.ColumnHeader adminColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button addPerformerButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox yearRecTextBox;
        private System.Windows.Forms.ComboBox albumComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox performerComboBox;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView albumListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader yearRecColumn;
        private System.Windows.Forms.ColumnHeader numColumn;
        private System.Windows.Forms.Button deleteAlbumButton;
        private System.Windows.Forms.Button updateAlbumButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numAlbumTextBox;
        private System.Windows.Forms.TextBox nameAlbumTextBox;
        private System.Windows.Forms.TextBox yearRecAlbumTextBox;
    }
}