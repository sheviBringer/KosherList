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
    }
}