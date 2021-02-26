using System;

namespace _2_Custom_Exception
{
    class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Login("sadikturan", "123456");
            }
            catch (LoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Login(string name, string password)
        {
            if (name.Contains(" "))
                throw new LoginException("username boşluk içemerez!");
            if (password.Length < 8)
                throw new LoginException("Parola min. 8 karakter olmalıdır!");

        }
    }
}
