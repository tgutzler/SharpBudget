using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class RecurringBill
    {
        public long Key { get; set; }
        public long? BillType { get; set; }
        public long? PayeeOrAccountKey { get; set; }
        public string Amount { get; set; }
        public string NextGenDate { get; set; }
        public long? RecurringIndex { get; set; }
        public long? Modulus { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
        public string Currency { get; set; }
        public string CurrencyAmount { get; set; }
        public string EndDate { get; set; }
        public string GenerateNow { get; set; }
        public long? CatKey { get; set; }
        public long? SubCatKey { get; set; }
        public long? FromAccountKey { get; set; }
        public string Notes { get; set; }
    }
}
