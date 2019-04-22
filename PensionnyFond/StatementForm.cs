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
            statementRepository = StatementRepository.GetRepository();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Document> documents = new List<Document>();
            for (int i = 0; i < ListOfDocuments.Items.Count; i++)
            {
                if (ListOfDocuments.GetItemChecked(i))
                {
                    documents.Add((Document)ListOfDocuments.Items[i]);
                }
            }
            try
            {
                if (statementRepository.Add(new Statement(
                    new Person(
                        Convert.ToInt32(INNBox.Text),
                        SernameBox.Text,
                        NameBox.Text,
                        MiddleName.Text,
                        PhoneBox.Text,
                        CityBox.Text,
                        Convert.ToDateTime(DateBox.Text)),
                    (TypePensy)TypePensyBox.SelectedItem,
                    documents,
                    DateTime.Now)))
                {
                    Close();
                }
                else
                {
                    OnError();
                };
            }catch(Exception ex)
            {
                OnError();
            }
        }
        private void OnError()
        {
            ErrorLabel.Visible = true;
        }
        private readonly PersonRepository personRepository;
        private readonly DocumentRepository documentRepository;
        private readonly TypePensyRepository typePensyRepository;
        private readonly StatementRepository statementRepository;


        private void StatementForm_Load(object sender, EventArgs e)
        {
            ListOfDocuments.Items.AddRange(documentRepository.GetAll().ToArray());
            TypePensyBox.Items.AddRange(typePensyRepository.GetAll().ToArray());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
