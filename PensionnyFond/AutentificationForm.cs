using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Security;
using Logic;

namespace PensionnyFond
{
    public partial class AutentificationForm : Form
    {
        public AutentificationForm()
        {
            InitializeComponent();
            autentification = new Autentification();
        }

        private void Autentification_Load(object sender, EventArgs e)
        {

        }

        private readonly Autentification autentification;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool check = autentification.CheckLogin(LoginBox.Text, PasswordBox.Text);
            
            if (check)
            {
                ConfigurateRepositories(autentification.GetConnectionString());
                Roles role = autentification.GetRole(LoginBox.Text, PasswordBox.Text);
                Hide();
                string cs = autentification.GetConnectionString();
                switch (role)
                {
                    case Roles.Worker:
                        FormForWorker mainWorkerPage = new FormForWorker(this);
                        mainWorkerPage.ShowDialog();
                        break;
                    case Roles.Gosty:
                        FormForGosty mainGostyPage = new FormForGosty(this);
                        mainGostyPage.ShowDialog();
                        break;
                    case Roles.Buhgalter:
                        FormForBuhgalter mainBuhgalterPage = new FormForBuhgalter(this);
                        mainBuhgalterPage.ShowDialog();
                        break;
                }
                

            }
            else
            {
                label4.Visible = true;
            }
        }
        private void ConfigurateRepositories(string connectionString)
        {
            DocumentRepository.Configure(connectionString);
            PersonRepository.Configure(connectionString);
            TypePensyRepository.Configure(connectionString);
        }

        
    }
}
