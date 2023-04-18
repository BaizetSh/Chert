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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderHasProduct = new HashSet<OrderHasProduct>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> DateOrder { get; set; }
        public Nullable<System.DateTime> DateProvide { get; set; }
        public Nullable<int> PickupPointMailIndex { get; set; }
        public Nullable<int> UserInfoID { get; set; }
        public Nullable<int> CodeForGet { get; set; }
        public Nullable<int> StatusOrderID { get; set; }
    
        public virtual PickupPoint PickupPoint { get; set; }
        public virtual StatusOrder StatusOrder { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderHasProduct> OrderHasProduct { get; set; }
    }
}
