using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_models;

[Table("Reeksen")]
public class Reeksen
    {
    [Key]
    public int ReeksID { get; set; }
    [Required]
    public string Titel { get; set; }
    [Required]
    public string Beschrijving { get; set; }
    [Required]
    public int ReekstypeID { get; set; }
    [Required]
    public string Website { get; set; }
    [Required]
    public DateTime LaatsteUpdate { get; set; }

    public Albums Albums { get; set; }

    public ICollection<ReeksenGenres> ReeksenGenres { get; set; }
}

