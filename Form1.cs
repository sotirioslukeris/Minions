using MySql.Data.MySqlClient;

namespace Minions
{
    public partial class Form1 : Form
    {
        //1.
        string connectionString = "server = 10.42.42.64;" +
            "port=3306;user=PC1;" +
            "password=1111;" +
            "database=minions";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //2.
            MySqlConnection dbMinions = new MySqlConnection(connectionString);
            dbMinions.Open();
            MessageBox.Show("Connection is now opened!", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //4.
            MySqlCommand command = new MySqlCommand("SELECT * FROM towns", dbMinions);

            //5.
            MySqlDataReader reader = command.ExecuteReader();

            //6.

            List<ComboItem> items = new List<ComboItem>();

            while (reader.Read())
            {
                ComboItem item = new ComboItem();
                item.Id = (int)reader[0];
                item.Name = (string)reader[1];

                items.Add(item);


                //item.Id = 101;
                //item.Name = "Sotirios";
            }

            reader.Close();

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            dbMinions.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtId.Text}. Ти въведе {txtName.Text}\nГодини: {textBox2.Text}" +
                $"\nГрад : {comboBox1.Text} -- > {comboBox1.SelectedValue}");

            string insertSQL = "INSERT INTO minions.minions " +
                "(id,`name`,age,town_id) " +
                "VALUES (103,@townName,@age,@townId)";

            MySqlConnection connect = new MySqlConnection(connectionString);

            if (connect.State == 0)
            {
                connect.Open();
            }

            MySqlCommand


            
        }
    }
}
