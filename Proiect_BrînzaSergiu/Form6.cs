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
    public partial class Form6 : Form
    {
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biblioteca.accdb";
        public Form6()
        {
            InitializeComponent();
            initializareListă();
        }

        private void tbNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        void initializareListă()
        {
            listViewCarti.Clear();
            listViewCarti.Columns.Add("Cod", 40);
            listViewCarti.Columns.Add("Categorie", 120);
            listViewCarti.Columns.Add("Denumire", 150);
            listViewCarti.Columns.Add("Autor", 100);
            listViewCarti.Columns.Add("ISBN", 110);
            listViewCarti.Columns.Add("Editură", 120);
            listViewCarti.Columns.Add("An lansare", 70);
            listViewCarti.Columns.Add("Academic", 50);
            listViewCarti.Columns.Add("Cantitate", 40);

            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conn;
                comanda.CommandText = "SELECT * FROM Carti";

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cod"].ToString());
                    itm.SubItems.Add(reader["categoria"].ToString());
                    itm.SubItems.Add(reader["denumire"].ToString());
                    itm.SubItems.Add(reader["autor"].ToString());
                    itm.SubItems.Add(reader["ISBN"].ToString());
                    itm.SubItems.Add(reader["editura"].ToString());
                    itm.SubItems.Add(reader["an"].ToString());

                    if (reader["academic"].ToString() == "-1")
                    {
                        itm.SubItems.Add("Da");
                    }
                    else
                        itm.SubItems.Add("Nu");
                    itm.SubItems.Add(reader["cantitate"].ToString());
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

        private void Form6_Load(object sender, EventArgs e)
        {
            panel1.AllowDrop = true;
            initializareListă();
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
                        comanda.CommandText = "DELETE FROM Carti WHERE cod=" + cod;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                initializareListă();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                        if (textBox1.Text == "")
                        {
                            errorProvider1.SetError(textBox1, "Acest câmp este obligatoriu!");
                        }
                        else
                        {
                            comanda.CommandText = "UPDATE Carti SET cantitate=@cantitate WHERE cod=" + cod;
                            comanda.Parameters.AddWithValue("cantitate", Convert.ToInt32(textBox1.Text));
                            comanda.ExecuteNonQuery();
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                initializareListă();
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                int cod = Convert.ToInt32(item.ListView.SelectedItems[0].SubItems[0].Text);


                OleDbConnection conexiune = new OleDbConnection(connString);

                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "DELETE FROM Carti WHERE cod=" + cod;
                    comanda.ExecuteNonQuery();
                    initializareListă();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.Source);
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            {
                e.Effect = DragDropEffects.Move;
            }

        }

        private void listViewCarti_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
