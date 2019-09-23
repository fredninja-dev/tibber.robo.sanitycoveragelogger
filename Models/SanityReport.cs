using System;
using System.Collections.Generic;

namespace tibber.robo.sanitycoveragelogger.Models
{
    public class SanityReport
    {
        public Start start { get; set; }
        public List<Commmand> commmands { get; set; }
    }

    public class Start
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class Commmand
    {
        public string direction { get; set; }
        public int steps { get; set; }
    }

}
