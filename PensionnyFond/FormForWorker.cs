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
    public partial class FormForWorker : Form
    {
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            StatementForm statement = new StatementForm(this);
            statement.ShowDialog();
        }

        private readonly Form mainForm;
        private readonly string connectionString;
    }
}
