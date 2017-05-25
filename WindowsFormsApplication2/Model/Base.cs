using System.Collections.Generic;
using System.Linq;

namespace Shopper_handbok
{
    public class Base : List<Company>
    {
        public int IndexOf(string n)
        {
            for (int x = 0; x < Count; x++)
            {
                if (this[x].Name == n)
                    return x;
            }
            return -1;
            
        }
    }
    
}
