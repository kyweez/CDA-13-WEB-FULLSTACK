using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Quote
    {
        #region ############### PROPERTIES ###############
        public int Id
        {
            get; private set;
        }

        public string State
        {
            get; private set;
        }

        public DateTime Date
        {
            get; private set;
        }

        public int Amount
        {
            get; private set;
        }

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
