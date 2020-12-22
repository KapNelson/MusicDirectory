
namespace MusicDirectory
{
    partial class DiskInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiskInfoForm));
            this.diskListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.makerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.circulColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // diskListView
            // 
            this.diskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn,
            this.makerColumn,
            this.dateColumn,
            this.circulColumn,
            this.quantityColumn});
            this.diskListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diskListView.FullRowSelect = true;
            this.diskListView.GridLines = true;
            this.diskListView.HideSelection = false;
            this.diskListView.Location = new System.Drawing.Point(12, 12);
            this.diskListView.MultiSelect = false;
            this.diskListView.Name = "diskListView";
            this.diskListView.Size = new System.Drawing.Size(776, 426);
            this.diskListView.TabIndex = 31;
            this.diskListView.UseCompatibleStateImageBehavior = false;
            this.diskListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "Номер партии";
            this.idColumn.Width = 161;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Название диска";
            this.nameColumn.Width = 164;
            // 
            // makerColumn
            // 
            this.makerColumn.Text = "Производитель";
            this.makerColumn.Width = 157;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Дата выпуска";
            this.dateColumn.Width = 145;
            // 
            // circulColumn
            // 
            this.circulColumn.Text = "Тираж";
            this.circulColumn.Width = 86;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Количество треков";
            this.quantityColumn.Width = 184;
            // 
            // DiskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diskListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiskInfoForm";
            this.Text = "Диски с данным треком";
            this.Load += new System.EventHandler(this.DiskInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView diskListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader makerColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader circulColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
    }
}