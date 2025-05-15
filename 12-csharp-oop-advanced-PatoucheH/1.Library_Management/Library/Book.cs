using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string _title;
        public string _author;
        public string _genre;
        public bool IsBorrowed = false;

        public string Title
        {
            get => _title;

            set
            {
                _title = value;
            }

        }
        public string Author
        {
            get => _author;
            set
            {
                _author = value;
            }
        }

        public string Genre
        {
            get => _genre;
            set
            {
                _genre = value;
            }
        }

        public string Borrow()
        {
            if(IsBorrowed)
            {
                return $"{Title} is already borrowed.";
            }
            else
            {
                IsBorrowed = true;
                return $"{Title} has been borrowed.";

            }
        }

        public string ReturnBook()
        {
            if(IsBorrowed)
            {
                IsBorrowed = false;
                return $"{Title} has been succesfully returned.";
            }
            else
            {
                return "Nothing to return .";
            }
        }


    }
}
