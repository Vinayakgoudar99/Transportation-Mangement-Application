//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportDataLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillTable
    {
        public int BillId { get; set; }
        public decimal BillAmount { get; set; }
        public Nullable<int> EmpId { get; set; }
    
        public virtual EmployeeTable EmployeeTable { get; set; }
    }
}
