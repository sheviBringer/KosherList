//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Store_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store_tbl()
        {
            this.Updates_tbl = new HashSet<Updates_tbl>();
        }
    
        public int codeStore { get; set; }
        public string nameStore { get; set; }
        public string addressStore { get; set; }
        public Nullable<int> clasificationStore { get; set; }
        public Nullable<System.TimeSpan> activityTimeStart { get; set; }
        public Nullable<System.TimeSpan> activityTimeEnd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Updates_tbl> Updates_tbl { get; set; }
    }
}