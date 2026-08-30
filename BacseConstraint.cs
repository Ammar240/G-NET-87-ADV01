using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Advanced_S01_Generics;

internal class Base
{
}

internal class Child : Base
{
}

internal class GenClass<T> where T : Base
{
   // T could be of type base or any of its derived types 
   // base or child
}



