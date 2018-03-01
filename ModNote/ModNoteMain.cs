/*
Student Name: Martin Lewis      Student Number: 014096

Program Synopsis: This is a windows form application, that has been developed for note taking, the user will 
be able to read already prepared .txt files into the application, also they will be able to create new modules
and be able to save the modules details.

*/

// ModNoteMain class

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
using System.IO;

namespace ModNote // namespace for the program.
{
    
    public partial class ModNoteMain : Form // constructor for ModNoteMain Class.
    {
        // lists for storing modules
        public static  List<Modules> modulesList    = new List<Modules>(); // moduleList created
        private static BindingList<Modules> modules = new BindingList<Modules>(modulesList); // binding list in modules class to modules in moduleslist
        private        BindingSource modInfoSource  = new BindingSource(modules, null); // binding data in datagrid modInfoGrid from modules.

        // variables for loading.
        int loadInCounter = 0; 

        // ModNoteMain initializes the program.
        public ModNoteMain()
        {
                InitializeComponent();         
        }

        // loads data grid for use within the program.
        private void ModNoteMain_Load(object sender, EventArgs e)
        {
            //attach the binding to the datagrid.
                modInfoGrid.DataSource = modInfoSource;
        }

        // saving modules in the moduleList into an xml file using the .net serializer.
        public void ModuleWrite()
        {
            // uses System.IO.TextWriter to record details to lists.
            System.IO.TextWriter adding = null;
            try
            {
                // serailizes data to be saved in xml file Modules.xml. 
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Modules>));
                adding = new System.IO.StreamWriter("Modules.xml", false);
                serializer.Serialize(adding, modulesList);
            }
            finally
            {
                if (adding != null)
                    adding.Close();
            }
        }
        
        // read modules from the moduleList from an xml file using .net serializer.
        public List<Modules> modulesRead()
        {
            // uses System.IO.TextReader to read data from lists.
            System.IO.TextReader reader = null;
            modulesList.Clear();

            try
            {
                // serializes data from the modules and allows data to be read.
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Modules>));
                reader = new System.IO.StreamReader("Modules.xml");
                return (List<Modules>)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        
        // refresh button refreshes the datagrid within modnote main.
        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                // reads data from module list using the modulesRead method.
                modulesList = modulesRead();

                // binds data from the modules to the modulesList.
                modules = new BindingList<Modules>(modulesList);
                modInfoSource = new BindingSource(modules, null);
                modInfoGrid.DataSource = modInfoSource;
                // changes the colour of the exp coloumn of the data grid.
                modInfoGrid.Columns["Exp"].DefaultCellStyle.ForeColor = Color.Red;
                // refreshes the above information into the datagrid.
                modInfoGrid.Refresh();
            } 
            catch (Exception error)
            {
                MessageBox.Show("An error has occurred." + error);
            }
        }

        // double click on datagrid method.
        private void modInfoGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // if a box in grid is clicked then opens specific edit module screen.
                if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType == typeof(string))
                {
                    EditScreen editForm = new EditScreen(((DataGridView)sender).Rows[e.RowIndex].Cells[0].FormattedValue.ToString(),
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[1].FormattedValue.ToString(),
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[2].FormattedValue.ToString(),
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[3].FormattedValue.ToString(),
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[4].FormattedValue.ToString(),
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[5].FormattedValue.ToString(),
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[6].FormattedValue.ToString()
                        );

                    editForm.ShowDialog();

                    if (editForm.DialogResult == DialogResult.OK)
                    {
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value = editForm.codeGetInfo();
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value = editForm.titleGetInfo();
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value = editForm.synoGetInfo();
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value = editForm.loGetInfo();
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[4].Value = editForm.assignGetInfo();
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[5].Value = editForm.notesGetInfo();
                        ((DataGridView)sender).Rows[e.RowIndex].Cells[6].Value = editForm.expGetInfo();
                    }



                    editForm.Close();
                }
            } catch (Exception error)
            {
                MessageBox.Show("An error has occurred." + error);
            }
        }

        // import text call readFilesIn method.
        private void importTextMod_Click(object sender, EventArgs e) // button and method for calling all files from modules in root folder of program.
        {
            readFilesIn();
        }

        // reading in files from .txt files.
        public void readFilesIn ()
        {
            if (loadInCounter != 1)
            {
                // so files are not duplicated within the lists.
                loadInCounter++;
                // calling .txt files to string array.
                string[] modFilesFolder = Directory.GetFiles(@"../../../Modules", "*.txt");

                // reading each .txt file in singularly
                foreach (var file in modFilesFolder)
                {
                    // newMod to record new module detail to.
                    Modules newMod = new Modules();
                    // writing each file in line by line.
                    string[] modLine = File.ReadAllLines(file);
                    for (int line = 0; line < modLine.Length; line++)
                    {
                        // line contains CODE save following line.
                        if (modLine[line].Contains("CODE"))
                        {
                            // line after to Code for newMod.
                            newMod.Code = modLine[line + 1];
                            //iterate to next line.
                            line++;
                        }

                        //  line contains TITLE save following line.
                        if (modLine[line].Contains("TITLE"))
                        {
                            // line after to Title for newMod.
                            newMod.Title = modLine[line + 1];
                            // iterate to next line.
                            line++;
                        }

                        // line contains SYNO save following line.
                        if (modLine[line].Contains("SYNO"))
                        {
                            // line after to Syno for newMod.
                            newMod.Syno = modLine[line + 1];
                            //iterate to next line.
                            line++;
                        }

                        // line contains LO iterate lines to no longer LO and store LO details.
                        if (modLine[line].Contains("L") && modLine[line].Contains("O"))
                        {
                            // line contains LO will add a new line and read the next line to see if same state.
                            newMod.Lo += modLine[line + 1] + "\n";
                        }

                        if (/*modLine[line].Contains("ASSIGNMENT") || */modLine[line].Contains("Assignment") || modLine[line].Contains("In-Class Test"))
                        {
                            //newMod.Assign += modLine[line] + "\n";
                            // creates char array for assignment date information
                            char[] saveDate = modLine[line].ToCharArray();
                            // creates a blank holder for found dates.
                            string newDateHolder = string.Empty;
                            // iterates through the following line
                            newMod.Assign += modLine[line] + Environment.NewLine;
                            // for statement to go through line and find dates.

                            // for statement, every string within the removes none numerical data from strings.
                            for (int dates = 0; dates < saveDate.Length; dates++)
                            {
                                // using ascii keys this will remove any none number characters including special characters.
                                if (saveDate[dates] > 47 && saveDate[dates] < 57)
                                {
                                    newDateHolder += saveDate[dates];
                                }
                                // adds the backslash back into the date once all other characters have been removed.
                                if (newDateHolder.Length == 2 || newDateHolder.Length == 5)
                                {
                                    newDateHolder += "/";
                                }
                            }

                            // iterate through dates for assignment due dates, to mods.
                            newMod.Assign += " ";

                            // parse dates to DateTime.
                            DateTime dateChecker = DateTime.Parse(newDateHolder, new System.Globalization.CultureInfo("en-GB", false));

                            // date checker to check date of assignement due against current date.
                            if (dateChecker < DateTime.Now)
                            {
                                newMod.Exp += dateChecker + "This assignment is Overdue \n";
                                modInfoGrid.Columns["Exp"].DefaultCellStyle.ForeColor = Color.Red;
                            }

                            //newMod.Assign += newDateHolder;
                            //newMod.Exp += DateTime.Parse(modLine[line]);
                        }
                    }
                    // add mods to module lists.
                    modules.Add(newMod);
                }

            }
       }

        // save method called when button clicked, by calling the ModuleWrite method.
        private void saveModButton_Click(object sender, EventArgs e)
        {
            // ModuleWrite Method called.
            ModuleWrite();
        }

        // delete button method called when clicked.
        private void delMod_Click(object sender, EventArgs e)
        {
            // if a row within the dataGrid is selected 
            if (this.modInfoGrid.SelectedRows.Count > 0)
            {
                // removes the selected at row point.
                modInfoGrid.Rows.RemoveAt(this.modInfoGrid.SelectedRows[0].Index);
            }
        }

        // exit program method button.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // dialog box opens when button is clicked, displaying the text below and showing clickable buttons to cancel or accept 
            // closing program.
            DialogResult d = MessageBox.Show("Are you Sure you wish to quit?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.OK)
                // calls close method.
               Close();
                     
        }
    }
}
