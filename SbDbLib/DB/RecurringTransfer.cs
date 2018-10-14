using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class RecurringTransfer
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public long? FromAccount { get; set; }
        public long? ToAccount { get; set; }
        public double? Amount { get; set; }
        public long? TimesAyear { get; set; }
        public string NextGenDate { get; set; }
        public long? Modulus { get; set; }
        public string Notes { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public string Currency { get; set; }
        public string CurrencyAmount { get; set; }
        public string EndDate { get; set; }
        public string GenerateNow { get; set; }
    }
}
