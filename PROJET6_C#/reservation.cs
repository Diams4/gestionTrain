using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET6_C_
{
    internal class reservation
    {
        public int idReserve { get; set; }
        public string NomVoyageur { get; set; }
        public int cin { get; set; }
        public int numPhone { get; set; }
        public String Voyage { get; set; }
        public int nbrPlace { get; set; }
        public String Paiement { get; set; }
        public int reste { get; set; }
        public int NetApayer { get; set; }
        public int IdIt { get; set; }

        public reservation(string nomVoyageur, int cin, int numPhone, string voyage, int nbrPlace, string paiement, int idIt)
        {
            NomVoyageur = nomVoyageur;
            this.cin = cin;
            this.numPhone = numPhone;
            Voyage = voyage;
            this.nbrPlace = nbrPlace;
            Paiement = paiement;
            IdIt = idIt;
        }

        public static MySqlConnection GetConnection()
        {
            String sql = "datasource=localhost; port=3306; username=root; password= ; database=gestion_train";
            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection!\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void remplirComboVoyage(System.Windows.Forms.ComboBox comboVoyage)
        {
            try
            {
                string sql = "SELECT voyage FROM itineraire";
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboVoyage.Items.Add(reader["voyage"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void remplirComboPaiement(System.Windows.Forms.ComboBox comboPaiement)
        {
            try
            {
                string sql = "SELECT mode FROM paiement";
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboPaiement.Items.Add(reader["mode"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void createReservation(reservation reserve)
        {
            string sql = "INSERT INTO reservation VALUES (NULL, @reservationNom_voyageur, @reservationCin, @reservationTelephone, @reservationVoyage,@reservationNbr_place,@reservationPaiement, ,@reservationReste, ,@reservationNetApayer,,@reservationIdIt)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("@reservationDate_reservation", MySqlDbType.Date).Value = reserve.Date_reservation;
            cmd.Parameters.Add("@reservationNom_voyageur", MySqlDbType.VarChar).Value = reserve.NomVoyageur;
            cmd.Parameters.Add("@reservationCin", MySqlDbType.Int32).Value = reserve.cin;
            cmd.Parameters.Add("@reservationTelephone", MySqlDbType.Int32).Value = reserve.numPhone;
            cmd.Parameters.Add("@reservationVoyage", MySqlDbType.VarChar).Value = reserve.Voyage;
            cmd.Parameters.Add("@reservationNbr_place", MySqlDbType.Int32).Value = reserve.nbrPlace;
            cmd.Parameters.Add("@reservationPaiement", MySqlDbType.Int32).Value = reserve.Paiement;
            cmd.Parameters.Add("@reservationReste", MySqlDbType.Int32).Value = reserve.reste;
            cmd.Parameters.Add("@reservationNetApayer", MySqlDbType.Int64).Value = reserve.NetApayer;
            cmd.Parameters.Add("@reservationIdIt", MySqlDbType.Int32).Value = reserve.IdIt;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Creating error!\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateReservation(reservation reserve, int ID)
        {
            string sql = "UPDATE reservation SET nom_voyageur = @reservationNom_voyageur, CIN = @reservationCin, Telephone = @reservationTelephone, Voyage = @reservationVoyage ,nbr_place = @reservationNbr_place, paiement = @reservationPaiement, reste = @reservationReste, netApayer = @reservationNetApayer WHERE idReserve = @reservationId_reserve";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@reservationNom_voyageur", MySqlDbType.VarChar).Value = reserve.NomVoyageur;
            cmd.Parameters.Add("@reservationCin", MySqlDbType.VarChar).Value = reserve.cin;
            cmd.Parameters.Add("@reservationTelephone", MySqlDbType.VarChar).Value = reserve.numPhone;
            cmd.Parameters.Add("@reservationVoyage", MySqlDbType.VarChar).Value = reserve.Voyage;
            cmd.Parameters.Add("@reservationNbr_place", MySqlDbType.VarChar).Value = reserve.nbrPlace;
            cmd.Parameters.Add("@reservationPaiement", MySqlDbType.VarChar).Value = reserve.Paiement;
            cmd.Parameters.Add("@reservationReste", MySqlDbType.VarChar).Value = reserve.reste;
            cmd.Parameters.Add("@reservationNetApayer", MySqlDbType.VarChar).Value = reserve.NetApayer;
            cmd.Parameters.Add("@reservationId_reserve", MySqlDbType.Int64).Value = ID;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Updating error!\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteReservation(int id)
        {
            string sql = "DELETE FROM reservation WHERE idReserve = @reservationIdReserve";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@reservationIdReserve", MySqlDbType.Int64).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Deleting error!\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void ReadReservation(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adp.Fill(table);
            dgv.DataSource = table;
            connection.Close();
        }
    }
}
