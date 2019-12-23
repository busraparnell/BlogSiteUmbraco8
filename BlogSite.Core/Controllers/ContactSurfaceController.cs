using System;
using System.Net.Mail;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using BlogSite.Core.Services;
using BlogSite.Core.ViewModels;
using Umbraco.Core.Logging;
using Umbraco.Web;

namespace BlogSite.Core.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        private readonly ISmtpService _smtpService;
        public ContactSurfaceController(ISmtpService smtpService)
        {
            _smtpService = smtpService;
        }

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel() { ContactFormId = CurrentPage.Id};
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
           
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool success = false;

            if (ModelState.IsValid)
            {
                success = _smtpService.SendEmail(model);
            }

            var contactPage = UmbracoContext.Content.GetById(preview:false, model.ContactFormId);

            var successMessage = contactPage.Value<IHtmlString>(alias: "successMessages");
            var errorMessage = contactPage.Value<IHtmlString>(alias: "errorMessage");

            return PartialView("~/Views/Partials/Contact/result.cshtml", success ? successMessage : errorMessage);
        }

    }
}
