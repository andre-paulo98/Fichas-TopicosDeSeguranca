﻿namespace FichaPratica5_Ex2
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
            this.tbHash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFinal = new System.Windows.Forms.Button();
            this.tbInputFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInput2 = new System.Windows.Forms.Button();
            this.buttonInput1 = new System.Windows.Forms.Button();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(237, 114);
            this.tbHash.Multiline = true;
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(202, 50);
            this.tbHash.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hash (HEX)";
            // 
            // buttonFinal
            // 
            this.buttonFinal.Location = new System.Drawing.Point(15, 141);
            this.buttonFinal.Name = "buttonFinal";
            this.buttonFinal.Size = new System.Drawing.Size(202, 23);
            this.buttonFinal.TabIndex = 19;
            this.buttonFinal.Text = "SHA1-TransformFinalBlock";
            this.buttonFinal.UseVisualStyleBackColor = true;
            this.buttonFinal.Click += new System.EventHandler(this.buttonFinal_Click);
            // 
            // tbInputFinal
            // 
            this.tbInputFinal.Location = new System.Drawing.Point(15, 114);
            this.tbInputFinal.Name = "tbInputFinal";
            this.tbInputFinal.Size = new System.Drawing.Size(202, 20);
            this.tbInputFinal.TabIndex = 18;
            this.tbInputFinal.Text = "Hash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Input Block ";
            // 
            // buttonInput2
            // 
            this.buttonInput2.Location = new System.Drawing.Point(237, 53);
            this.buttonInput2.Name = "buttonInput2";
            this.buttonInput2.Size = new System.Drawing.Size(204, 23);
            this.buttonInput2.TabIndex = 16;
            this.buttonInput2.Text = "SHA1-TransformBlock";
            this.buttonInput2.UseVisualStyleBackColor = true;
            this.buttonInput2.Click += new System.EventHandler(this.buttonInput2_Click);
            // 
            // buttonInput1
            // 
            this.buttonInput1.Location = new System.Drawing.Point(15, 53);
            this.buttonInput1.Name = "buttonInput1";
            this.buttonInput1.Size = new System.Drawing.Size(202, 23);
            this.buttonInput1.TabIndex = 15;
            this.buttonInput1.Text = "SHA1-TransformBlock";
            this.buttonInput1.UseVisualStyleBackColor = true;
            this.buttonInput1.Click += new System.EventHandler(this.buttonInput1_Click);
            // 
            // tbInput2
            // 
            this.tbInput2.Location = new System.Drawing.Point(237, 25);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(204, 20);
            this.tbInput2.TabIndex = 14;
            this.tbInput2.Text = "Compute.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Input Block 2";
            // 
            // tbInput1
            // 
            this.tbInput1.Location = new System.Drawing.Point(15, 26);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(202, 20);
            this.tbInput1.TabIndex = 12;
            this.tbInput1.Text = "Data.to.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input Block 1 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 179);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFinal);
            this.Controls.Add(this.tbInputFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonInput2);
            this.Controls.Add(this.buttonInput1);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInput1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFinal;
        private System.Windows.Forms.TextBox tbInputFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInput2;
        private System.Windows.Forms.Button buttonInput1;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.Label label1;
    }
}

