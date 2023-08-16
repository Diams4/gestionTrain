using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET6_C_
{
    public partial class designItineraire : Form
    {
        private TimeSpan selectedHeureVoyage;
        private DateTime selectedDateVoyage;
        public designItineraire()
        {
            InitializeComponent();
            /*itineraire.remplirComboHeure(comboHeure);
            itineraire.remplirComboFrais(comboFrais);*/
            itineraire.remplirComboNumTrain(comboNumTrain);
            /*comboVoyage.SelectedIndex = 1;
            comboVoyage.DropDownStyle = ComboBoxStyle.DropDownList;*/
            read();
        }

        public void clear()
        {
            txtVoyage.Text = comboNumTrain.Text = string.Empty;
            selectedDateVoyage = DateTime.Now;
            heureVoyage.Value = DateTime.Now;
            fraisVoyage.Value = 0;
        }

        public void read()
        {
            itineraire.ReadItineraire("SELECT * FROM itineraire", tableItineraire);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //DateTime selectedDateTime = dateVoyage.Value;
            /*if (txtCin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student's class is empty ( > 1) ");
                return;
            }
            if (txtPhone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student's section is empty ( > 1) ");
                return;
            }*/

            if (btnAjouter.Text == "AJOUTER")
            {
                DateTime valeurDate = dateVoyage.Value;
                itineraire itineraire = new itineraire(txtVoyage.Text.Trim(), valeurDate, heureVoyage.Value, Convert.ToInt32(fraisVoyage.Value), int.Parse(comboNumTrain.Text.Trim()));
                itineraire.createItineraire(itineraire);
                read();
                clear();
            }
        }

        private void comboNumTrain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text == "MODIFIER")
            {
                DateTime valeurDate = dateVoyage.Value;
                itineraire Itineraire = new itineraire(txtVoyage.Text.Trim(), valeurDate, heureVoyage.Value, Convert.ToInt32(fraisVoyage.Value), int.Parse(comboNumTrain.Text.Trim()));
                itineraire.UpdateItineraire(Itineraire, Convert.ToInt32(txtId.Text));
            }
            clear();
            read();
        }

        private void tableItineraire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txtId.Text = tableItineraire.Rows[row].Cells[0].Value.ToString();
            txtVoyage.Text = tableItineraire.Rows[row].Cells[1].Value.ToString();
            dateVoyage.Value = Convert.ToDateTime(tableItineraire.Rows[row].Cells[2].Value);
            heureVoyage.Value = Convert.ToDateTime(tableItineraire.Rows[row].Cells[3].Value.ToString());
            fraisVoyage.Value = Convert.ToInt64(tableItineraire.Rows[row].Cells[4].Value);
            comboNumTrain.Text = tableItineraire.Rows[row].Cells[6].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text == "SUPPRIMER")
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Veuillez selectionner un itineraire");
                }else itineraire.DeleteItineraire(Convert.ToInt32(txtId.Text));
            }
            clear(); read();
        }
    }
}