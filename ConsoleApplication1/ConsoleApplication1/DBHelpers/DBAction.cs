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
            Console.Clear();
            Console.WriteLine("===== Add New ask =====");
            Console.WriteLine("Title:");
            string newTaskTitle = Console.ReadLine();
            Console.WriteLine("Deadline:");
            DateTime newTaskDeadline = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Commentary:");
            string newTaskCommentary = Console.ReadLine();
            Console.WriteLine("========================");

            using (Context context = new Context())
            {
                Task task = new Task()
                {
                    Title = newTaskTitle,
                    DeadLine = newTaskDeadline,
                    Commentary = newTaskCommentary,
                    CreatedDate = DateTime.Now
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
