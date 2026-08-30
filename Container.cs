using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Advanced_S01_Generics;

internal class Container<T>
{
    private T tItem;
    public void Add(T item)
    {
        this.tItem = item;
    }
    public T Get() { return this.tItem; }
}
