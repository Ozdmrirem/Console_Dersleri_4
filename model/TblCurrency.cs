//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Console_Dersleri_4.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblCurrency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblCurrency()
        {
            this.TblCurrencyValue = new HashSet<TblCurrencyValue>();
            this.TblOperation = new HashSet<TblOperation>();
        }
    
        public int ID { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCurrencyValue> TblCurrencyValue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblOperation> TblOperation { get; set; }
    }
}
