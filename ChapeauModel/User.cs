using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
   public class User
    {

        public int User_ID;//Database gaat geef me de new id daarom heb ik het niet in e constracter gedaan
        public string FirstName;
        public string LastName;
        public string Email;
        public int Passcode;
        string Hash;
        public string Type;

        public User()
        {



        }
        public User(string FirstName, string LastName, string Email, string Type, int Passcode)
        {
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Passcode = Passcode;
            this.Type = Type;
        }
    }
}
    