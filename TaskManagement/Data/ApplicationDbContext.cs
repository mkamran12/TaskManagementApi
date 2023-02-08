﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;

namespace TaskManagement.Data
{
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
        }
}
