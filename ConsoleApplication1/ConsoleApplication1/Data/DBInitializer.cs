using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ConsoleApplication1.Model;
using ConsoleApplication1.Data;

namespace ConsoleApplication1.Data
{
    class DBInitializer: DropCreateDatabaseAlways<TaskerContext>
    {
        protected override void Seed(TaskerContext context)
        {
            #region Users

            User user1 = new User
            {
                Login = "User1",
                Password = "123",
                Profile = new UserProfile
                {
                    FirstName = "Robert",
                    LastName = "De Niro",
                    Age = 73
                }
            };

            User user2 = new User
            {
                Login = "User2",
                Password = "321",
                Profile = new UserProfile
                {
                    FirstName = "Al",
                    LastName = "Pacino",
                    Age = 77
                }
            };

            context.UserSet.AddRange(new List<User> { user1, user2 });
            context.SaveChanges();

            #endregion

            #region Tasks

            Task task1 = new Task
            {
                Title = "Clean the house",
                DeadLine = new DateTime(2002, 2, 2),
                Commentary = "It's really annoying when the house is a real mess, Plase, do something about this",
                User = user1
            };

            Task task2 = new Task
            {
                Title = "Make dinner",
                DeadLine = new DateTime(2004, 10, 18),
                Commentary = "make something tasty at home",
                User = user2
            };

            Task task3 = new Task
            {
                Title = "Kill the bad guy",
                DeadLine = new DateTime(2004, 10, 18),
                Commentary = "It turns out that there is the game with the same name",
                User = user1
            };

            Task task4 = new Task
            {
                Title = "Buy Playsttation 4 PRO",
                DeadLine = new DateTime(2004, 10, 18),
                Commentary = "It is pretty powerful system!",
                User = user2
            };

            context.TaskSet.AddRange(new List<Task> { task1, task2, task3, task4 });
            context.SaveChanges();


            #endregion
        }
    }
}
