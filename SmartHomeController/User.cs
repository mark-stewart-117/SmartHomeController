using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        //private fields
        private int userID;
        private string userName;
        private string contactInfo;
        private string password;
        private bool isLoggedin;

        //public properties
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsLoggedin
        {
            get { return isLoggedin; }
            set { isLoggedin = value; }
        }

        //methods for classes
        public bool Login(string userName, string password)
        {
            if (UserName == userName && Password == password)
            {
                isLoggedin = true;
                Console.WriteLine("Login successful.");
            }
            else
            {
                isLoggedin = false;
                Console.WriteLine("Login failed. Incorrect username or password.");
            }
            return isLoggedin;
        }

    }
}
