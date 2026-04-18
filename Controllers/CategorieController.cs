using G1WEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace G1WEB.Controllers
{
    public class CategorieController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            using(var context = new EF.AppContext())
            {
                var categories = context.Categories.ToList();
                return View(categories);
            }


           // return View();
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorie c)
        {
            
            if (ModelState.IsValid)
            {
                using (var context = new EF.AppContext())
                {

                    context.Categories.Add(c);

                     context.SaveChanges();

                    

                    return RedirectToAction(nameof(Index));
                }
              
            }
            else
            {
                return View(c); 
            }
               
            
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                using (var context = new EF.AppContext())
                {
                    var categorie = context.Categories.Find(id);
                    if (categorie != null)
                    {
                        return View(categorie);
                    }
                    else
                    {
                        return NotFound();
                    }

                }
              
            }
            catch
            {
                return View();
            }

           
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Categorie categorie )
        {
            try
            {
                using (var context = new EF.AppContext())
                {
                    var c = context.Categories.Find(id);
                    if (c != null)
                    {
                       
                       c.Nom = categorie.Nom;
                       c.Description = categorie.Description;
                       c.Image = categorie.Image;
                       
                        context.Entry(c).State = EntityState.Modified;
                        context.Categories.Update(c);
                        context.SaveChanges();

                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return NotFound();
                    }

                }

            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                using (var context = new EF.AppContext())
                {
                    var categorie = context.Categories.Find(id);
                    if (categorie != null)
                    {
                        context.Categories.Remove(categorie);
                        context.SaveChanges();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return NotFound()  ;
            }
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                    using (var context = new EF.AppContext())
                    {
                        var categorie = context.Categories.Find(id);
                        if (categorie != null)
                        {
                            context.Categories.Remove(categorie);
                            context.SaveChanges();
                        }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
