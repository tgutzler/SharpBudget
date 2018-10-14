using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Category
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string DeleteOk { get; set; }
        public long? SeqNum { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
    }
}
