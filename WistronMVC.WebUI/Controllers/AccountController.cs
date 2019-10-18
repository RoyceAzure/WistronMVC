using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WistronMVC.DataAccess.InMemory;
using WIstronMVC.Core.Models;

namespace WistronMVC.WebUI.Controllers
{
    public class AccountController : Controller
    {

        // GET: Account
        MemoryReopstory<User> context ;

        public AccountController()
        {
            context = new MemoryReopstory<User>();
        }
        public ActionResult Index()
        {
            List<User> Users = context.Collection().ToList();
            return View(Users);
        }
        public ActionResult Create()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if(!ModelState.IsValid)
            {
                return View(user);
            }
            context.Insert(user);
            context.Commit();
            return RedirectToAction("Index");
        }
       public ActionResult Edit(string Id)
        {
            User userToEdit;
            try
            {
                userToEdit = context.Find(Id);
                return View(userToEdit);
            }
            catch
            {
                return HttpNotFound();
            }
        }
        [HttpPost]
        public ActionResult Edit(User user,string Id)
        {
            User userToEdit = context.Find(Id);
            if (userToEdit == null)
                return HttpNotFound();
            else
            {
                if (!ModelState.IsValid)
                    return View(user);
                userToEdit.Email = user.Email;
                userToEdit.EnName = user.EnName;
                userToEdit.MobelPhone = user.MobelPhone;
                userToEdit.Name = user.Name;
                userToEdit.Password = user.Password;
                userToEdit.TelPhone = user.TelPhone;
                userToEdit.WorkNumber = user.WorkNumber;
                userToEdit.Dep = user.Dep;
                context.Commit();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Delete(string Id)
        {
            User userToDelete = context.Find(Id);
            if (userToDelete == null)
                return HttpNotFound();
            return View(userToDelete);
        }
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult ConfirmDelete(string Id)
        {
            User userToDelete = context.Find(Id);

            if (userToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");
            }
        }
    }
}