using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyApp
{
    public class Client
    {
        public int Id { get; internal set; }

        public string Name { get; internal set; }

        public ClientStatus ClientStatus { get; set; }
    }
}
