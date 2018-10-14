using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class AccountLog
    {
        public long Key { get; set; }
        public long? AccountKey { get; set; }
        public string TimeStamp { get; set; }
        public long? TransType { get; set; }
        public long? TransKey { get; set; }
        public double? TransAmount { get; set; }
        public double? NewBalance { get; set; }
        public string Checked { get; set; }
        public string TransDate { get; set; }
    }
}
