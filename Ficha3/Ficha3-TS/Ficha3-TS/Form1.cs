﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btEncrypt_Click(object sender, EventArgs e) {
            using(AesCryptoServiceProvider aes = new AesCryptoServiceProvider()) {
                aes.Key;
                aes.IV;
            }
        }

        private void btDecrypt_Click(object sender, EventArgs e) {

        }
    }
}