//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDescription
    {
        public ProductDescription()
        {
            this.ProductModelProductDescriptions = new HashSet<ProductModelProductDescription>();
        }
    
        public int ProductDescriptionID { get; set; }
        public string Description { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ProductModelProductDescription> ProductModelProductDescriptions { get; set; }
    }
}
