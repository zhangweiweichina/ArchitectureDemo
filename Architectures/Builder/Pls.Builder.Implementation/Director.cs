using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Builder.Contact;

namespace Pls.Builder.Implementation
{
    public class Director : IDirector
    {
        public INoteBook BuildNoteBook(IBuilder builder)
        {
            builder.BuildCPU();
            builder.BuildDisk();
            builder.BuildMainboard();
            builder.BuildMemory();
            builder.BuildMoniter();
            return builder.GetNoteBook();
        }

    }
}
