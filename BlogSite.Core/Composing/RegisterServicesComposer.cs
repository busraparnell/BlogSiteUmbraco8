using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSite.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace BlogSite.Core.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISmtpService, SmtpService>(Lifetime.Singleton);

        }
    }
}
