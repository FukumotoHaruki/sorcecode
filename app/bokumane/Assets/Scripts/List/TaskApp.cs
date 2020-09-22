using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace TodoApp
{
    public class TaskApp
    {
        public List<Task> Tasks { get; private set; }

        public TaskApp()
        {
            this.Tasks = new List<Task>();
        }

        public void Save()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path = Path.Combine(path, "data.dat");
            using (var s = new FileStream(path, FileMode.Create))
            {
                var f = new BinaryFormatter();
                f.Serialize(s, this.Tasks);
                s.Flush();
                s.Close();
            }
        }

        public void Load()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path = Path.Combine(path, "data.dat");
            if (!File.Exists(path))
            {
                return;
            }

            this.Tasks.Clear();
            using (var s = new FileStream(path, FileMode.Open))
            {
                var f = new BinaryFormatter();
                var result = (List<Task>)f.Deserialize(s);
                this.Tasks.AddRange(result);
            }
        }
    }
}
