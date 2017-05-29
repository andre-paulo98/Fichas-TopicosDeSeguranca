using EI.SI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2_Cliente {
    class Program {

        private static ProtocolSI protocolSI;
        private const int PORT = 9999;

        static void Main(string[] args) {


            protocolSI = new ProtocolSI();
            TcpClient tcpClient = null;
            NetworkStream networkStream = null;

            try {
                Console.WriteLine("Starting client... ");
                tcpClient = new TcpClient();
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);

                Console.WriteLine("Start connection? Press any key.");
                Console.ReadKey();

                tcpClient.Connect(endPoint);

                Console.WriteLine("Connected to the Server.");
                networkStream = tcpClient.GetStream();

                #region Send String Message



                string msg = "Hello from client!";
                byte[] msgByte = Encoding.UTF8.GetBytes(msg);
                byte[] packet = protocolSI.Make(ProtocolSICmdType.DATA, msgByte);
                networkStream.Write(packet, 0, packet.Length);


                
                byte[] buffer = new byte[2];
                int bytesRead = networkStream.Read(buffer, 0, 2);
                Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, buffer.Length));

                #endregion

            } catch (Exception) {

                throw;
            } finally {
                if (networkStream != null) {
                    networkStream.Close();
                }
                if (tcpClient != null) {
                    tcpClient.Close();
                }
            }

            Console.WriteLine("Client");
            Console.ReadKey();
        }
    }
}
