using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebSite.Models
{
    [Table("customer_cats")]
    public class CustomerCat
    {
        #region ############### PROPERTIES ###############
        [Key]
        [Column("cat_id")]
        [ForeignKey("FK_cat_id")]
        public int ID
        {
            get; set;
        }

        [StringLength()]
        public string Name
        {
            get; set;
        }

        []
        public string Description
        {
            get; set;
        }
        #endregion
    }
}