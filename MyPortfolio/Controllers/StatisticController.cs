using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using System.Collections.Immutable;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Count(x => x.IsRead == false);
            ViewBag.v4 = context.Messages.Count(x => x.IsRead == true);

            ViewBag.t1 = context.ToDoLists.Count();
            ViewBag.t2 = context.ToDoLists.Count(x => x.Status == false);
            ViewBag.t3 = context.ToDoLists.Count(x => x.Status == true);
            ViewBag.t4 = context.ToDoLists.Count(x => x.Date.Day == DateTime.Today.Day);

            ViewBag.skills = context.Skills.ToList();

            ViewBag.e1 = context.Experiences.Count();
            
            ViewBag.p1 = context.Portfolios.Count();
            return View();
        }
    }
}
