using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSite.Core.ViewModels;

namespace BlogSite.Core.Services
{
    public interface ISmtpService
    {
        bool SendEmail(ContactViewModel model);
    }
}
