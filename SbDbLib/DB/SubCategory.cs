using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class SubCategory
    {
        public long Key { get; set; }
        public long? CatKey { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string DeleteOk { get; set; }
        public double? Amount { get; set; }
        public long? ForPeriod { get; set; }
        public string AutoGenExpEntry { get; set; }
        public long? AutoGenDay { get; set; }
        public string RecurExpAmount { get; set; }
        public string NextGenDate { get; set; }
        public long? TimesAyear { get; set; }
        public long? Modulus { get; set; }
        public long? PayFrom { get; set; }
        public long? ExpenseType { get; set; }
        public long? SeqNum { get; set; }
        public long? Payee { get; set; }
        public long? DeviceIdKey { get; set; }
        public long? DeviceKey { get; set; }
    }
}
