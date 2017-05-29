using EI.SI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2_Servidor {
    class Program {

        private static ProtocolSI protocolSI;
        private const int PORT = 9999;
        static void Main(string[] args) {

            protocolSI = new ProtocolSI();
            NetworkStream networkStream = null;
            TcpListener tcpListener = null;
            TcpClient tcpClient = null;

            try {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);
                tcpListener = new TcpListener(endPoint);

                Console.WriteLine("Starting Server... ");

                tcpListener.Start();

                Console.WriteLine("Waiting for connections...");
                tcpClient =  tcpListener.AcceptTcpClient();

                Console.WriteLine("Client Connected..");

                networkStream = tcpClient.GetStream();

                int bytesRead = 0;

                #region Receive String Message



                int bufferSize = tcpClient.ReceiveBufferSize;
                //byte[] buffer = new byte[bufferSize];

                bytesRead = networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
                byte[] packet = protocolSI.GetData();

                if(protocolSI.GetCmdType() === ProtocolSICmdType.DATA) {

                }

                Console.WriteLine(Encoding.UTF8.GetString(packet));



                // enviar string a dizer ok
                byte[] ack = Encoding.UTF8.GetBytes("OK");
                networkStream.Write(ack, 0, ack.Length);

                #endregion

            } catch (Exception) {

                throw;
            } finally {
                if (networkStream != null) {
                    networkStream.Close();
                }
                if (tcpListener != null) {
                    tcpListener.Stop();
                }
                if (tcpClient != null) {
                    tcpClient.Close();
                }
            }
            Console.WriteLine("Servidor");
            Console.ReadKey();
        }
    }
}
