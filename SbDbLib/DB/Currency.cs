using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Currency
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Locale { get; set; }
        public string ExchangeRate { get; set; }
    }
}
