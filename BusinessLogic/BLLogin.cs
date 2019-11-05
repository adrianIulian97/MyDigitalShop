using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class BLLogin
    {
        public BLLogin()
        {

        }

        public UserModel CheckUser(string userName, string password, out bool status)
        {
            status = false;
            UserModel user = new UserModel();
            DALogin da = new DALogin();
            DataTable tableUsers = da.CheckUser(userName);

            if (tableUsers.Rows.Count == 0)
            {
                MessageBox.Show("Nu exista niciun utilizator cu numele: " + userName, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            if (tableUsers.Rows.Count == 0)
                status = false;
            else
            {
                for (int i = 0; i < tableUsers.Rows.Count; i++)
                {
                    if (tableUsers.Rows[i]["UserPassword"].ToString().Length % 4 == 0)
                    {
                        Console.WriteLine(tableUsers.Rows[i]["UserPassword"].ToString());
                        byte[] data = Convert.FromBase64String(tableUsers.Rows[i]["UserPassword"].ToString());
                        string decodedString = Encoding.UTF8.GetString(data);
                        if (password == decodedString)
                        {
                            status = true;
                            user.UserId = Convert.ToInt32(tableUsers.Rows[i]["UserId"]);
                            user.UserName = tableUsers.Rows[i]["UserName"].ToString();
                            user.UserPassword = tableUsers.Rows[i]["UserPassword"].ToString();
                            //user.LastLogin = Convert.ToDateTime(tableUsers.Rows[i]["LastLogin"]); // in acest moment ultima logare este aceasta
                            user.LastLogin = DateTime.Now;
                        }
                    }
                }
                if (status == false)
                {
                    MessageBox.Show("Parola nu este corecta!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }


            return user;
        }

        public void InsertLastLogin(DateTime dateTimeLastLogin, int idUser)
        {
            DALogin login = new DALogin();
            login.InsertLastLogin(dateTimeLastLogin, idUser);
        }
    }
}
