//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektOI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Specialisation
    {
        public Specialisation()
        {
            this.Doctors = new HashSet<Doctor>();
        }
    
        public int IDSpecialisation { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
