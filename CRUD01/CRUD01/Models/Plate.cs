using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

public partial class Plate
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Color { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime? InitialDate { get; set; }

    [Required]
    [Range(9.00, 25.00, ErrorMessage = "The price for the plates must be between $9 and $25")]
    public decimal Price { get; set; }

    public bool OnDeal { get; set; }
}
