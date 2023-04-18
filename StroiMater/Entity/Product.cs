//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StroiMater.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderHasProduct = new HashSet<OrderHasProduct>();
        }
    
        public string ArticleNumber { get; set; }
        public int NameID { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> MaxDiscount { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public Nullable<int> ProviderItemID { get; set; }
        public Nullable<int> CategoryItemID { get; set; }
        public Nullable<int> CurrentDiscount { get; set; }
        public Nullable<int> CountProductStock { get; set; }
        public string Discription { get; set; }
    
        public virtual CategoryItem CategoryItem { get; set; }
        public virtual ManufacturerItem ManufacturerItem { get; set; }
        public virtual NameItem NameItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderHasProduct> OrderHasProduct { get; set; }
        public virtual ProviderItem ProviderItem { get; set; }
    }
}
