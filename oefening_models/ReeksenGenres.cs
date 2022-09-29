using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_models;

[Table("ReeksGenres")]
[Index(nameof(ReeksID), nameof(GenreID), IsUnique = true, Name ="IX_ReeksIDGenreID")]
public class ReeksenGenres
    {
    [Key]
    public int ReeksGenreID { get; set; }
    [Required]
    [ForeignKey("Reeks")]
    public int ReeksID { get; set; }
    [Required]
    [ForeignKey("Genre")]
    public int GenreID { get; set; }

    public Genres Genre { get; set; }
    public Reeksen Reeks { get; set; }
}

