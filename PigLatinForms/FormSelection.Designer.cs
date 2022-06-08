namespace PigLatinForms
{
    partial class FormSelection
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
            this.btnPL = new System.Windows.Forms.Button();
            this.btnRPS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPL
            // 
            this.btnPL.Location = new System.Drawing.Point(60, 67);
            this.btnPL.Name = "btnPL";
            this.btnPL.Size = new System.Drawing.Size(199, 75);
            this.btnPL.TabIndex = 0;
            this.btnPL.Text = "Pig Latin";
            this.btnPL.UseVisualStyleBackColor = true;
            this.btnPL.Click += new System.EventHandler(this.btnPL_Click);
            // 
            // btnRPS
            // 
            this.btnRPS.Location = new System.Drawing.Point(60, 167);
            this.btnRPS.Name = "btnRPS";
            this.btnRPS.Size = new System.Drawing.Size(199, 75);
            this.btnRPS.TabIndex = 1;
            this.btnRPS.Text = "Rock, Paper, Scissors!";
            this.btnRPS.UseVisualStyleBackColor = true;
            this.btnRPS.Click += new System.EventHandler(this.btnRPS_Click);
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRPS);
            this.Controls.Add(this.btnPL);
            this.Name = "FormSelection";
            this.Text = "FormSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPL;
        private System.Windows.Forms.Button btnRPS;
    }
}