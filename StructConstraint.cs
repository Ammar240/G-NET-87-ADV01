using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Advanced_S01_Generics;

internal class StructConstraint<T> where T : struct
{
    // T is place holder for struct(value) types only ( int, double..)
    // class types are not allowed
}
