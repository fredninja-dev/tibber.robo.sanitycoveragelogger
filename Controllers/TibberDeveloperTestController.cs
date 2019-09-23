using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tibber.robo.sanitycoveragelogger.Database;
using tibber.robo.sanitycoveragelogger.DTO;
using tibber.robo.sanitycoveragelogger.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tibber.robo.sanitycoveragelogger.Controllers
{
    [Route("tibber-developer-test")]
    public class TibberDeveloperTestController : Controller
    {
        private readonly RoboDBContext _context;

        public TibberDeveloperTestController(RoboDBContext context)
        {
            _context = context;
        }

        [HttpPost("enter-path")]
        public ActionResult<Executions> savereport([FromBody]SanityReport report)
        {
            int startCoordinateVertexCount = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var execution = new Executions
            {
                commmands = report.commmands.Count,
                result = report.commmands.Select(x => x.steps).Sum() + startCoordinateVertexCount,
                timestamp = DateTime.Now
            };
            stopwatch.Stop();
            execution.duration = (decimal)stopwatch.Elapsed.TotalSeconds;
            _context.Executions.Add(execution);
            _context.SaveChanges();
            return execution;
        }
    }
}
