using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    enum UserType
    {
        Student=0,Parent=1,Teacher=2,Manager=3
    }
    public class Users
    {
        public Users(global::System.Int32 userId, UserType userType)
        {
            UserId = userId;
            UserType = userType;
        }

        public int UserId { get; set; }//it's better to be user phone number
        public UserType UserType { get; set; }
    }
}
