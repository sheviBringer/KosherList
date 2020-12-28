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
    public class WorkerBL
    {
        public static List<WorkerDto> GetAllWorkers()
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var worker = db.Worker_tbl.ToList();
                return WorkerConvertion.convertToListDto(worker);

            }
        }
        public static bool AddWorker(WorkerDto worker)
        {
            using (KosherListEntities db = new KosherListEntities())
            {
                var newWorker = WorkerConvertion.convertToStore(worker);
                db.Worker_tbl.Add(newWorker);
                db.SaveChanges();
                return true;

            }
        }
        public static bool WorkerStore(WorkerDto worker)
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var updatedWorker = db.Worker_tbl.FirstOrDefault(x => x.codeWorker == worker.codeWorker);
                updatedWorker.nameWorker = worker.nameWorker;
                //TODO
                db.SaveChanges();
                return true;

            }
        }
    }
}
