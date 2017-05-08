using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApplication2
{
    public class Company
    {
        public String Name { get;  set; }
        public String Address { get;  set; }
        public String Phone { get;  set; }
        public String Specialization { get;  set; }
        public String Possetion { get;  set; }
        public String TimeFrom { get;  set; }
        public String TimeTo { get; set; }
        public Company(string n, string a, string p, string s, string pos, string tf, string tt)
        {
            Name = n;
            Address = a;
            Phone = p;
            Specialization = s;
            Possetion = pos;
            TimeFrom = tf;
            TimeTo = tt;
        }
    }
}

