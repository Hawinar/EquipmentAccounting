//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquipmentAccounting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusHistory
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public string Status { get; set; }
        public System.DateTime ChangeDate { get; set; }
    
        public virtual Equipment Equipment { get; set; }
    }
}
