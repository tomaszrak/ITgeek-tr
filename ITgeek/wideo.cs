//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITgeek
{
    using System;
    using System.Collections.Generic;
    
    public partial class wideo
    {
        public int id_wideo { get; set; }
        public int id_projekt { get; set; }
        public string nazwa_wideo { get; set; }
        public string format_wideo { get; set; }
        public byte[] plik_wideo { get; set; }
    
        public virtual projekt projekt { get; set; }
    }
}
