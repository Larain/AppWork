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
using System.Xml.Serialization;
using WorkingLib;


namespace WorkingGUI
{
    public partial class MainForm : Form
    {
        List<Human> users;
        static Human currentUser;
        int currentIndex = 0; // Index of choosen human from list;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSetName_Click(object sender, EventArgs e)
        {
            if (this.Text == "")
                MessageBox.Show("Enter value", "Empty");
            else
            {
                currentUser.Name = textBoxName.Text;
            }
        }

        private void buttonSetYear_Click(object sender, EventArgs e)
        {
            if (this.Text == "")
                MessageBox.Show("Enter value", "Empty");
            else
            {
                try
                {
                    int year = Convert.ToInt16(textBoxYear.Text);
                    currentUser.Age = (Bank.GetAge(year)); // Calculating of age based on date of birth;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Year is not valid", "Check value");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
        //
        // Calculation billing rate;
        //
        private void buttonCalc_Click(object sender, EventArgs e) 
        {
            currentUser.Tariff = Bank.Billing(currentUser.Age);
            richTextBoxOutput.Text += currentUser.ToString() + "\n";
        }
        //
        // Navigation
        //
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (users == null)
                MessageBox.Show("Load data first");
            else
            {
                currentIndex++;
                if (currentIndex >= users.Count)
                    currentIndex = 0;
                UpdateInfo();
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (users == null)
                MessageBox.Show("Load data first");
            else
            {
                currentIndex--;
                if (currentIndex <= 0)
                    currentIndex = users.Count - 1;
                UpdateInfo();
            }
        }
        //
        // Serialization methods
        //
        static public void XMLSerialization(List<Human> list)
        {
            Human[] arr = new Human[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                arr[i] = list[i];
            }
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\..\"));
            string reslutPath = newPath + "\\WorkingGUI\\WorkingGUI\\bin\\Debug\\SerializedData.xml";
            StreamWriter swriter = new StreamWriter(reslutPath);
            XmlSerializer serializer = new XmlSerializer(typeof(Human[]));
            serializer.Serialize(swriter, arr);
            swriter.Close();
        }
        static public List<Human> XMLDeserialization()
        {
            List<Human> result = new List<Human>();
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\..\"));
            string reslutPath = newPath + "\\WorkingGUI\\WorkingGUI\\bin\\Debug\\SerializedData.xml";
            Stream sreader = new FileStream(reslutPath, FileMode.Open, FileAccess.Read);

            XmlSerializer deserializer = new XmlSerializer(typeof(Human[]));
            Human[] list = (Human[])deserializer.Deserialize(sreader);

            for (int i = 0; i < list.Length; i++)
            {
                result.Add(list[i]);
            }

            sreader.Close();

            return result;
        }
        //
        // Load data from XML file  
        // located in project directory bin/debug
        // called 'SerializedData.xml'
        //
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            users = XMLDeserialization();
            UpdateInfo();
        }
        //
        // Wirte and save data to XML file
        // located in project directory bin/debug
        // called 'SerializedData.xml'
        //
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (users == null)
                MessageBox.Show("Load data first");
            else
            {
                XMLSerialization(users);
            }
        }
        //
        // Method that update info in GUI about current user;
        //
        private void UpdateInfo()
        {
            currentUser = users[currentIndex];
            textBoxName.Text = currentUser.Name;
            textBoxYear.Text = (DateTime.Now.Year - currentUser.Age) + "";
            textBoxState.Text = currentIndex + 1 + " of " + users.Count;
        }
    }
}
