
namespace MusicDirectory
{
    partial class PerformerInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformerInfoForm));
            this.countryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musicianListView = new System.Windows.Forms.ListView();
            this.nameMusPerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateEColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateLColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(281, 47);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(130, 20);
            this.countryLabel.TabIndex = 26;
            this.countryLabel.Text = "Неисзвестно";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(281, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(130, 20);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Неисзвестно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Страна:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название исполнителя:";
            // 
            // musicianListView
            // 
            this.musicianListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameMusPerColumn,
            this.birthColumn,
            this.dateEColumn,
            this.dateLColumn,
            this.roleColumn});
            this.musicianListView.FullRowSelect = true;
            this.musicianListView.HideSelection = false;
            this.musicianListView.Location = new System.Drawing.Point(12, 118);
            this.musicianListView.Name = "musicianListView";
            this.musicianListView.Size = new System.Drawing.Size(537, 253);
            this.musicianListView.TabIndex = 27;
            this.musicianListView.UseCompatibleStateImageBehavior = false;
            this.musicianListView.View = System.Windows.Forms.View.Details;
            // 
            // nameMusPerColumn
            // 
            this.nameMusPerColumn.Text = "ФИО музыканта";
            this.nameMusPerColumn.Width = 126;
            // 
            // birthColumn
            // 
            this.birthColumn.Text = "Дата рождения";
            // 
            // dateEColumn
            // 
            this.dateEColumn.Text = "Дата вступления";
            // 
            // dateLColumn
            // 
            this.dateLColumn.Text = "Дата выхода";
            // 
            // roleColumn
            // 
            this.roleColumn.Text = "Роль в группе";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(281, 85);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(130, 20);
            this.typeLabel.TabIndex = 29;
            this.typeLabel.Text = "Неисзвестно";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Тип:";
            // 
            // PerformerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 384);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.musicianListView);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerformerInfoForm";
            this.Text = "Информация о исполнителе";
            this.Load += new System.EventHandler(this.PerformerInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView musicianListView;
        private System.Windows.Forms.ColumnHeader nameMusPerColumn;
        private System.Windows.Forms.ColumnHeader dateEColumn;
        private System.Windows.Forms.ColumnHeader dateLColumn;
        private System.Windows.Forms.ColumnHeader roleColumn;
        private System.Windows.Forms.ColumnHeader birthColumn;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label label4;
    }
}