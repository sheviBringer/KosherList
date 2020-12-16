using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.convertion
{
   public class WorkerConvertion
    {
        //המרה מDB
        public static WorkerDto convertToDto(Worker_tbl w)
        {
            WorkerDto newWorker = new WorkerDto();
            newWorker.addressWorker= w.addressWorker;
            newWorker.codeWorker = w.codeWorker;
            newWorker.dateStart = w.dateStart;
            newWorker.email = w.email;
            newWorker.experience = w.experience;
            newWorker.mobility = w.mobility;
            newWorker.nameWorker = w.nameWorker;
            newWorker.telWorker = w.telWorker;
            return newWorker;
        }
        public static List<WorkerDto> convertToListDto(List<Worker_tbl> w)
        {
            List<WorkerDto> newWorker = new List<WorkerDto>();
            w.ForEach(x =>
            {
                newWorker.Add(convertToDto(x));
            });
            return newWorker;
        }
        public static List<Worker_tbl> convertToListStore(List<WorkerDto> w)
        {
            List<Worker_tbl> newWorker = new List<Worker_tbl>();
            w.ForEach(x =>
            {
                newWorker.Add(convertToStore(x));
            });
            return newWorker;
        }
        //המרה לDB
        public static Worker_tbl convertToStore(WorkerDto w)
        {
            Worker_tbl newWorker = new Worker_tbl();
            newWorker.addressWorker = w.addressWorker;
            newWorker.codeWorker = w.codeWorker;
            newWorker.dateStart = w.dateStart;
            newWorker.email = w.email;
            newWorker.experience = w.experience;
            newWorker.mobility = w.mobility;
            newWorker.nameWorker = w.nameWorker;
            newWorker.telWorker = w.telWorker;
            return newWorker;
        }
    }
}
