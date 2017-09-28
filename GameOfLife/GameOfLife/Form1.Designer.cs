namespace GameOfLife
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cellBox = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.stepButton = new System.Windows.Forms.Button();
            this.wrapCheck = new System.Windows.Forms.CheckBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.prefabBox = new System.Windows.Forms.PictureBox();
            this.prefabSelector = new System.Windows.Forms.ComboBox();
            this.genButton = new System.Windows.Forms.Button();
            this.exampleCell = new System.Windows.Forms.PictureBox();
            this.cellTypeBox = new System.Windows.Forms.ComboBox();
            this.normalProb = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priestProb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nomadProb = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.zombieProb = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cancerProb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cellBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefabBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priestProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomadProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombieProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancerProb)).BeginInit();
            this.SuspendLayout();
            // 
            // cellBox
            // 
            this.cellBox.BackColor = System.Drawing.Color.White;
            this.cellBox.Location = new System.Drawing.Point(12, 12);
            this.cellBox.Name = "cellBox";
            this.cellBox.Size = new System.Drawing.Size(500, 500);
            this.cellBox.TabIndex = 0;
            this.cellBox.TabStop = false;
            this.cellBox.Paint += new System.Windows.Forms.PaintEventHandler(this.cellBox_Paint);
            this.cellBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cellBox_MouseDown);
            this.cellBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cellBox_MouseMove);
            this.cellBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cellBox_MouseUp);
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(275, 526);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(356, 526);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(437, 526);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(12, 518);
            this.trackBar1.Maximum = 950;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(257, 45);
            this.trackBar1.SmallChange = 50;
            this.trackBar1.TabIndex = 4;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(683, 464);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 5;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.clock_Tick);
            // 
            // wrapCheck
            // 
            this.wrapCheck.AutoSize = true;
            this.wrapCheck.Checked = true;
            this.wrapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wrapCheck.Location = new System.Drawing.Point(683, 532);
            this.wrapCheck.Name = "wrapCheck";
            this.wrapCheck.Size = new System.Drawing.Size(89, 17);
            this.wrapCheck.TabIndex = 6;
            this.wrapCheck.Text = "Wrap Around";
            this.wrapCheck.UseVisualStyleBackColor = true;
            this.wrapCheck.CheckedChanged += new System.EventHandler(this.wrapCheck_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(522, 473);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(71, 39);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Population: 0\r\nGeneration: 0\r\nSize: 50";
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(683, 506);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(74, 20);
            this.sizeBox.TabIndex = 8;
            this.sizeBox.TextChanged += new System.EventHandler(this.sizeBox_TextChanged);
            this.sizeBox.Leave += new System.EventHandler(this.sizeBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set World Size";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.Title = "Save Your World";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text Files|*.txt";
            this.openFileDialog1.Title = "Open Your World";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(518, 526);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(599, 526);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(518, 12);
            this.vScrollBar1.Maximum = 999;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 461);
            this.vScrollBar1.TabIndex = 12;
            this.vScrollBar1.Value = 900;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // prefabBox
            // 
            this.prefabBox.BackColor = System.Drawing.Color.White;
            this.prefabBox.Location = new System.Drawing.Point(672, 12);
            this.prefabBox.Name = "prefabBox";
            this.prefabBox.Size = new System.Drawing.Size(100, 100);
            this.prefabBox.TabIndex = 13;
            this.prefabBox.TabStop = false;
            this.prefabBox.Paint += new System.Windows.Forms.PaintEventHandler(this.prefabBox_Paint);
            // 
            // prefabSelector
            // 
            this.prefabSelector.FormattingEnabled = true;
            this.prefabSelector.Location = new System.Drawing.Point(672, 119);
            this.prefabSelector.MaxDropDownItems = 20;
            this.prefabSelector.Name = "prefabSelector";
            this.prefabSelector.Size = new System.Drawing.Size(100, 21);
            this.prefabSelector.TabIndex = 14;
            this.prefabSelector.SelectionChangeCommitted += new System.EventHandler(this.prefabSelector_SelectionChangeCommitted);
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(538, 227);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(75, 23);
            this.genButton.TabIndex = 15;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // exampleCell
            // 
            this.exampleCell.BackColor = System.Drawing.Color.Green;
            this.exampleCell.Location = new System.Drawing.Point(672, 166);
            this.exampleCell.Name = "exampleCell";
            this.exampleCell.Size = new System.Drawing.Size(50, 50);
            this.exampleCell.TabIndex = 16;
            this.exampleCell.TabStop = false;
            // 
            // cellTypeBox
            // 
            this.cellTypeBox.FormattingEnabled = true;
            this.cellTypeBox.Items.AddRange(new object[] {
            "Normal",
            "Nomad",
            "Priest",
            "Zombie",
            "Cancer"});
            this.cellTypeBox.Location = new System.Drawing.Point(672, 227);
            this.cellTypeBox.Name = "cellTypeBox";
            this.cellTypeBox.Size = new System.Drawing.Size(100, 21);
            this.cellTypeBox.TabIndex = 17;
            this.cellTypeBox.SelectionChangeCommitted += new System.EventHandler(this.cellTypeBox_SelectionChangeCommitted);
            // 
            // normalProb
            // 
            this.normalProb.Enabled = false;
            this.normalProb.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.normalProb.Location = new System.Drawing.Point(538, 24);
            this.normalProb.Name = "normalProb";
            this.normalProb.ReadOnly = true;
            this.normalProb.Size = new System.Drawing.Size(120, 20);
            this.normalProb.TabIndex = 18;
            this.normalProb.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Normal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Priest";
            // 
            // priestProb
            // 
            this.priestProb.Location = new System.Drawing.Point(538, 63);
            this.priestProb.Name = "priestProb";
            this.priestProb.ReadOnly = true;
            this.priestProb.Size = new System.Drawing.Size(120, 20);
            this.priestProb.TabIndex = 21;
            this.priestProb.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.priestProb.ValueChanged += new System.EventHandler(this.priestProb_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nomad";
            // 
            // nomadProb
            // 
            this.nomadProb.Location = new System.Drawing.Point(538, 102);
            this.nomadProb.Name = "nomadProb";
            this.nomadProb.ReadOnly = true;
            this.nomadProb.Size = new System.Drawing.Size(120, 20);
            this.nomadProb.TabIndex = 23;
            this.nomadProb.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nomadProb.ValueChanged += new System.EventHandler(this.nomadProb_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Zombie";
            // 
            // zombieProb
            // 
            this.zombieProb.Location = new System.Drawing.Point(538, 142);
            this.zombieProb.Name = "zombieProb";
            this.zombieProb.ReadOnly = true;
            this.zombieProb.Size = new System.Drawing.Size(120, 20);
            this.zombieProb.TabIndex = 25;
            this.zombieProb.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.zombieProb.ValueChanged += new System.EventHandler(this.zombieProb_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cancer";
            // 
            // cancerProb
            // 
            this.cancerProb.Location = new System.Drawing.Point(538, 183);
            this.cancerProb.Name = "cancerProb";
            this.cancerProb.ReadOnly = true;
            this.cancerProb.Size = new System.Drawing.Size(120, 20);
            this.cancerProb.TabIndex = 27;
            this.cancerProb.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cancerProb.ValueChanged += new System.EventHandler(this.cancerProb_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cancerProb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zombieProb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nomadProb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priestProb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.normalProb);
            this.Controls.Add(this.cellTypeBox);
            this.Controls.Add(this.exampleCell);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.prefabSelector);
            this.Controls.Add(this.prefabBox);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.wrapCheck);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cellBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cellBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefabBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priestProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomadProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombieProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancerProb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cellBox;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.CheckBox wrapCheck;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox prefabBox;
        private System.Windows.Forms.ComboBox prefabSelector;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.PictureBox exampleCell;
        private System.Windows.Forms.ComboBox cellTypeBox;
        private System.Windows.Forms.NumericUpDown normalProb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priestProb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nomadProb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown zombieProb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cancerProb;
    }
}

