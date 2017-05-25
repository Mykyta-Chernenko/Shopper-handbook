using System.Collections.Generic;

namespace Shopper_handbok.Model
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
