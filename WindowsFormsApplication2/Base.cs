using System;
using System.Collections.Generic;
namespace WindowsFormsApplication2
{
    public class Base : List<Company>
    {
        public Base() : base() { }
        public int IndexOf(string n)
        {
            for (int x = 0; x < this.Count; x++)
            {
                if (this[x].Name == n)
                    return x;
            }
            return -1;
        }
    }
    
}
