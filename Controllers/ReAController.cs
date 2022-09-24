using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ReAController : Controller
    {
        string[] newArray;
        // GET: ReA
        public ActionResult ReAIndex(string[] arrayN, int[] arrayO)
        {

            ///Variables used for test
            //arrayN = new string[] { "Amazon", "Apple", "Google" };
            //arrayO = new int[] { 2, 3, 1 };

            ///Set the size of the array
            int k = 0;
            foreach (string s in arrayN)
                k++;

            ///Create the new array
            newArray = new string[k];
            try
            {
                ///Reordered the values 
                for (int j = 0; j < k; j++)
                {
                    string name = arrayN[j];
                    int order = arrayO[j];
                    newArray.SetValue(name, order - 1);
                }
            }
            catch (Exception e)
            {
                ///For this example, if something wrong happen, show the error meesagge
                newArray.SetValue(e.Message, 0);
            }

            ///Passing the values to the View
            ViewData["Size"] = k;
            ViewData["NewArray"] = newArray;
            return View();
        }
    }
}