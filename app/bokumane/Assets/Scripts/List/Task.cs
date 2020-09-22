using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoApp
{
    [Serializable]
    public class Task
    {
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}
