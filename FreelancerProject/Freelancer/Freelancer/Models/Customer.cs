using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Customer
    {
        #region ############### PROPERTIES ###############
        public int Id
        {
            get; private set;
        }

        public string Name
        {
            get; private set;
        }

        public string Email
        {
            get; private set;
        }
        #endregion
    }
}
