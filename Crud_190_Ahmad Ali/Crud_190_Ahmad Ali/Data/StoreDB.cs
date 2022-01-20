using CRUD_190_Ahmad_Ali.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_190_Ahmad_Ali.Data
{
    public class StoreDB : DbContext
    {
        public StoreDB(DbContextOptions<StoreDB> options) : base(options)
        {

        }
        public DbSet<OrderClass> Orders { get; set; }
    }
}
