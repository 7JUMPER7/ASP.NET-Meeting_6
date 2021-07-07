using Meeting_6.DAL;
using Meeting_6.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_6.Utils
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<News>>().To<NewsRepository>().InSingletonScope();
        }
    }
}