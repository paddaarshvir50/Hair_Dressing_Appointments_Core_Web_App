﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hair_Dressing_Appointments_Core_Web_App.BusinessLayer;
using Hair_Dressing_Appointments_Core_Web_App.Models;

namespace Hair_Dressing_Appointments_Core_Web_App.Pages.HairDressingOptions
{
    public class DetailsModel : PageModel
    {
        private readonly Hair_Dressing_Appointments_Core_Web_App.Models.Hair_Dressing_Appointments_DataContext _context;

        public DetailsModel(Hair_Dressing_Appointments_Core_Web_App.Models.Hair_Dressing_Appointments_DataContext context)
        {
            _context = context;
        }

        public HairDressingOption HairDressingOption { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HairDressingOption = await _context.HairDressingOption.FirstOrDefaultAsync(m => m.Id == id);

            if (HairDressingOption == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
