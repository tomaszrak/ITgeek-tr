
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
    
public partial class kategoria
{

    public kategoria()
    {

        this.pozycja_kategorii = new HashSet<pozycja_kategorii>();

    }


    public int id_kategoria { get; set; }

    public string nazwa_kategorii { get; set; }



    public virtual ICollection<pozycja_kategorii> pozycja_kategorii { get; set; }

}

}
