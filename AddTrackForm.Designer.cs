
namespace MusicDirectory
{
    partial class AddTrackForm
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
            this.yearRecTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.performerComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addPerformerButton = new System.Windows.Forms.Button();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearRecTextBox
            // 
            this.yearRecTextBox.Location = new System.Drawing.Point(353, 94);
            this.yearRecTextBox.Name = "yearRecTextBox";
            this.yearRecTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearRecTextBox.TabIndex = 1;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(353, 208);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 22);
            this.durationTextBox.TabIndex = 2;
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(353, 252);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 22);
            this.numTextBox.TabIndex = 3;
            // 
            // performerComboBox
            // 
            this.performerComboBox.FormattingEnabled = true;
            this.performerComboBox.Location = new System.Drawing.Point(353, 153);
            this.performerComboBox.Name = "performerComboBox";
            this.performerComboBox.Size = new System.Drawing.Size(121, 24);
            this.performerComboBox.TabIndex = 4;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(353, 300);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(121, 24);
            this.genreComboBox.TabIndex = 5;
            // 
            // albumComboBox
            // 
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.Location = new System.Drawing.Point(353, 343);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(121, 24);
            this.albumComboBox.TabIndex = 6;
            // 
            // addTrackButton
            // 
            this.addTrackButton.Location = new System.Drawing.Point(334, 394);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(153, 53);
            this.addTrackButton.TabIndex = 7;
            this.addTrackButton.Text = "Добавить песню";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(353, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 8;
            // 
            // addPerformerButton
            // 
            this.addPerformerButton.Location = new System.Drawing.Point(502, 153);
            this.addPerformerButton.Name = "addPerformerButton";
            this.addPerformerButton.Size = new System.Drawing.Size(180, 24);
            this.addPerformerButton.TabIndex = 9;
            this.addPerformerButton.Text = "Добавить исполнителя";
            this.addPerformerButton.UseVisualStyleBackColor = true;
            this.addPerformerButton.Click += new System.EventHandler(this.addPerformerButton_Click);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(502, 299);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(180, 24);
            this.addGenreButton.TabIndex = 10;
            this.addGenreButton.Text = "Добавить жанр";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Location = new System.Drawing.Point(502, 342);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(180, 24);
            this.addAlbumButton.TabIndex = 11;
            this.addAlbumButton.Text = "Добавить альбом";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // AddTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.addAlbumButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.addPerformerButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addTrackButton);
            this.Controls.Add(this.albumComboBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.performerComboBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.yearRecTextBox);
            this.Name = "AddTrackForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox yearRecTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.ComboBox performerComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox albumComboBox;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addPerformerButton;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button addAlbumButton;
    }
}