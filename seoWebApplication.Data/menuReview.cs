
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
    
public partial class menuReview
{

    public Nullable<int> menuReviews_id { get; set; }

    public Nullable<int> ReviewFields_id { get; set; }

    public Nullable<int> feel { get; set; }

    public Nullable<int> rate { get; set; }

    public string comment { get; set; }

    public int webstore_id { get; set; }

    public int product_id { get; set; }



    public virtual product product { get; set; }

    public virtual ReviewField ReviewField { get; set; }

    public virtual webstore webstore { get; set; }

}

}
