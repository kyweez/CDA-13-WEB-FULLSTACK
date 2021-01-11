using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebSite.Models
{
    [Table("jobs")]
    public class JobModel
    {
        #region ############### PROPERTIES ###############
        [Key]
        [Column("job_id", Order = 1)]
        public int ID
        {
            get; private set;
        }

        [Column("job_state", TypeName = "char(10)", Order = 2)]
        [Required]
        public string State
        {
            get; private set;
        }

        [Column("job_title", Order = 3)]
        [Required]
        [StringLength(100)]
        public string Title
        {
            get; private set;
        }

        [Column("job_start", Order = 4)]
        [DataType(DataType.DateTime)]
        public DateTime Start
        {
            get; private set;
        }

        [Column("job_end", Order = 5)]
        [DataType(DataType.DateTime)]
        public DateTime End
        {
            get; private set;
        }

        [Column("job_description", Order = 6)]
        [DataType(DataType.MultilineText)]
        public string Description
        {
            get; private set;
        }
        #endregion
    }
}