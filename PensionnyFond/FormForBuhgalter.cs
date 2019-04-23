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
            typePensyRepository = TypePensyRepository.GetRepository();
            pricazRepository = PricazRepository.GetRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listSizePency.DisplayMember = "NameSize"; 
            listSizePency.Items.AddRange(typePensyRepository.GetAll().ToArray());
            ListPricaz.Items.AddRange(pricazRepository.GetAll().ToArray());
        }

        private void onFormClousing(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string[] newList = Search.SerchString(SearchBox.Text, pricazRepository
                 .GetAll()
                 .ToArray()
                 .Select(a => a.ToString())
                 .ToArray()
                 );

            ListPricaz.Items.Clear();
            ListPricaz.Items.AddRange(newList);
        }

        private void Window_OnDoubleClic(object sender, EventArgs e)
        {
            string thisPricaz = ListPricaz.SelectedItem.ToString();
            string INN = new string(thisPricaz.TakeWhile(el => el != ' ').ToArray());
            PersonPricazForm personPricaz = new PersonPricazForm(INN);
            personPricaz.ShowDialog();
        }

        private readonly Form mainForm;
        private readonly TypePensyRepository typePensyRepository;
        private readonly PricazRepository pricazRepository;

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
