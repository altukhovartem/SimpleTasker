using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DBHelpers
{
    static class DBAction
    {
        public static void AddTask()
        {
            using (Context context = new Context())
            {
                Task task = new Task()
                {
                    createdDate = new DateTime(2007, 2, 2),
                    title = "Second Task"
                };
                try
                {
                    context.TaskSet.Add(task);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                context.SaveChanges();
            }
        }

        public static void DeleteTask()
        {

        }

        public static void ShowAllTask()
        {

        }
    }
}
