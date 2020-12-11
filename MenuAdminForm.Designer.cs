
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trackDataGridView = new System.Windows.Forms.DataGridView();
            this.reloadButton = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackDataGridView)).BeginInit();
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
            // addAlbumButton
            // 
            this.addAlbumButton.Location = new System.Drawing.Point(568, 318);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(180, 24);
            this.addAlbumButton.TabIndex = 21;
            this.addAlbumButton.Text = "Добавить альбом";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(568, 275);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(180, 24);
            this.addGenreButton.TabIndex = 20;
            this.addGenreButton.Text = "Добавить жанр";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addPerformerButton
            // 
            this.addPerformerButton.Location = new System.Drawing.Point(568, 129);
            this.addPerformerButton.Name = "addPerformerButton";
            this.addPerformerButton.Size = new System.Drawing.Size(180, 24);
            this.addPerformerButton.TabIndex = 19;
            this.addPerformerButton.Text = "Добавить исполнителя";
            this.addPerformerButton.UseVisualStyleBackColor = true;
            this.addPerformerButton.Click += new System.EventHandler(this.addPerformerButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(402, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(153, 22);
            this.nameTextBox.TabIndex = 18;
            // 
            // albumComboBox
            // 
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.Location = new System.Drawing.Point(402, 319);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(153, 24);
            this.albumComboBox.TabIndex = 17;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(402, 276);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(153, 24);
            this.genreComboBox.TabIndex = 16;
            // 
            // performerComboBox
            // 
            this.performerComboBox.FormattingEnabled = true;
            this.performerComboBox.Location = new System.Drawing.Point(402, 129);
            this.performerComboBox.Name = "performerComboBox";
            this.performerComboBox.Size = new System.Drawing.Size(153, 24);
            this.performerComboBox.TabIndex = 15;
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(402, 228);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(153, 22);
            this.numTextBox.TabIndex = 14;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(402, 184);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(153, 22);
            this.durationTextBox.TabIndex = 13;
            // 
            // yearRecTextBox
            // 
            this.yearRecTextBox.Location = new System.Drawing.Point(402, 70);
            this.yearRecTextBox.Name = "yearRecTextBox";
            this.yearRecTextBox.Size = new System.Drawing.Size(153, 22);
            this.yearRecTextBox.TabIndex = 12;
            // 
            // addTrackButton
            // 
            this.addTrackButton.Location = new System.Drawing.Point(402, 358);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(153, 53);
            this.addTrackButton.TabIndex = 0;
            this.addTrackButton.Text = "Добавить песню\r\n";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.reloadButton);
            this.tabPage2.Controls.Add(this.trackDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удалить трек";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(941, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(851, 447);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(90, 23);
            this.reloadButton.TabIndex = 1;
            this.reloadButton.Text = "Обновить";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView trackDataGridView;
        private System.Windows.Forms.Button reloadButton;
    }
}