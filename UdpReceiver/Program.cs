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
            
            UdpReciver receiver = new UdpReciver();

            // starter metoden
            receiver.ReciverData();
            
            Car car = new Car();

            // starter metoden
            // giver udfyldens krav, så uri, object
            // den bruger generic til at vide hvad er den skal sender til api'en
            Car p = SenderToApi.Post<Car, Car>("", car).Result;

            // beder programmet om at vis resultet fra metoden i console applikation
            Console.WriteLine("Added: " + p);
        }
    }
}
