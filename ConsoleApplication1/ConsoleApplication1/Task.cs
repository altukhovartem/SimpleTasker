using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Task
    {
        public int taskID { get; set; }
        public string title { get; set; }
        public DateTime createdDate { get; set; }
    }
}
