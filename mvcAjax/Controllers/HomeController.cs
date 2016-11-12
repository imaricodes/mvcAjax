using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcAjax.Models;

namespace mvcAjax.Controllers
{
  // ----- makeITspendIT.com -----

  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public void Test01()
    {
      // call only, no return 
      // Tthis string is only for debugging - you can breakpoint here
      string notUsedString = "We got to Test01";
    }

    [HttpPost]
    public string Test02()
    {
      // call and return a string
      return "Hello from Test02";
    }

    [HttpPost]
    public string Test03( string str1, string str2 )
    {
      // call with two parameters and return them back
      return String.Format( "Test03: String1={0}; String2={1}", str1, str2 );
    }

    [HttpPost]
    public PartialViewResult Test04()
    {
      // call with two parameters and return them back
      return PartialView( "_MyPartialView" );
    }

    //This attaches to #SearchBtn element
    public JsonResult ProcessToCaps(string SearchInput)
    {
        var temp = SearchInput;

            // TODO: look up database and return multiple rows

            //constructor takes user input fires private method to capitalize (test)..this works
            ProcessModel processModel = new ProcessModel (SearchInput);
            //can set properties during contructions inside these braces:
        //{
        //    Id = IdFromDatabase,
        //    Title = TitleFromDatabase,
        //    //add more if you want according to your model
        //}
        
        return Json(processModel.Input);
    }

        //This attaches to #JSObjectSendBtn element
        public bool JSTestMethod(Person thisGuy)
        {
            return thisGuy != null;
        }

    }
}