using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishEducomics.Models
{
    public class Question
    {
        private Guid _id;

        private Guid _objectiveID;

        private string _content;

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

        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
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

        public Guid ObjectiveID
        {
            get
            {
                return _objectiveID;
            }
            set
            {
                _objectiveID = value;
            }
        }
    }
}
