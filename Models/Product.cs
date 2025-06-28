using System.ComponentModel.DataAnnotations;

namespace crudProduct.Models
{
    public class Product
    {


        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El nombre no puede estar vacio")]
        public string Name { get; set; } = " ";

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage ="El precio no puede ser menor que 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "El cantidad es obligatorio")]
        [Range(1,int.MaxValue, ErrorMessage = "La cantidad no puede ser menor que 0")]
        public int Quantity { get; set; }
    }
}
