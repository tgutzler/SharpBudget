using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class Budget
    {
        public long Key { get; set; }
        public long? CatKey { get; set; }
        public long? SubCatKey { get; set; }
        public long? Month { get; set; }
        public long? Year { get; set; }
        public string Amount { get; set; }
    }
}
