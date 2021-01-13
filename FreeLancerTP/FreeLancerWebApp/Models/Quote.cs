using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebApp.Models
{
    [Table("quotes")]
    public class Quote
    {
        [Key]
        [Column("quote_id", Order = 1)]
        public int ID
        {
            get; private set;
        }

        [Column("quote_state", TypeName = "char(10)", Order = 2)]
        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Etat du devis")]
        public string State
        {
            get; private set;
        }

        [Column("quote_date", Order = 3)]
        [Required(ErrorMessage = "Champs obligatoire")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date du devis")]
        public DateTime Date
        {
            get; private set;
        }

        [Column("quote_amount", Order = 4)]
        [Required(ErrorMessage = "Champs obligatoire")]
        [Display(Name = "Montant du devis")]
        public int Amount
        {
            get; private set;
        }

        [Column("quote_final_date", Order = 5)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date d'acceptation du devis")]
        public DateTime FinalDate
        {
            get; private set;
        }

        [Column("quote_final_amount", Order = 6)]
        [Display(Name = "Montant final")]
        public int FinalAmount
        {
            get; private set;
        }

        // Foreign Key
        [ForeignKey("FK_job_in_quote")]
        [Column("job_id", Order = 7)]
        public int JobID
        {
            get; set;
        }
        public Job Job
        {
            get; set;
        }
    }
}
