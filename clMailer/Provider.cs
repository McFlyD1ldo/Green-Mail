﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clMailer
{
    public class Provider
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Name { get; set; }
        public Provider(string host, int port, string name)
        {
            Host = host;
            Port = port;
            Name = name;
        }
    }
}
