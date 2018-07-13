using System.Web.Mvc;
using Gonashapelg.CalculatorTwoArgument;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiplication", Text ="Умножение"
                },
                new SelectListItem()
                {
                    Value = "Addition", Text ="Сложение"
                },
                new SelectListItem()
                {
                    Value = "Subtraction", Text ="Вычитание"
                },
                new SelectListItem()
                {
                    Value = "Division", Text ="Деление"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator(operation);
            double result = calculator.Calculator(firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiplication", Text ="Умножение"
                },
                new SelectListItem()
                {
                    Value = "Addition", Text ="Сложение"
                },
                new SelectListItem()
                {
                    Value = "Subtraction", Text ="Вычитание"
                },
                new SelectListItem()
                {
                    Value = "Division", Text ="Деление"
                }
            };
            return View();
        }
    }
}