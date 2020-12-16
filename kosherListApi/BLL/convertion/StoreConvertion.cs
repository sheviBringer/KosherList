using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.convertion
{
   public class StoreConvertion
    {
        //המרה מDB
        public static StoreDto convertToDto(Store_tbl s)
        {
            StoreDto newStore = new StoreDto();
            newStore.nameStore = s.nameStore;
            newStore.addressStore = s.addressStore;
            newStore.activityTimeStart = s.activityTimeStart;
            newStore.activityTimeEnd = s.activityTimeEnd;
            newStore.clasificationStore = s.clasificationStore;
            newStore.codeStore = s.codeStore;
            return newStore;
        }
        public static List<StoreDto> convertToListDto(List<Store_tbl> s)
        {
            List<StoreDto> newStores = new List<StoreDto>();
            s.ForEach(x =>
            {
                newStores.Add(convertToDto(x));
            });
            return newStores;
        }
        public static List<Store_tbl> convertToListStore(List<StoreDto> s)
        {
            List<Store_tbl> newStores = new List<Store_tbl>();
            s.ForEach(x =>
            {
                newStores.Add(convertToStore(x));
            });
            return newStores;
        }
        //המרה לDB
        public static Store_tbl convertToStore(StoreDto s)
        {
            Store_tbl newStore = new Store_tbl();
            newStore.nameStore = s.nameStore;
            newStore.addressStore = s.addressStore;
            newStore.activityTimeStart = s.activityTimeStart;
            newStore.activityTimeEnd = s.activityTimeEnd;
            newStore.clasificationStore = s.clasificationStore;
            newStore.codeStore = s.codeStore;
            return newStore;
        }

    }
}
