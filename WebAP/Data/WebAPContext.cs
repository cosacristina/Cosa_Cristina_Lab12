using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAP.Models;

namespace WebAP.Data
{
    public class WebAPContext : DbContext
    {
        public WebAPContext (DbContextOptions<WebAPContext> options)
            : base(options)
        {
        }

        public DbSet<WebAP.Models.ShopList> ShopList { get; set; }
    }
}
