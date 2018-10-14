using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Account
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string AccountType { get; set; }
        public double? Balance { get; set; }
        public string DeleteOk { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public DateTime BalanceDate { get; set; }
        public string IncludeAccount { get; set; }
        public long? SeqNum { get; set; }
        public string Currency { get; set; }
    }
}
