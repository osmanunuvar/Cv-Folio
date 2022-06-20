using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager SkillManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = SkillManager.TGetList();
            return View(values);
        }
    }
}
