using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormApp.DataModel;

namespace WindowsFormApp
{
    public partial class UsersForm : Form
    {
        IUserRepository _repo;

        public UsersForm(IUserRepository repo)
        {
            _repo = repo;
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                DateofBirth = dateTimePickerBirthDate.Value,
                Address = textBoxAddress.Text,
                PostalCode = textBoxPostalCode.Text,
                Email = textBoxEmail.Text,
                AddInfo = richTextBoxAddInfo.Text
            };

            //reset form
            textBoxName.Clear();
            textBoxSurname.Clear();
            dateTimePickerBirthDate.ResetText();
            textBoxAddress.Clear();
            textBoxPostalCode.Clear();
            textBoxEmail.Clear();
            richTextBoxAddInfo.Clear();



            _repo.Create(newUser);

            listBoxRegisteredUsers.Items.Clear();
            listBoxRegisteredUsers.Items.AddRange(_repo.ReadAllUsers().Select(user => user.Name + ' ' + user.Surname).ToArray());
        }
    }
}