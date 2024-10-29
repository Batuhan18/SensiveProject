﻿using Microsoft.EntityFrameworkCore;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccessLayer.Context
{
    public class SensiveContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TMJ1T9T; initial Catalog=SensiveBlogDb;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Newsletter> Newsletters{ get; set; }
        public DbSet<TagCloud> TagClouds{ get; set; }
    }
}
