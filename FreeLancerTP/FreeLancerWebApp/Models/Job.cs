using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebApp.Models
{
    [Table("jobs")]
    public class Job
    {
        [Key]
        [Column("job_id", Order = 1)]
        public int ID
        {
            get; private set;
        }

        [Column("job_state", TypeName = "char(10)", Order = 2)]
        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Etat du travail")]
        public string State
        {
            get; private set;
        }

        [Column("job_title", Order = 3)]
        [Required(ErrorMessage = "Champs obligatoire")]
        [StringLength(100, ErrorMessage = "Longueur maximum : 100")]
        [Display(Name = "Nom du travail")]
        public string Title
        {
            get; private set;
        }

        [Column("job_start", Order = 4)]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date de début du travail")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Start
        {
            get; private set;
        }

        [Column("job_end", Order = 5)]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date de fin du travail")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
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

        public ICollection<Quote> Quotes
        {
            get; set;
        }

        // Foreign Key
        [ForeignKey("FK_customer_in_job")]
        [Column("customer_id", Order = 7)]
        public int CustomerID
        {
            get; set;
        }
        public Customer Customer
        {
            get; set;
        }
    }
}