using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Fitrans
    {
        public long Key { get; set; }
        public long? AccountKey { get; set; }
        public string FiTid { get; set; }
        public string TrnType { get; set; }
        public string DatePosted { get; set; }
        public string TrnAmount { get; set; }
        public string Sic { get; set; }
        public string Name { get; set; }
        public string ProcessState { get; set; }
        public long? ProcessAs { get; set; }
        public long? CatKey { get; set; }
        public long? SubCatKey { get; set; }
        public long? PayeeKey { get; set; }
        public long? Account2Key { get; set; }
    }
}
