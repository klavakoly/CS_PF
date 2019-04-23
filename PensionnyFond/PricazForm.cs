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
    public partial class PricazForm : Form
    {
        public PricazForm()
        {
            InitializeComponent();
            pricazRepository = PricazRepository.GetRepository();
        }

        private void PricazForm_Load(object sender, EventArgs e)
        {
            ListPricaz.Items.AddRange(pricazRepository.GetAll().ToArray());
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
        private readonly PricazRepository pricazRepository;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
