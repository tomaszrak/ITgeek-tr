
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
    
public partial class podkomentarz
{

    public podkomentarz()
    {

        this.ocena_podkomentarza = new HashSet<ocena_podkomentarza>();

    }


    public int id_podkomentarz { get; set; }

    public int id_komentarz { get; set; }

    public int id_uzytkownik { get; set; }

    public string tresc_podkomentarza { get; set; }



    public virtual komentarz komentarz { get; set; }

    public virtual ICollection<ocena_podkomentarza> ocena_podkomentarza { get; set; }

    public virtual uzytkownik uzytkownik { get; set; }

}

}
