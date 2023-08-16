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
    public partial class designTrain : Form
    {
        private int id_Train;
        public designTrain()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtDesign.Text = txtNbr.Text = string.Empty;
        }

        public void read()
        {
            train.ReadTrain("SELECT * FROM train", tableTrain);
        }

        private void designTrain_Shown(object sender, EventArgs e)
        {
            read();
        }

        private void tableTrain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            TextBox[] tab = { txtId, txtDesign, txtNbr };
            for (int i = 0; i < 3; i++)
            {
                tab[i].Text = tableTrain.Rows[row].Cells[i].Value.ToString();
            }
            id_Train = int.Parse(txtId.Text);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtDesign.Text.Trim().Length > 3)
            {
                MessageBox.Show("Student's name is empty (>3) ");
                return;
            }
            if (txtNbr.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student's reg is empty ( > 1) ");
                return;
            }

            if (btnAjouter.Text == "AJOUTER")
            {
                train trains = new train(txtDesign.Text.Trim(), txtNbr.Text.Trim());
                train.createTrain(trains);
                read();
                clear();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text == "MODIFIER")
            {
                train trains = new train(txtDesign.Text.Trim(), txtNbr.Text.Trim());
                train.UpdateTrain(trains, id_Train);
            }
            TextBox[] tab = { txtId, txtDesign, txtNbr };
            for (int i = 0; i < 3; i++)
            {
                tab[i].Text = "";
            }
            clear();
            read();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text == "SUPPRIMER")
            {
                train.DeleteTrain(id_Train);
            }
            TextBox[] tab = { txtId, txtDesign, txtNbr };
            for (int i = 0; i < 3; i++)
            {
                tab[i].Text = "";
            }
            clear(); read();
        }
    }
}
