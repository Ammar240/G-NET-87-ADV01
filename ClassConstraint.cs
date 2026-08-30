using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Advanced_S01_Generics;

internal class ClassConstraint<T> where T : class
{
    // T is place holder for class types (rference types)  ( string ,array ...)
    // value types are not allowed
    // can be null
}
