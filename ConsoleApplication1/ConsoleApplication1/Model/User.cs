using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication1.Model
{
    class User
    {
        public int UserID { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public UserProfile UserProfile { get; set; }
        public List<Task> Tasks { get; set; }
        public User()
        {
            Tasks = new List<Task>();
        }
    }
}
