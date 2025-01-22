using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context= new  MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.V1 = context.Skills.Count();
            ViewBag.V2=context.Messages.Count();
            ViewBag.V3=context.Messages.Where(x=>x.IsRead==false).Count();
            ViewBag.V4=context.Messages.Where(x=>x.IsRead==true).Count();

            ViewBag.V5=context.Experiences.Count();
            ViewBag.V6= context.SocialMedias.Count();
            return View();
        }
    }
}
