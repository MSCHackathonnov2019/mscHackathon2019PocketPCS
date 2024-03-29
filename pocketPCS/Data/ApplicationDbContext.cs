﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pcsHackathon2019.Models;
using pocketPCS.Models;

namespace pocketPCS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> PocketUsersTable { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<AdditionalCost> BoardTable { get; set; }
        public DbSet<Thread> ThreadTable { get; set; }
        public DbSet<Comment> CommentTable { get; set; }


    }
}
