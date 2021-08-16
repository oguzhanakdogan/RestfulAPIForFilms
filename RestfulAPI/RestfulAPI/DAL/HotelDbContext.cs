using Microsoft.EntityFrameworkCore;
using RestfulAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulAPI.DAL
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=ELD-PC-23\SQLEXPRESS; Database=HotelDB; uid=sa; pwd=Password123");
        }

        public DbSet<Hotel> Hotels {get; set;}

    }
}
