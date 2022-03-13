using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPI.Model.Domain
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public Category Category { get; set; }
    }
}
