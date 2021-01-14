using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebApp.Models
{
    [Table("customer_cats")]
    public class CustomerCat
    {
        [Key]
        [Column("cat_id", Order = 1)]
        public int ID
        {
            get; set;
        }

        [Column("cat_name", Order = 2)]
        [MaxLength(50, ErrorMessage = "Longueur maximum 50")]
        [Display(Name = "Categorie de client")]
        public string Name
        {
            get; set;
        }

        [Column("cat_description", Order = 3)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string Description
        {
            get; set;
        }

        public ICollection<Customer> Customers
        {
            get; set;
        }
    }
}