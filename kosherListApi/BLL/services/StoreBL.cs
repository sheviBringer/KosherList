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

        public static bool AddStore(StoreDto store)
        {
            using (KosherListEntities db = new KosherListEntities())
            {
                var newStore = StoreConvertion.convertToStore(store); 
                db.Store_tbl.Add(newStore);
                db.SaveChanges();
                return true;

            }
        }
        public static bool UpdateStore(StoreDto store)
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var updatedStore = db.Store_tbl.FirstOrDefault(x => x.codeStore == store.codeStore);
                updatedStore.nameStore = store.nameStore;
                //TODO
                db.SaveChanges();
                return true;

            }
        }
    }
}
