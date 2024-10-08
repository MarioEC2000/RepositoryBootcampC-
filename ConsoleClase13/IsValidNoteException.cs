using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClase13
{
    public class IsValidNoteException : Exception
    {
        public IsValidNoteException()
        {
            
        }
        public IsValidNoteException(string message) : base (message)
        {
            
        }
    }
}
