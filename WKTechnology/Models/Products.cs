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
        [Display(Name = "Descrição"), Required(ErrorMessage = "Campo obrigatório:Descrição")]
        public string Description { get; set; }

        [Display(Name = "NCM")]
        [Column("Ncm")]
        public string Ncm { get; set; }

        [Display(Name = "P.Custo")]
        [Column("PriceCost")]
        public decimal? PriceCost { get; set; }

        [Display(Name = "P.Venda")]
        [Column("PriceSale")]
        public decimal? PriceSale { get; set; }

        [Display(Name = "Categoria")]
        [Column("IdCategory")]
        [ForeignKey(nameof(IdCategory))]
        [InverseProperty(nameof(Categories.Products))]
        public virtual Categories IdCategoryNavigation { get; set; }
    }
}
