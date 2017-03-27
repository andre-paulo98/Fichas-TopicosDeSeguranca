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

namespace FichaPratica5_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.sha1 = SHA1.Create();
        }

        private SHA1 sha1;

        private void buttonInput1_Click(object sender, EventArgs e) {
            byte[] dados = Encoding.UTF8.GetBytes(tbInput1.Text);
            byte[] output = new byte[dados.Length];
            sha1.TransformBlock(dados, 0, dados.Length, output, 0);
        }

        private void buttonInput2_Click(object sender, EventArgs e) {
            byte[] dados = Encoding.UTF8.GetBytes(tbInput2.Text);
            byte[] output = new byte[dados.Length];
            sha1.TransformBlock(dados, 0, dados.Length, output, 0);
        }

        private void buttonFinal_Click(object sender, EventArgs e) {
            byte[] dados = Encoding.UTF8.GetBytes(tbInputFinal.Text);
            sha1.TransformFinalBlock(dados, 0, dados.Length);
            tbHash.Text = BitConverter.ToString(sha1.Hash);
        }
    }
}