using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDataAccessDemo2
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List< Person>();

        public Dashboard()
        {
            InitializeComponent();

            //connect directly the list
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(LastNameText.Text);

            UpdateBinding();
        }
    }
}
