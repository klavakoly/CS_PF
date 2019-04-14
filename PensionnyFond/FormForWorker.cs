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
    public partial class FormForWorker : Form
    {
        private readonly Form mainForm;
        public FormForWorker()
        {
            InitializeComponent();
        }

        public FormForWorker(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void OnClosing(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void CalculationFormForWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
