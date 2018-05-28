using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Builder.Contact
{
    public interface IBuilder
    {
        void BuildCPU();

        void BuildMainboard();

        void BuildMoniter();

        void BuildDisk();

        void BuildMemory();

        INoteBook GetNoteBook();
    }

    public interface IIntelBuilder : IBuilder
    {
    }

    public interface IAMDBuilder : IBuilder
    {
    }
}
