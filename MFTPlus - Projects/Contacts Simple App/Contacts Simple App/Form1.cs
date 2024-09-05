using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_Simple_App
{
    public partial class Form1 : Form
    {

        DataTable contactsDataTable = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddNewContactWindow addNewContact = new AddNewContactWindow(contactsDataTable);
            addNewContact.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contactsDataTable.Columns.Add("FirstName");
            contactsDataTable.Columns.Add("LastName");
            contactsDataTable.Columns.Add("PhoneNumber");
            contactsDataGrid.DataSource = contactsDataTable;
        }
    }
}
