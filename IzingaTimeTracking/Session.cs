using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzingaTimeTracking {
    class Session {
        public int sessionID { get; set; }
        public string comment { get; set; }
        public double hours { get; set; }
        public User user { get; set; }
        public Area area { get; set; }
        public Project project { get; set; }
    }
}
