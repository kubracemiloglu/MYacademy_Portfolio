using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace MYacademy_Portfolio.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
