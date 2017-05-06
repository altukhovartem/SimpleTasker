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
            Console.WriteLine("User: ");
            string newUserID = Console.ReadLine();
            Console.WriteLine("========================");

            using (TaskerContext context = new TaskerContext())
            {
                User userToAssign = context.UserSet.FirstOrDefault(x => x.Login == newUserID);

                Task currenttask = new Task()
                {
                    Title = newTaskTitle,
                    DeadLine = newTaskDeadline,
                    Commentary = newTaskCommentary,
                    User = userToAssign
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
            using (TaskerContext context = new TaskerContext())
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
            using (TaskerContext context = new TaskerContext())
            {
                List<Task> allTask = context.TaskSet.Include("User").ToList();

                foreach (Task item in allTask)
                {
                    Console.WriteLine("ID: {0}\nTitle: {1}\nDeadline:{2}\nCreatedDate: {3}\nCommentary: {4}\nUser: {5}",
                        item.TaskID, item.Title, item.DeadLine, item.CreatedDate, item.Commentary, item.User.Login);
                    Console.WriteLine();
                }
                Console.WriteLine("Press any key");
            }
            Console.ReadKey();
        }

        public static void AddUser()
        {
            Console.Clear();
            Console.WriteLine("===== Add New Person =====");
            Console.WriteLine("Login: ");
            string newLogin = Console.ReadLine();
            Console.WriteLine("Password: ");
            string newPassword = Console.ReadLine();

            Console.WriteLine("First Name: ");
            string newFirstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string newLastName = Console.ReadLine();
            Console.WriteLine("Age: ");
            int newAge = Convert.ToInt32(Console.ReadLine());

            using (TaskerContext context = new TaskerContext())
            {
                User currentUser = new User()
                {
                    Login = newLogin,
                    Password = newPassword,    
                };

                UserProfile currentUserProfile = new UserProfile
                {
                    FirstName = newFirstName,
                    LastName = newLastName,
                    Age = newAge
                };

                try
                {
                    currentUser.Profile = currentUserProfile;
                    context.UserSet.Add(currentUser);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                context.SaveChanges();
            }
        }

        public static void ShowAllUsers()
        {
            Console.Clear();
            Console.WriteLine("===== All Available User: =====\n");
            using (TaskerContext context = new TaskerContext())
            {
                List<User> allUsers = context.UserSet.Include("Profile").ToList();

                foreach (User item in allUsers)
                {
                    Console.WriteLine("ID: {0}\nLogin: {1}\nLast Name: {2}\nFirst Name: {3}\nAge: {4}",
                        item.UserID, item.Login, item.Profile.LastName, item.Profile.FirstName, item.Profile.Age);
                    Console.WriteLine();
                }
                Console.WriteLine("Press any key");
            }
            Console.ReadKey();
        }

    }
}
