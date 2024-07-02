using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class ContactsBook : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;

        public ContactsBook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone Number");
            contacts.Columns.Add("Email");

            //set data
            contactsDataGrid.DataSource = contacts;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            firstNameTextbox.Text = "";
            lastNameTextbox.Text = "";
            phoneNumberTextbox.Text = "";
            emailTextbox.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            firstNameTextbox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameTextbox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneNumberTextbox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailTextbox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["First Name"] = firstNameTextbox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Last Name"] = lastNameTextbox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Phone Number"] = phoneNumberTextbox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Email"] = emailTextbox.Text;
            }
            else
            {
                contacts.Rows.Add(firstNameTextbox.Text, lastNameTextbox.Text, phoneNumberTextbox.Text, emailTextbox.Text);
            }
            firstNameTextbox.Text = "";
            lastNameTextbox.Text = "";
            phoneNumberTextbox.Text = "";
            emailTextbox.Text = "";
            editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not Valid");
            }
        }

        private void contactDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            firstNameTextbox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastNameTextbox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            phoneNumberTextbox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailTextbox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }
    }
}
