//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tenders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.Guid UserOwnerId { get; set; }
        public double Cost { get; set; }
        public string ImgUrls { get; set; }
        public Nullable<int> Status { get; set; }
        public System.DateTime Created { get; set; }
        public int CurrencyId { get; set; }
        public int CategoryId { get; set; }
    }
}
