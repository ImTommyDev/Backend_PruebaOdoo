using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Backend_PruebaOdoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Conexiones.conexionDB))
                {
                    conn.Open();
                    string query = "SELECT id, login FROM res_users ORDER BY id DESC;"; // Consulta a la tabla de usuarios de Odoo
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridUsuarios.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
