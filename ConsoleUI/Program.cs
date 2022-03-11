using System;
using System.Net.NetworkInformation;

namespace ConsoleUI
{
    public class Program
    {
        static TableServers host1List = TableServers.GetTabelServers();
        static TableServers host2List = TableServers.GetTabelServers();
        static void Main(string[] args)
        {
            TableServers servers = TableServers.GetTabelServers();

            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("the next server is: " + servers.GetNextServer());
                Host1GetNextServer();
                Host2GetNextServer();
            }
            Console.ReadLine();
        }

        private static void Host1GetNextServer()
        {
            Console.WriteLine("the next server is: " + host1List.GetNextServer());
        }
        
        private static void Host2GetNextServer()
        {
            Console.WriteLine("the next server is: " + host2List.GetNextServer());
        }
    }
}