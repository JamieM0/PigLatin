namespace PigLatinForms
{
    partial class RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPS));
            this.lbRPS = new System.Windows.Forms.Label();
            this.pnlPlayerSide = new System.Windows.Forms.Panel();
            this.pbScissors = new System.Windows.Forms.PictureBox();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.pbRock = new System.Windows.Forms.PictureBox();
            this.pbPlayerSelection = new System.Windows.Forms.PictureBox();
            this.pnlOpponentsSide = new System.Windows.Forms.Panel();
            this.pbOpponentsSelection = new System.Windows.Forms.PictureBox();
            this.lbPlayerScore = new System.Windows.Forms.Label();
            this.lbOpponentsScore = new System.Windows.Forms.Label();
            this.pnlPlayerSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerSelection)).BeginInit();
            this.pnlOpponentsSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponentsSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRPS
            // 
            this.lbRPS.AutoSize = true;
            this.lbRPS.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRPS.Location = new System.Drawing.Point(309, 34);
            this.lbRPS.Name = "lbRPS";
            this.lbRPS.Size = new System.Drawing.Size(349, 47);
            this.lbRPS.TabIndex = 0;
            this.lbRPS.Text = "Rock, Paper, Scissors!";
            // 
            // pnlPlayerSide
            // 
            this.pnlPlayerSide.Controls.Add(this.pbScissors);
            this.pnlPlayerSide.Controls.Add(this.pbPaper);
            this.pnlPlayerSide.Controls.Add(this.pbRock);
            this.pnlPlayerSide.Controls.Add(this.pbPlayerSelection);
            this.pnlPlayerSide.Location = new System.Drawing.Point(285, 90);
            this.pnlPlayerSide.Name = "pnlPlayerSide";
            this.pnlPlayerSide.Size = new System.Drawing.Size(396, 380);
            this.pnlPlayerSide.TabIndex = 1;
            // 
            // pbScissors
            // 
            this.pbScissors.Image = ((System.Drawing.Image)(resources.GetObject("pbScissors.Image")));
            this.pbScissors.Location = new System.Drawing.Point(261, 290);
            this.pbScissors.Name = "pbScissors";
            this.pbScissors.Size = new System.Drawing.Size(68, 62);
            this.pbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScissors.TabIndex = 4;
            this.pbScissors.TabStop = false;
            this.pbScissors.Click += new System.EventHandler(this.pbScissors_Click);
            // 
            // pbPaper
            // 
            this.pbPaper.Image = ((System.Drawing.Image)(resources.GetObject("pbPaper.Image")));
            this.pbPaper.Location = new System.Drawing.Point(160, 290);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(67, 62);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPaper.TabIndex = 3;
            this.pbPaper.TabStop = false;
            this.pbPaper.Click += new System.EventHandler(this.pbPaper_Click);
            // 
            // pbRock
            // 
            this.pbRock.Image = ((System.Drawing.Image)(resources.GetObject("pbRock.Image")));
            this.pbRock.Location = new System.Drawing.Point(57, 290);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(67, 62);
            this.pbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRock.TabIndex = 2;
            this.pbRock.TabStop = false;
            this.pbRock.Click += new System.EventHandler(this.pbRock_Click);
            // 
            // pbPlayerSelection
            // 
            this.pbPlayerSelection.Location = new System.Drawing.Point(57, 28);
            this.pbPlayerSelection.Name = "pbPlayerSelection";
            this.pbPlayerSelection.Size = new System.Drawing.Size(272, 229);
            this.pbPlayerSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayerSelection.TabIndex = 0;
            this.pbPlayerSelection.TabStop = false;
            // 
            // pnlOpponentsSide
            // 
            this.pnlOpponentsSide.Controls.Add(this.pbOpponentsSelection);
            this.pnlOpponentsSide.Location = new System.Drawing.Point(538, 90);
            this.pnlOpponentsSide.Name = "pnlOpponentsSide";
            this.pnlOpponentsSide.Size = new System.Drawing.Size(396, 380);
            this.pnlOpponentsSide.TabIndex = 2;
            // 
            // pbOpponentsSelection
            // 
            this.pbOpponentsSelection.Location = new System.Drawing.Point(66, 28);
            this.pbOpponentsSelection.Name = "pbOpponentsSelection";
            this.pbOpponentsSelection.Size = new System.Drawing.Size(272, 229);
            this.pbOpponentsSelection.TabIndex = 1;
            this.pbOpponentsSelection.TabStop = false;
            // 
            // lbPlayerScore
            // 
            this.lbPlayerScore.AutoSize = true;
            this.lbPlayerScore.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerScore.Location = new System.Drawing.Point(12, 9);
            this.lbPlayerScore.Name = "lbPlayerScore";
            this.lbPlayerScore.Size = new System.Drawing.Size(54, 65);
            this.lbPlayerScore.TabIndex = 3;
            this.lbPlayerScore.Text = "0";
            // 
            // lbOpponentsScore
            // 
            this.lbOpponentsScore.AutoSize = true;
            this.lbOpponentsScore.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpponentsScore.Location = new System.Drawing.Point(901, 9);
            this.lbOpponentsScore.Name = "lbOpponentsScore";
            this.lbOpponentsScore.Size = new System.Drawing.Size(54, 65);
            this.lbOpponentsScore.TabIndex = 4;
            this.lbOpponentsScore.Text = "0";
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 495);
            this.Controls.Add(this.lbOpponentsScore);
            this.Controls.Add(this.lbPlayerScore);
            this.Controls.Add(this.pnlPlayerSide);
            this.Controls.Add(this.pnlOpponentsSide);
            this.Controls.Add(this.lbRPS);
            this.Name = "RPS";
            this.Text = "Rock Paper Scissors";
            this.pnlPlayerSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerSelection)).EndInit();
            this.pnlOpponentsSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponentsSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRPS;
        private System.Windows.Forms.Panel pnlPlayerSide;
        private System.Windows.Forms.PictureBox pbScissors;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.PictureBox pbRock;
        private System.Windows.Forms.PictureBox pbPlayerSelection;
        private System.Windows.Forms.Panel pnlOpponentsSide;
        private System.Windows.Forms.PictureBox pbOpponentsSelection;
        private System.Windows.Forms.Label lbPlayerScore;
        private System.Windows.Forms.Label lbOpponentsScore;
    }
}