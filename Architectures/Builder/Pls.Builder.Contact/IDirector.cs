using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Builder.Contact
{
    public interface IDirector
    {
        INoteBook BuildNoteBook(IBuilder builder);
    }
}
