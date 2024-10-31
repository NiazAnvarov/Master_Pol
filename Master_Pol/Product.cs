//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Master_Pol
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Partner_Product = new HashSet<Partner_Product>();
            this.ProductMinCostHistory = new HashSet<ProductMinCostHistory>();
            this.ProductCountHistory = new HashSet<ProductCountHistory>();
            this.Material = new HashSet<Material>();
        }
    
        public string Product_Article { get; set; }
        public int Product_Type { get; set; }
        public string Product_Name { get; set; }
        public decimal Product_MinCost { get; set; }
        public string Product_Description { get; set; }
        public string Product_Photo { get; set; }
        public Nullable<decimal> Product_Length { get; set; }
        public Nullable<decimal> Product_Width { get; set; }
        public Nullable<decimal> Product_Height { get; set; }
        public Nullable<decimal> Product_NetWeight { get; set; }
        public Nullable<decimal> Product_GrossWeight { get; set; }
        public string Product_QualityCertificate { get; set; }
        public string Product_StandartNumber { get; set; }
        public Nullable<System.TimeSpan> Product_ManfacturingTime { get; set; }
        public Nullable<decimal> Product_CostPrice { get; set; }
        public string Product_WorkshopNumber { get; set; }
        public Nullable<int> Product_PersonalCountInProduction { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partner_Product> Partner_Product { get; set; }
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMinCostHistory> ProductMinCostHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCountHistory> ProductCountHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Material { get; set; }
    }
}