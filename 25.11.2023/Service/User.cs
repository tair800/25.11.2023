using _25._11._2023.Interface;


namespace _25._11._2023.Service
{
    public class User : IAccount
    {
        public int Id { get; } = 1;
        public string Fullname;
        public string Email;
        public string Password;

        public User(string fullName, string email, string password)
        {
            Id++;
            Fullname = fullName;
            Email = email; 
            Password= password;
        }








    }
}
