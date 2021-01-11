﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeLancerWebSite.Models
{
    [Table("quotes")]
    public class QuoteModel
    {
        #region ############### PROPERTIES ###############
        [Key]
        [Column("quote_id", Order = 1)]
        public int ID
        {
            get; private set;
        }

        [Column("quote_state", TypeName = "char(10)", Order = 2)]
        [Required]
        public string State
        {
            get; private set;
        }

        [Column("quote_date", Order = 3)]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date
        {
            get; private set;
        }

        [Column("quote_amount", Order = 4)]
        [Required]
        public int Amount
        {
            get; private set;
        }

        [Column("quote_final_date", Order = 5)]
        [DataType(DataType.Date)]
        public DateTime FinalDate
        {
            get; private set;
        }

        [Column("quote_final_amount", Order = 6)]
        public int FinalAmount
        {
            get; private set;
        }
        #endregion
    }
}