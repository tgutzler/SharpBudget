using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Bill
    {
        public long Key { get; set; }
        public long? PayeeKey { get; set; }
        public double? Amount { get; set; }
        public string DueDate { get; set; }
        public string Paid { get; set; }
        public long? ExpenseKey { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public string TimeStamp { get; set; }
        public long? BillType { get; set; }
        public string Currency { get; set; }
        public string CurrencyAmount { get; set; }
        public long? RecurringKey { get; set; }
        public long? CatKey { get; set; }
        public long? SubCatKey { get; set; }
        public long? FromAccountKey { get; set; }
        public string Notes { get; set; }
    }
}
