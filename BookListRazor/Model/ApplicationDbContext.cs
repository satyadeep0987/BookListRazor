using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            //this will be a empty constructor but parameters are needed for dependency injection
        }

        //then we add model 

        public DbSet<Book> Book { get; set; }

    }
}
