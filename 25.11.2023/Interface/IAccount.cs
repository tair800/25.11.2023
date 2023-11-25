using System.Text.RegularExpressions;

namespace _25._11._2023.Interface
{
    public   interface IAccount
    {
        public bool PasswordChecker(  string password)
        {

            if ( password.Length < 8)
                return false;
            if(!Regex.IsMatch(password, "[A-Z]"))
                return false;
            if(!Regex.IsMatch(password,"[a-z]"))
                return false;
            if(!Regex.IsMatch(password,"[1-9]"))
                return false;

            return true;
           
            
        }
        
        public void ShowInfo()
        {
            
        }

        
    }

}
