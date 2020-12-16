using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.convertion;
namespace BLL.services
{
   public class StoreBL
    {

        public static List<StoreDto> GetAllStores() {
            using (KosherListEntities db = new KosherListEntities()) {

                var stores = db.Store_tbl.ToList();
                return StoreConvertion.convertToListDto(stores);

            }

        }
    }
}
