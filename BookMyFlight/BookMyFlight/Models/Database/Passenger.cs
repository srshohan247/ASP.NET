//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookMyFlight.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passenger
    {
        public Passenger()
        {
            this.Seats = new HashSet<Seat>();
        }
    
        public int passenger_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime dob { get; set; }
        public string bg { get; set; }
    
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
