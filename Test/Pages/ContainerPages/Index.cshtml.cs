using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test;

namespace Test.Pages.ContainerPages
{
    public class IndexModel : PageModel
    {
        private readonly Test.RediRndContext _context;

        public IndexModel(Test.RediRndContext context)
        {
            _context = context;
        }

        public IList<Container> Container { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Containers != null)
            {
                Container = await _context.Containers
                .Include(c => c.Parent).ToListAsync();
            }
        }
    }
}
