using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Pls.Builder.Contact;

namespace Pls.Builder.Implementation
{
    public class NoteBook : INoteBook
    {
        public string CPU { get; set; }

        public string Mainboard { get; set; }

        public string Moniter { get; set; }

        public string Disk { get; set; }

        public string Memory { get; set; }

        public void Display()
        {
            Console.WriteLine(string.Format("CPU:{0}",CPU));
            Console.WriteLine(string.Format("Mainboard:{0}", Mainboard));
            Console.WriteLine(string.Format("Moniter:{0}", Moniter));
            Console.WriteLine(string.Format("Disk:{0}", Disk));
            Console.WriteLine(string.Format("Memory:{0}", Memory));
        }
    }
}
