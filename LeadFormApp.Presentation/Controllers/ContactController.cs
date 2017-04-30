using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeadFormApp.Domain.Entities;
using LeadFormApp.Services.ContactServices;
using System.Text.RegularExpressions;

namespace LeadFormApp.Presentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        // GET: Contact/Manage
        public ActionResult Manage()
        {
            return View(_contactService.GetContacts());
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View(_contactService.Find(id));
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(Contact model)
        {
            bool success = false;

            try
            {
                //Server side validation
                if (!string.IsNullOrEmpty(model.Email))
                {
                    string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                    Regex re = new Regex(emailRegex);
                    if (!re.IsMatch(model.Email))
                    {
                        ModelState.AddModelError("Email", "Email is not valid");
                    }
                }
                else
                {
                    ModelState.AddModelError("Email", "Email is required");
                }

                if (ModelState.IsValid)
                {
                    _contactService.Insert(model);
                    success = true;
                }
                else
                {
                    return View(model);
                }
           }
            catch
            {
                success = false;
            }

            return PartialView("_SubmitMessage", success);
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_contactService.Find(id));
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Manage");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            _contactService.Delete(id);
            return RedirectToAction("Manage");
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Manage");
            }
            catch
            {
                return View();
            }
        }
    }
}