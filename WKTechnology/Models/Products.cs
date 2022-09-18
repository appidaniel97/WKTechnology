using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WKTechnology.Models
{

    [Table("Products")]
    public class Products
    {
        
        [Column("Id")]
        [Display(Name="Código")]
        public int Id { get; set; }
        public int? IdCategory { get; set; }
       
        [Column("Description")]
        [Display(Name = "Descrição"), Required(ErrorMessage = "Campo obrigatório")]
        public string Description { get; set; }

        [Display(Name = "NCM"), Required(ErrorMessage = "Campo obrigatório")]
        [Column("Ncm")]
        public string Ncm { get; set; }

        [Display(Name = "P.Custo")]
        [Column("PriceCost")]
        public decimal? PriceCost { get; set; }

        [Display(Name = "P.Venda")]
        [Column("PriceSale")]
        public decimal? PriceSale { get; set; }

        
        [Column("Categoria")]
        [ForeignKey(nameof(IdCategory))]
        [InverseProperty(nameof(Categories.Products))]
        [Display(Name = "Categoria")]
        public virtual Categories CategoriaNavigation { get; set; }
    }
}
