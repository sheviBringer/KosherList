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
        public static bool AddUpdate(UpdatesDto update)
        {
            using (KosherListEntities db = new KosherListEntities())
            {
                var newUpdate = UpdatesConvertion.convertToUpdates(update);
                db.Updates_tbl.Add(newUpdate);
                db.SaveChanges();
                return true;

            }
        }
        public static bool UpdateUpdates(UpdatesDto updates)
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var updatedUpdates = db.Updates_tbl.FirstOrDefault(x => x.updatesId == updates.updatesId);
               // updatedUpdates.nameUpdates = updates.nameUpdate;
                //TODO
                db.SaveChanges();
                return true;

            }
        }
    }
}
