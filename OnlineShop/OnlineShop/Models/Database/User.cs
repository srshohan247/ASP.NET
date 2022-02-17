//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShop.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Carts = new HashSet<Cart>();
            this.Logins = new HashSet<Login>();
            this.Orders = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
