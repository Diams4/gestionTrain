using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET6_C_
{
    internal class itineraire
    {
        public int idItineraire { get; set; }
      
        public string Voyage { get; set; }
        public DateTime Date { get; set; }
        public DateTime Heure{ get; set; }
        public int Frais { get; set; }
        public int nbrPlace { get; set; }
        public int idTrain { get; set; }

        public itineraire(string voyage, DateTime date, DateTime heure, int frais, int idTrain)
        {
            Voyage = voyage;
            Date = date;
            Heure = heure;
            Frais = frais;
            this.idTrain = idTrain;
            this.nbrPlace = NbrPlace(this.idTrain);
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

        public static int NbrPlace(int id)
        {
            try
            {
                string sql = "SELECT nbrPlace FROM train where idTrain="+id;
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return Convert.ToInt32(reader["nbrPlace"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return -1;
        }
        /*public static void remplirComboHeure(System.Windows.Forms.ComboBox comboHeure)
        {

            try
            {
                string sql = "SELECT heure FROM itineraire";
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboHeure.Items.Add(reader["heure"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void remplirComboFrais(System.Windows.Forms.ComboBox comboFrais)
        {

            try
            {
                string sql = "SELECT frais FROM itineraire";
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboFrais.Items.Add(reader["frais"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }*/

        public static void remplirComboNumTrain(System.Windows.Forms.ComboBox comboNumTrain)
        {

            try
            {
                string sql = "SELECT idTrain FROM train";
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboNumTrain.Items.Add(reader["idTrain"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void createItineraire(itineraire voyage)
        {
            string sql = "INSERT INTO itineraire VALUES (NULL, @itineraireVoyage, @itineraireDateVoyage, @itineraireHeureVoyage, @itineraireFrais ,@itineraireNbrPlaceDispo, @itineraireIdTrain)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("@reservationDate_reservation", MySqlDbType.Date).Value = reserve.Date_reservation;
            //cmd.Parameters.Add("@itineraireDepart", MySqlDbType.VarChar).Value = voyage.Depart;
            //cmd.Parameters.Add("@itineraireArrivee", MySqlDbType.VarChar).Value = voyage.Arrivee;
            cmd.Parameters.Add("@itineraireVoyage", MySqlDbType.VarChar).Value = voyage.Voyage;
            cmd.Parameters.Add("@itineraireDateVoyage", MySqlDbType.Date).Value = voyage.Date;
            cmd.Parameters.Add("@itineraireHeureVoyage", MySqlDbType.Time).Value = voyage.Heure.TimeOfDay;
            cmd.Parameters.Add("@itineraireFrais", MySqlDbType.Int64).Value = voyage.Frais;
            cmd.Parameters.Add("@itineraireNbrPlaceDispo", MySqlDbType.Int64).Value = voyage.nbrPlace;
            cmd.Parameters.Add("@itineraireIdTrain", MySqlDbType.Int64).Value = voyage.idTrain;
            //cmd.Parameters.Add("@reservationTelephone", MySqlDbType.VarChar).Value = reserve.Telephone;
            //cmd.Parameters.Add("@reservationId_train", MySqlDbType.Int64).Value = reserve.id_train;

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

       public static void UpdateItineraire(itineraire voyage, int ID)
        {
            string sql = "UPDATE itineraire SET voyage = @itineraireVoyage ,dateVoyage=@itineraireDateVoyage, heure=@itineraireHeureVoyage, frais=@itineraireFrais, nbrPlaceDispo=@itineraireNbrPlaceDispo, idTrain=@itineraireIdTrain WHERE idIt = @itineraireIdIt";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@itineraireVoyage", MySqlDbType.VarChar).Value = voyage.Voyage;
            cmd.Parameters.Add("@itineraireDateVoyage", MySqlDbType.Date).Value = voyage.Date;
            cmd.Parameters.Add("@itineraireHeureVoyage", MySqlDbType.Time).Value = voyage.Heure.TimeOfDay;
            cmd.Parameters.Add("@itineraireFrais", MySqlDbType.Int64).Value = voyage.Frais;
            cmd.Parameters.Add("@itineraireNbrPlaceDispo", MySqlDbType.Int64).Value = voyage.nbrPlace;
            cmd.Parameters.Add("@itineraireIdTrain", MySqlDbType.Int64).Value = voyage.idTrain;
            cmd.Parameters.Add("@itineraireIdIt", MySqlDbType.Int64).Value = ID;
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

        public static void DeleteItineraire(int id)
        {
            string sql = "DELETE FROM itineraire WHERE idIt = @itineraireIdIt";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@itineraireIdIt", MySqlDbType.Int64).Value = id;

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

        public static void ReadItineraire(string query, DataGridView dgv)
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
