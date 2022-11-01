namespace PigLatinForms
{
    partial class CodeBreaker
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Roboto Medium", 48F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(315, 77);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(70, 77);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "1";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Roboto Medium", 48F, System.Drawing.FontStyle.Bold);
            this.lb2.Location = new System.Drawing.Point(414, 77);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(70, 77);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "2";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Roboto Medium", 48F, System.Drawing.FontStyle.Bold);
            this.lb3.Location = new System.Drawing.Point(522, 77);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(70, 77);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "3";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Roboto Medium", 48F, System.Drawing.FontStyle.Bold);
            this.lb4.Location = new System.Drawing.Point(630, 77);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(70, 77);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "4";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(328, 170);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(359, 54);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(366, 292);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(52, 46);
            this.txt1.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(444, 292);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(52, 46);
            this.txt2.TabIndex = 6;
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.Location = new System.Drawing.Point(600, 292);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(52, 46);
            this.txt4.TabIndex = 8;
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(522, 292);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(52, 46);
            this.txt3.TabIndex = 7;
            // 
            // CodeBreaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 495);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "CodeBreaker";
            this.Text = "CodeBreaker";
            this.Load += new System.EventHandler(this.CodeBreaker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
    }
}