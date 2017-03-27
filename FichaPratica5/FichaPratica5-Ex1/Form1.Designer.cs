namespace FichaPratica5_Ex1
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
            this.tbBits = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSHA512 = new System.Windows.Forms.Button();
            this.buttonSHA1 = new System.Windows.Forms.Button();
            this.buttonMD5 = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBits
            // 
            this.tbBits.AutoSize = true;
            this.tbBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBits.Location = new System.Drawing.Point(376, 120);
            this.tbBits.MinimumSize = new System.Drawing.Size(30, 2);
            this.tbBits.Name = "tbBits";
            this.tbBits.Size = new System.Drawing.Size(30, 15);
            this.tbBits.TabIndex = 17;
            this.tbBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "bits";
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(12, 140);
            this.tbHash.Multiline = true;
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(395, 62);
            this.tbHash.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hash In HEX";
            // 
            // buttonSHA512
            // 
            this.buttonSHA512.Location = new System.Drawing.Point(274, 80);
            this.buttonSHA512.Name = "buttonSHA512";
            this.buttonSHA512.Size = new System.Drawing.Size(133, 23);
            this.buttonSHA512.TabIndex = 13;
            this.buttonSHA512.Text = "SHA512-ComputeHash";
            this.buttonSHA512.UseVisualStyleBackColor = true;
            this.buttonSHA512.Click += new System.EventHandler(this.buttonSHA512_Click);
            // 
            // buttonSHA1
            // 
            this.buttonSHA1.Location = new System.Drawing.Point(137, 80);
            this.buttonSHA1.Name = "buttonSHA1";
            this.buttonSHA1.Size = new System.Drawing.Size(130, 23);
            this.buttonSHA1.TabIndex = 12;
            this.buttonSHA1.Text = "SHA1-ComputeHash";
            this.buttonSHA1.UseVisualStyleBackColor = true;
            this.buttonSHA1.Click += new System.EventHandler(this.buttonSHA1_Click);
            // 
            // buttonMD5
            // 
            this.buttonMD5.Location = new System.Drawing.Point(12, 80);
            this.buttonMD5.Name = "buttonMD5";
            this.buttonMD5.Size = new System.Drawing.Size(118, 23);
            this.buttonMD5.TabIndex = 11;
            this.buttonMD5.Text = "MD5-ComputeHash";
            this.buttonMD5.UseVisualStyleBackColor = true;
            this.buttonMD5.Click += new System.EventHandler(this.buttonMD5_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(12, 26);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(395, 47);
            this.tbData.TabIndex = 10;
            this.tbData.Text = "Data.to.Compute.Hash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data to Compute";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 227);
            this.Controls.Add(this.tbBits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSHA512);
            this.Controls.Add(this.buttonSHA1);
            this.Controls.Add(this.buttonMD5);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSHA512;
        private System.Windows.Forms.Button buttonSHA1;
        private System.Windows.Forms.Button buttonMD5;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label1;
    }
}

