
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
    
public partial class projekt
{

    public projekt()
    {

        this.komentarz = new HashSet<komentarz>();

        this.ocena_projektu = new HashSet<ocena_projektu>();

        this.pliki = new HashSet<pliki>();

        this.pozycja_kategorii = new HashSet<pozycja_kategorii>();

        this.wideo = new HashSet<wideo>();

        this.zdjecia = new HashSet<zdjecia>();

    }


    public int id_projekt { get; set; }

    public int id_uzytkownik { get; set; }

    public string nazwa_projektu { get; set; }

    public string wstep { get; set; }

    public string rozwiniecie { get; set; }

    public string zakonczenie { get; set; }

    public int poziom_ukonczenia { get; set; }

    public string uwagi_problemy { get; set; }



    public virtual ICollection<komentarz> komentarz { get; set; }

    public virtual ICollection<ocena_projektu> ocena_projektu { get; set; }

    public virtual ICollection<pliki> pliki { get; set; }

    public virtual ICollection<pozycja_kategorii> pozycja_kategorii { get; set; }

    public virtual uzytkownik uzytkownik { get; set; }

    public virtual ICollection<wideo> wideo { get; set; }

    public virtual ICollection<zdjecia> zdjecia { get; set; }

}

}
