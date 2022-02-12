using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DreamcatcherMembers.Models;

    public class DreamcatcherMembersContext : DbContext
    {
        public DreamcatcherMembersContext (DbContextOptions<DreamcatcherMembersContext> options)
            : base(options)
        {
        }

        public DbSet<DreamcatcherMembers.Models.Member> Member { get; set; }
    }
