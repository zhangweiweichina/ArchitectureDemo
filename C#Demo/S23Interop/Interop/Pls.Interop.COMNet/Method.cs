using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Interop.COMNet
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IMethod
    {
        double Add(double a, double b);
    }

    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWelcome
    {
        string Greeting(string strName);
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("2E3C7BAD-1051-4622-9C4C-215182C6BF58")]
    [ProgId("Pls.Interop.COMNet.Method")]
    public class Method : IMethod, IWelcome
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Greeting(string strName)
        {
            return "Welcome " + strName;
        }
    }
}
