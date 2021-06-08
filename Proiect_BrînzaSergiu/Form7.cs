using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect_BrînzaSergiu
{
    public partial class Form7 : Form
    {
        string tip;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biblioteca.accdb";
        int codcit;
        CititorAcadem cAc = new CititorAcadem();
        CititorAdult cA = new CititorAdult();

        private void initializareListă(int cod)
        {
            listViewCarti.Clear();
            listViewCarti.Columns.Add("Cod carte", 100);
            listViewCarti.Columns.Add("Denumire", 120);
            listViewCarti.Columns.Add("Cod cititor", 150);


            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conn;

                comanda.CommandText = "SELECT * FROM Imprumuturi WHERE codcit=@cod";
                comanda.Parameters.AddWithValue("@cod", cod);


                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["codcarte"].ToString());
                    itm.SubItems.Add(reader["denumire"].ToString());
                    itm.SubItems.Add(reader["codcit"].ToString());

                    listViewCarti.Items.Add(itm);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public Form7(CititorAdult c)
        {
            cA = c;
            tip = c.Tip;
            InitializeComponent();
            initializareListă(c.CodCititor);
            codcit = c.CodCititor;
        }

        public Form7(CititorAcadem c)
        {
            cAc = c;
            tip = c.Tip;
            InitializeComponent();
            initializareListă(c.CodCititor);
            codcit = c.CodCititor;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conn;
                foreach (ListViewItem itm in listViewCarti.Items)
                    if (itm.Selected)
                    {
                        int cod = Convert.ToInt32(itm.ListView.SelectedItems[0].SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM Imprumuturi WHERE codcarte="+cod+" AND codcit="+codcit;
                        comanda.ExecuteNonQuery();
                        comanda.CommandText = "UPDATE Carti SET cantitate=cantitate+1 WHERE cod="+ cod;
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Retur efectuat cu succes!");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                initializareListă(codcit);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tip == "Academic")
            {
                Form4 form4 = new Form4(cAc);
                this.Hide();
                form4.ShowDialog();
                this.Close();
            }
            else if (tip == "Adult")
            {
                Form4 form4 = new Form4(cA);
                this.Hide();
                form4.ShowDialog();
                this.Close();
            }
        }
    }
}
