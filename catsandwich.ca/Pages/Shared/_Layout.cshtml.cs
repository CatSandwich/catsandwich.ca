﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace catsandwich.ca.Pages.Shared
{
    public class _LayoutModel : PageModel
    {

        public void OnGet()
        {

        }

        public void Test()
        {
            var thing = HttpContext.Request.Path;
        }
    }
}