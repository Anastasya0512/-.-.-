namespace WindowsFormsBus
{
    partial class FormBusConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxOs = new System.Windows.Forms.CheckBox();
            this.checkBoxGarm = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupBoxTypeBus = new System.Windows.Forms.GroupBox();
            this.labelBusGarm = new System.Windows.Forms.Label();
            this.labelBus = new System.Windows.Forms.Label();
            this.panelBus = new System.Windows.Forms.Panel();
            this.pictureBoxBusDraw = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelDarkViolet = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelDarkOrange = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFalse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.groupBoxTypeBus.SuspendLayout();
            this.panelBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusDraw)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxOs);
            this.groupBox1.Controls.Add(this.checkBoxGarm);
            this.groupBox1.Controls.Add(this.numericUpDownWeight);
            this.groupBox1.Controls.Add(this.numericUpDownSpeed);
            this.groupBox1.Controls.Add(this.labelWeight);
            this.groupBox1.Controls.Add(this.labelMaxSpeed);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // checkBoxOs
            // 
            this.checkBoxOs.AutoSize = true;
            this.checkBoxOs.Checked = true;
            this.checkBoxOs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOs.Location = new System.Drawing.Point(215, 88);
            this.checkBoxOs.Name = "checkBoxOs";
            this.checkBoxOs.Size = new System.Drawing.Size(145, 21);
            this.checkBoxOs.TabIndex = 5;
            this.checkBoxOs.Text = "Третья ось колес";
            this.checkBoxOs.UseVisualStyleBackColor = true;
            // 
            // checkBoxGarm
            // 
            this.checkBoxGarm.AutoSize = true;
            this.checkBoxGarm.Checked = true;
            this.checkBoxGarm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGarm.Location = new System.Drawing.Point(215, 56);
            this.checkBoxGarm.Name = "checkBoxGarm";
            this.checkBoxGarm.Size = new System.Drawing.Size(97, 21);
            this.checkBoxGarm.TabIndex = 4;
            this.checkBoxGarm.Text = "Гармошка";
            this.checkBoxGarm.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(80, 115);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(80, 56);
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(18, 89);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(100, 17);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес автобуса:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(18, 36);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(112, 17);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // groupBoxTypeBus
            // 
            this.groupBoxTypeBus.Controls.Add(this.labelBusGarm);
            this.groupBoxTypeBus.Controls.Add(this.labelBus);
            this.groupBoxTypeBus.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTypeBus.Name = "groupBoxTypeBus";
            this.groupBoxTypeBus.Size = new System.Drawing.Size(209, 139);
            this.groupBoxTypeBus.TabIndex = 7;
            this.groupBoxTypeBus.TabStop = false;
            this.groupBoxTypeBus.Text = "Тип автобуса";
            // 
            // labelBusGarm
            // 
            this.labelBusGarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBusGarm.Location = new System.Drawing.Point(18, 79);
            this.labelBusGarm.Name = "labelBusGarm";
            this.labelBusGarm.Size = new System.Drawing.Size(170, 39);
            this.labelBusGarm.TabIndex = 1;
            this.labelBusGarm.Text = "Автобус с гармошкой";
            this.labelBusGarm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBusGarm_MouseDown);
            // 
            // labelBus
            // 
            this.labelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBus.Location = new System.Drawing.Point(18, 27);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(170, 41);
            this.labelBus.TabIndex = 0;
            this.labelBus.Text = "Автобус";
            this.labelBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBus_MouseDown);
            // 
            // panelBus
            // 
            this.panelBus.AllowDrop = true;
            this.panelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBus.Controls.Add(this.pictureBoxBusDraw);
            this.panelBus.Location = new System.Drawing.Point(227, 21);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(317, 134);
            this.panelBus.TabIndex = 8;
            this.panelBus.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBus_DragDrop);
            this.panelBus.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBus_DragEnter);
            // 
            // pictureBoxBusDraw
            // 
            this.pictureBoxBusDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBusDraw.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBusDraw.Name = "pictureBoxBusDraw";
            this.pictureBoxBusDraw.Size = new System.Drawing.Size(309, 126);
            this.pictureBoxBusDraw.TabIndex = 6;
            this.pictureBoxBusDraw.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelDarkViolet);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelLightBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelDarkOrange);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(550, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(300, 189);
            this.groupBoxColors.TabIndex = 9;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(29, 145);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(39, 38);
            this.panelBlue.TabIndex = 1;
            // 
            // panelDarkViolet
            // 
            this.panelDarkViolet.BackColor = System.Drawing.Color.DarkViolet;
            this.panelDarkViolet.Location = new System.Drawing.Point(94, 145);
            this.panelDarkViolet.Name = "panelDarkViolet";
            this.panelDarkViolet.Size = new System.Drawing.Size(39, 38);
            this.panelDarkViolet.TabIndex = 1;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPink.Location = new System.Drawing.Point(155, 145);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(39, 38);
            this.panelPink.TabIndex = 1;
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.Aqua;
            this.panelLightBlue.Location = new System.Drawing.Point(225, 145);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(39, 38);
            this.panelLightBlue.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(225, 92);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(39, 38);
            this.panelGreen.TabIndex = 1;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(155, 92);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(39, 38);
            this.panelYellow.TabIndex = 1;
            // 
            // panelDarkOrange
            // 
            this.panelDarkOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.panelDarkOrange.Location = new System.Drawing.Point(94, 92);
            this.panelDarkOrange.Name = "panelDarkOrange";
            this.panelDarkOrange.Size = new System.Drawing.Size(39, 38);
            this.panelDarkOrange.TabIndex = 1;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(155, 30);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(139, 41);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDop_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMain_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(17, 30);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(132, 41);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMain_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMain_DragEnter);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(29, 92);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(39, 38);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(426, 170);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 35);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFalse
            // 
            this.buttonFalse.Location = new System.Drawing.Point(426, 213);
            this.buttonFalse.Name = "buttonFalse";
            this.buttonFalse.Size = new System.Drawing.Size(103, 35);
            this.buttonFalse.TabIndex = 11;
            this.buttonFalse.Text = "Отмена";
            this.buttonFalse.UseVisualStyleBackColor = true;
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 365);
            this.Controls.Add(this.buttonFalse);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelBus);
            this.Controls.Add(this.groupBoxTypeBus);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBusConfig";
            this.Text = "Выбор автобуса";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.groupBoxTypeBus.ResumeLayout(false);
            this.panelBus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusDraw)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxOs;
        private System.Windows.Forms.CheckBox checkBoxGarm;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxBusDraw;
        private System.Windows.Forms.GroupBox groupBoxTypeBus;
        private System.Windows.Forms.Label labelBusGarm;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelDarkViolet;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelDarkOrange;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFalse;
    }
}