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
    public partial class VDVPForm : Form
    {
        public VDVPForm()
        {
            InitializeComponent();
            typePensyRepository = TypePensyRepository.GetRepository();
            documentRepository = DocumentRepository.GetRepository();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VDVPForm_Load(object sender, EventArgs e)
        {
            PencyBox.Items.AddRange(typePensyRepository.GetAll().ToArray());
        }
        private void PencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocumentsList.Items.Clear();
            int a = typePensyRepository.GetIdPency((PencyBox.Text));
            DocumentsList.Items.AddRange(documentRepository.GetDocumentsForPency(a).ToArray());
        }

        private readonly TypePensyRepository typePensyRepository;
        private readonly DocumentRepository documentRepository;
    }
}
