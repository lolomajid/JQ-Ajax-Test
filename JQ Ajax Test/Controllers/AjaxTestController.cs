using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JQ_Ajax_Test.Controllers
{
    public class AjaxTestController : Controller
    {
        [HttpGet]
        public IActionResult Index38()
        {
            return View();
        }
        [HttpPost]
        public string Index38(string name,int id)
        {
            return name + " " + id.ToString();
        }
        [HttpGet]
        public IActionResult Index39()
        {
            return View();
        }
        [HttpPost]
        public string Index39(string name, string family)
        {
            return name + " " + family;
        }
        [HttpGet]
        public IActionResult Index40()
        {
            return View();
        }
        [HttpPost]
        public string Index40(string email)
        {
            if (email.ToUpper().Contains("@GMAIL.COM"))
            {
                return "Ok";
            }
            else
            {
                return "Not Ok";
            }
            
        }
        [HttpGet]
        public IActionResult Index41()
        {
            return View();
        }
        [HttpPost]
        public string Index41(string email)
        {
            if (email.ToUpper().Contains("@GMAIL.COM"))
            {
                return "Ok";
            }
            else
            {
                return "Not Ok";
            }

        }
    }
}