using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace LabJJ2.Models
{
    public class ProductsClass
    {
        [Required(ErrorMessage ="Enter Name PLease")]
        [MaxLength(20)]
        [RegularExpression(@"^[A-Za-z.\s_-]+$", ErrorMessage = "Invalid Character Input")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description Required")]
        [MaxLength(50, ErrorMessage = "Message Exceeds Maximum Length")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Could you try adding a price, please? Thanks.")]
        [RegularExpression(@"[0-9.$\s]*", ErrorMessage = "Contains invalid input")]
        public float Price { get; set; }
        [Required]
        [Range(0,20, ErrorMessage = "Exceeded weight Limit")]
        [RegularExpression(@"[0-9.$\s]*", ErrorMessage = "Contains invalid input")]
        public float Weight { get; set; }
    }
}