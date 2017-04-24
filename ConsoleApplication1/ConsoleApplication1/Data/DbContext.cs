using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ConsoleApplication1.Model;

namespace ConsoleApplication1.Data
{
    class currentContext: DbContext
    {
        public currentContext()
            :base("currentConnection")
        {

        }

        public DbSet<Task> TaskSet { get; set; }
        public DbSet<User> UserSet { get; set; }
    }
}
