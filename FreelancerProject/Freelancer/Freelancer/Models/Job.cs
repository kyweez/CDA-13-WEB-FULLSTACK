using System;
using System.ComponentModel.DataAnnotations;

namespace Freelancer.Models
{
    public class Job
    {
        /// <summary>
        /// [DataType(DataType.Date)]: The [DataType] attribute specifies the type of the data (Date). With this attribute:
        /// The user isn't required to enter time information in the date field.
        /// Only the date is displayed, not time information.
        /// </summary>
        [DataType(DataType.Date)]

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