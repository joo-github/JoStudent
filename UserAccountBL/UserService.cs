using UserAccountDL;

namespace UserAccountBL
{
    public class UserService
    {
        public bool VerifyUserAccount(string UserID, string UserName, string Password)
        {
            UserDataService dataService = new UserDataService();
            var result = dataService.GetUser(UserID, UserName, Password);

            return result.UserID != null;
            return result.UserName != null;
            return result.Password != null;


        }

        public bool VerifyUserAccount(string v)
        {
            throw new NotImplementedException();
        }
    }
}
