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
    public partial class InformationAboutPersonForm : Form
    {
        public InformationAboutPersonForm(string INN)
        {
            InitializeComponent();
            personRepository = PersonRepository.GetRepository();
            documentRepository = DocumentRepository.GetRepository();
            typePensyRepository = TypePensyRepository.GetRepository();
            statementRepository = StatementRepository.GetRepository();
            this.INN = INN;
        }

        private void InformationAboutPersonForm_Load(object sender, EventArgs e)
        {

            INNBox.Text = INN;
            INNBox.Enabled = false;
            person = new Person(personRepository.Get(int.Parse(INN)));
            SernameBox.Text = person.Surname;
            SernameBox.Enabled = false;
            NameBox.Text = person.Name;
            NameBox.Enabled = false;
            MiddleName.Text = person.MiddleName;
            MiddleName.Enabled = false;
            DateBox.Text = person.DataRogdeniya.ToShortDateString();
            DateBox.Enabled = false;
            CityBox.Text = person.RegistrationCity;
            CityBox.Enabled = false;
            PhoneBox.Text = person.ContactPhone;
            PhoneBox.Enabled = false;
            TypePensyBox.Text = (typePensyRepository.Get(int.Parse(INN))).ToString();
            TypePensyBox.Enabled = false;
            ListOfDocuments.Items.AddRange(documentRepository.GetAll().ToArray());

            documents = documentRepository.GetByID(int.Parse(INN));

            for (int i = 0; i < ListOfDocuments.Items.Count; i++)
            {
                for (int j = 0; j < documents.Length; j++)
                {
                    Document d = (Document)ListOfDocuments.Items[i];
                    if (documents[j].Equals(d))
                    {
                        ListOfDocuments.SetItemChecked(i, true);
                    }
                }
            }
            ListOfDocuments.MultiColumn = true;
            ListOfDocuments.ColumnWidth = 300;
            ListOfDocuments.Enabled = false;
        }

        private readonly PersonRepository personRepository;
        private readonly DocumentRepository documentRepository;
        private readonly TypePensyRepository typePensyRepository;
        private readonly StatementRepository statementRepository;
        private string INN;
        private Document[] documents;
        private Person person;


        private void ChangeButtonState()
        {
            bool cur = (bool)button1.Tag;
            if (cur)
            {
                button1.Text = "Сохранить";
            }
            else
            {
                button1.Text = "Редактировать";
            }
            button1.Tag = !cur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((bool)button1.Tag)
            {
                ListOfDocuments.Enabled = true;
                PhoneBox.Enabled = true;
                CityBox.Enabled = true;
                DateBox.Enabled = true;
                MiddleName.Enabled = true;
                NameBox.Enabled = true;
                SernameBox.Enabled = true;
                ChangeButtonState();
            }
            else
            {
                ChangeButtonState();
                List<Document> docs = new List<Document>();
                for (int i = 0; i < ListOfDocuments.Items.Count; i++)
                {
                    if (ListOfDocuments.GetItemChecked(i))
                    {
                        docs.Add((Document)ListOfDocuments.Items[i]);
                    }
                }
                
                //List<Document> docs2 = new List<Document>();
                foreach(Document doc in documents)
                {
                    if (docs.Contains(doc))
                    {
                        docs.Remove(doc);
                    }
                }

                try
                {
                    if (statementRepository.Update(new Statement(
                        new Person(
                            Convert.ToInt32(INNBox.Text),
                            SernameBox.Text,
                            NameBox.Text,
                            MiddleName.Text,
                            PhoneBox.Text,
                            CityBox.Text,
                            Convert.ToDateTime(DateBox.Text)),
                        (TypePensy)TypePensyBox.SelectedItem,
                        docs,
                        DateTime.Now)))
                    {
                        Close();
                    }
                    else
                    {
                        OnError();
                    };
                }
                catch (Exception ex)
                {
                    OnError();
                }
            }
        }
        private void OnError()
        {
            ErrorLabel.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CheckForm check = new CheckForm(OnDeleting, person.INN );
            check.ShowDialog();
        }

        private void OnDeleting(bool ok)
        {
            Close();
        }

        //statementRepository.Update();


    }
}

