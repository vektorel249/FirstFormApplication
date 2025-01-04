using System.Text.Json;

namespace Vektorel.BasicControls
{
    public partial class FrmPeople : Form
    {
        const string FILENAME = "people.json";
        public FrmPeople()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var person = new Person
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirthDate.Value
            };

            lstPeople.Items.Add(person);
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dtpBirthDate.Value = dtpBirthDate.MaxDate;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItem == null)
            {
                return;
            }

            var removeRequest = MessageBox.Show("Bu kayıt silinsin mi?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (removeRequest == DialogResult.Yes)
            {
                lstPeople.Items.Remove(lstPeople.SelectedItem);
            }
        }

        private void lstPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(null, null);
            }
        }

        private void ctbDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click(null, null);
        }

        private void FrmPeople_FormClosing(object sender, FormClosingEventArgs e)
        {
            var people = new List<Person>();
            foreach (var item in lstPeople.Items)
            {
                var person = item as Person;
                people.Add(person);
            }
            var json = JsonSerializer.Serialize(people);
            File.WriteAllText(FILENAME, json);
        }

        private void FrmPeople_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILENAME))
            {
                var people = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(FILENAME));
                foreach (var person in people) 
                { 
                    lstPeople.Items.Add(person);
                }
            }
        }
    }
}
