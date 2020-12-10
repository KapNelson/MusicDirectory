
namespace MusicDirectory
{
    partial class AddGenreForm
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
            this.addGenreButton = new System.Windows.Forms.Button();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(288, 310);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(180, 24);
            this.addGenreButton.TabIndex = 11;
            this.addGenreButton.Text = "Добавить жанр";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(288, 193);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(180, 22);
            this.genreTextBox.TabIndex = 12;
            // 
            // AddGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.addGenreButton);
            this.Name = "AddGenreForm";
            this.Text = "AddGenreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.TextBox genreTextBox;
    }
}