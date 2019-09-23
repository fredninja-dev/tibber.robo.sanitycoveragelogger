using System;
namespace tibber.robo.sanitycoveragelogger.DTO
{
    public class Executions
    {
        public int id { get; set; }
        public DateTime timestamp { get; set; }
        public int commmands { get; set; }
        public int result { get; set; }
        public decimal duration { get; set; }
    }
}
