using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using datatable_app.Models;

namespace datatable_app.Controllers
{
    public class HomeController : Controller
    {
        Database Data = new Database();
        public ActionResult Start()

        {    
            ViewBag.lang= new SelectList(Data.cList, "Cname", "Value");
            return View();
        }

        [HttpPost]
        public ActionResult Start(FormCollection form)

        {
            foreach (var key in form.AllKeys)
            {
                TempData[key] = form[key];
                
            }

            if (ModelState.IsValid)
            {
                return View("Index");
            }
            return View();
        }
        public ActionResult Index()

        {   
            return View();
        }
        [HttpPost]
        public ActionResult About()
        {
            var draw = Request.Form.GetValues("draw").FirstOrDefault();
            var start = Request.Form.GetValues("start").FirstOrDefault();
            var length = Request.Form.GetValues("length").FirstOrDefault();
            //Find Order Column
           // var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
            var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
            var name=Request.Form.GetValues("search[value]").FirstOrDefault();
            var v = (from a in Data.userList select a);
            if (sortColumnDir=="desc")
            {

               v = v.OrderByDescending(C => C.Name).ThenByDescending(C => C.Div).ThenByDescending(C => C.RollNo);
            }
            if(sortColumnDir == "asc")
            {
                v = v.OrderBy(C => C.Name).ThenBy(C => C.Div).ThenBy(C => C.RollNo);
            }

           v = v.Where(x => x.Name.Contains(name)||x.RollNo.Contains(name)||x.Div.Contains(name)).Select(x=>new User
               {
                   Name = x.Name,
                   country =x.country,
                   Div=x.Div,
                   RollNo=x.RollNo,
               }).ToList();
            
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;

            recordsTotal = v.Count();
                var data = v.Skip(skip).Take(pageSize).ToList();
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data }, JsonRequestBehavior.AllowGet);
            
           
        }
        public ActionResult AddEditEmployee(String id)
        {  
          
            User model = new User();
            foreach (var item in Data.userList.Where(i => i.RollNo == id))
            {
                model.Name = item.Name;
                model.RollNo = item.RollNo;
                model.Div=item.Div; }
            return View("start",model);
        }

        [HttpGet]   
        public JsonResult Getz()
        {   
            var StateList = Data.cList;
            ViewBag.list = StateList;
            return Json(new SelectList(StateList, "Cname","Value"), JsonRequestBehavior.AllowGet);
        }

    }
}