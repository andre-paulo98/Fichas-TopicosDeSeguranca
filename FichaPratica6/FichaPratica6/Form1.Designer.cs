namespace FichaPratica6
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
            this.tbIsVerified = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonVerifyData = new System.Windows.Forms.Button();
            this.buttonVerifyHash = new System.Windows.Forms.Button();
            this.buttonSignData = new System.Windows.Forms.Button();
            this.buttonSignHash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBitsSignature = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBitsHashData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHashData = new System.Windows.Forms.TextBox();
            this.tbDataToSign = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIsVerified
            // 
            this.tbIsVerified.Enabled = false;
            this.tbIsVerified.Location = new System.Drawing.Point(71, 379);
            this.tbIsVerified.Name = "tbIsVerified";
            this.tbIsVerified.Size = new System.Drawing.Size(69, 20);
            this.tbIsVerified.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Is Verified:";
            // 
            // buttonVerifyData
            // 
            this.buttonVerifyData.Location = new System.Drawing.Point(445, 376);
            this.buttonVerifyData.Name = "buttonVerifyData";
            this.buttonVerifyData.Size = new System.Drawing.Size(129, 23);
            this.buttonVerifyData.TabIndex = 31;
            this.buttonVerifyData.Text = "VerifyData";
            this.buttonVerifyData.UseVisualStyleBackColor = true;
            this.buttonVerifyData.Click += new System.EventHandler(this.buttonVerifyData_Click);
            // 
            // buttonVerifyHash
            // 
            this.buttonVerifyHash.Location = new System.Drawing.Point(305, 376);
            this.buttonVerifyHash.Name = "buttonVerifyHash";
            this.buttonVerifyHash.Size = new System.Drawing.Size(134, 23);
            this.buttonVerifyHash.TabIndex = 30;
            this.buttonVerifyHash.Text = "VerifyHash";
            this.buttonVerifyHash.UseVisualStyleBackColor = true;
            this.buttonVerifyHash.Click += new System.EventHandler(this.buttonVerifyHash_Click);
            // 
            // buttonSignData
            // 
            this.buttonSignData.Location = new System.Drawing.Point(445, 69);
            this.buttonSignData.Name = "buttonSignData";
            this.buttonSignData.Size = new System.Drawing.Size(129, 23);
            this.buttonSignData.TabIndex = 29;
            this.buttonSignData.Text = "SignData";
            this.buttonSignData.UseVisualStyleBackColor = true;
            this.buttonSignData.Click += new System.EventHandler(this.buttonSignData_Click);
            // 
            // buttonSignHash
            // 
            this.buttonSignHash.Location = new System.Drawing.Point(305, 69);
            this.buttonSignHash.Name = "buttonSignHash";
            this.buttonSignHash.Size = new System.Drawing.Size(134, 23);
            this.buttonSignHash.TabIndex = 28;
            this.buttonSignHash.Text = "SignHash";
            this.buttonSignHash.UseVisualStyleBackColor = true;
            this.buttonSignHash.Click += new System.EventHandler(this.buttonSignHash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "bits";
            // 
            // tbBitsSignature
            // 
            this.tbBitsSignature.Enabled = false;
            this.tbBitsSignature.Location = new System.Drawing.Point(584, 226);
            this.tbBitsSignature.Name = "tbBitsSignature";
            this.tbBitsSignature.ReadOnly = true;
            this.tbBitsSignature.Size = new System.Drawing.Size(48, 20);
            this.tbBitsSignature.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Signature of Data";
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(12, 226);
            this.tbSignature.Multiline = true;
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.Size = new System.Drawing.Size(565, 144);
            this.tbSignature.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "bits";
            // 
            // tbBitsHashData
            // 
            this.tbBitsHashData.Enabled = false;
            this.tbBitsHashData.Location = new System.Drawing.Point(584, 136);
            this.tbBitsHashData.Name = "tbBitsHashData";
            this.tbBitsHashData.ReadOnly = true;
            this.tbBitsHashData.Size = new System.Drawing.Size(48, 20);
            this.tbBitsHashData.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hash of Data";
            // 
            // tbHashData
            // 
            this.tbHashData.Location = new System.Drawing.Point(12, 136);
            this.tbHashData.Multiline = true;
            this.tbHashData.Name = "tbHashData";
            this.tbHashData.Size = new System.Drawing.Size(565, 47);
            this.tbHashData.TabIndex = 20;
            // 
            // tbDataToSign
            // 
            this.tbDataToSign.Location = new System.Drawing.Point(12, 30);
            this.tbDataToSign.Name = "tbDataToSign";
            this.tbDataToSign.Size = new System.Drawing.Size(603, 20);
            this.tbDataToSign.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data to be Signed";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 69);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(287, 23);
            this.buttonGenerate.TabIndex = 17;
            this.buttonGenerate.Text = "Instantiate Asymmetric Algorithm and Generate Keys";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 412);
            this.Controls.Add(this.tbIsVerified);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonVerifyData);
            this.Controls.Add(this.buttonVerifyHash);
            this.Controls.Add(this.buttonSignData);
            this.Controls.Add(this.buttonSignHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBitsSignature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBitsHashData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHashData);
            this.Controls.Add(this.tbDataToSign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIsVerified;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonVerifyData;
        private System.Windows.Forms.Button buttonVerifyHash;
        private System.Windows.Forms.Button buttonSignData;
        private System.Windows.Forms.Button buttonSignHash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBitsSignature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBitsHashData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHashData;
        private System.Windows.Forms.TextBox tbDataToSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

