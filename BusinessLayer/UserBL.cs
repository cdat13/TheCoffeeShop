using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataTranfer;

namespace BusinessLayer
{

        public class UserBL
        {
            private UserDL userDL;

            public UserBL()
            {
                userDL = new UserDL();
            }

            public User Login(string username, string password)
            {
                try
                {
                    return userDL.GetUser(username, password);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
