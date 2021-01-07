using System;
using System.ComponentModel.DataAnnotations;

namespace FreeLancerWebSite.Models
{
    public class Quote
    {
        #region ############### PROPERTIES ###############
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
