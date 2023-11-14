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

namespace Admin_System_Dictionary
{
    public partial class AdminForm : Form
    {
        //instance of FormDictionary
        private FormDictionary formDictionary;

        TextWriterTraceListener traceListener = new TextWriterTraceListener(); 

        public AdminForm(FormDictionary formDictionary, string selectedID, string selectedName)
        {
            InitializeComponent();
            this.formDictionary = formDictionary;
            PopulateSelectedData(selectedID, selectedName);     
        }

        #region 5.2. 	
        //Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
        private void PopulateSelectedData(string staffID, string staffName)
        {
            TextBox_StaffID.ReadOnly = true;
            TextBox_StaffID.Text = staffID.ToString();
            TextBox_StaffName.Text = staffName; 

            if(staffID.StartsWith("77") && string.IsNullOrEmpty(staffName))
            {
                TextBox_StaffID.ReadOnly = false;
                int newStaffID = GenerateUniqueID();
                TextBox_StaffID.Text = newStaffID.ToString();
                TextBox_StaffID.ReadOnly = true;
                toolStripStatusLabel.Text = "UniqueID Created in the StaffID Textbox";
            }
            else
            {
                toolStripStatusLabel.Text = "Display the data from Main Form";
            }
        }
        #endregion

        #region 5.3.	
        /*Create a method that will create a new Staff ID and input the staff name from the related text box. 
          The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated. 
          The new staff member must be added to the Dictionary data structure.*/
        private int GenerateUniqueID()
        {
            Random random = new Random();
            //int UnitqueID = 77 + random.Next(10000000, 999999999);
            int uniqueID = 770000000 + random.Next(0, 9999999);

            //check dupulicate ID is exist in the dictionary and generate NewID(UniqueID)
            while (FormDictionary.MasterFile.ContainsKey(uniqueID))
            {
                uniqueID = 770000000 + random.Next(0, 9999999);                
            }
            return uniqueID;          

        }
        private void CreateNewStaffID()
        {
            try
            {
                Trace.Listeners.Add(traceListener);
                Trace.WriteLine("");
                Trace.WriteLine("---Admin Form TraceLog---");
                Trace.WriteLine("--Create New Staff ID--");
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                if (!string.IsNullOrEmpty(TextBox_StaffName.Text))
                {
                    //int newStaffID = GenerateUniqueID();
                    //TextBox_StaffID.Text = newStaffID.ToString();

                    int newStaffID = int.Parse(TextBox_StaffID.Text);
                    //Add New Staff member to the Dictionary data structure
                    string staffName = TextBox_StaffName.Text;
                    FormDictionary.MasterFile.Add(newStaffID, staffName);

                    toolStripStatusLabel.Text = "Created New Staff and Added to MasterFile";
                    TextBox_StaffID.Clear();
                    TextBox_StaffName.Clear();

                    stopWatch.Stop();
                    Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
                    Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
                    Trace.WriteLine("-----------------------------");
                }
                else
                {
                    toolStripStatusLabel.Text = "Enter New Staff Name";
                }

            }
            catch
            {
                toolStripStatusLabel.Text = "Error occurred";
            }

        }

        #endregion

        #region 5.4.	
        //Create a method that will Update the name of the current Staff ID.
        private void UpdateStaffName()
        {
            try
            {
                int staffID = int.Parse(TextBox_StaffID.Text);
                string newStaffName = TextBox_StaffName.Text;

                Trace.WriteLine("--Updated Staff Records--");
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                //check if the StaffID exists in the dictionary
                //if(FormDictionary.MasterFile.ContainsKey(staffID))

                //check staff name is not null
                if (!string.IsNullOrEmpty(newStaffName))
                {
                    //Update the name for the given StaffID and remove the whitespace when updating the Name
                    FormDictionary.MasterFile[staffID] = newStaffName.TrimStart();
                    toolStripStatusLabel.Text = "Updated Staff Name in the Master File";
                    TextBox_StaffID.Clear();
                    TextBox_StaffName.Clear();

                    stopWatch.Stop();
                    Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
                    Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
                    Trace.WriteLine("-----------------------------");

                }
                else
                {
                    toolStripStatusLabel.Text = "Cannot Update Staff Name";
                }
            }
            catch
            {
                toolStripStatusLabel.Text = "An error occurred while updating the Staff Name";
            }
            
        }
        #endregion

        #region 5.5.	
        //Create a method that will Remove the current Staff ID and clear the text boxes.
        private void DeleteStaffRecords()
        {
            int StaffID = int.Parse(TextBox_StaffID.Text);

            Trace.WriteLine("--Deleted Staff Records--");
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            //if(FormDictionary.MasterFile.ContainsKey(StaffID))
            if (!string.IsNullOrEmpty(TextBox_StaffName.Text))             {   

                FormDictionary.MasterFile.Remove(StaffID);
                //message" Delted Staff Data"
                toolStripStatusLabel.Text = "Deleted Staff records in the Master File";

                TextBox_StaffID.Clear();
                TextBox_StaffName.Clear();

                stopWatch.Stop();
                Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
                Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
                Trace.WriteLine("-----------------------------");

            }
            else
            {
                toolStripStatusLabel.Text = "Cannot Delete the Staff ID";
            }
        }
        #endregion

        #region 5.6.	
        //Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
        private void SaveMasterFile()
        {
            string filePath = @"MalinStaffNamesV2.csv";
            Trace.WriteLine("--Save and Close Staff Records--");
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try
            {
                //using StreamWriter to write changes to CSV
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    //writer.WriteLine("StaffID, StaffName");

                    //write data into dictionary
                    foreach (var kvp in FormDictionary.MasterFile)
                    {
                        writer.WriteLine($"{kvp.Key},{kvp.Value}");
                    }
                }

                TextBox_StaffID.Clear();
                TextBox_StaffName.Clear();

                stopWatch.Stop();
                Trace.WriteLine($"Elapsed time in ticks: {stopWatch.ElapsedTicks}");
                Trace.WriteLine($"Elapsed time in milliseconds: {stopWatch.ElapsedMilliseconds}");
                Trace.WriteLine("-----------------------------");

            }
            catch
            {
                toolStripStatusLabel.Text = "Error! File Cannot Save the File.";
            }
            
        }
        #endregion

        #region 5.7.	
        //Create a method that will close the Admin GUI when the Alt + L keys are pressed.
        private void CloseAdminForm()
        {
            SaveMasterFile();
            Close();
            formDictionary.Refresh();
        }
        #endregion

        #region 5.8.	
        /* Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience. 
           Make all methods private and ensure the Dictionary is updated. */
        
        #endregion

        #region Keyboard Control

        #endregion

        private void AdminForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt)
            {
                switch (e.KeyCode)
                {
                    //C -> Create New Staff Data
                    case Keys.C:
                        CreateNewStaffID();
                        break;

                    //U -> Update Staff Data
                    case Keys.U:
                        UpdateStaffName();
                        break;

                    //R -> Remove Staff Data
                    case Keys.R:
                        DeleteStaffRecords();
                        break;                    

                    //L -> Close Admin GUI
                    case Keys.L:                        
                        CloseAdminForm();                        
                        break;
                }
            }
        }


    }
}
