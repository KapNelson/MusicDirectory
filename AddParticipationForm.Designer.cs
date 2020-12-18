
namespace MusicDirectory
{
    partial class AddParticipationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddParticipationForm));
            this.musicianListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addInBandButton = new System.Windows.Forms.Button();
            this.addPerformerButton = new System.Windows.Forms.Button();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.leavingTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // musicianListView
            // 
            this.musicianListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn});
            this.musicianListView.HideSelection = false;
            this.musicianListView.Location = new System.Drawing.Point(12, 12);
            this.musicianListView.Name = "musicianListView";
            this.musicianListView.Size = new System.Drawing.Size(412, 306);
            this.musicianListView.TabIndex = 0;
            this.musicianListView.UseCompatibleStateImageBehavior = false;
            this.musicianListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "Номер музыканта";
            this.idColumn.Width = 142;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "ФИО музыканта";
            this.nameColumn.Width = 237;
            // 
            // addInBandButton
            // 
            this.addInBandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInBandButton.Location = new System.Drawing.Point(444, 76);
            this.addInBandButton.Name = "addInBandButton";
            this.addInBandButton.Size = new System.Drawing.Size(168, 63);
            this.addInBandButton.TabIndex = 30;
            this.addInBandButton.Text = "Добавить в группу";
            this.addInBandButton.UseVisualStyleBackColor = true;
            this.addInBandButton.Click += new System.EventHandler(this.addInBandButton_Click);
            // 
            // addPerformerButton
            // 
            this.addPerformerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPerformerButton.Location = new System.Drawing.Point(444, 199);
            this.addPerformerButton.Name = "addPerformerButton";
            this.addPerformerButton.Size = new System.Drawing.Size(168, 63);
            this.addPerformerButton.TabIndex = 31;
            this.addPerformerButton.Text = "Завершить набор";
            this.addPerformerButton.UseVisualStyleBackColor = true;
            this.addPerformerButton.Click += new System.EventHandler(this.addPerformerButton_Click);
            // 
            // entryTextBox
            // 
            this.entryTextBox.Location = new System.Drawing.Point(98, 341);
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(130, 22);
            this.entryTextBox.TabIndex = 33;
            this.entryTextBox.Text = "NULL";
            // 
            // leavingTextBox
            // 
            this.leavingTextBox.Location = new System.Drawing.Point(336, 341);
            this.leavingTextBox.Name = "leavingTextBox";
            this.leavingTextBox.Size = new System.Drawing.Size(130, 22);
            this.leavingTextBox.TabIndex = 34;
            this.leavingTextBox.Text = "NULL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Вступил:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(243, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Покинул:";
            // 
            // AddParticipationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leavingTextBox);
            this.Controls.Add(this.entryTextBox);
            this.Controls.Add(this.addPerformerButton);
            this.Controls.Add(this.addInBandButton);
            this.Controls.Add(this.musicianListView);
            this.Name = "AddParticipationForm";
            this.Text = "Добавить учасников в группу";
            this.Load += new System.EventHandler(this.AddParticipationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView musicianListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.Button addInBandButton;
        private System.Windows.Forms.Button addPerformerButton;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.TextBox leavingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}