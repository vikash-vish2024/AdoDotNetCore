using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace CodeFirstApporachCore.Filters
{
    public class WatchActionAsync :IAsyncActionFilter
    {
        private Stopwatch _watch;

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _watch = Stopwatch.StartNew();
            await next();
        }
        //public override void OnActionExecutedAsync(ActionExecutedContext context)
        //{
        //    _watch.Stop();
        //    var elelaspsedMillSec = _watch.ElapsedMilliseconds;
        //    Console.WriteLine($"Time Taken to complete the action : {elelaspsedMillSec}");

        //}
    }
}
