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
    public partial class CheckForm : Form
    {
        public CheckForm(Action<bool> action, int INN)
        {
            InitializeComponent();
            personRepository = PersonRepository.GetRepository();
            this.action = action;
            this.INN = INN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personRepository.Delete(INN);
            action(true);
            Close();
        }

        private readonly PersonRepository personRepository;

        private void No_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Action<bool> action;
        private int INN;
    }
}
