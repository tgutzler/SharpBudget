using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class AccountTrans
    {
        public long Key { get; set; }
        public long? AccountKey { get; set; }
        public string TimeStamp { get; set; }
        public long? TransType { get; set; }
        public long? TransKey { get; set; }
        public string TransDate { get; set; }
        public double? TransAmount { get; set; }
        public string Checked { get; set; }
    }
}
