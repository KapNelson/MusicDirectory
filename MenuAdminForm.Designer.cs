
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
            this.addTrackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTrackButton
            // 
            this.addTrackButton.Location = new System.Drawing.Point(406, 358);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(153, 53);
            this.addTrackButton.TabIndex = 0;
            this.addTrackButton.Text = "Добавить песню\r\n";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // MenuAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.addTrackButton);
            this.Name = "MenuAdminForm";
            this.Text = "Меню администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTrackButton;
    }
}