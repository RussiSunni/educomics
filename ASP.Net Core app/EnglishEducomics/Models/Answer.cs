using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishEducomics.Models
{
    public class Answer
    {
        private Guid _id;

        private Guid _questionID;

        private Boolean _isCorrectOption;

        private string _content;


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

        public Boolean IsCorrectOption
        {
            get
            {
                return _isCorrectOption;
            }
            set
            {
                _isCorrectOption = value;
            }
        }

        public Guid QuestionID
        {
            get
            {
                return _questionID;
            }
            set
            {
                _questionID = value;
            }
        }
    }
}
