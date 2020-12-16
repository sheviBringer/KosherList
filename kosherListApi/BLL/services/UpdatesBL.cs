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
    public class UpdatesBL
    {
        public static List<UpdatesDto> GetAllUpdates()
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var updates = db.Updates_tbl.ToList();
                return UpdatesConvertion.convertToListDto(updates);

            }
        }
    }
}
