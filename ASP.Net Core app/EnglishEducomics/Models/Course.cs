using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishEducomics.Models
{
    public class Course
    {
        private Guid _id;

        private string _name;

        private string _syllabus;



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


        public string Syllabus
        {
            get
            {
                return _syllabus;
            }
            set
            {
                _syllabus = value;
            }
        }
    }
}
