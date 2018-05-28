using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Builder.Contact;

namespace Pls.Builder.Implementation
{
    public class IntelBuilder : IIntelBuilder
    {
        private INoteBook _noteBook = new NoteBook();
        public void BuildCPU()
        {
            _noteBook.CPU = "Intel Core I7";
        }

        public void BuildMainboard()
        {
            _noteBook.Mainboard = "Intel I85 MainBorad";
        }

        public void BuildMoniter()
        {
            _noteBook.Moniter = "Samsung Moniter";
        }

        public void BuildDisk()
        {
            _noteBook.Disk = "Seagate Disk";
        }

        public void BuildMemory()
        {
            _noteBook.Memory = "Kingston Memroy";
        }

        public INoteBook GetNoteBook()
        {
            return _noteBook;
        }
    }
}
