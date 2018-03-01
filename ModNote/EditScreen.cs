/*
Student Name: Martin Lewis      Student Number: 014096

Program Synopsis: This is a windows form application, that has been developed for note taking, the user will 
be able to read already prepared .txt files into the application, also they will be able to create new modules
and be able to save the modules details.

*/

// EditScreen class

// using librarys.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModNote
{

    public partial class EditScreen : Form // constructor for editScreen class
    {
        // initializes editscreen.
        public EditScreen()
        {
            InitializeComponent();
        }

        // creates instances of where to store data on the editScreen.
        public EditScreen(string editCode, string editTitle, string editSyno, string editLo, string editAssign, string editNote, string editExp) // constructor.
        {
            InitializeComponent();
            // variables.
            code.Text       =   editCode;
            title.Text      =   editTitle;
            syno.Text       =   editSyno;
            lo.Text         =   editLo;
            assign.Text     =   editAssign;
            notes.Text      =   editNote;
            expDates.Text   =   editExp;
        }
        
        public string codeGetInfo() // get code information method.
        {
            return code.Text;
        } 

        public string titleGetInfo() // get title informaiton method
        {
            return title.Text;
        }

        public string synoGetInfo() // get synopsis information method.
        {
            return syno.Text;
        }

        public string loGetInfo() // get learning out comes information method.
        {
            return lo.Text;
        }

        public string assignGetInfo() // get assignment dates information method.
        {
            return assign.Text;
        }

        public string notesGetInfo() // get notes information method.
        {
            return notes.Text;
        }

        public string expGetInfo() // get expiry date information method.
        {
            return expDates.Text;
        }
        

        private void addButtonComp_Click(object sender, EventArgs e) // add button, when this is clicked this will add any details that have been added to the module information.
        {
            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        // reset button resets all of the information within the edit module screen.
        private void resetButton_Click(object sender, EventArgs e)
        {
            code.Text     =   string.Empty;
            title.Text    =   string.Empty;
            syno.Text     =   string.Empty;
            lo.Text       =   string.Empty;
            assign.Text   =   string.Empty;
            expDates.Text =   string.Empty;
        }

        // close button for edit screen.
        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you wish to close edit form?", "Close Edit Screen", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.OK)
                Close();
        }
    }
}
