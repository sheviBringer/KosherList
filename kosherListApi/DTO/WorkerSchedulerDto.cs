using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class WorkerSchedulerDto
    {
        public int workerSchedulerID { get; set; }
        public int workerId { get; set; }
        public int hour { get; set; }
        public Nullable<int> day1 { get; set; }
        public Nullable<int> day2 { get; set; }
        public Nullable<int> day3 { get; set; }
        public Nullable<int> day4 { get; set; }
        public Nullable<int> day5 { get; set; }
        public Nullable<int> day6 { get; set; }
        public Nullable<int> day7 { get; set; }

    }
}
