using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderWebApp.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CommandLine { get; set; }

        public Command()
        {

        }
    }
}
