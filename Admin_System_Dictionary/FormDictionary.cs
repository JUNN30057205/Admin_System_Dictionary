using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ID: 30057205
//Name: JUN SUMIDA
//C# Complex Data Structure: Assessment 3
namespace Admin_System_Dictionary
{
    public partial class FormDictionary : Form
    {
        public FormDictionary()
        {
            InitializeComponent();
            ReadMasterFile();
        }
        //Create a file for output TraceLog file.         
        TextWriterTraceListener traceListener = new TextWriterTraceListener();

        #region 4.1 & 4.2 Dictionary Data Structure and Read MasterFile
        /* 4.1. Create a Dictionary data structure with a TKey of type integer and a TValue of type string,
          name the new data structure “MasterFile”. */
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

        // 4.2.	Create a method that will read the data from the.csv file into the Dictionary data structure when the GUI loads.
        private void ReadMasterFile()
        {
            
            MasterFile.Clear();

            Trace.Listeners.Add(traceListener);
            Trace.WriteLine("---Dictionary TraceLog---");
            Trace.WriteLine("--Read MasterFile and Display--");

            string filePath = @"MalinStaffNamesV2.csv";            
            try
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                //Read CSV file from filePath and store in lines
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    //split data by comma and store in dicData
                    string[] dicData = line.Split(',');
                    int StaffID = int.Parse(dicData[0]);
                    string StaffName = dicData[1];
                    MasterFile.Add(StaffID, StaffName);                            
                }                   
                    
                DisplayAllData();
                ToolStripStatusLabel.Text = "Successfully Load the File.";
                
