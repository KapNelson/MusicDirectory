
namespace MusicDirectory
{
    partial class MenuUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUserForm));
            this.trackListView = new System.Windows.Forms.ListView();
            this.nameTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.performerTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trackListView
            // 
            this.trackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameTrack,
            this.performerTrack,
            this.yearTrack});
            this.trackListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackListView.GridLines = true;
            this.trackListView.HideSelection = false;
            this.trackListView.Location = new System.Drawing.Point(12, 12);
            this.trackListView.Name = "trackListView";
            this.trackListView.Size = new System.Drawing.Size(918, 399);
            this.trackListView.TabIndex = 0;
            this.trackListView.UseCompatibleStateImageBehavior = false;
            this.trackListView.View = System.Windows.Forms.View.Details;
            // 
            // nameTrack
            // 
            this.nameTrack.Text = "Название трека";
            this.nameTrack.Width = 261;
            // 
            // performerTrack
            // 
            this.performerTrack.Text = "Исполнитель";
            this.performerTrack.Width = 243;
            // 
            // yearTrack
            // 
            this.yearTrack.Text = "Год выпуска";
            this.yearTrack.Width = 126;
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Location = new System.Drawing.Point(371, 417);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(64, 64);
            this.playButton.TabIndex = 1;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseButton.Location = new System.Drawing.Point(555, 417);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(64, 64);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoButton.BackgroundImage")));
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoButton.Location = new System.Drawing.Point(464, 417);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(64, 64);
            this.infoButton.TabIndex = 3;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // MenuUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.trackListView);
            this.Name = "MenuUserForm";
            this.Text = "Список треков";
            this.Load += new System.EventHandler(this.MenuUserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView trackListView;
        private System.Windows.Forms.ColumnHeader nameTrack;
        private System.Windows.Forms.ColumnHeader performerTrack;
        private System.Windows.Forms.ColumnHeader yearTrack;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button infoButton;
    }
}