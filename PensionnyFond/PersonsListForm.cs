using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace PensionnyFond
{
    public partial class PersonsListForm : Form
    {
        public PersonsListForm()
        {
            InitializeComponent();
            personRepository = PersonRepository.GetRepository();

        }

        private void PersonsListForm_Load(object sender, EventArgs e)
        {
            ListPersons.Items.AddRange(personRepository.GetAll().ToArray());
        }

        private void UpdateList()
        {
            ListPersons.Items.Clear();
            ListPersons.Items.AddRange(personRepository.GetAll().ToArray());
        }

        private readonly PersonRepository personRepository;

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string[] newList = Search.SerchString(SearchBox.Text, personRepository
                 .GetAll()
                 .ToArray()
                 .Select(a => a.ToString())
                 .ToArray()
                 );

            ListPersons.Items.Clear();
            ListPersons.Items.AddRange(newList);
        }

        private void Window_OnDoubleClic(object sender, EventArgs e)
        {
            string thisPerson = ListPersons.SelectedItem.ToString();
            string INN = new string(thisPerson.TakeWhile(el => el != ' ').ToArray());
            InformationAboutPersonForm infPerson = new InformationAboutPersonForm(INN);
            infPerson.ShowDialog();          
            UpdateList();
        }
    }
}
