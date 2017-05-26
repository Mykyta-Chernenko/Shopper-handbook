using System;

namespace Shopper_handbok.Model
{
    [Serializable]
    public class Company
    {
        public string Name { get;  set; }
        public string Address { get;  set; }
        public string Phone { get;  set; }
        public string Specialization { get;  set; } // Специализация
        public string Possetion { get;  set; } // Форма владения 
        public string TimeFrom { get;  set; } // Начало рабочего дня
        public string TimeTo { get; set; } // Конец рабочего дня
        public Company(string n, string a, string p, string s, string pos, string tf, string tt)
        {
            Name = n;
            Address = a;
            Phone = p;
            Specialization = s;
            Possetion = pos;
            if (tf != null && tf.Length == 4)
                TimeFrom = "0" +  tf;
            else
                TimeFrom = tf;
            if (tt != null && tt.Length == 4)
                TimeTo = "0" +  tt;
            else
                TimeTo =  tt;
        }
    }
}

