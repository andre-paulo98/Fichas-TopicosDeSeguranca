namespace Ficha3_TS {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbEncrypt = new System.Windows.Forms.TextBox();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEncrypted = new System.Windows.Forms.TextBox();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.tbDecrypted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to Encrypt";
            // 
            // tbEncrypt
            // 
            this.tbEncrypt.Location = new System.Drawing.Point(12, 25);
            this.tbEncrypt.Name = "tbEncrypt";
            this.tbEncrypt.Size = new System.Drawing.Size(569, 20);
            this.tbEncrypt.TabIndex = 1;
            // 
            // btEncrypt
            // 
            this.btEncrypt.Location = new System.Drawing.Point(12, 51);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(144, 23);
            this.btEncrypt.TabIndex = 2;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypted Text (UTF-8)";
            // 
            // tbEncrypted
            // 
            this.tbEncrypted.Location = new System.Drawing.Point(12, 97);
            this.tbEncrypted.Multiline = true;
            this.tbEncrypted.Name = "tbEncrypted";
            this.tbEncrypted.Size = new System.Drawing.Size(569, 146);
            this.tbEncrypted.TabIndex = 4;
            // 
            // btDecrypt
            // 
            this.btDecrypt.Location = new System.Drawing.Point(12, 250);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(144, 23);
            this.btDecrypt.TabIndex = 5;
            this.btDecrypt.Text = "Decrypt using TextBox data";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // tbDecrypted
            // 
            this.tbDecrypted.Location = new System.Drawing.Point(12, 373);
            this.tbDecrypted.Name = "tbDecrypted";
            this.tbDecrypted.Size = new System.Drawing.Size(569, 20);
            this.tbDecrypted.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDecrypted);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.tbEncrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEncrypt);
            this.Controls.Add(this.tbEncrypt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEncrypt;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEncrypted;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.TextBox tbDecrypted;
        private System.Windows.Forms.Label label3;
    }
}

