using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String originalFilePath = "security.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                originalFilePath = openFileDialog1.FileName;
            }

            labelCopyFile.Text = "Imagem copiada";
            labelCopyFile.Visible = true;

           
            String destinationFilePath = "securitycopia.jpg";
            int bufferSize = 20480;
            Byte[] buffer = new Byte[bufferSize];
            int bytesRead = 0;

            FileStream originalFileStream = new FileStream(originalFilePath, FileMode.Open);
            StreamWriter log = new StreamWriter("log.txt", true);

            if (File.Exists(destinationFilePath)) {
                File.Delete(destinationFilePath);
            }

            progressBar1.Maximum = (int)originalFileStream.Length;

            FileStream destinationFileStream = new FileStream(destinationFilePath, FileMode.CreateNew);

            while ((bytesRead = originalFileStream.Read(buffer, 0, bufferSize)) > 0)
            {
                destinationFileStream.Write(buffer, 0, bytesRead);
                progressBar1.Increment(bytesRead);
            }

            log.WriteLine("Ficheiro = " + originalFilePath + "\tBytes: " + originalFileStream.Length);
            log.Close();



            originalFileStream.Close();
            destinationFileStream.Close();




        }
    }
}
