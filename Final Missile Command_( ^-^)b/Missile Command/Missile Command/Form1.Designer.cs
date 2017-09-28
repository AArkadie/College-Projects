namespace Missile_Command
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.myName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toCandidateChooser = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.enemyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(12, 426);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 410);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(93, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Score: 0 Cities: 42";
            // 
            // myName
            // 
            this.myName.AutoSize = true;
            this.myName.Enabled = false;
            this.myName.Location = new System.Drawing.Point(696, 448);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(104, 13);
            this.myName.TabIndex = 3;
            this.myName.Text = "Anthoney B. Arkadie";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toCandidateChooser
            // 
            this.toCandidateChooser.Location = new System.Drawing.Point(93, 426);
            this.toCandidateChooser.Name = "toCandidateChooser";
            this.toCandidateChooser.Size = new System.Drawing.Size(119, 23);
            this.toCandidateChooser.TabIndex = 4;
            this.toCandidateChooser.Text = "Choose Candidate";
            this.toCandidateChooser.UseVisualStyleBackColor = true;
            this.toCandidateChooser.Click += new System.EventHandler(this.toCandidateChooser_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerLabel.Location = new System.Drawing.Point(218, 417);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(123, 25);
            this.playerLabel.TabIndex = 5;
            this.playerLabel.Text = "Joe Schmoe";
            // 
            // vsLabel
            // 
            this.vsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(421, 426);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(21, 13);
            this.vsLabel.TabIndex = 6;
            this.vsLabel.Text = "vs.";
            this.vsLabel.Click += new System.EventHandler(this.vsLabel_Click);
            // 
            // enemyLabel
            // 
            this.enemyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enemyLabel.AutoSize = true;
            this.enemyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLabel.ForeColor = System.Drawing.Color.Purple;
            this.enemyLabel.Location = new System.Drawing.Point(448, 417);
            this.enemyLabel.Name = "enemyLabel";
            this.enemyLabel.Size = new System.Drawing.Size(123, 25);
            this.enemyLabel.TabIndex = 7;
            this.enemyLabel.Text = "Joe Schmoe";
            this.enemyLabel.Click += new System.EventHandler(this.enemyLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 461);
            this.Controls.Add(this.enemyLabel);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.toCandidateChooser);
            this.Controls.Add(this.myName);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label myName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button toCandidateChooser;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Label enemyLabel;
    }
}

