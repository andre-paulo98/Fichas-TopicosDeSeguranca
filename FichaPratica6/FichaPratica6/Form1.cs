using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaPratica6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RSACryptoServiceProvider rsaSign;
        private RSACryptoServiceProvider rsaVerify;

        private void buttonGenerate_Click(object sender, EventArgs e) {
            rsaSign = new RSACryptoServiceProvider();
            string publicKey = rsaSign.ToXmlString(false);

            rsaVerify = new RSACryptoServiceProvider();
            rsaVerify.FromXmlString(publicKey);

            using(SHA1 sha1 = SHA1.Create()) {
                byte[] dados = Encoding.UTF8.GetBytes(tbDataToSign.Text);
                byte[] hash = sha1.ComputeHash(dados);

                tbHashData.Text = Convert.ToBase64String(hash);
                tbBitsHashData.Text = (hash.Length * 8) + "";

            }
        }

        private void buttonSignHash_Click(object sender, EventArgs e) {
            byte[] hash = Convert.FromBase64String(tbHashData.Text);
            byte[] signature = rsaSign.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
            tbSignature.Text = Convert.ToBase64String(signature);
        }

        private void buttonSignData_Click(object sender, EventArgs e) {
            byte[] dados = Encoding.UTF8.GetBytes(tbDataToSign.Text);
            using(SHA1 sha1 = SHA1.Create()) {
                byte[] signature = rsaSign.SignData(dados, sha1);
                tbSignature.Text = Convert.ToBase64String(signature);
            }

           
        }

        private void buttonVerifyHash_Click(object sender, EventArgs e) {
            byte[] signature = Convert.FromBase64String(tbSignature.Text);
            byte[] hash = Convert.FromBase64String(tbHashData.Text);
            bool verify = rsaVerify.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
            tbIsVerified.Text = verify.ToString();
        }

        private void buttonVerifyData_Click(object sender, EventArgs e) {
            using(SHA1 sha1 = SHA1.Create()) {
                byte[] signature = Convert.FromBase64String(tbSignature.Text);
                byte[] data = Encoding.UTF8.GetBytes(tbDataToSign.Text);
                bool verify = rsaVerify.VerifyData(data, sha1, signature);
                tbIsVerified.Text = verify.ToString();
            }
            
        }
    }
}
