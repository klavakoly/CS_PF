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
    public partial class FormForBuhgalter : Form
    {
        public FormForBuhgalter(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=LAPTOP-TSM0D2RH\SQLEXPRESS;Database=Pensionny_Fond;User Id=admin; " +
                "Password = admin; ";
            IRepository<Person> a = PersonRepository.GetRepository();
            Person p = a.Get(1);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            StatementForm person = new StatementForm(this);
            person.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void onFormClousing(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private readonly Form mainForm;
        private readonly string connectionString;

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
