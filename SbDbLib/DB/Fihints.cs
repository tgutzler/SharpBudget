using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Fihints
    {
        public long Key { get; set; }
        public long? AccountKey { get; set; }
        public string Name { get; set; }
        public long? TrnType { get; set; }
        public long? ProcessAs { get; set; }
        public long? CatKey { get; set; }
        public long? SubCatKey { get; set; }
        public long? PayeeKey { get; set; }
        public long? Account2Key { get; set; }
    }
}
