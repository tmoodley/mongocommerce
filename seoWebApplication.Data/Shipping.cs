
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace seoWebApplication.Data
{

using System;
    using System.Collections.Generic;
    
public partial class Shipping
{

    public Shipping()
    {

        this.Orders = new HashSet<Order>();

    }


    public int ShippingID { get; set; }

    public Nullable<int> webstore_id { get; set; }

    public string ShippingType { get; set; }

    public decimal ShippingCost { get; set; }

    public Nullable<int> ShippingRegionID { get; set; }



    public virtual ICollection<Order> Orders { get; set; }

}

}