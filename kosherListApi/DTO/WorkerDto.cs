using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class WorkerDto
    {
        public int codeWorker { get; set; }
        public string nameWorker { get; set; }
        public string addressWorker { get; set; }
        public string telWorker { get; set; }
        public Nullable<int> experience { get; set; }
        public Nullable<System.DateTime> dateStart { get; set; }
        public string email { get; set; }
        public Nullable<bool> mobility { get; set; }

    }
}
