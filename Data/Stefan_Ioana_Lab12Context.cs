using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stefan_Ioana_Lab12.Models;

namespace Stefan_Ioana_Lab12.Data
{
    public class Stefan_Ioana_Lab12Context : DbContext
    {
        public Stefan_Ioana_Lab12Context (DbContextOptions<Stefan_Ioana_Lab12Context> options)
            : base(options)
        {
        }

        public DbSet<Stefan_Ioana_Lab12.Models.ShopList> ShopList { get; set; }
    }
}
