using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishEducomics.Models
{
    public class Lesson
    {
        private Guid _id;

        private string _name;

        private string _content;

        private Guid _objectiveID;

        private Boolean _isComplete;


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

        public Boolean IsComplete
        {
            get
            {
                return _isComplete;
            }
            set
            {
                _isComplete = value;
            }
        }
    }
}
