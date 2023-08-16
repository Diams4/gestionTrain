using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET6_C_
{
    internal class train
    {
        public int idTrain { get; set; }
        public String Design { get; set; }
        public string Nbr_place { get; set; }

        public train(string design, string nbr_place)
        {
            Design = design;
            Nbr_place = nbr_place;
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

        public static void createTrain(train train)
        {
            string sql = "INSERT INTO train VALUES (NULL, @trainDesign, @trainNbr_place)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("@reservationDate_reservation", MySqlDbType.Date).Value = reserve.Date_reservation;
            cmd.Parameters.Add("@trainDesign", MySqlDbType.VarChar).Value = train.Design;
            cmd.Parameters.Add("@trainNbr_place", MySqlDbType.VarChar).Value = train.Nbr_place;

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

        public static void UpdateTrain(train train, int ID)
        {
            string sql = "UPDATE train SET design = @trainDesign, nbrPlace = @trainNbr_place WHERE idTrain = @trainIdTrain";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@trainDesign", MySqlDbType.VarChar).Value = train.Design;
            cmd.Parameters.Add("@trainNbr_place", MySqlDbType.VarChar).Value = train.Nbr_place;
            cmd.Parameters.Add("@trainIdTrain", MySqlDbType.Int64).Value = ID;
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

        public static void DeleteTrain(int id)
        {
            string sql = "DELETE FROM train WHERE idTrain = @trainIdTrain";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@trainIdTrain", MySqlDbType.Int64).Value = id;

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

        public static void ReadTrain(string query, DataGridView dgv)
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
