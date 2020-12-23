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
        public static List<WorkerDto> GetAllWorker()
        {
            using (KosherListEntities db = new KosherListEntities())
            {

                var worker = db.Worker_tbl.ToList();
                return WorkerConvertion.convertToListDto(worker);

            }
        }
    }
}
