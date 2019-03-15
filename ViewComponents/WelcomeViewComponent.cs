using core_bili.Myserver;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_bili.ViewComponents
{
    public class WelcomeViewComponent:ViewComponent
    {
        private readonly IMyserver<student> myserver;

        public WelcomeViewComponent(IMyserver<student> myserver ) {
            this.myserver = myserver;
        }

        public IViewComponentResult Invoke()
        {
            var ss= myserver.GetAll().Count().ToString();
            return View("Defalut", ss);
        }
    }
}
