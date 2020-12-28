using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using BLL.convertion;


namespace BLL.services
{
    public class UsersBL
    {
        public static List<UsersDto> GetAllUsers()
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var users = db.Users_tbl.ToList();
                return UsersConvertion.convertToListDto(users);

            }
        }
        public static bool AddUser(UsersDto User)
        {
            using (KosherListEntities db = new KosherListEntities())
            {
                var newUser = UsersConvertion.convertToUser(User);
                db.Users_tbl.Add(newUser);
                db.SaveChanges();
                return true;

            }
        }
        public static bool UpdateUser(UsersDto user)
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var updatedUser = db.Users_tbl.FirstOrDefault(x => x.userPassword == user.userPassword);
                updatedUser.userUserName = user.userUserName;
                //TODO
                db.SaveChanges();
                return true;

            }
        }
    }
}