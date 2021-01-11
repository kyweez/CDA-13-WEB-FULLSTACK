using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebSite.Models
{
    [Table("customer_cats")]
    public class CustomerCatModel
    {
        #region ############### PROPERTIES ###############
        [Key]
        [Column("cat_id", Order = 1)]
        public int ID
        {
            get; set;
        }

        [Column("cat_name", Order = 2)]
        [MaxLength(50)]
        public string Name
        {
            get; set;
        }

        [Column("cat_description", Order = 3)]
        [DataType(DataType.MultilineText)]
        public string Description
        {
            get; set;
        }

        public ICollection<CustomerCatModel> Customers
        {
            get; set;
        }
        #endregion
    }
}