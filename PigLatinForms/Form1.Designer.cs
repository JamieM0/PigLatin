﻿namespace PigLatinForms
{
    partial class frmMain
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
            this.lbInstructions1 = new System.Windows.Forms.Label();
            this.txtCleartext = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlConvertedSide = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlClearSide = new System.Windows.Forms.Panel();
            this.btnTestAnimate = new System.Windows.Forms.Button();
            this.pnlConvertedSide.SuspendLayout();
            this.pnlClearSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInstructions1
            // 
            this.lbInstructions1.AutoSize = true;
            this.lbInstructions1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructions1.Location = new System.Drawing.Point(56, 20);
            this.lbInstructions1.Name = "lbInstructions1";
            this.lbInstructions1.Size = new System.Drawing.Size(256, 37);
            this.lbInstructions1.TabIndex = 0;
            this.lbInstructions1.Text = "Input normal phrase";
            // 
            // txtCleartext
            // 
            this.txtCleartext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCleartext.Location = new System.Drawing.Point(11, 81);
            this.txtCleartext.Name = "txtCleartext";
            this.txtCleartext.Size = new System.Drawing.Size(347, 35);
            this.txtCleartext.TabIndex = 1;
            this.txtCleartext.TextChanged += new System.EventHandler(this.txtCleartext_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(80, 184);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(199, 47);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert to Pig Latin";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(68, 184);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(92, 47);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtConverted
            // 
            this.txtConverted.Enabled = false;
            this.txtConverted.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConverted.Location = new System.Drawing.Point(3, 81);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(347, 35);
            this.txtConverted.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Here\'s the phrase in Pig Latin";
            // 
            // pnlConvertedSide
            // 
            this.pnlConvertedSide.Controls.Add(this.btnReset);
            this.pnlConvertedSide.Controls.Add(this.btnCopy);
            this.pnlConvertedSide.Controls.Add(this.label1);
            this.pnlConvertedSide.Controls.Add(this.txtConverted);
            this.pnlConvertedSide.Location = new System.Drawing.Point(540, 106);
            this.pnlConvertedSide.Name = "pnlConvertedSide";
            this.pnlConvertedSide.Size = new System.Drawing.Size(359, 245);
            this.pnlConvertedSide.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(166, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 47);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlClearSide
            // 
            this.pnlClearSide.Controls.Add(this.lbInstructions1);
            this.pnlClearSide.Controls.Add(this.btnConvert);
            this.pnlClearSide.Controls.Add(this.txtCleartext);
            this.pnlClearSide.Location = new System.Drawing.Point(283, 106);
            this.pnlClearSide.Name = "pnlClearSide";
            this.pnlClearSide.Size = new System.Drawing.Size(361, 245);
            this.pnlClearSide.TabIndex = 7;
            // 
            // btnTestAnimate
            // 
            this.btnTestAnimate.Location = new System.Drawing.Point(385, 375);
            this.btnTestAnimate.Name = "btnTestAnimate";
            this.btnTestAnimate.Size = new System.Drawing.Size(75, 23);
            this.btnTestAnimate.TabIndex = 8;
            this.btnTestAnimate.Text = "Test";
            this.btnTestAnimate.UseVisualStyleBackColor = true;
            this.btnTestAnimate.Visible = false;
            this.btnTestAnimate.Click += new System.EventHandler(this.btnTestAnimate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 495);
            this.Controls.Add(this.pnlClearSide);
            this.Controls.Add(this.btnTestAnimate);
            this.Controls.Add(this.pnlConvertedSide);
            this.Name = "frmMain";
            this.Text = "Pig Latin";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlConvertedSide.ResumeLayout(false);
            this.pnlConvertedSide.PerformLayout();
            this.pnlClearSide.ResumeLayout(false);
            this.pnlClearSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbInstructions1;
        private System.Windows.Forms.TextBox txtCleartext;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlConvertedSide;
        private System.Windows.Forms.Panel pnlClearSide;
        private System.Windows.Forms.Button btnTestAnimate;
        private System.Windows.Forms.Button btnReset;
    }
}

