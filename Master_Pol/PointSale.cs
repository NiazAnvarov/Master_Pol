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
    
    public partial class PointSale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PointSale()
        {
            this.Partner = new HashSet<Partner>();
        }
    
        public int PointSaleID { get; set; }
        public string PointSale_Index { get; set; }
        public string PointSale_Region { get; set; }
        public string PointSale_City { get; set; }
        public string PointSale_Street { get; set; }
        public string PointSale_House { get; set; }
        public int Partner_ID { get; set; }
        public string PointSale_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partner> Partner { get; set; }
    }
}