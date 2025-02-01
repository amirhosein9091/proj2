using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Businessentity;

namespace DAL
{
    public class Db : DbContext
    {
        public Db() : base("name=proj3") { }
        public DbSet<person> persons { get; set; }
        public DbSet<human> humen { get; set; }
        public DbSet<kala > kalas { get; set; }
        public DbSet<poshak> poshak { get; set; }
        public DbSet<sport> sport { get; set; }
    }
}
