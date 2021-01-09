using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebSite.Models
{
    [Table("quotes")]
    public class Quote
    {
        #region ############### PROPERTIES ###############
        [Key]
        [Column("quote_id")]
        public int ID
        {
            get; private set;
        }

        public string State
        {
            get; private set;
        }

        [DataType(DataType.Date)]
        public DateTime Date
        {
            get; private set;
        }

        public int Amount
        {
            get; private set;
        }

        [DataType(DataType.Date)]
        public DateTime FinalDate
        {
            get; private set;
        }

        public int FinalAmount
        {
            get; private set;
        }
        #endregion
    }
}
