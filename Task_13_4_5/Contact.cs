using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_4_5
{
    public class Contact // модель класса
    {
        public Contact(long phoneNumber, String email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public long PhoneNumber { get; set; }
        public String Email { get; }
    }
}
