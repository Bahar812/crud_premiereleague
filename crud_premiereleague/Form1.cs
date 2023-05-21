using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace crud_premiereleague
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=;database=premier_league ; ";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader reader;
        DataTable data;
        DataTable playerRmv;
       
        string sqlQuery;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new DataTable();

            sqlConnect = new MySqlConnection(connectionString);
            sqlQuery = "SELECT nationality_id AS `nationid`, nation AS `nation_name` FROM premier_league.nationality; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            comboBoxnationality.DataSource = data;
            comboBoxnationality.DisplayMember = "nation_name";
            comboBoxnationality.ValueMember = "nationid";

            data = new DataTable();
            sqlQuery = "SELECT playing_pos AS `pos` from premier_league.player group by 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            comboBoxposition.DataSource = data;
            comboBoxposition.DisplayMember = "pos";
            comboBoxposition.ValueMember = "pos";

            data = new DataTable();
            sqlQuery = "SELECT team_name AS `namatim`, team_id AS `timid` from  premier_league.team ; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            comboBoxteamname.DataSource = data;
            comboBoxteamname.DisplayMember = "namatim";
            comboBoxteamname.ValueMember = "timid";

            data=new DataTable();
            sqlQuery = "SELECT team_name AS `namatim`, team_id AS `timid` from  premier_league.team ; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            comboBoxteammanager.DataSource = data;
            comboBoxteammanager.DisplayMember = "namatim";
            comboBoxteammanager.ValueMember = "timid";

            data = new DataTable();
            sqlQuery = "SELECT team_name AS `namatim`, team_id AS `timid` from  premier_league.team ; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            comboBoxTeamRemove.DataSource = data;
            comboBoxTeamRemove.DisplayMember = "namatim";
            comboBoxTeamRemove.ValueMember = "timid";

       

          

            data = new DataTable();
            RefreshDataGridViewCurrent();



        }

        private void RefreshDataGridViewCurrent()
        {
            try
            {
                sqlConnect.Open(); // Buka koneksi ke database

                string query = "SELECT m.manager_name, m.birthdate, n.nation FROM manager m, nationality n WHERE `working` = 0 AND m.nationality_id = n.nationality_id";
                MySqlCommand command = new MySqlCommand(query, sqlConnect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);

                dataGridViewcurrent.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnect.Close(); // Tutup koneksi ke database
            }
        }


        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneladdplayer.Visible = true;
            panelmanager.Visible = false;
            panelRemove.Visible = false;

        }

        private void editManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneladdplayer.Visible = false;
            panelmanager.Visible = true;
            panelRemove.Visible = false;


        }

        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneladdplayer.Visible = false;
            panelmanager.Visible = false;
            panelRemove.Visible = true;
           
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxid.Text != "" && textBoxplayernumber.Text != "" && textboxnameplayer.Text != "" && textBoxheight.Text != "" && textBoxweight.Text != "")
            {
                sqlConnect = new MySqlConnection(connectionString);
                sqlQuery = $"INSERT INTO premier_league.player(player_id,team_number,player_name,nationality_id,playing_pos,height,weight,birthdate,team_id, status, `delete`)" +
                           $" VALUES ('{textBoxid.Text}', {textBoxplayernumber.Text}, '{textboxnameplayer.Text}', '{comboBoxnationality.SelectedValue.ToString()}', '{comboBoxposition.SelectedIndex}', {textBoxheight.Text}, {textBoxweight.Text}, '{dateTimePickerbirthdate.Value.ToString("yyyy-MM-dd")}', '{comboBoxteamname.SelectedValue.ToString()}', 1, 0);";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                reader = sqlCommand.ExecuteReader();
                sqlConnect.Close();
                MessageBox.Show("Add Player Success");
            }
            else
            {
                MessageBox.Show("Gaboleh kosong ya");
            }
           

            //query = $"insert into premier_league.player (player_id, team_number, player_name, nationality_id, playing_pos, height, weight, birthdate, team_id, status, `delete`) " +
            //        $"values ('{txtID.Text}', {txtNumber.Text}, '{txtName.Text}', '{cbNationality.SelectedValue.ToString()}', '{cbPosition.SelectedValue.ToString()}', {txtHeight.Text}, {txtWeight.Text}, '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', '{cbTeamname.SelectedValue.ToString()}', 1, 0);";
            //MessageBox.Show(query);

            //conn = new MySqlConnection(strconn);
            //conn.Open();
            //cmd = new MySqlCommand(query, conn);
            //reader = cmd.ExecuteReader();
            //conn.Close();
        }

        private void comboBoxnationality_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        string namatim;
        DataTable manager = new DataTable();
        private void comboBoxteammanager_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open(); // Buka koneksi ke database

                namatim = comboBoxteammanager.SelectedValue.ToString();
                sqlQuery = $"SELECT m.manager_name, t.team_name,DATE_FORMAT(m.birthdate, '%Y-%m-%d') as birthdate, n.nation FROM manager m, team t, nationality n WHERE m.manager_id = t.manager_id AND m.nationality_id = n.nationality_id AND t.team_id = '{namatim}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(manager);

                string labelData = "";

                foreach (DataRow row in manager.Rows)
                {
                    labelData = $"Name: {row["manager_name"]}\nTeam: {row["team_name"]}\nBirthdate: {row["birthdate"]}\nNationality: {row["nation"]}";
                }

                label10.Text = labelData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnect.Close(); // Tutup koneksi ke database
            }
        }

        private void buttonswitch_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open(); // Buka koneksi ke database

                if (dataGridViewcurrent.SelectedRows.Count > 0)
                {
                    string selectedManagerName = dataGridViewcurrent.SelectedRows[0].Cells["manager_name"].Value.ToString();

                    string updatePreviousManagerQuery = "UPDATE manager SET working = 0 WHERE manager_id IN (SELECT manager_id FROM team WHERE team_id = @teamId)";
                    MySqlCommand updatePreviousManagerCommand = new MySqlCommand(updatePreviousManagerQuery, sqlConnect);
                    updatePreviousManagerCommand.Parameters.AddWithValue("@teamId", namatim);
                    updatePreviousManagerCommand.ExecuteNonQuery();

                    // Perbarui kolom 'manager_id' pada tabel 'team' dengan manajer yang dipilih
                    
                    string updateNewManagerQuery = "UPDATE team SET manager_id = (SELECT manager_id FROM manager WHERE manager_name = @managerName) WHERE team_id = @teamId";
                    MySqlCommand updateNewManagerCommand = new MySqlCommand(updateNewManagerQuery, sqlConnect);
                    updateNewManagerCommand.Parameters.AddWithValue("@managerName", selectedManagerName);
                    updateNewManagerCommand.Parameters.AddWithValue("@teamId", namatim);
                    updateNewManagerCommand.ExecuteNonQuery();

                    // Perbarui kolom 'working' pada tabel 'manager' menjadi 1 untuk manajer yang dipilih
                    string updateSelectedManagerQuery = "UPDATE manager SET working = 1 WHERE manager_name = @managerName";
                    MySqlCommand updateSelectedManagerCommand = new MySqlCommand(updateSelectedManagerQuery, sqlConnect);
                    updateSelectedManagerCommand.Parameters.AddWithValue("@managerName", selectedManagerName);
                    updateSelectedManagerCommand.ExecuteNonQuery();

                    MessageBox.Show("Manager of the team has been updated successfully.");

                    // Refresh the manager details and not working managers
                    comboBoxteammanager_SelectionChangeCommitted(null, null);

                    // Refresh the DataGridViewcurrent by re-binding it to the updated data source
                    data.Clear();
                    RefreshDataGridViewCurrent();
                    label10.Text = "";

                    MessageBox.Show("udah di refresh");
                }
                else
                {
                    MessageBox.Show("Please select a manager from the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnect.Close(); // Tutup koneksi ke database
            }
        }

        private void comboBoxteammanager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        DataTable playerr = new DataTable();
        string pilihTimm;
        private void comboBoxTeamRemove_SelectionChangeCommitted(object sender, EventArgs e)
        {
            playerr.Clear();
            pilihTimm = comboBoxTeamRemove.SelectedValue.ToString();
            sqlQuery = $"SELECT p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight,DATE_FORMAT(p.birthdate, '%Y-%m-%d') as birthdate  FROM player p, nationality n WHERE `status` = 1 AND p.nationality_id = n.nationality_id AND p.team_id = '{pilihTimm}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(playerr);
            dataGridViewPlayerRemove.DataSource = playerr;
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            int playerCount = dataGridViewPlayerRemove.Rows.Count;

            // Cek apakah jumlah pemain lebih dari 11
            if (playerCount <= 11)
            {
                MessageBox.Show("Jumlah pemain tidak dapat kurang dari atau sama dengan 11. Tidak dapat menghapus pemain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Ambil nilai dari kolom "team_number" dan "player_name" dari baris terpilih dalam DataGridView
            string teamNumber = dataGridViewPlayerRemove.CurrentRow.Cells["team_number"].Value.ToString();
            string playerName = dataGridViewPlayerRemove.CurrentRow.Cells["player_name"].Value.ToString();

            // Konfirmasi penghapusan dengan dialog konfirmasi
            DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus pemain '{playerName}' Nomer Punggung '{teamNumber}'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                sqlConnect.Open();
                // Update nilai kolom "status" menjadi 0 dalam database
                string updateQuery = $"UPDATE player SET status = 0 WHERE team_number = '{teamNumber}' AND player_name = '{playerName}';";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, sqlConnect);
                updateCommand.ExecuteNonQuery();

                // Tampilkan pesan sukses dan muat ulang data pemain
                MessageBox.Show("Pemain berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerr.Clear();
                sqlQuery = $"SELECT p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight,DATE_FORMAT(p.birthdate, '%Y-%m-%d') as birthdate FROM player p, nationality n WHERE `status` = 1 AND p.nationality_id = n.nationality_id AND p.team_id = '{pilihTimm}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(playerr);
                dataGridViewPlayerRemove.DataSource = playerr;
                sqlConnect.Close();
            }
        }
    }
}
