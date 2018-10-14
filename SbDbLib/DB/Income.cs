using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Income
    {
        public long Key { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
        public string Notes { get; set; }
        public long? MasterKey { get; set; }
        public long? AddIncomeTo { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public string TimeStamp { get; set; }
        public string Currency { get; set; }
        public string CurrencyAmount { get; set; }
        public long? RecurringKey { get; set; }
    }
}
