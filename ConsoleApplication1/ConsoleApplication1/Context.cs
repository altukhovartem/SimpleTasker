﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication1
{
    class Context: DbContext
    {
        public Context()
            :base("currentCnnection")
        {

        }
        
        public DbSet<Task> TaskSet { get; set; }
    }
}
