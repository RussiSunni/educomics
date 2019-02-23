using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishEducomics.Models
{
    public class User
    {
        private Guid _id;

        private string _name;

        private int _initialLevel;

        private string _email;

        private DateTime _dateJoined;


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


        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }


        public int InitialLevel
        {
            get
            {
                return _initialLevel;
            }
            set
            {
                _initialLevel = value;
            }
        }


        public DateTime DateJoined
        {
            get
            {
                return _dateJoined;
            }
            set
            {
                _dateJoined = value;
            }
        }


    }
}
