using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class UserService
    {

        UserDao userDao;
        public UserService()
        {
            userDao = new UserDao();
        }
        public User UserLogin(string FirstName, int Passcode)
        {
            User user = userDao.UserLogin(FirstName, Passcode);
            return user;
        }
    }
}
