using Microsoft.AspNetCore.Mvc;

namespace Demo02MVC02.Controllers
{
    public class MoviesController : Controller
    {
        //Actions : Public non-Static Funcations

        public string Test()
        {
            return $" Default Path";
        }
       // Actions
        public string GetMovies(int id)
        {
            return $" ID: {id}";
        }

 //---------------------------------------------------------------------------
        public IActionResult GetMovie(int? id, string Name, Movie movie)
        {
            //var result = new ContentResult();
            //result.Content = $" ID : {id}";
            //result.ContentType = "text/html"; // 
            //                                  // result.ContentType = "object/pdf"; 

            //Content() اسمها Function بدل ما اعمل كل الكلام ده في 

            return Content($"ID : {id}", "text/html");


        }

    //----------------------------------------------------------------------
        //Action Parameter Binding: 
        // 1. From
        // 2. Segment
        // 3. Query String (or) Query Params
        // 4. File

        //-------------------------------------------------------------

 
        public RedirectToActionResult Test01()
        {
            RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id = "Hamda" });
            return result;
        }

        ///======================================================

        
        public IActionResult Test02(int id)
        {
            RedirectResult result;
            if (id == 1)
            {
                // result = new RedirectResult("https://www.facebook.com");

                //---------------------------------
                return Redirect("https://www.facebook.com");
            }
            else
            {
                result = new RedirectResult("https://www.google.com");

                //--------------------------------------
                return Redirect("https://www.google.com");
            }
            return result;
            
            ///======================================================
        }
      
        public ActionResult Test03(int? id)
        {
            if (id == null)
            {
                //RedirectResult result = new RedirectResult("https://www.facebook.com");
                //return result;

                //-----------------------------
                return Redirect("https://www.facebook.com");

            }
            else
            {
                //RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id = "Hamda" });
                //return result;

                //---------------------------------------
                return RedirectToAction("GetMovie", "Movies", new { id = "1000" });
            }
        }
    }
}
