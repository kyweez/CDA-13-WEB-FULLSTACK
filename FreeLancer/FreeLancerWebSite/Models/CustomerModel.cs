using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebSite.Models
{
    [Table("customers")]
    public class CustomerModel
    {
        #region ############### PROPERTIES ###############
        [Key]
        [Column("customer_id", Order = 1)]
        public int ID
        {
            get; set;
        }

        [Column("customer_name", Order = 2)]
        [MaxLength(100)]
        [DataType(DataType.Text)]
        public string Name
        {
            get; set;
        }

        [Column("customer_email", Order = 3)]
        [Required]
        [MaxLength(255)]
        [DataType(DataType.EmailAddress)]
        public string Email
        {
            get; set;
        }
        #endregion
    }
}