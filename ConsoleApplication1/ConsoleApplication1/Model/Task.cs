﻿using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ConsoleApplication1.Model
{
    class Task
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeadLine { get; set; }
        public string Commentary { get; set; }

        public int? UserID { get; set; }
        public User User { get; set; }

        public Task()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
