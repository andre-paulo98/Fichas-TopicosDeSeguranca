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

namespace FichaPratica5_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMD5_Click(object sender, EventArgs e) {
            using(MD5 md5 = MD5.Create()) {

                byte[] dados = Encoding.UTF8.GetBytes(tbData.Text);
                byte[] hash = md5.ComputeHash(dados);
                tbBits.Text = hash.Length * 8 + "";

                tbHash.Text = BitConverter.ToString(hash);
            }
        }

        private void buttonSHA1_Click(object sender, EventArgs e) {
            using(SHA1 sha1 = SHA1.Create()) {
                byte[] dados = Encoding.UTF8.GetBytes(tbData.Text);
                byte[] hash = sha1.ComputeHash(dados);
                tbBits.Text = hash.Length * 8+"";

                tbHash.Text = BitConverter.ToString(hash);
            }
        }

        private void buttonSHA512_Click(object sender, EventArgs e) {
            using(SHA256 sha256 = SHA256.Create()) {
                byte[] dados = Encoding.UTF8.GetBytes(tbData.Text);
                byte[] hash = sha256.ComputeHash(dados);
                tbBits.Text = hash.Length * 8 + "";

                tbHash.Text = BitConverter.ToString(hash);
            }
        }
    }
}
