//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesApp2.Models
{
    using System;
    
    public partial class NmrhID_Result
    {
        public int Id { get; set; }
        public Nullable<int> IdType { get; set; }
        public Nullable<int> IdColor { get; set; }
        public Nullable<int> IdBrand { get; set; }
        public Nullable<int> IdProvider { get; set; }
        public int IdCatalog { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public Nullable<decimal> PriceDistributor { get; set; }
        public decimal PriceClient { get; set; }
        public decimal PriceMember { get; set; }
        public bool IsEnabled { get; set; }
        public string Keywords { get; set; }
        public System.DateTime DateUpdate { get; set; }
    }
}
