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
    public partial class designReservation : Form
    {
        private int id_reserve;
        public designReservation()
        {
            InitializeComponent();
            reservation.remplirComboVoyage(comboVoyage);
            reservation.remplirComboPaiement(comboPaiement);
        }

        public void clear()
        {
            txtNom.Text = txtCin.Text = txtPhone.Text = comboVoyage.Text = txtNbr.Text = comboPaiement.Text = string.Empty;
        }

        public void read()
        {
            reservation.ReadReservation("SELECT * FROM reservation", tableReservation);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            /*if (txtNom.Text.Trim().Length > 3)
            {
                MessageBox.Show("Student's name is empty (>3) ");
                return;
            }
            if (txtNom.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student's name is empty (>3) ");
                return;
            }
            if (txtCin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student's class is empty ( > 1) ");
                return;
            }
            if (txtPhone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student's section is empty ( > 1) ");
                return;
            }
            if (txtNbr.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student's reg is empty ( > 1) ");
                return;
            }*/

            if (btnAjouter.Text == "AJOUTER")
            {
                reservation reserve = new reservation(txtNom.Text.Trim(), Convert.ToInt32(txtCin.Value), Convert.ToInt32(txtPhone.Value), comboVoyage.Text, Convert.ToInt32(txtNbr.Value), comboPaiement.Text, Convert.ToInt32(txtId.Text));
                reservation.createReservation(reserve);
                read();
                clear();
            }
        }

        private void designReservation_Shown(object sender, EventArgs e)
        {
            read();
        }

        private void tableReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            /*TextBox[] tab = { txtNom, txtCin,txtPhone,comboVoyage,txtNbr,comboPaiement};
            for (int i = 0; i < 6; i++)
            {
                tab[i].Text = tableReservation.Rows[row].Cells[i].Value.ToString();
            }*/
            txtId.Text = tableReservation.Rows[row].Cells[0].Value.ToString();
            txtNom.Text = tableReservation.Rows[row].Cells[1].Value.ToString();
            txtCin.Text = tableReservation.Rows[row].Cells[2].Value.ToString();
            txtPhone.Text = tableReservation.Rows[row].Cells[3].Value.ToString();
            comboVoyage.Text = tableReservation.Rows[row].Cells[4].Value.ToString();
            txtNbr.Text = tableReservation.Rows[row].Cells[5].Value.ToString();
            comboPaiement.Text = tableReservation.Rows[row].Cells[6].Value.ToString();


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text == "MODIFIER")
            {
                reservation reserve = new reservation(txtNom.Text.Trim(), Convert.ToInt32(txtCin.Value), Convert.ToInt32(txtPhone.Value), comboVoyage.Text, Convert.ToInt32(txtNbr.Value), comboPaiement.Text, int.Parse(txtId.Text));
                reservation.UpdateReservation(reserve, id_reserve);
            }
            clear();
            read();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text == "SUPPRIMER")
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Veuillez selectionner un itineraire");
                }
                else itineraire.DeleteItineraire(Convert.ToInt32(txtId.Text));
            }
            clear(); read();
        }
    }
}
