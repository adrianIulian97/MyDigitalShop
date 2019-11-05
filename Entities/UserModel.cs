using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserModel
    {
        public int UserId { set; get; }
        public string UserName { set; get; }
        public string UserPassword { set; get; }
        public DateTime LastLogin { set; get; }

        //private static UserModel instance;
        //private UserModel() { }

        //public static UserModel Instance
        //{
        //    get
        //    {
        //        if(instance == null)
        //        {
        //            instance = new UserModel();
        //        }
        //        return instance;
        //    }
        //}

        public UserModel() { }
    }
}
