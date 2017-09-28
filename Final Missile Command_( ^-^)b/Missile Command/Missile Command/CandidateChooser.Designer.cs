namespace Missile_Command
{
    partial class CandidateChooser
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
            this.candidatePicture = new System.Windows.Forms.PictureBox();
            this.candidateBox = new System.Windows.Forms.ComboBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // candidatePicture
            // 
            this.candidatePicture.Location = new System.Drawing.Point(318, 12);
            this.candidatePicture.Name = "candidatePicture";
            this.candidatePicture.Size = new System.Drawing.Size(300, 300);
            this.candidatePicture.TabIndex = 0;
            this.candidatePicture.TabStop = false;
            // 
            // candidateBox
            // 
            this.candidateBox.FormattingEnabled = true;
            this.candidateBox.Items.AddRange(new object[] {
            "Bacteria",
            "Cactus",
            "Cat",
            "Dog",
            "Donkey",
            "Elephant",
            "Falcon",
            "Frog",
            "Mushroom",
            "Octopus",
            "Spider",
            "Sunfish",
            "Tapeworm"});
            this.candidateBox.Location = new System.Drawing.Point(12, 12);
            this.candidateBox.Name = "candidateBox";
            this.candidateBox.Size = new System.Drawing.Size(300, 21);
            this.candidateBox.TabIndex = 1;
            this.candidateBox.SelectedIndexChanged += new System.EventHandler(this.candidateBox_SelectedIndexChanged);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 39);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(300, 273);
            this.descriptionBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "okay!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CandidateChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.candidateBox);
            this.Controls.Add(this.candidatePicture);
            this.Name = "CandidateChooser";
            this.Text = "CandidateChooser";
            ((System.ComponentModel.ISupportInitialize)(this.candidatePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox candidatePicture;
        private System.Windows.Forms.ComboBox candidateBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button button1;
    }
}