
namespace MusicDirectory
{
    partial class MenuDiskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDiskForm));
            this.diskListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.makerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.circulColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trackListView = new System.Windows.Forms.ListView();
            this.numOnDiskColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.performerTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.deleteTrackButton = new System.Windows.Forms.Button();
            this.albumGroupBox = new System.Windows.Forms.GroupBox();
            this.mixRadioButton = new System.Windows.Forms.RadioButton();
            this.albumListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.albumRadioButton = new System.Windows.Forms.RadioButton();
            this.circulTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.addDiskButton = new System.Windows.Forms.Button();
            this.updateDiskButton = new System.Windows.Forms.Button();
            this.deleteDiskButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.batchNumTextBox = new System.Windows.Forms.TextBox();
            this.makerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statisticButton = new System.Windows.Forms.Button();
            this.albumGroupBox.SuspendLayout();
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
            this.diskListView.Size = new System.Drawing.Size(910, 451);
            this.diskListView.TabIndex = 30;
            this.diskListView.UseCompatibleStateImageBehavior = false;
            this.diskListView.View = System.Windows.Forms.View.Details;
            this.diskListView.Click += new System.EventHandler(this.diskListView_Click);
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
            // trackListView
            // 
            this.trackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numOnDiskColumn,
            this.idTrack,
            this.nameTrack,
            this.performerTrack,
            this.yearTrack});
            this.trackListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackListView.FullRowSelect = true;
            this.trackListView.GridLines = true;
            this.trackListView.HideSelection = false;
            this.trackListView.Location = new System.Drawing.Point(949, 12);
            this.trackListView.MultiSelect = false;
            this.trackListView.Name = "trackListView";
            this.trackListView.Size = new System.Drawing.Size(431, 451);
            this.trackListView.TabIndex = 31;
            this.trackListView.UseCompatibleStateImageBehavior = false;
            this.trackListView.View = System.Windows.Forms.View.Details;
            // 
            // numOnDiskColumn
            // 
            this.numOnDiskColumn.Text = "Номер на диске";
            // 
            // idTrack
            // 
            this.idTrack.Text = "Номер трека";
            this.idTrack.Width = 121;
            // 
            // nameTrack
            // 
            this.nameTrack.Text = "Название трека";
            this.nameTrack.Width = 150;
            // 
            // performerTrack
            // 
            this.performerTrack.Text = "Исполнитель";
            this.performerTrack.Width = 123;
            // 
            // yearTrack
            // 
            this.yearTrack.Text = "Год выпуска";
            this.yearTrack.Width = 126;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(949, 568);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(431, 23);
            this.progressBar.TabIndex = 32;
            // 
            // addTrackButton
            // 
            this.addTrackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTrackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addTrackButton.Location = new System.Drawing.Point(1008, 480);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(122, 25);
            this.addTrackButton.TabIndex = 40;
            this.addTrackButton.Text = "Добавить";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // deleteTrackButton
            // 
            this.deleteTrackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTrackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteTrackButton.Location = new System.Drawing.Point(1210, 480);
            this.deleteTrackButton.Name = "deleteTrackButton";
            this.deleteTrackButton.Size = new System.Drawing.Size(122, 24);
            this.deleteTrackButton.TabIndex = 39;
            this.deleteTrackButton.Text = "Удалить";
            this.deleteTrackButton.UseVisualStyleBackColor = true;
            this.deleteTrackButton.Click += new System.EventHandler(this.deleteTrackButton_Click);
            // 
            // albumGroupBox
            // 
            this.albumGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.albumGroupBox.Controls.Add(this.mixRadioButton);
            this.albumGroupBox.Controls.Add(this.albumListView);
            this.albumGroupBox.Controls.Add(this.albumRadioButton);
            this.albumGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.albumGroupBox.Location = new System.Drawing.Point(12, 480);
            this.albumGroupBox.Name = "albumGroupBox";
            this.albumGroupBox.Size = new System.Drawing.Size(465, 266);
            this.albumGroupBox.TabIndex = 45;
            this.albumGroupBox.TabStop = false;
            this.albumGroupBox.Text = "Доступные альбомы";
            // 
            // mixRadioButton
            // 
            this.mixRadioButton.AutoSize = true;
            this.mixRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.mixRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mixRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mixRadioButton.Location = new System.Drawing.Point(259, 231);
            this.mixRadioButton.Name = "mixRadioButton";
            this.mixRadioButton.Size = new System.Drawing.Size(104, 24);
            this.mixRadioButton.TabIndex = 65;
            this.mixRadioButton.TabStop = true;
            this.mixRadioButton.Text = "Сборный";
            this.mixRadioButton.UseVisualStyleBackColor = false;
            // 
            // albumListView
            // 
            this.albumListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.albumListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumListView.FullRowSelect = true;
            this.albumListView.HideSelection = false;
            this.albumListView.Location = new System.Drawing.Point(6, 21);
            this.albumListView.Name = "albumListView";
            this.albumListView.Size = new System.Drawing.Size(440, 204);
            this.albumListView.TabIndex = 46;
            this.albumListView.UseCompatibleStateImageBehavior = false;
            this.albumListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер альбома";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название альбома";
            this.columnHeader2.Width = 171;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Год записи";
            this.columnHeader3.Width = 110;
            // 
            // albumRadioButton
            // 
            this.albumRadioButton.AutoSize = true;
            this.albumRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.albumRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.albumRadioButton.Location = new System.Drawing.Point(73, 231);
            this.albumRadioButton.Name = "albumRadioButton";
            this.albumRadioButton.Size = new System.Drawing.Size(126, 24);
            this.albumRadioButton.TabIndex = 64;
            this.albumRadioButton.TabStop = true;
            this.albumRadioButton.Text = "Альбомный";
            this.albumRadioButton.UseVisualStyleBackColor = false;
            // 
            // circulTextBox
            // 
            this.circulTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circulTextBox.Location = new System.Drawing.Point(729, 639);
            this.circulTextBox.Name = "circulTextBox";
            this.circulTextBox.Size = new System.Drawing.Size(171, 23);
            this.circulTextBox.TabIndex = 62;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTextBox.Location = new System.Drawing.Point(729, 610);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(171, 23);
            this.dateTextBox.TabIndex = 61;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(729, 552);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 23);
            this.nameTextBox.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(561, 610);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 20);
            this.label19.TabIndex = 59;
            this.label19.Text = "Дата выпуска:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(595, 552);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 58;
            this.label16.Text = "Название:";
            // 
            // addDiskButton
            // 
            this.addDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDiskButton.Location = new System.Drawing.Point(538, 711);
            this.addDiskButton.Name = "addDiskButton";
            this.addDiskButton.Size = new System.Drawing.Size(112, 33);
            this.addDiskButton.TabIndex = 57;
            this.addDiskButton.Text = "Добавить";
            this.addDiskButton.UseVisualStyleBackColor = true;
            this.addDiskButton.Click += new System.EventHandler(this.addDiskButton_Click);
            // 
            // updateDiskButton
            // 
            this.updateDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateDiskButton.Location = new System.Drawing.Point(695, 710);
            this.updateDiskButton.Name = "updateDiskButton";
            this.updateDiskButton.Size = new System.Drawing.Size(112, 33);
            this.updateDiskButton.TabIndex = 56;
            this.updateDiskButton.Text = "Обновить";
            this.updateDiskButton.UseVisualStyleBackColor = true;
            this.updateDiskButton.Click += new System.EventHandler(this.updateDiskButton_Click);
            // 
            // deleteDiskButton
            // 
            this.deleteDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteDiskButton.Location = new System.Drawing.Point(857, 711);
            this.deleteDiskButton.Name = "deleteDiskButton";
            this.deleteDiskButton.Size = new System.Drawing.Size(112, 33);
            this.deleteDiskButton.TabIndex = 55;
            this.deleteDiskButton.Text = "Удалить";
            this.deleteDiskButton.UseVisualStyleBackColor = true;
            this.deleteDiskButton.Click += new System.EventHandler(this.deleteDiskButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(625, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Тираж:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(543, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Производитель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(557, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Номер партии:";
            // 
            // batchNumTextBox
            // 
            this.batchNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batchNumTextBox.Location = new System.Drawing.Point(729, 523);
            this.batchNumTextBox.Name = "batchNumTextBox";
            this.batchNumTextBox.Size = new System.Drawing.Size(171, 23);
            this.batchNumTextBox.TabIndex = 49;
            // 
            // makerTextBox
            // 
            this.makerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makerTextBox.Location = new System.Drawing.Point(729, 581);
            this.makerTextBox.Name = "makerTextBox";
            this.makerTextBox.Size = new System.Drawing.Size(171, 23);
            this.makerTextBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(945, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Место на диске:";
            // 
            // statisticButton
            // 
            this.statisticButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statisticButton.Location = new System.Drawing.Point(1105, 638);
            this.statisticButton.Name = "statisticButton";
            this.statisticButton.Size = new System.Drawing.Size(122, 25);
            this.statisticButton.TabIndex = 64;
            this.statisticButton.Text = "Статистика";
            this.statisticButton.UseVisualStyleBackColor = true;
            this.statisticButton.Click += new System.EventHandler(this.statisticButton_Click);
            // 
            // MenuDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1392, 758);
            this.Controls.Add(this.statisticButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.circulTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.addDiskButton);
            this.Controls.Add(this.updateDiskButton);
            this.Controls.Add(this.deleteDiskButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batchNumTextBox);
            this.Controls.Add(this.makerTextBox);
            this.Controls.Add(this.albumGroupBox);
            this.Controls.Add(this.addTrackButton);
            this.Controls.Add(this.deleteTrackButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.trackListView);
            this.Controls.Add(this.diskListView);
            this.Name = "MenuDiskForm";
            this.Text = "Управление дисками";
            this.Load += new System.EventHandler(this.MenuDiskForm_Load);
            this.albumGroupBox.ResumeLayout(false);
            this.albumGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView diskListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader makerColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader circulColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ListView trackListView;
        private System.Windows.Forms.ColumnHeader idTrack;
        private System.Windows.Forms.ColumnHeader nameTrack;
        private System.Windows.Forms.ColumnHeader performerTrack;
        private System.Windows.Forms.ColumnHeader yearTrack;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.Button deleteTrackButton;
        private System.Windows.Forms.GroupBox albumGroupBox;
        private System.Windows.Forms.ListView albumListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox circulTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button addDiskButton;
        private System.Windows.Forms.Button updateDiskButton;
        private System.Windows.Forms.Button deleteDiskButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox batchNumTextBox;
        private System.Windows.Forms.TextBox makerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton mixRadioButton;
        private System.Windows.Forms.RadioButton albumRadioButton;
        private System.Windows.Forms.ColumnHeader numOnDiskColumn;
        private System.Windows.Forms.Button statisticButton;
    }
}