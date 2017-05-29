using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaPratica8_Base
{
    public partial class Form1 : Form
    {
        private const int SALTSIZE = 8;
        private const string CNNSTRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Utilizador\Documents\GitHub\Fichas-TopicosDeSeguranca\FichaPratica8_Base\FichaPratica8_Base\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }



        private bool VerifyLogin(string username, string password)
        {
            SqlConnection conn = null;
            try
            {
                // Configurar ligação à Base de Dados
                conn = new SqlConnection();
                conn.ConnectionString = String.Format(CNNSTRING);

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração do comando SQL
                String sql = "SELECT * FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;

                // Declaração dos parâmetros do comando SQL
                SqlParameter param = new SqlParameter("@username", username);

                // Introduzir valor ao parâmentro registado no comando SQL
                cmd.Parameters.Add(param);

                // Associar ligação à Base de Dados ao comando a ser executado
                cmd.Connection = conn;

                // Executar comando SQL
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    throw new Exception("Error while trying to access an user");
                }

                // Ler resultado da pesquisa
                reader.Read();

                // Obter Hash (password + salt)
                byte[] saltedPasswordHashStored = (byte[])reader["SaltedPasswordHash"];

                // Obter salt
                byte[] saltStored = (byte[])reader["Salt"];

                conn.Close();
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = GenerateSaltedHash(passwordBytes, saltStored);
                return saltedPasswordHashStored.SequenceEqual(hash);
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred");
                return false;
            }
        }

        private void Register(string username, byte[] saltedPasswordHash, byte[] salt)
        {
            SqlConnection conn = null;
            try
            {
                // Configurar ligação à Base de Dados
                conn = new SqlConnection();
                conn.ConnectionString = String.Format(CNNSTRING);

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração dos parâmetros do comando SQL
                SqlParameter paramUsername = new SqlParameter("@username", username);
                SqlParameter paramPassHash = new SqlParameter("@saltedPasswordHash", saltedPasswordHash);
                SqlParameter paramSalt = new SqlParameter("@salt", salt);

                // Declaração do comando SQL
                String sql = "INSERT INTO Users (Username, SaltedPasswordHash, Salt) VALUES (@username,@saltedPasswordHash,@salt)";

                // Prepara comando SQL para ser executado na Base de Dados
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Introduzir valores aos parâmentros registados no comando SQL
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassHash);
                cmd.Parameters.Add(paramSalt);

                // Executar comando SQL
                int lines = cmd.ExecuteNonQuery();

                // Fechar ligação
                conn.Close();
                if (lines == 0)
                {
                    // Se forem devolvidas 0 linhas alteradas então o não foi executado com sucesso
                    throw new Exception("Error while inserting an user");
                } else {
                    string exclamacao = "";
                    for(int i = 0; i < 2000; i++) {
                        exclamacao += "!";
                    }
                    MessageBox.Show("User inserted" + exclamacao);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error while inserting an user:" + e.Message);
            }
        }

        private static byte[] GenerateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return buff;
        }

        private static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            using (HashAlgorithm hashAlgorithm = SHA512.Create())
            {
                // Declarar e inicializar buffer para o texto e salt
                byte[] plainTextWithSaltBytes =
                              new byte[plainText.Length + salt.Length];

                // Copiar texto para buffer
                for (int i = 0; i < plainText.Length; i++)
                {
                    plainTextWithSaltBytes[i] = plainText[i];
                }
                // Copiar salt para buffer a seguir ao texto
                for (int i = 0; i < salt.Length; i++)
                {
                    plainTextWithSaltBytes[plainText.Length + i] = salt[i];
                }

                //Devolver hash do text + salt
                return hashAlgorithm.ComputeHash(plainTextWithSaltBytes);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            /*String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            if(VerifyLogin(username, password)) {
                MessageBox.Show("Valid User");
            } else {
                MessageBox.Show("Invalid User");
            }*/
            MessageBox.Show("1");
            MessageBox.Show("2");

        }

        private void buttonRegister_Click(object sender, EventArgs e) {/*
            byte[] salt = GenerateSalt(SALTSIZE);
            textBoxSalt.Text = Convert.ToBase64String(salt);
            textBoxSizeSalt.Text = (salt.Length * 8) + "";

            byte[] password = Encoding.UTF8.GetBytes(textBoxPassword.Text);
            byte[] hash = GenerateSaltedHash(password, salt);


            textBoxSizePass.Text = (hash.Length * 8) + "";
            textBoxSaltedHash.Text = Convert.ToBase64String(hash);

            Register(textBoxUsername.Text, hash, salt);*/

            ClientThread ct = new ClientThread("Thread 1");
            ct.Run();

            ClientThread ct2 = new ClientThread("Thread 2");
            ct2.Run();


        }

        private class ClientThread {
            private String message;

            public ClientThread(String message) {
                this.message = message;
            }

            public void Run() {
                Thread t = new Thread(showMessage);
                t.Start();
            }

            private void showMessage() {
                MessageBox.Show(message);
            }
        }
    }
}
