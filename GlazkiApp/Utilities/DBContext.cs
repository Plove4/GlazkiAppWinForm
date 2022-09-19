using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlazkiApp.Models;
using GlazkiApp.Utilities;

namespace GlazkiApp.Utilities
{
    internal class DBContext
    {
        private static ModelDB db { get; set; }

        public static ModelDB Context
        {
            get 
            {
                if (db == null)
                    db = new ModelDB();
                return db;
            }  
        }
    }
}
