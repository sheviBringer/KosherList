using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class UpdatesDto
    {
        public int updatesId { get; set; }
        public int codeStore { get; set; }
        public int codeWorker { get; set; }
        public System.DateTime dateVisit { get; set; }
        public Nullable<System.TimeSpan> begginingTime { get; set; }
        public Nullable<System.TimeSpan> exitingTime { get; set; }
        public string remarks { get; set; }
        public Nullable<int> result { get; set; }

        public virtual Store_tbl Store_tbl { get; set; }
        public virtual Worker_tbl Worker_tbl { get; set; }
    }
}
