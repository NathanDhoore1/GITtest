using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_models;

public class Reekstypes
    {
    [Key]
    public int ReekstypeID { get; set; }
    public string? Beschrijving { get; set; }

}

