namespace Vektorel.BasicControls
{
    public partial class FrmMatchScore : Form
    {
        List<Team> teams = new List<Team>();
        public FrmMatchScore()
        {
            InitializeComponent();
        }

        private void FrmMatchScore_Load(object sender, EventArgs e)
        {
            teams.Add(new Team
            {
                Name = "Galatasaray",
                PrimaryColor = Color.FromArgb(169, 4, 50),
                SecondaryColor = Color.FromArgb(253, 185, 18)
            });
            teams.Add(new Team
            {
                Name = "Fenerbahçe",
                PrimaryColor = Color.DarkBlue,
                SecondaryColor = Color.Yellow
            });
            teams.Add(new Team
            {
                Name = "Beşiktaş",
                PrimaryColor = Color.Black,
                SecondaryColor = Color.White
            });
            teams.Add(new Team
            {
                Name = "Trabzonspor",
                PrimaryColor = Color.DarkRed,
                SecondaryColor = Color.DarkBlue
            });
            teams.Add(new Team
            {
                Name = "Samsunspor",
                PrimaryColor = Color.Red,
                SecondaryColor = Color.White
            });

            // Teams listesindeki verileri combobox a veri kaybağı ver.
            // Dolayısı ile 4 er takımı toplamda 8 kere cmbHome.Items.Add(...) şeklinde yazmaktan kurtulduk
            cmbHome.DataSource = teams;
            cmbAway.DataSource = teams.ToList(); // Bu listeyi ToList diyerek yeni bir liste oluşturduk çünkü DataSource verdiğimiz kaynak aynı olduğu için seçilen takım diğer combobox'ta da seçiliyordu. Farklı referans vermek zorundayız.
        }

        private void cmbHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            var team = cmbHome.SelectedItem as Team;
            pnlHomeColor1.BackColor = team.PrimaryColor;
            pnlHomeColor2.BackColor = team.SecondaryColor;
        }

        private void cmbAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            var team = cmbAway.SelectedItem as Team;
            pnlAwayColor1.BackColor = team.PrimaryColor;
            pnlAwayColor2.BackColor = team.SecondaryColor;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            counter = 0;
            tmr.Interval = 100;
            tmr.Start();
        }

        private int counter;
        private void tmr_Tick(object sender, EventArgs e)
        {
            lblHomeScore.Text = Random.Shared.Next(0, 6).ToString();
            lblAwayScore.Text = Random.Shared.Next(0, 6).ToString();
            counter++;
            if (counter == 20)
            {
                tmr.Interval = 300;
            }
            else if (counter == 25)
            {
                tmr.Interval = 500;
            }
            if (counter == 30)
            {
                tmr.Stop();
            }
        }
    }

    class Team
    {
        public string Name { get; init; }
        public Color PrimaryColor { get; init; }
        public Color SecondaryColor { get; init; }
        public override string ToString()
        {
            return Name;
        }
    }
}
