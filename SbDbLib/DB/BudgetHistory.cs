using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class BudgetHistory
    {
        public long Key { get; set; }
        public string BudgetType { get; set; }
        public long? CatKey { get; set; }
        public long? SubCatKey { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Amount { get; set; }
        public string RolloverBalance { get; set; }
        public string RolloverOnOff { get; set; }
    }
}
