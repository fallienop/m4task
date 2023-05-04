using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4task
{
    public interface IAccount
    {
        public bool PasswordChecker(string password);


        public string ShowInfo();
    }

    public class User : IAccount
    {
        private static byte cnt=0;
        public byte Id { get; }  
        public string Fullname    ;
        public string Email       ;
        public string Password;
        public User(string fullname,string email,string password)
        {
            if (PasswordChecker(password))
            {
                this.Password = password;
            }
            else
            {
                throw new ArgumentException("Invalid password format.");
            }
            this.Id = ++cnt;
            this.Fullname = fullname;   
            this.Email = email;
           
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length < 8) { return false; }
            if (!password.Any(char.IsUpper)){ return false; }
           else if(!password.Any(char.IsLower)){ return false; }
            else  if(!password.Any(char.IsNumber)){ return false; }
            else { return true; }
        }

        public string ShowInfo()
        {
            return this.Id+" "+this.Fullname+" "+this.Email;
        }
    }
}
