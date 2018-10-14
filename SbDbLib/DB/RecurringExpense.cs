using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class RecurringExpense
    {
        public long Key { get; set; }
        public long? SubCatKey { get; set; }
        public long? CatKey { get; set; }
        public string Amount { get; set; }
        public long? TimesAyear { get; set; }
        public string NextGenDate { get; set; }
        public long? Modulus { get; set; }
        public long? PayFrom { get; set; }
        public long? Payee { get; set; }
        public string Notes { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public string Currency { get; set; }
        public string CurrencyAmount { get; set; }
        public string EndDate { get; set; }
        public string GenerateNow { get; set; }
    }
}
