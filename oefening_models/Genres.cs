using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_models;

[Table("Genres")]
public class Genres
    {
    [Key]
    public int GenreID { get; set; }
    [Required]
    public string Naam { get; set; }
    [Required]
    public string Beschrijving { get; set; }

    public ICollection<ReeksenGenres> ReeksenGenres { get; set; }

}

