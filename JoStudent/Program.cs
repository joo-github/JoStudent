using UserAccountBL;

namespace UserAccountUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter UserID: ");
            string userID = Console.ReadLine();

            Console.Write("Enter Username: ");
            string userName = Console.ReadLine();


            Console.Write("Enter Password: ");
            string password = Console.ReadLine();


            UserService userService = new UserService();
            bool result = userService.VerifyUserAccount("UserID, UserName, Password");

            if (result)
            {
                Console.WriteLine();
                Console.WriteLine("Account is Verrified!");
            }

            else
            {
                Console.WriteLine("Account is Not Found, Try again!");
            }
        }
    }
}
