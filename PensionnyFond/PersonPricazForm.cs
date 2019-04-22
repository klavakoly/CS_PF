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
    public partial class PersonPricazForm : Form
    {
        public PersonPricazForm(string INN)
        {
            InitializeComponent();
            pricazRepository = PricazRepository.GetRepository();
            this.INN = INN;
        }

        private void PersonPricazForm_Load(object sender, EventArgs e)
        {
            Pricaz pricaz = pricazRepository.Get(int.Parse(INN));
            NumberLabel.Text = (pricaz.ID).ToString();
            labelDate.Text = "01." + pricaz.Month + "." + pricaz.Year;
            labelName.Text = pricaz.Sername + " " + pricaz.Name + " " + pricaz.MiddleName + @", назначен\на на получение пенсии";
            labelPency.Text = pricaz.pency;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string INN;
        private readonly PricazRepository pricazRepository;
    }
}
