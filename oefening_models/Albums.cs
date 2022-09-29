using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_models;

[Table("Albums")]
public class Albums
    {
    [Key]
    public int AlbumID { get; set; }
    [Required]
    [ForeignKey("Reeksen")]
    public int Reeksnummer { get; set; }
    [Required]
    public string Titel { get; set; }
    public string? Beschrijving { get; set; }
    [Required]
    public int AlbumTypeID { get; set; }
    [Required]
    public bool Favoriet { get; set; }
    public byte? Waardering { get; set; }
    public DateTime? Uitgiftedatum { get; set; }
    [Required]
    public bool EersteDruk { get; set; }
    [Required]
    public string Kaft { get; set; }
    [Required]
    public string Inkleuring { get; set; }
    [Required]
    public int Paginas { get; set; }
    [Required]
    [Precision(18, 2)]
    public decimal Breedte { get; set; }
    [Required]
    [Precision(18, 2)]
    public decimal Hoogte { get; set; }
    [Required]
    public string Taal { get; set; }
    public byte? Conditie { get; set; }
    [Precision(18, 2)]
    public decimal? InBedrag { get; set; }
    [Precision(18, 2)]
    public decimal? Waarde { get; set; }
    [Precision(18, 2)]
    public decimal? Uitbedrag { get; set; }
    [Required]
    public DateTime LaatsteUpdate { get; set; }
    [Required]
    public int ReeksID { get; set; }
    [Required]
    public int UitgeverID { get; set; }
    public int? EventIDIn { get; set; }
    public int? EventIDUit { get; set; }

    public ICollection<Reeksen> Reeksens { get; set; }



}

