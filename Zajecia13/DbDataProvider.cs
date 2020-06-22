using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia13
{
    public class DbDataProvider : IDataProvider
    {
        public DbDataProvider(Context context)
        {
            Context = context;
        }

        public Context Context { get; private set; }

        public int GetData()
        {
            return 1;
            //return Context.Models.FirstOrDefault().Amount;
        }
    }
}
