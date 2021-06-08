using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.OleDb;

namespace Proiect_BrînzaSergiu
{
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();
        Form6 form6 = new Form6();
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biblioteca.accdb";
        public Form3()
        {
            InitializeComponent();
        }

        private void tbAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            bool error = false;
            try
            {
                conn.Open();
                comanda.Connection = conn;
                if (tbDenumire.Text == "")
                {
                    errorProvider1.SetError(tbDenumire, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbDenumire, "");
                    error = false;
                }
                if (tbAutor.Text == "")
                {
                    errorProvider1.SetError(tbAutor, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbAutor, "");
                    error = false;
                }

                if (tbEditura.Text == "")
                {
                    errorProvider1.SetError(tbEditura, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbEditura, "");
                    error = false;
                }

                if (tbISBN.Text == "")
                {
                    errorProvider1.SetError(tbISBN, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbISBN, "");
                    error = false;
                }

                if (tbAn.Text == "")
                {
                    errorProvider1.SetError(tbAn, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                if(tbAn.Text.Length!=4)
                {
                    errorProvider1.SetError(tbAn, "Format incorect");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbAn, "");
                    error = false;
                }

                if (cbCategorie.SelectedItem == null)
                {
                    errorProvider1.SetError(cbCategorie, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(cbCategorie, "");
                    error = false;
                }

                if (!error)
                {
                    string denumire = tbDenumire.Text;
                    string autor = tbAutor.Text;
                    string isbn = tbISBN.Text;
                    string editura = tbEditura.Text;
                    int an = Convert.ToInt32(tbAn.Text);
                    string categorie = cbCategorie.Text;
                    bool academic = cbAcademic.Checked;
                    int cantitate = Convert.ToInt32(numericUpDown1.Value); 

                    Carte C = new Carte(denumire, autor, isbn, editura, an, categorie, academic);

                    comanda.CommandText = "SELECT MAX(cod) FROM Carti";
                    int cod = Convert.ToInt32(comanda.ExecuteScalar());

                    comanda.CommandText = "INSERT INTO Carti VALUES(?,?,?,?,?,?,?,?,?)";

                    comanda.Parameters.Add("cod", OleDbType.Integer).Value = cod+1;
                    comanda.Parameters.Add("denumire", OleDbType.Char, 30).Value = C.Denumire;
                    comanda.Parameters.Add("autor", OleDbType.Char, 30).Value = C.Autor;
                    comanda.Parameters.Add("ISBN", OleDbType.Char, 16).Value = C.Isbn;
                    comanda.Parameters.Add("categorie", OleDbType.Char, 20).Value = C.Categorie;
                    comanda.Parameters.Add("editura", OleDbType.Char, 10).Value = C.Editura;
                    comanda.Parameters.Add("an", OleDbType.Integer).Value = C.An;
                    comanda.Parameters.Add("academic", OleDbType.Boolean).Value = C.Academ;
                    comanda.Parameters.Add("cantitate", OleDbType.Integer).Value = cantitate;

                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Carte nouă adaugat cu succes!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                tbAn.Clear();
                tbDenumire.Clear();
                tbAutor.Clear();
                tbEditura.Clear();
                tbISBN.Clear();
                cbCategorie.Text = "";
                cbAcademic.Checked = false;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form6.ShowDialog();
            this.Close();
        }
    }

}
