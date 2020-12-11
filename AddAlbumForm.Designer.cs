
namespace MusicDirectory
{
    partial class AddAlbumForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.yearRecTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(311, 101);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 22);
            this.nameTextBox.TabIndex = 19;
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Location = new System.Drawing.Point(311, 325);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(180, 24);
            this.addAlbumButton.TabIndex = 18;
            this.addAlbumButton.Text = "Добавить альбом";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // yearRecTextBox
            // 
            this.yearRecTextBox.Location = new System.Drawing.Point(310, 149);
            this.yearRecTextBox.Name = "yearRecTextBox";
            this.yearRecTextBox.Size = new System.Drawing.Size(181, 22);
            this.yearRecTextBox.TabIndex = 17;
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(310, 196);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(181, 22);
            this.numTextBox.TabIndex = 2;
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addAlbumButton);
            this.Controls.Add(this.yearRecTextBox);
            this.Name = "AddAlbumForm";
            this.Text = "AddAlbumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.TextBox yearRecTextBox;
        private System.Windows.Forms.TextBox numTextBox;
    }
}