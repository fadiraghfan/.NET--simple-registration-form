using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_camp
{
    public partial class Registration : Form
    {
        private static MySqlConnection connection;


        public Registration()
        {
            InitializeComponent();

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void optrip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cont_TextChanged(object sender, EventArgs e)
        {

        }

        private void dadfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dadcont_TextChanged(object sender, EventArgs e)
        {

        }

        private void regBtn_Click(object sender, EventArgs e)
        {

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Password = "root";
            builder.Database = "ecamp";
            builder.SslMode = MySqlSslMode.Disabled;

     

            try
            {
                connection = new MySqlConnection(builder.ToString());

                String name = fname.Text;
                String age = ageBox.Text;
                String gender = gend.Text;
                String contact = cont.Text;
                String optionals = optrip.Text;
                String guardian_name = dadfname.Text;
                String guardian_cont = dadcont.Text;

                string query = "INSERT INTO camper(c_fullname, c_age, c_gender, c_contact, c_optionaltrip, c_guardianname, c_guardiancont) values (@c_fullname, @c_age, @c_gender, @c_contact, @c_optionaltrip, @c_guardianname, @c_guardiancont);";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@c_fullname", name);
                    cmd.Parameters.AddWithValue("@c_age", age);
                    cmd.Parameters.AddWithValue("@c_gender", gender);
                    cmd.Parameters.AddWithValue("@c_contact", contact);
                    cmd.Parameters.AddWithValue("@c_optionaltrip", optionals);
                    cmd.Parameters.AddWithValue("@c_guardianname", guardian_name);
                    cmd.Parameters.AddWithValue("@c_guardiancont", guardian_cont);

                    MessageBox.Show("Added Successfully");
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            fname.Clear();
            ageBox.Clear();
            cont.Clear();
            //optrip.Clear();
            dadfname.Clear();
            dadcont.Clear();
            ageBox.Clear();
        }
    }
}
