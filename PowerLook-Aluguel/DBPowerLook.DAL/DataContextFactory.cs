using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPowerLook.DAL
{
   public class DataContextFactory
    {
        private static PowerLookDataContext dataContext;

        public static PowerLookDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new PowerLookDataContext();

                return dataContext;
            }
        }
    }
}
