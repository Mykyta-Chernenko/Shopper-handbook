namespace Shopper_handbok
{
    public class Company
    {
        public string Name { get;  set; }
        public string Address { get;  set; }
        public string Phone { get;  set; }
        public string Specialization { get;  set; }
        public string Possetion { get;  set; }
        public string TimeFrom { get;  set; }
        public string TimeTo { get; set; }
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

