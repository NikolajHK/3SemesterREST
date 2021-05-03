using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UdpReceiver.Model;

namespace UdpReceiver
{
    public class UdpReciver
    {
        public void ReciverData()
        {
            UdpClient udpServer = new UdpClient(9999);

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint RemoteIPEndpoint = new IPEndPoint(ip, 9999);

            try
            {
                Car car = new Car();

                Byte[] recivedBytes = udpServer.Receive(ref RemoteIPEndpoint);

                string recivedData = Encoding.ASCII.GetString(recivedBytes);

                string[] data = recivedData.Split("");
                car.Farve = data[0];
                car.Visind = Int32.Parse(data[1]);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
