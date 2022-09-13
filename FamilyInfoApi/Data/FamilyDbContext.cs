using FamilyInfoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyInfoApi.Data
{
    public class FamilyDbContext:DbContext
    {
        public FamilyDbContext(DbContextOptions<FamilyDbContext> options):base(options)
        {

        }

        public DbSet<Info> infos { get; set; }
    }
}
