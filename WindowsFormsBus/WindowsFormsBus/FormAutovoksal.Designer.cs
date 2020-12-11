namespace WindowsFormsBus
{
    partial class FormAutovoksal
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
            this.pictureBoxAutovoksal = new System.Windows.Forms.PictureBox();
            this.groupBoxTakingBus = new System.Windows.Forms.GroupBox();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxAutovoksal = new System.Windows.Forms.ListBox();
            this.Autovoksal = new System.Windows.Forms.Label();
            this.textBoxAutovoksalName = new System.Windows.Forms.TextBox();
            this.buttonAddAutovoksal = new System.Windows.Forms.Button();
            this.buttonDeleteAutovoksal = new System.Windows.Forms.Button();
            this.buttonAddBus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutovoksal)).BeginInit();
            this.groupBoxTakingBus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAutovoksal
            // 
            this.pictureBoxAutovoksal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAutovoksal.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxAutovoksal.Name = "pictureBoxAutovoksal";
            this.pictureBoxAutovoksal.Size = new System.Drawing.Size(1141, 573);
            this.pictureBoxAutovoksal.TabIndex = 0;
            this.pictureBoxAutovoksal.TabStop = false;
            // 
            // groupBoxTakingBus
            // 
            this.groupBoxTakingBus.Controls.Add(this.buttonTakeBus);
            this.groupBoxTakingBus.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxTakingBus.Controls.Add(this.labelPlace);
            this.groupBoxTakingBus.Location = new System.Drawing.Point(1200, 450);
            this.groupBoxTakingBus.Name = "groupBoxTakingBus";
            this.groupBoxTakingBus.Size = new System.Drawing.Size(150, 109);
            this.groupBoxTakingBus.TabIndex = 3;
            this.groupBoxTakingBus.TabStop = false;
            this.groupBoxTakingBus.Text = "Забрать автобус";
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(17, 64);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(103, 30);
            this.buttonTakeBus.TabIndex = 2;
            this.buttonTakeBus.Text = "Забрать";
            this.buttonTakeBus.UseVisualStyleBackColor = true;
            this.buttonTakeBus.Click += new System.EventHandler(this.buttonTakeBus_Click_1);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(73, 36);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(47, 22);
            this.maskedTextBoxNumber.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(14, 36);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxAutovoksal
            // 
            this.listBoxAutovoksal.FormattingEnabled = true;
            this.listBoxAutovoksal.ItemHeight = 16;
            this.listBoxAutovoksal.Location = new System.Drawing.Point(1203, 125);
            this.listBoxAutovoksal.Name = "listBoxAutovoksal";
            this.listBoxAutovoksal.Size = new System.Drawing.Size(150, 116);
            this.listBoxAutovoksal.TabIndex = 4;
            this.listBoxAutovoksal.Click += new System.EventHandler(this.listBoxAutovoksal_SelectedIndexChanged);
            // 
            // Autovoksal
            // 
            this.Autovoksal.AutoSize = true;
            this.Autovoksal.Location = new System.Drawing.Point(1239, 21);
            this.Autovoksal.Name = "Autovoksal";
            this.Autovoksal.Size = new System.Drawing.Size(84, 17);
            this.Autovoksal.TabIndex = 5;
            this.Autovoksal.Text = "Автовокзал";
            // 
            // textBoxAutovoksalName
            // 
            this.textBoxAutovoksalName.Location = new System.Drawing.Point(1203, 41);
            this.textBoxAutovoksalName.Name = "textBoxAutovoksalName";
            this.textBoxAutovoksalName.Size = new System.Drawing.Size(150, 22);
            this.textBoxAutovoksalName.TabIndex = 6;
            // 
            // buttonAddAutovoksal
            // 
            this.buttonAddAutovoksal.Location = new System.Drawing.Point(1200, 69);
            this.buttonAddAutovoksal.Name = "buttonAddAutovoksal";
            this.buttonAddAutovoksal.Size = new System.Drawing.Size(153, 50);
            this.buttonAddAutovoksal.TabIndex = 7;
            this.buttonAddAutovoksal.Text = "Добавить автокозал";
            this.buttonAddAutovoksal.UseVisualStyleBackColor = true;
            this.buttonAddAutovoksal.Click += new System.EventHandler(this.buttonAddAutovoksal_Click);
            // 
            // buttonDeleteAutovoksal
            // 
            this.buttonDeleteAutovoksal.Location = new System.Drawing.Point(1200, 247);
            this.buttonDeleteAutovoksal.Name = "buttonDeleteAutovoksal";
            this.buttonDeleteAutovoksal.Size = new System.Drawing.Size(150, 34);
            this.buttonDeleteAutovoksal.TabIndex = 8;
            this.buttonDeleteAutovoksal.Text = "Удалить автовокзал";
            this.buttonDeleteAutovoksal.UseVisualStyleBackColor = true;
            this.buttonDeleteAutovoksal.Click += new System.EventHandler(this.buttonDeleteAutovoksal_Click_1);
            // 
            // buttonAddBus
            // 
            this.buttonAddBus.Location = new System.Drawing.Point(1203, 380);
            this.buttonAddBus.Name = "buttonAddBus";
            this.buttonAddBus.Size = new System.Drawing.Size(144, 53);
            this.buttonAddBus.TabIndex = 9;
            this.buttonAddBus.Text = "Добавить автобус";
            this.buttonAddBus.UseVisualStyleBackColor = true;
            this.buttonAddBus.Click += new System.EventHandler(this.buttonAddBus_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1359, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(1203, 304);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(144, 45);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormAutovoksal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 601);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddBus);
            this.Controls.Add(this.buttonDeleteAutovoksal);
            this.Controls.Add(this.buttonAddAutovoksal);
            this.Controls.Add(this.textBoxAutovoksalName);
            this.Controls.Add(this.Autovoksal);
            this.Controls.Add(this.listBoxAutovoksal);
            this.Controls.Add(this.groupBoxTakingBus);
            this.Controls.Add(this.pictureBoxAutovoksal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAutovoksal";
            this.Text = "Автовокзал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutovoksal)).EndInit();
            this.groupBoxTakingBus.ResumeLayout(false);
            this.groupBoxTakingBus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAutovoksal;
        private System.Windows.Forms.GroupBox groupBoxTakingBus;
        private System.Windows.Forms.Button buttonTakeBus;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxAutovoksal;
        private System.Windows.Forms.Label Autovoksal;
        private System.Windows.Forms.TextBox textBoxAutovoksalName;
        private System.Windows.Forms.Button buttonAddAutovoksal;
        private System.Windows.Forms.Button buttonDeleteAutovoksal;
        private System.Windows.Forms.Button buttonAddBus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}