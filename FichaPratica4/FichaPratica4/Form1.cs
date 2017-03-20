using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaPratica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RSACryptoServiceProvider rsa;
        private string publicKey;
        private string privateKey;

        private void buttonGenerateKeys_Click(object sender, EventArgs e) {
            rsa = new RSACryptoServiceProvider();
            publicKey = rsa.ToXmlString(false);
            tbPublicKey.Text = publicKey;

            privateKey = rsa.ToXmlString(true);
            tbBothKeys.Text = privateKey;
        }

        private void buttonSavePublicKey_Click(object sender, EventArgs e) {
            File.WriteAllText("publicKey.txt", publicKey);
        }

        private void buttonSavePublicPrivateKey_Click(object sender, EventArgs e) {
            File.WriteAllText("privateKey.txt", privateKey);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e) {
            string textEncrypt = tbSymmentricKey.Text;
            byte[] dados = Encoding.UTF8.GetBytes(textEncrypt);
            byte[] encriptado;
            encriptado = rsa.Encrypt(dados, false);
            tbSymmetricKeyEncrtypted.Text = Convert.ToBase64String(encriptado);
            tbBitSize.Text = encriptado.Length+"";

        }

        private void buttonDecrypt_Click(object sender, EventArgs e) {
            string textDecrypt = tbSymmetricKeyEncrtypted.Text;
            byte[] dados = Convert.FromBase64String(textDecrypt);
            byte[] desencriptado;
            desencriptado = rsa.Decrypt(dados, false);
            tbSymmetricKeyDecrypted.Text = Encoding.UTF8.GetString(desencriptado);
        }
    }
}
