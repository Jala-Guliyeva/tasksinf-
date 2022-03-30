using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Enums
{
    internal class User:IEntity
    {
        public string UserName { get; set; } 
        public string Email { get; set; }
        public  enum Role { get};
        public User(string username,string email)
        {
         UserName = username;
            Email = email;
          
        }
        public void ShowInfo()
        {
            Console.WriteLine($"UserName:{UserName} - Email:{Email} - Role:");
        }
    }
}
