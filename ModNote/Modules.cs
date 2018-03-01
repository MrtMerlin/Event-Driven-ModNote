/*
Student Name: Martin Lewis      Student Number: 014096

Program Synopsis: This is a windows form application, that has been developed for note taking, the user will 
be able to read already prepared .txt files into the application, also they will be able to create new modules
and be able to save the modules details.

*/

// using librarys.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using System.ComponentModel;
using System.IO;

namespace ModNote
{
    public class Modules // modules class constructor.
    {
        // variables.
        private string  code;
        private string  title;
        private string  syno;
        private string  lo;
        private string  assign;
        private string  notes;
        private string  exp;

        // get set statements for each of the above variables.
        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Syno
        {
            get
            {
                return syno;
            }

            set
            {
                syno = value;
            }
        }

        public string Lo
        {
            get
            {
                return lo;
            }

            set
            {
                lo = value;
            }
        }

        public string Assign
        {
            get
            {
                return assign;
            }

            set
            {
                assign = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }

        public string Exp
        {
            get
            {
                return exp;
            }

            set
            {
                exp = value;
            }
        }
    }
}
