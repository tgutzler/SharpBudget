using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Payee
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public string AccountNum { get; set; }
        public string PhoneNum { get; set; }
        public string WebUrl { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public string Notes { get; set; }
    }
}
