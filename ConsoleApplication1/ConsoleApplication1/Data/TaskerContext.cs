using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ConsoleApplication1.Model;

namespace ConsoleApplication1.Data
{
    class TaskerContext : DbContext
    {
        static TaskerContext()
        {
            Database.SetInitializer(new DBInitializer());
        }

        public TaskerContext()
            :base("TaskerDB")
        {

        }

        public DbSet<Task> TaskSet { get; set; }
        public DbSet<User> UserSet { get; set; }
    }
}
