using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allup.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:255)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName ="money")]
        public double Price { get; set; }
   
        [Column(TypeName = "money")]
        public double DiscountPrice { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public double ExTable { get; set; }
        [Required]
        [StringLength(maximumLength: 4)]
        public string Seria { get; set; }
        [Range(0,9999)]
        public int Code { get; set; }
        [StringLength(maximumLength:1000)]
        public  string Description { get; set; }
        [Range(0,int.MaxValue)]
        public int Count { get; set; }

        public Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}
