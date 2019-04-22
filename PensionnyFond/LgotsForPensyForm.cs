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
    public partial class LgotsForPensyForm : Form
    {
        public LgotsForPensyForm()
        {
            InitializeComponent();
            typePensyRepository = TypePensyRepository.GetRepository();
            lgoteRepository = LgoteRepository.GetRepository();

        }

        private void LgotsForPensyForm_Load(object sender, EventArgs e)
        {
            PencyBox.Items.AddRange(typePensyRepository.GetAll().ToArray());
            
        }

        private readonly TypePensyRepository typePensyRepository;
        private readonly LgoteRepository lgoteRepository;

        private void PencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LgotsList.Items.Clear();
            int a = typePensyRepository.GetIdPency((PencyBox.Text));            
            LgotsList.Items.AddRange(lgoteRepository.GetLgotsForPency(a).ToArray());
        }
    }
}
