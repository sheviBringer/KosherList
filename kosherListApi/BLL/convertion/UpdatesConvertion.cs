using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.convertion
{
    public class UpdatesConvertion
    {       
       
        //המרה מDB
        public static UpdatesDto convertToDto(Updates_tbl u)
        {
            UpdatesDto newUpdates = new UpdatesDto();
            newUpdates.updatesId = u.updatesId;
            newUpdates.codeStore = u.codeStore;
            newUpdates.codeWorker = u.codeWorker;
            newUpdates.dateVisit = u.dateVisit;
            newUpdates.begginingTime = u.begginingTime;
            newUpdates.exitingTime = u.exitingTime;
            newUpdates.remarks = u.remarks;
            newUpdates.result = u.result;
            return newUpdates;
        }
        public static List<UpdatesDto> convertToListDto(List<Updates_tbl> u)
        {
            List<UpdatesDto> newUpdates = new List<UpdatesDto>();
            u.ForEach(x =>
            {
                newUpdates.Add(convertToDto(x));
            });
            return newUpdates;
        }
        public static List<Updates_tbl> convertToListStore(List<UpdatesDto> u)
        {
            List<Updates_tbl> newUpdates = new List<Updates_tbl>();
            u.ForEach(x =>
            {
                newUpdates.Add(convertToUpdates(x));
            });
            return newUpdates;
        }
        //המרה לDB
        public static Updates_tbl convertToUpdates(UpdatesDto u)
        {
            Updates_tbl newUpdates = new Updates_tbl();
            newUpdates.updatesId = u. updatesId;
            newUpdates.codeStore = u.codeStore;
            newUpdates.codeWorker = u.codeWorker;
            newUpdates.dateVisit = u.dateVisit;
            newUpdates.begginingTime = u.begginingTime;
            newUpdates.exitingTime = u.exitingTime;
            newUpdates.remarks = u.remarks;
            newUpdates.result = u.result;
            return newUpdates;

        }

    }

}

