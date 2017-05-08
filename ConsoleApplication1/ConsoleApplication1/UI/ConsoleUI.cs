using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.DBHelpers;

namespace ConsoleApplication1.UI
{
    static class ConsoleUI
    {
        public static void MainConsoleUI()
        {
            bool loop = true;
            Console.WriteLine("*** Tasker 3000 ***");
            Console.WriteLine("Available command for now ... Press nessecety button");
            while (loop)
            {
                Console.WriteLine("1 - {0}\n2 - {1}\n3 - {2}\n4 - {3}\n5 - {4}",
                    "Add new task",
                    "Delete existing task",
                    "Show all available task",
                    "Add new User",
                    "Show all available users");

                int currentCommand = Convert.ToInt32(Console.ReadLine());
                switch (currentCommand)
                {
                    case 1: DBAction.AddTask(); break;
                    case 2: DBAction.DeleteTask(); break;
                    case 3: DBAction.ShowAllTask(); break;
                    case 4: DBAction.AddUser(); break;
                    case 5: DBAction.ShowAllUsers(); break;
                    case 0: loop = false; break;
                    default:
                        break;
                }
            }
        }

    }
}
