using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAccountModel;

namespace UserAccountDL
{
    public class UserDataService
    {
        List<User> dummyUsers = new List<User>();

        public UserDataService()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {

            User user1 = new User { UserID = "2022-00273-BN-0", UserName = "Jonalynramos", Password = "1210" };
            User user2 = new User { UserID = "2022-00275-BN-0", UserName = "Jackielynchavez", Password = "1914" };
            User user3 = new User { UserID = "2022-00279-BN-0", UserName = "Danicafuentes", Password = "0675" };

            dummyUsers.Add(user1);
            dummyUsers.Add(user2);
            dummyUsers.Add(user3);
        }

        public User GetUser(string UserID, string UserName, string Password)
        {
            User foundUser = new User();

            foreach (var dummy in dummyUsers)
            {
                if (UserID == dummy.UserID && UserName == dummy.UserName && Password == dummy.Password)
                {
                    foundUser = dummy;
                }
            }

            return foundUser;
        }
    }
}