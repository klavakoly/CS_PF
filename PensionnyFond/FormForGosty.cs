using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PensionnyFond
{
    public partial class FormForGosty : Form
    {
        public FormForGosty(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            
        }

        public void OnClosing(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }
        
        private void CalculationFormForGosty_Load(object sender, EventArgs e)
        {

        }
        
        private readonly Form mainForm;
    }
}
