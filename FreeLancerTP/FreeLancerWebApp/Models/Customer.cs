using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebApp.Models
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        [Column("customer_id", Order = 1)]
        [Display(Name = "Identifiant")]
        public int ID
        {
            get; set;
        }

        [Column("customer_name", Order = 2)]
        [MaxLength(100, ErrorMessage = "Longueur maximum : 100")]
        [DataType(DataType.Text)]
        [Display(Name = "Nom du client")]
        public string Name
        {
            get; set;
        }

        [Column("customer_email", Order = 3)]
        [Required(ErrorMessage = "Champs obligatoire")]
        [MaxLength(255, ErrorMessage = "Longueur maximum : 255")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email invalide")]
        [Display(Name = "E-mail")]
        public string Email
        {
            get; set;
        }

        // Foreign Key CustomerCat
        [ForeignKey("FK_cat_in_customer")]
        [Column("cat_id", Order = 4)]
        public int CustomerCatID
        {
            get; set;
        }
        public CustomerCat CustomerCat
        {
            get; set;
        }

        public ICollection<Job> Jobs
        {
            get; set;
        }
    }
}
