using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class SyncUpdate
    {
        public long Key { get; set; }
        public string UpdateType { get; set; }
        public string Uuid { get; set; }
        public string Payload { get; set; }
    }
}
