using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DreamcatcherMembers.Models;

namespace Dreamcatcher.Pages_Members
{
    public class IndexModel : PageModel
    {
        private readonly DreamcatcherMembersContext _context;

        public IndexModel(DreamcatcherMembersContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}
