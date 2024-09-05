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
    public partial class AddNewContactWindow : Form
    {

        private DataTable _contactsDataTable;

        public AddNewContactWindow(DataTable contactsDataTable)
        {
            InitializeComponent();
            _contactsDataTable = contactsDataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contactsFirstName = contactsFirstNameField.Text;
            string contactsLastName = contactsLastNameField.Text;
            string contactsPhoneNumber = contactsPhoneNumberField.Text;

            _contactsDataTable.Rows.Add(contactsFirstName, contactsLastName, contactsPhoneNumber);

            this.Close();
        }

        private void contactsFirstNameField_Enter(object sender, EventArgs e)
        {
            if (contactsFirstNameField.Text == "e.g Amirhossein...") contactsFirstNameField.Text = "";
        }

        private void contactsFirstNameField_Leave(object sender, EventArgs e)
        {
            if (contactsFirstNameField.Text == "") contactsFirstNameField.Text = "e.g Amirhossein...";

        }

        private void contactsLastNameField_Enter(object sender, EventArgs e)
        {
            if (contactsLastNameField.Text == "e.g Gholizadeh...") contactsLastNameField.Text = "";
        }

        private void contactsLastNameField_Leave(object sender, EventArgs e)
        {
            if (contactsLastNameField.Text == "") contactsLastNameField.Text = "e.g Gholizadeh...";
        }

        private void contactsPhoneNumberField_Enter(object sender, EventArgs e)
        {
            if (contactsPhoneNumberField.Text == "e.g 093123456789...") contactsPhoneNumberField.Text = "";
        }

        private void contactsPhoneNumberField_Leave(object sender, EventArgs e)
        {
            if (contactsPhoneNumberField.Text == "") contactsPhoneNumberField.Text = "e.g 093123456789...";
        }
    }
}
