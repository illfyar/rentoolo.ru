//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Applications
    {
        public Applications()
        {
            this.Memberships = new HashSet<Memberships>();
            this.Roles = new HashSet<Roles>();
            this.Users = new HashSet<Users>();
        }
    
        public string ApplicationName { get; set; }
        public System.Guid ApplicationId { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Memberships> Memberships { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
