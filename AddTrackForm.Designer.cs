
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrackForm));
            this.addTrackButton = new System.Windows.Forms.Button();
            this.trackListView = new System.Windows.Forms.ListView();
            this.idTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.performerTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.albumTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durationTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTrackButton
            // 
            this.addTrackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTrackButton.Location = new System.Drawing.Point(512, 386);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(112, 52);
            this.addTrackButton.TabIndex = 58;
            this.addTrackButton.Text = "Добавить трек";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // trackListView
            // 
            this.trackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTrack,
            this.nameTrack,
            this.performerTrack,
            this.yearTrack,
            this.albumTrack,
            this.numTrack,
            this.genreTrack,
            this.durationTrack});
            this.trackListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackListView.FullRowSelect = true;
            this.trackListView.GridLines = true;
            this.trackListView.HideSelection = false;
            this.trackListView.Location = new System.Drawing.Point(12, 12);
            this.trackListView.MultiSelect = false;
            this.trackListView.Name = "trackListView";
            this.trackListView.Size = new System.Drawing.Size(776, 360);
            this.trackListView.TabIndex = 59;
            this.trackListView.UseCompatibleStateImageBehavior = false;
            this.trackListView.View = System.Windows.Forms.View.Details;
            // 
            // idTrack
            // 
            this.idTrack.Text = "Номер трека";
            this.idTrack.Width = 130;
            // 
            // nameTrack
            // 
            this.nameTrack.Text = "Название трека";
            this.nameTrack.Width = 164;
            // 
            // performerTrack
            // 
            this.performerTrack.Text = "Исполнитель";
            this.performerTrack.Width = 136;
            // 
            // yearTrack
            // 
            this.yearTrack.Text = "Год выпуска";
            this.yearTrack.Width = 126;
            // 
            // albumTrack
            // 
            this.albumTrack.Text = "Альбом";
            this.albumTrack.Width = 86;
            // 
            // numTrack
            // 
            this.numTrack.Text = "Номер в альбоме";
            this.numTrack.Width = 164;
            // 
            // genreTrack
            // 
            this.genreTrack.Text = "Жанр";
            // 
            // durationTrack
            // 
            this.durationTrack.Text = "Длительность";
            this.durationTrack.Width = 140;
            // 
            // numTextBox
            // 
            this.numTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTextBox.Location = new System.Drawing.Point(261, 399);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(212, 26);
            this.numTextBox.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Номер на диске:";
            // 
            // AddTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.trackListView);
            this.Controls.Add(this.addTrackButton);
            this.Name = "AddTrackForm";
            this.Text = "Добавить треки";
            this.Load += new System.EventHandler(this.AddTrackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.ListView trackListView;
        private System.Windows.Forms.ColumnHeader idTrack;
        private System.Windows.Forms.ColumnHeader nameTrack;
        private System.Windows.Forms.ColumnHeader performerTrack;
        private System.Windows.Forms.ColumnHeader yearTrack;
        private System.Windows.Forms.ColumnHeader albumTrack;
        private System.Windows.Forms.ColumnHeader numTrack;
        private System.Windows.Forms.ColumnHeader genreTrack;
        private System.Windows.Forms.ColumnHeader durationTrack;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Label label1;
    }
}