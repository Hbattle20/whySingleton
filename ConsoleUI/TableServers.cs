using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TableServers
    {

        private List<string> servers = new List<string>();
        private int nextServer = 0;


        public TableServers()
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Bob");
            servers.Add("Mary");

        }

        public string GetNextServer()
        {

            string output = servers[nextServer];
            nextServer++;

            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }

            return output;

        }
    }
}
