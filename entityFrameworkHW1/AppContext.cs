
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkHW1
{
      public class AppContext : DbContext
        {
            public DbSet<Person> Persons => Set<Person>();
            public DbSet<Product> Products => Set<Product>();
            public AppContext()

            { Database.EnsureCreated();

                //Database.EnsureDeleted();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-0LP9EBH; Database=ProductsAndPersons; TrustServerCertificate=true; Integrated Security = true;");

            }
        }


    }

    

