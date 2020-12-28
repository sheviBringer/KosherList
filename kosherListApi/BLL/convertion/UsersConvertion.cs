using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.convertion
{
   public class UsersConvertion
    {
         
        //המרה מDB
        public static UsersDto convertToDto(Users_tbl u)
        {
            UsersDto newUsers = new UsersDto();
            newUsers.userId = u.userId;
            newUsers.userPassword = u.userPassword;
            newUsers.userRole = u.userRole;
            newUsers.userUserName = u.userUserName;
            return newUsers;
        }
        public static List<UsersDto> convertToListDto(List<Users_tbl> u)
        {
            List<UsersDto> newUsers = new List<UsersDto>();
            u.ForEach(x =>
            {
                newUsers.Add(convertToDto(x));
            });
            return newUsers;
        }
        public static List<Users_tbl> convertToListStore(List<UsersDto> u)
        {
            List<Users_tbl> newUsers = new List<Users_tbl>();
            u.ForEach(x =>
            {
                newUsers.Add(convertToUser(x));
            });
            return newUsers;
        }
        //המרה לDB
        public static Users_tbl convertToUser(UsersDto u)
        {
            Users_tbl newUsers = new Users_tbl();
            newUsers.userId = u.userId;
            newUsers.userPassword = u.userPassword;
            newUsers.userRole = u.userRole;
            newUsers.userUserName = u.userUserName;
            return newUsers;
        }

    }
}
