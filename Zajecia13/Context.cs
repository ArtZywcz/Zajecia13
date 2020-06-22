using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia13
{
    public class Context : DbContext
    {
        public DbSet<Model> Models { get; set; }
    }
}
