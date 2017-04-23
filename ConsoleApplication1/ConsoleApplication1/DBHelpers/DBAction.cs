using ConsoleApplication1.Model;
using ConsoleApplication1.Data;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApplication1.DBHelpers
{
    static class DBAction
    {
        public static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("===== Add New ask =====");
            Console.WriteLine("Title: ");
            string newTaskTitle = Console.ReadLine();
            Console.WriteLine("Deadline: ");
            DateTime newTaskDeadline = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Commentary: ");
            string newTaskCommentary = Console.ReadLine();
            Console.WriteLine("========================");

            using (currentContext context = new currentContext())
            {
                Task currenttask = new Task()
                {
                    Title = newTaskTitle,
                    DeadLine = newTaskDeadline,
                    Commentary = newTaskCommentary,
                    CreatedDate = DateTime.Now
                };
                try
                {
                    context.TaskSet.Add(currenttask);
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
            Console.WriteLine("Enter the name of the task: ");
            int idOfTaskToDelete = Convert.ToInt32(Console.ReadLine());
            using (currentContext context = new currentContext())
            {
                Task taskToDelete = context.TaskSet.FirstOrDefault(n => n.TaskID == idOfTaskToDelete);
                if(taskToDelete != null)
                {
                    context.TaskSet.Remove(taskToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Task is successfully deleted\n");
                }
                else
                {
                    Console.WriteLine("Error: There is no Task with ID {0}", idOfTaskToDelete);
                }
                Console.WriteLine("Press any key");
                Console.ReadKey();
            }
        }

        public static void ShowAllTask()
        {
            Console.Clear();
            Console.WriteLine("===== All Current Tasks: =====\n");
            using (currentContext context = new currentContext())
            {
                List<Task> allTask = context.TaskSet.ToList();

                foreach (Task item in allTask)
                {
                    Console.WriteLine("ID: {0}\nTitle: {1}\nDeadline:{2}\nCreatedDate: {3}\nCommentary: {4}",
                        item.TaskID, item.Title, item.DeadLine, item.CreatedDate, item.Commentary);
                    Console.WriteLine();
                }
                Console.WriteLine("Press any key");
            }
            Console.ReadKey();
        }
    }
}
