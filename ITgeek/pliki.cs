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
    
    public partial class pliki
    {
        public int id_pliki { get; set; }
        public int id_projekt { get; set; }
        public string format_pliku { get; set; }
        public string nazwa_pliku { get; set; }
        public byte[] plik { get; set; }
    
        public virtual projekt projekt { get; set; }
    }
}