                stopWatch.Stop();
                Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
                Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
                Trace.WriteLine("-----------------------------");
            }
            catch
            {
                ToolStripStatusLabel.Text = "Error! File Cannot Read.";
            }
            //https://www.sejuku.net/blog/85579
            //https://sakai-kojiblog.com/csharp-csv-reader/
        }
        #endregion

        #region 4.3. Display the Dictionary data	
        //  Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
        private void DisplayAllData()
        {
            ListBox_AllStaff.Items.Clear();
            foreach (var dicData in MasterFile)
            {                
                ListBox_AllStaff.Items.Add(dicData);
            }            
        }

        private void Form_Dictionary_Load(object sender, EventArgs e)
        {
            DisplayAllData();            
        }
        #endregion

        #region 4.4 Filter Staff Name
        /*
        Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box. 
        This method must use a text box input and update as each character is entered. The list box must reflect the filtered data in real time.
        */
        private void FilterStaffName()
        {
            
            Trace.WriteLine("--Filter Staff Name--");
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            List<string> filteredList = new List<string>();            
            string staffNameTextBox = TextBox_StaffName.Text.ToLower();            
            foreach (var value in MasterFile)
            {                
                string staffName = value.Value.ToLower();                
                if (staffName.Contains(staffNameTextBox))
                {                    
                    filteredList.Add(value.ToString());
                }
            }
            ListBox_Filtered.DataSource = filteredList;

            stopWatch.Stop();
            Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
            Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
            Trace.WriteLine("-----------------------------");

        }
        private void TextBox_StaffName_TextChanged(object sender, EventArgs e)
        {
            FilterStaffName();
        }
        #endregion

        #region 4.5 Filter Staff ID
        /*
        Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box. 
        This method must use a text box input and update as each number is entered. The list box must reflect the filtered data in real time.
        */
        private void FilterStaffID()
        {
            Trace.WriteLine("--Filter Staff ID--");
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            List<string> filteredList = new List<string>();
            string staffIdTextBox = TextBox_StaffID.Text;
           
            foreach (var key in MasterFile)
            {               
                string staffId = key.Key.ToString();                
                if (staffId.Contains(staffIdTextBox))
                {                    
                    filteredList.Add(key.ToString());
                }
            }
            ListBox_Filtered.DataSource = filteredList;
            stopWatch.Stop();
            Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
            Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
            Trace.WriteLine("-----------------------------");

        }
        private void TextBox_StaffID_TextChanged(object sender, EventArgs e)
        {
            FilterStaffID();
        }
        //not allow except digits for staffID 
        private void TextBox_StaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 4.6 Cear and Focus: Staff Name
        /*
        Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box.
        Utilise a keyboard shortcut.
        */
        private void ClearFocusName()
        {
            TextBox_StaffName.Clear();
            TextBox_StaffName.Focus();
        }

        #endregion

        #region 4.7 Cear and Focus: Staff ID
        /*
        Create a method for the Staff ID text box which will clear the contents and place the focus into the text box. Utilise a keyboard shortcut.
        */
        private void ClearFocusID()
        {
            TextBox_StaffID.Clear();            
            TextBox_StaffID.Focus();
        }
        #endregion

        #region 4.8 Display Selected Staff
        /*
        Create a method for the filtered and selectable list box which will populate the two text boxes when a staff record is selected. 
        Utilise the Tab and keyboard keys.
        */
        private void ListBox_Filtered_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Trace.WriteLine("--Populate staff records into Textboxes--");
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try       
            {                       
                if (e.KeyCode == Keys.Enter)
                {
                    string selectedItem = ListBox_Filtered.SelectedItem.ToString();
                    string[] splits = selectedItem.Split(',');

                    //[0] = StaffID and [1] = StaffName and remove '[]'.
                    TextBox_StaffID.Text = splits[0].Trim('[');
                    TextBox_StaffName.Text = splits[1].Trim(']');

                    ToolStripStatusLabel.Text = "Displayed in the Textboxes";                    

                }
                stopWatch.Stop();
                Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
                Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
                Trace.WriteLine("-----------------------------");
            }
            catch
            {
                ToolStripStatusLabel.Text = "Enter TextBoxes and Choose Staff ID or Staff Name in the Filtered ListBox";
            }
            
        }
        #endregion

        #region 4.9 Open Admin Form
        /*
        Create a method that will open the Admin GUI when the Alt + A keys are pressed. 
        Ensure the General GUI sends the currently selected Staff ID and Staff Name to the Admin GUI for Update and Delete purposes and is opened as modal. 
        Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77 and the Staff Name is empty. 
        Read the appropriate criteria in the Admin GUI for further information.
        */
        private void OpenAdminGUI()
        {
            //if (selectedID == 77 && string.IsNullOrEmpty(selectedName)) {}

            string selectedID = TextBox_StaffID.Text;
            string selectedName = TextBox_StaffName.Text;
            try
            {
                Trace.WriteLine("--Open Admin Form with 77--");
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                // Check if the first two characters of ID are '77' and name is empty
                if (selectedID.StartsWith("77") && string.IsNullOrEmpty(selectedName))
                {
                    // Create an instance of AdminForm
                    AdminForm adminForm = new AdminForm(this, selectedID, selectedName);
                    // Open Admin form with selected values
                    adminForm.ShowDialog();
                    ToolStripStatusLabel.Text = "Open Admin Form";

                    stopWatch.Stop();
                    Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
                    Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
                    Trace.WriteLine("-----------------------------");
                }
                else
                {
                    Trace.WriteLine("--Open Admin Form with selected staffID and Name--");                    
                    stopWatch.Start();
                    // Check if both ID and name are not empty
                    if (!string.IsNullOrEmpty(selectedID) && !string.IsNullOrEmpty(selectedName))
                    {
                        // Create an instance of AdminForm
                        AdminForm adminForm = new AdminForm(this, selectedID, selectedName);
                        // Open Admin form with selected values
                        adminForm.ShowDialog();
                        ToolStripStatusLabel.Text = "Open Admin Form";

                        stopWatch.Stop();
                        Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
                        Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
                        Trace.WriteLine("-----------------------------");
                    }           
                }
            }
            catch
            {
                ToolStripStatusLabel.Text = "Error occured in Open Admin GUI!";
            }
            
            //if (!string.IsNullOrEmpty(TextBox_StaffID.Text))
            //{
            //    //int selectedID = int.Parse(TextBox_StaffID.Text);
            //    
            //    //Create instance of Admin Fomr
            //    AdminForm adminForm = new AdminForm(this, selectedID, selectedName);
            //    //Open Admin form with selected values
            //    adminForm.ShowDialog();
            //    ToolStripStatusLabel.Text = "Open Admin Form";

            //}
            //else
            //{
            //    //msg Enter StaffID or Select StaffID from filteredListBox
            //    ToolStripStatusLabel.Text = "Please Enter StaffID to Open Admin Form";
            //    TextBox_StaffID.Focus();
            //}

        }

        private void CloseDictionaryForm()
        {
           //Close the Dictionary form
            Close();
            Trace.WriteLine("Close TraceLog");
            Trace.WriteLine("");
            Trace.Close();
        }
        #endregion

        #region KeyBoard Control
        //*setup KeyPreview first!*
        private void Form_Dictionary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt)
            {
                switch (e.KeyCode)
                {
                    //S -> StaffName clear and focus
                    case Keys.S: 
                        ClearFocusName();
                        break;

                    //K -> StaffKey clear and focus
                    case Keys.K: 
                        ClearFocusID();                        
                        break;

                    //A -> Open AdminGUI
                    case Keys.A: 
                        OpenAdminGUI();
                        break;

                    //L -> Close General Form GUI
                    case Keys.Z: 
                        CloseDictionaryForm();
                        break;
                }
            }
        }
        
        #endregion


                
    }
}
