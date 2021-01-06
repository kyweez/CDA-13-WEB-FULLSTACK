using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Job
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

        public string Title
        {
            get; private set;
        }

        public DateTime Start
        {
            get; private set;
        }

        public DateTime End
        {
            get; private set;
        }

        public string Description
        {
            get; private set;
        }
        #endregion
    }
}
