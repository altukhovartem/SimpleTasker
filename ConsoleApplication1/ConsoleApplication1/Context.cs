using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ConsoleApplication1.Model;

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
