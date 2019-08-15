using SqliteDemoLibrary;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteDemoUI
{
    public partial class peopleForm : Form
    {

        private List<PersonModel> peopleList = new List<PersonModel>();

        public peopleForm()
        {
            InitializeComponent();
            LoadPeopleList();
            CheckForUpdates();
        }

        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(@"D:\Releases"))
            {
                await manager.UpdateApp();
            }

        }

        private void LoadPeopleList()
        {
            peopleList = SqliteDataAccess.LoadPeople();
            WireUpPeopleList();
        }


        private void WireUpPeopleList()
        {
            peopleListBox.DataSource = null;
            peopleListBox.DataSource = peopleList;
            peopleListBox.DisplayMember = "FullName";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel();

            person.FirstName = firstNameValue.Text;
            person.LastName = lastNameValue.Text;

            SqliteDataAccess.SavePerson(person);

            firstNameValue.Text = "";
            lastNameValue.Text = "";
            LoadPeopleList();
        }

        private void refrechButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }
    }
}
