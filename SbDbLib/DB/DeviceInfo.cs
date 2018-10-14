using System;
using System.Collections.Generic;

namespace SbDbLib.DB
{
    internal class DeviceInfo
    {
        public long Key { get; set; }
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string IsActive { get; set; }
        public string IsPrimary { get; set; }
    }
}
