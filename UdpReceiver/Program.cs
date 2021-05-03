using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UdpReceiver.Model;

namespace UdpReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UdpReciver receiver = new UdpReciver();
            receiver.ReciverData();
            
            Car car = new Car();

            Car p = SenderToApi.Post<Car, Car>("", car).Result;
            Console.WriteLine("Added: " + p);
        }
    }
}
