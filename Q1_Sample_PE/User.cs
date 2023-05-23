using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q1_Sample_PE
{
    internal class User
    {
        private string username;
        private string email;
        private int roleid;

        public string Username 
        {
            get { return username; }  
            set { username = value; }   
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int RoleID
        {
            get { return roleid; }
            set { roleid = value; }
        }

        public User()
        {
            Username = "trungnhhe130146";
            Email = "trungnhhe130146@fpt.edu.vn";
            RoleID = 1;
        }

        public User(string username, string email, int roleID)
        {
            Username = username;
            Email = email;
            RoleID = roleID;
        }

        public override string? ToString()
        {
            return $"Student's Info: \nUsername: {Username}, Email: {Email}, RoleID:{RoleID}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            User other = (User)obj;

            return Username.Equals(other.Username);
        }
    }
}
