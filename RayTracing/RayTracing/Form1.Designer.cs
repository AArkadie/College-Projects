namespace RayTracing
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
            this.pBox = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.phiControl = new System.Windows.Forms.TrackBar();
            this.thetaControl = new System.Windows.Forms.TrackBar();
            this.distControl = new System.Windows.Forms.TrackBar();
            this.thetaLabel = new System.Windows.Forms.Label();
            this.phiLabel = new System.Windows.Forms.Label();
            this.distLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distControl)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.pBox.Location = new System.Drawing.Point(13, 13);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(300, 300);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pBox_Paint);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 379);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "Snap";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // phiControl
            // 
            this.phiControl.Location = new System.Drawing.Point(468, 132);
            this.phiControl.Maximum = 100;
            this.phiControl.Name = "phiControl";
            this.phiControl.Size = new System.Drawing.Size(104, 45);
            this.phiControl.TabIndex = 2;
            // 
            // thetaControl
            // 
            this.thetaControl.Location = new System.Drawing.Point(468, 204);
            this.thetaControl.Maximum = 100;
            this.thetaControl.Name = "thetaControl";
            this.thetaControl.Size = new System.Drawing.Size(104, 45);
            this.thetaControl.TabIndex = 3;
            // 
            // distControl
            // 
            this.distControl.LargeChange = 1;
            this.distControl.Location = new System.Drawing.Point(468, 68);
            this.distControl.Maximum = -1;
            this.distControl.Minimum = -20;
            this.distControl.Name = "distControl";
            this.distControl.Size = new System.Drawing.Size(104, 45);
            this.distControl.TabIndex = 4;
            this.distControl.Value = -5;
            this.distControl.Scroll += new System.EventHandler(this.distControl_Scroll);
            // 
            // thetaLabel
            // 
            this.thetaLabel.AutoSize = true;
            this.thetaLabel.Location = new System.Drawing.Point(472, 180);
            this.thetaLabel.Name = "thetaLabel";
            this.thetaLabel.Size = new System.Drawing.Size(70, 13);
            this.thetaLabel.TabIndex = 5;
            this.thetaLabel.Text = "Blue Intensity";
            // 
            // phiLabel
            // 
            this.phiLabel.AutoSize = true;
            this.phiLabel.Location = new System.Drawing.Point(472, 116);
            this.phiLabel.Name = "phiLabel";
            this.phiLabel.Size = new System.Drawing.Size(78, 13);
            this.phiLabel.TabIndex = 6;
            this.phiLabel.Text = "Green Intensity";
            // 
            // distLabel
            // 
            this.distLabel.AutoSize = true;
            this.distLabel.Location = new System.Drawing.Point(472, 52);
            this.distLabel.Name = "distLabel";
            this.distLabel.Size = new System.Drawing.Size(100, 13);
            this.distLabel.TabIndex = 7;
            this.distLabel.Text = "Distance to Camera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.distLabel);
            this.Controls.Add(this.phiLabel);
            this.Controls.Add(this.thetaLabel);
            this.Controls.Add(this.distControl);
            this.Controls.Add(this.thetaControl);
            this.Controls.Add(this.phiControl);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TrackBar phiControl;
        private System.Windows.Forms.TrackBar thetaControl;
        private System.Windows.Forms.TrackBar distControl;
        private System.Windows.Forms.Label thetaLabel;
        private System.Windows.Forms.Label phiLabel;
        private System.Windows.Forms.Label distLabel;
    }
}

