//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Namu.Entity.ServicePOCOs;

namespace Namu.Entity.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tprovider : Provider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tprovider()
        {
            this.taddresses = new HashSet<taddress>();
        }

        public int idtprovider { get; set; }
        public string name { get; set; }
        public int providerTypeCode { get; set; }
        public int numcode { get; set; }
        public int phonecode { get; set; }
        public Nullable<int> userid { get; set; }
    
        public virtual tprovider_hoteltype tprovider_hoteltype { get; set; }
        public virtual tprovider_tourtype tprovider_tourtype { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<taddress> taddresses { get; set; }
    }
}
