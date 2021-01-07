using System;
using System.ComponentModel.DataAnnotations;

namespace FreeLancerWebSite.Models
{
    public class Job
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

        public string Title
        {
            get; private set;
        }

        [DataType(DataType.Date)]
        public DateTime Start
        {
            get; private set;
        }

        [DataType(DataType.Date)]
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