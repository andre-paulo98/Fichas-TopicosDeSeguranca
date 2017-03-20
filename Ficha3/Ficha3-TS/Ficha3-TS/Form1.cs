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
        private byte[] bytes;

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
                    bytes = ms.ToArray();
                    dadosEnc = ms.ToArray();
                }
                // 3º mostrar os dados cifrados
                //tbEncrypted.Text = Encoding.UTF8.GetString(dadosEnc);
                tbEncrypted.Text = Convert.ToBase64String(dadosEnc);

            }
        }

        private void btDecrypt_Click(object sender, EventArgs e) {
            using(AesCryptoServiceProvider aes = new AesCryptoServiceProvider()) {
                aes.Key = this.key;
                aes.IV = this.iv;

                // cifrar
                // 1º obter os dados a cifrar
                byte[] dados = Convert.FromBase64String(tbEncrypted.Text);
                //byte[] dados = this.bytes;
                // 2º aplicar o algoritmo de símetrico
                byte[] dadosDe = new byte[dados.Length];
                int bytesread = 0;
                using(MemoryStream ms = new MemoryStream(dados)) {
                    using(CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read)) {
                        bytesread = cs.Read(dadosDe, 0, dadosDe.Length);
                    }
                }
                // 3º mostrar os dados cifrados
                tbDecrypted.Text = Encoding.UTF8.GetString(dadosDe, 0, bytesread);

            }
        }
    }
}
