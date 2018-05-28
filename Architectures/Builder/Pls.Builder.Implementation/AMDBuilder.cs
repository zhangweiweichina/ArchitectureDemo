using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Builder.Contact;

namespace Pls.Builder.Implementation
{
    public class AMDBuilder : IAMDBuilder
    {
        private INoteBook _notebook = new NoteBook();
        public void BuildCPU()
        {
            _notebook.CPU = "AMD CPU";
        }

        public void BuildMainboard()
        {
            _notebook.Mainboard = "KV800";
        }

        public void BuildMoniter()
        {
            _notebook.Moniter = "BOE Moniter";
        }

        public void BuildDisk()
        {
            _notebook.Disk = "Samsung Disk";
        }

        public void BuildMemory()
        {
            _notebook.Memory = "A-Data";
        }

        public INoteBook GetNoteBook()
        {
            return _notebook;
        }
    }
}
