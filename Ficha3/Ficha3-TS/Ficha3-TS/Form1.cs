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

namespace Ficha3_TS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private byte[] key;
        private byte[] iv;

        private void btEncrypt_Click(object sender, EventArgs e) {
            using(AesCryptoServiceProvider aes = new AesCryptoServiceProvider()) {
                this.key = aes.Key;
                this.iv = aes.IV;

                // cifrar
                // 1º obter os dados a cifrar
                byte[] dados = Encoding.UTF8.GetBytes(tbEncrypt.Text);
                // 2º aplicar o algoritmo de símetrico
                byte[] dadosEnc;
                using(MemoryStream ms = new MemoryStream()) {
                    using(CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write)) {
                        cs.Write(dados, 0, dados.Length);
                    }
                    dadosEnc = ms.ToArray();
                }
                // 3º mostrar os dados cifrados
                tbEncrypted.Text = Encoding.UTF8.GetString(dadosEnc);

            }
        }

        private void btDecrypt_Click(object sender, EventArgs e) {

        }
    }
}
