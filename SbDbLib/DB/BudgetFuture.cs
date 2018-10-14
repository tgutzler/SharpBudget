using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class BudgetFuture
    {
        public long Key { get; set; }
        public long? CatKey { get; set; }
        public long? SubCatKey { get; set; }
        public long? Cycle { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Amount { get; set; }
    }
}
