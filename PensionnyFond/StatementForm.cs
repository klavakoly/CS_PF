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
    public partial class StatementForm : Form
    {
        public StatementForm(Form f)
        {
            InitializeComponent();
            personRepository = PersonRepository.GetRepository();
            documentRepository = DocumentRepository.GetRepository();
            typePensyRepository = TypePensyRepository.GetRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //personRepository.Add(new Person(
            //    Convert.ToInt32(INNBox.Text),
            //    SernameBox.Text,
            //    NameBox.Text,
            //    MiddleName.Text,
            //    PhoneBox.Text,
            //    CityBox.Text,
            //    Convert.ToDateTime(DateBox.Text)));


        }

        private readonly PersonRepository personRepository ;
        private readonly DocumentRepository documentRepository;
        private readonly TypePensyRepository typePensyRepository;

        private void StatementForm_Load(object sender, EventArgs e)
        {
            ListOfDocuments.Items.AddRange(documentRepository.GetAll().ToArray());
            TypePensyBox.Items.AddRange(typePensyRepository.GetAll().ToArray());
        }
    }
}
