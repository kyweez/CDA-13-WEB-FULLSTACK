using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebSite.Models
{
    [Table("customers")]
    public class Customer
    {
        #region ############### PROPERTIES ###############
        [Key]
        [Column("customer_id")]
        public int ID
        {
            get; set;
        }

        [Column("customer_name")]
        [MaxLength(100)]
        [DataType(DataType.Text)]
        public string Name
        {
            get; set;
        }

        [Column("customer_email")]
        [MaxLength(100)]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email
        {
            get; set;
        }


        #endregion
    }
}