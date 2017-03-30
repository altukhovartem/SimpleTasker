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
                Console.WriteLine("*** Tasker 3000 ***");
                Console.WriteLine("Available command for now ... Press nessecety button");
                while (true)
                {
                    Console.WriteLine("1 - {0}\n2 - {1}\n3 - {2}", 
                        "Add new task", 
                        "Delete existing task",
                        "Show all available task");

                    int currentCommand = Convert.ToInt32(Console.ReadLine());
                    switch (currentCommand)
                    {
                        case 1: Console.WriteLine("AddTask"); ; break;
                        case 2: Console.WriteLine("DeleteTask"); ; break;
                        case 3: Console.WriteLine("ShowTasks"); break;
                        default:
                            break;
                    
                }

                //Task task = new Task()
                //{
                //    taskID = 1,
                //    createdDate = new DateTime(2007, 2, 2),
                //    title = "Task1"
                //};

                //currentDbContext.TaskSet.Add(task);
                //currentDbContext.SaveChanges();
            }
        }
    }
}
