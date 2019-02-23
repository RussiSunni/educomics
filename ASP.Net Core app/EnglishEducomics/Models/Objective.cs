using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishEducomics.Models
{
    public class Objective
    {
        private Guid _id;

        private string _name;

        private Guid _courseID;

        private Boolean _isMastered;


        public Guid ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Boolean IsMastered
        {
            get
            {
                return _isMastered;
            }
            set
            {
                _isMastered = value;
            }
        }

        public Guid CourseID
        {
            get
            {
                return _courseID;
            }
            set
            {
                _courseID = value;
            }
        }
    }
}
