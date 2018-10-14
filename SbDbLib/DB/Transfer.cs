using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Transfer
    {
        public long Key { get; set; }
        public DateTime TransferDate { get; set; }
        public long? FromAccount { get; set; }
        public long? ToAccount { get; set; }
        public double? Amount { get; set; }
        public string Notes { get; set; }
        public long? BillKey { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public string Currency { get; set; }
        public string CurrencyAmount { get; set; }
        public long? RecurringKey { get; set; }
    }
}
