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
    public partial class FormForGosty : Form
    {
        public FormForGosty(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            personRepository = PersonRepository.GetRepository();
        }

        public void OnClosing(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }
        
        private void CalculationFormForGosty_Load(object sender, EventArgs e)
        {
            //personRepository.Add();
        }
        
        private readonly Form mainForm;
        private readonly PersonRepository personRepository;


    }
}
