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

internal class GenClass<T> where T : Base , IRepository<T>, new()
{
   // T could be of type base or any of its derived types 
   // base or child

   // To apply multiple constarints 
   // 1. class or struct or base class  (only one of the three)
   // 2. interface constraints (any number of intferfaces)
   // 3. new() constraint
}



