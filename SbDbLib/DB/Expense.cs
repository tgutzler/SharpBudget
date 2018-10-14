using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Expense
    {
        public long Key { get; set; }
        public DateTime Date { get; set; }
        public long? CatKey { get; set; }
        public long? SubCatKey { get; set; }
        public double? Amount { get; set; }
        public long? Periods { get; set; }
        public string Notes { get; set; }
        public string IsDetailEntry { get; set; }
        public long? MasterKey { get; set; }
        public string IncludesReceipt { get; set; }
        public long? PayFrom { get; set; }
        public long? PayeeKey { get; set; }
        public long? BillKey { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public string TimeStamp { get; set; }
        public string Currency { get; set; }
        public string CurrencyAmount { get; set; }
        public long? RecurringKey { get; set; }
        public string IsCategorySplit { get; set; }
    }
}
