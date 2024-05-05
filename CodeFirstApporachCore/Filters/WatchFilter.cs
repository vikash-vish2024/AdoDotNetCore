using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace CodeFirstApporachCore.Filters
{
    public class WatchFilter : ActionFilterAttribute
    {
        private Stopwatch _watch;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _watch = Stopwatch.StartNew();
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _watch.Stop();
            var elelaspsedMillSec=_watch.ElapsedMilliseconds;
            Console.WriteLine($"Time Taken to complete the action : {elelaspsedMillSec}");
        }
    }
}
