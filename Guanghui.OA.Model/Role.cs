//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Guanghui.OA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Role()
        {
            this.ActionInfo = new HashSet<ActionInfo>();
            this.User = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string RoleName { get; set; }
        public System.DateTime SubmitTime { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public short DelFlag { get; set; }
        public string Remark { get; set; }
        public string Sort { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionInfo> ActionInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}