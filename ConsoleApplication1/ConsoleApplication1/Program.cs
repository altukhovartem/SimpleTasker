using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.DBHelpers;
using System.Data.Entity;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());

            bool loop = true;
            Console.WriteLine("*** Tasker 3000 ***");
            Console.WriteLine("Available command for now ... Press nessecety button");
            while (loop)
            {
                Console.WriteLine("1 - {0}\n2 - {1}\n3 - {2}",
                    "Add new task",
                    "Delete existing task",
                    "Show all available task");

                int currentCommand = Convert.ToInt32(Console.ReadLine());
                switch (currentCommand)
                {
                    case 1: DBAction.AddTask(); break;
                    case 2: DBAction.DeleteTask(); break;
                    case 3: DBAction.ShowAllTask(); break;
                    case 0: loop = false; break;
                    default:
                        break;
                }
            }
        }
    }
}



