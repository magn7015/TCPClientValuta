using System;
using System.IO;
using System.Net.Sockets;

namespace TCPClientValuta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            TcpClient clientSocket = new TcpClient("192.168.191.33", 7777);

            Stream ns = clientSocket.GetStream();  //provides a Stream
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            string message = Console.ReadLine();
            sw.WriteLine(message);
            string serverAnswer = sr.ReadLine();
            Console.WriteLine("Server: " + serverAnswer);
            Console.ReadLine();

            ns.Close();

            clientSocket.Close();
        }
    }
}
