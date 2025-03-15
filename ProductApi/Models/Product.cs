using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApi.Models
{
    [Table("Product", Schema = "dbo")]
    [Index(nameof(ProductName), IsUnique = false, Name = "ProductName_Idx")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductId")]
        public int ProductId { get; set; }

        [Column("ProductName")]
        [Required]
        public string? ProductName { get; set; }

        [Column("ProductDescription")]
        public string? ProductDescription { get; set; }

        [Column("ProductPrice", TypeName = "int")]
        public int ProductPrice { get; set; }

        [Column("ProductStock", TypeName = "int")]
        public int ProductStock { get; set; }
    }
}
