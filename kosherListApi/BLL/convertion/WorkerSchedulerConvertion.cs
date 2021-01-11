using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.convertion
{
    public class WorkerSchedulerConvertion
    {
        //המרה מDB
        public static WorkerSchedulerDto convertToDto(WorkerScheduler_tbl WS)
        {
            WorkerSchedulerDto newWorkerScheduler = new WorkerSchedulerDto();
            newWorkerScheduler.workerSchedulerID = WS.workerSchedulerID;
            newWorkerScheduler.workerId = WS.workerId;
            newWorkerScheduler.day1 = WS.day1;
            newWorkerScheduler.day2 = WS.day2;
            newWorkerScheduler.day3 = WS.day3;
            newWorkerScheduler.day4 = WS.day4;
            newWorkerScheduler.day5 = WS.day5;
            newWorkerScheduler.day6 = WS.day6;
            newWorkerScheduler.day7 = WS.day7;

            return newWorkerScheduler;
        }

        public static List<WorkerSchedulerDto> convertToListDto(List<WorkerScheduler_tbl> WS)
        {
            List<WorkerSchedulerDto> newWorkerScheduler = new List<WorkerSchedulerDto>();
            WS.ForEach(x =>
            {
                newWorkerScheduler.Add(convertToDto(x));
            });
            return newWorkerScheduler;
        }
        public static List<WorkerScheduler_tbl> convertToListWorkerScheduler(List<WorkerSchedulerDto> WS)
        {
            List<WorkerScheduler_tbl> newWorkerScheduler = new List<WorkerScheduler_tbl>();
            WS.ForEach(x =>
            {
                newWorkerScheduler.Add(convertToWorkerScheduler(x));
            });
            return newWorkerScheduler;
        }
        //המרה לDB
        public static WorkerScheduler_tbl convertToWorkerScheduler(WorkerSchedulerDto WS)
        {
            WorkerScheduler_tbl newWorkerScheduler = new WorkerScheduler_tbl();
            newWorkerScheduler.workerSchedulerID = WS.workerSchedulerID;
            newWorkerScheduler.workerId = WS.workerId;
            newWorkerScheduler.day1 = WS.day1;
            newWorkerScheduler.day2 = WS.day2;
            newWorkerScheduler.day3 = WS.day3;
            newWorkerScheduler.day4 = WS.day4;
            newWorkerScheduler.day5 = WS.day5;
            newWorkerScheduler.day6 = WS.day6;
            newWorkerScheduler.day7 = WS.day7;

            return newWorkerScheduler;
        }

    }
}
