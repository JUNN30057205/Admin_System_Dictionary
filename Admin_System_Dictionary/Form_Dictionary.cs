using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Form_Dictionary : Form
    {
        public Form_Dictionary()
        {
            InitializeComponent();
            ReadMasterFile();
        }
        // 4.1.	Create a Dictionary data structure with a TKey of type integer and a TValue of type string,
        // name the new data structure “MasterFile”.
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

        // 4.2.	Create a method that will read the data from the.csv file into the Dictionary data structure when the GUI loads.
        private void ReadMasterFile()
        {
            
            MasterFile.Clear();
            
            string filePath = @"MalinStaffNamesV2.csv";            
            try
            {
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

            }
            catch
            {
                ToolStripStatusLabel.Text = "Error! File Cannot Read.";
            }
            //https://www.sejuku.net/blog/85579
            //https://sakai-kojiblog.com/csharp-csv-reader/
        }

        //4.3.	Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
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

        //
    }
}
