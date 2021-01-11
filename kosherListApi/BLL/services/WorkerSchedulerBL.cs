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
    public class WorkerSchedulerBL
    {
        public static List<WorkerSchedulerDto> GetAllWorkerScheduler()
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var WorkerSchedulers = db.WorkerScheduler_tbl.ToList();
                return WorkerSchedulerConvertion.convertToListDto(WorkerSchedulers);

            }

        }

        public static bool AddWorkerScheduler(WorkerSchedulerDto WorkerScheduler)
        {
            using (KosherListEntities db = new KosherListEntities())
            {
                var newWorkerScheduler = WorkerSchedulerConvertion.convertToWorkerScheduler(WorkerScheduler);
                db.WorkerScheduler_tbl.Add(newWorkerScheduler);
                db.SaveChanges();
                return true;

            }
        }
        public static bool UpdateWorkerScheduler(WorkerSchedulerDto WorkerScheduler)
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var updatedWorkerScheduler = db.WorkerScheduler_tbl.FirstOrDefault(x => x.workerSchedulerID == WorkerScheduler.workerSchedulerID);
                updatedWorkerScheduler.day1 = WorkerScheduler.day1;
                updatedWorkerScheduler.day2 = WorkerScheduler.day2;
                updatedWorkerScheduler.day3 = WorkerScheduler.day3;
                updatedWorkerScheduler.day4 = WorkerScheduler.day4;
                updatedWorkerScheduler.day5 = WorkerScheduler.day5;
                updatedWorkerScheduler.day6 = WorkerScheduler.day6;
                updatedWorkerScheduler.day7 = WorkerScheduler.day7;
                db.SaveChanges();
                return true;

            }
        }
    }
}
