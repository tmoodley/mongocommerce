
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
    
public partial class zone
{

    public zone()
    {

        this.webstores = new HashSet<webstore>();

    }


    public int idZone { get; set; }

    public int idCity { get; set; }

    public string zoneName { get; set; }



    public virtual city city { get; set; }

    public virtual ICollection<webstore> webstores { get; set; }

}

}