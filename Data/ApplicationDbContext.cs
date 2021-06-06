using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MS587FinalProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MS587FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClassSession> ClassSessions { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
