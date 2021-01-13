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

        // Foreign Key CustomerCat
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
