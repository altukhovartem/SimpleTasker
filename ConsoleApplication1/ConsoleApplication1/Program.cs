using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context currentDbContext = new Context())
            {
                Task task = new Task()
                {
                    taskID = 1,
                    createdDate = new DateTime(2007, 2, 2),
                    title = "Task1"
                };

                currentDbContext.TaskSet.Add(task);
                currentDbContext.SaveChanges();
            }
        }
    }
}
