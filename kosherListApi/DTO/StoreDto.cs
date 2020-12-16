using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class StoreDto
    {
        public int codeStore { get; set; }
        public string nameStore { get; set; }
        public string addressStore { get; set; }
        public Nullable<int> clasificationStore { get; set; }
        public Nullable<System.TimeSpan> activityTimeStart { get; set; }
        public Nullable<System.TimeSpan> activityTimeEnd { get; set; }

    }
}
