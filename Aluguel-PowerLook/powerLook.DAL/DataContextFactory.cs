using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerLook.DAL
{
    public class DataContextFactory
    {
        private static powerLookDataContext dataContext;

        public static powerLookDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new powerLookDataContext();

                return dataContext;
            }
        }
    }
}
