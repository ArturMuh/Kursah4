//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Мухутдинов.NewFolder1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zakaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zakaz()
        {
            this.Sostav_zakaza = new HashSet<Sostav_zakaza>();
        }
    
        public long ID_zakaza { get; set; }
        public string Nazvanie_knigi { get; set; }
        public Nullable<System.DateTime> Date_zakaza { get; set; }
        public string Price { get; set; }
        public string Kolichestvo { get; set; }
        public Nullable<long> ID_postavshika { get; set; }
    
        public virtual Postavshik Postavshik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sostav_zakaza> Sostav_zakaza { get; set; }
    }
}
