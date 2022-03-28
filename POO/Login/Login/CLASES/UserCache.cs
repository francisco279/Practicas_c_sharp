using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.CLASES
{
    public static class UserCache
    {
        private static int idUser;
        private static string loginName;
        private static string password;
        private static string firstName;
        private static string lastName;
        private static string position;

        public static int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }


        public static string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        public static string Password
        {
            get { return password; }
            set { password = value; }
        }



        public static string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public static string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }



        public static string Position
        {
            get { return position; }
            set { position = value; }
        }

        private static string email;

        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

       

    }
}
