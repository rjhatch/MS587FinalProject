using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS587FinalProject.Data.Models
{
    public class ClassSession
    {
        public int ClassSessionId { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
