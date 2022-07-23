//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flight_Management_System.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transport()
        {
            this.SeatInfos = new HashSet<SeatInfo>();
            this.TransportSchedules = new HashSet<TransportSchedule>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> MaximumSeat { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeatInfo> SeatInfos { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportSchedule> TransportSchedules { get; set; }
    }
}
