using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media;

namespace WpfApp1
{
    public class AddProfile
    {
        string name;
        int age;
        string type;
        System.Windows.Media.ImageSource filepath;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Type { get => type; set => type = value; }
        public ImageSource Filepath { get => filepath; set => filepath = value; }

        public AddProfile()
        {
        }
        public AddProfile(string n, int a, string t, System.Windows.Media.ImageSource fp)
        {
            name = n;
            age = a;
            type = t;
            filepath = fp;

        }

        public void storeProfile()
        {
            using (StreamWriter sw = File.AppendText("ProfileLog.txt"))
            {
                sw.WriteLine(name + "/r" + age + "/r" + type + "/r" + filepath);
            }
        }
    }
}
