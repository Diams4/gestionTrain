namespace PROJET6_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            designTrain train = new designTrain();
            train.ShowDialog();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
             designReservation reservation = new designReservation();
            reservation.ShowDialog();
        }

        private void btnItineraire_Click(object sender, EventArgs e)
        {
            designItineraire itineraire = new designItineraire();
            itineraire.ShowDialog();
        }

        private void btnListeRecherche_Click(object sender, EventArgs e)
        {
            designRecherche recherche = new designRecherche();
            recherche.ShowDialog();
        }
    }
}