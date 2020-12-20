using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_ListQuestionnaire_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            List<Questionnaire> Questionnaires = new List<Questionnaire>
            {
                new Questionnaire{Surname="Stefanishin"},
                new Questionnaire{Name="Mikita"},
                new Questionnaire{Email="stefanishin92@gmail.com"},
                new Questionnaire{Phone="0688229350"}

            };
            listBox1.DataSource = Questionnaires;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Email";


            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void AddInfoClick(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string email = (string)listBox1.SelectedValue;

            Questionnaire Questionnaire = (Questionnaire)listBox1.SelectedItem;
            MessageBox.Show(email.ToString()+"." + Questionnaire.Name);
        }
    }
    class Questionnaire
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
