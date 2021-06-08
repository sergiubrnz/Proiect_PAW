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
using System.Data.OleDb;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace Proiect_BrînzaSergiu
{
    
    public partial class Form2 : Form
    {
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biblioteca.accdb";
        CultureInfo culture = new CultureInfo("fr-FR");

        Form1 form1 = new Form1();
        List<CititorAdult> Adulti = new List<CititorAdult>();
        List<CititorAcadem> Academic = new List<CititorAcadem>();
        List<Carte> CartiImprumutate = new List<Carte>();
        public Form2()
        {
            InitializeComponent();
        }

        public bool EmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void btnInregistrare_Click_1(object sender, EventArgs e)
        {
            bool error = false;
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conn.Open();
                comanda.Connection = conn;

                if (rbClasic.Checked == false && rbAcademic.Checked == false)
                {
                    errorProvider1.SetError(groupBox2, "Alegeți o obțiune!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(groupBox2, "");
                    error = false;
                }
                if (tbNume.Text == "")
                {
                    errorProvider1.SetError(tbNume, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbNume, "");
                    error = false;
                }

                if (tbCNP.Text == "")
                {
                    errorProvider1.SetError(tbCNP, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbCNP, "");
                    error = false;
                }

                if (tbCNP.Text.Length != 13)
                {
                    errorProvider1.SetError(tbCNP, "CNP-ul trebuie să aibă 13 caractere");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbCNP, "");
                    error = false;
                }

                if (tbEmail.Text == "")
                {
                    errorProvider1.SetError(tbEmail, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbEmail, "");
                    error = false;
                }

                if (!EmailValid(tbEmail.Text))
                {
                    errorProvider1.SetError(tbEmail, "Email invalid");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbEmail, "");
                    error = true;
                }

                if (tbAdresa.Text == "")
                {
                    errorProvider1.SetError(tbAdresa, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbAdresa, "");
                    error = false;
                }

                if (tbTelefon.Text == "")
                {
                    errorProvider1.SetError(tbTelefon, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbTelefon, "");
                    error = false;
                }

                if (tbTelefon.Text.Length != 10)
                {
                    errorProvider1.SetError(tbTelefon, "Numărul de telefon trebuie să aibă 10 caractere");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbTelefon, "");
                    error = false;
                }

                if (tbParola.Text == "")
                {
                    errorProvider1.SetError(tbParola, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbParola, "");
                    error = false;
                }

                if (tbRepetare.Text == "")
                {
                    errorProvider1.SetError(tbRepetare, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbRepetare, "");
                    error = false;
                }

                if (tbRepetare.Text != tbParola.Text)
                {
                    errorProvider1.SetError(tbRepetare, "Parola nu coincide!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbRepetare, "");
                    error = false;
                }

                if (dtNastere.Value.ToString() == "01.01.1990 00:00:00")
                {
                    errorProvider1.SetError(dtNastere, "Acest câmp este obligatoriu!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(dtNastere, "");
                    error = false;
                }
                if (rbClasic.Checked == true)
                {
                    if (!error)
                    {
                        string nume = tbNume.Text;
                        string adresa = tbAdresa.Text;
                        string telefon = tbTelefon.Text;
                        string email = tbEmail.Text;
                        DateTime data = dtNastere.Value;
                        string parola = tbParola.Text;
                        string CNP = tbCNP.Text;
                        string universitate = "-";
                        string titlu = "-";

                        int cod = Convert.ToInt32(CNP.Substring(7, 6));

                        CititorAdult ca = new CititorAdult(cod, adresa, nume, telefon, email, data, parola, CNP);

                        int nrUseri = 0;
                        OleDbCommand checkUniqueUser = new OleDbCommand("SELECT email FROM cititor WHERE email='" + ca.Email + "'", conn);
                        OleDbDataReader readUsers = checkUniqueUser.ExecuteReader();
                        while (readUsers.Read())
                        {
                            nrUseri++;
                        }

                        if (nrUseri > 0)
                        {
                            MessageBox.Show("Exista deja un utilizator cu acest username!");
                        }
                        else
                        {

                            comanda.CommandText = "INSERT INTO Cititor VALUES(?,?,?,?,?,?,?,?,?,?,?)";

                            comanda.Parameters.Add("cod", OleDbType.Integer).Value = ca.CodCititor;
                            comanda.Parameters.Add("tip", OleDbType.Char, 10).Value = ca.Tip;
                            comanda.Parameters.Add("nume", OleDbType.Char, 30).Value = ca.Nume;
                            comanda.Parameters.Add("cnp", OleDbType.Char, 13).Value = ca.CodNumericPersonal;
                            comanda.Parameters.Add("adresa", OleDbType.Char, 30).Value = ca.Adresa;
                            comanda.Parameters.Add("telefon", OleDbType.Char, 10).Value = ca.NrTelefon;
                            comanda.Parameters.Add("email", OleDbType.Char, 20).Value = ca.Email;
                            comanda.Parameters.Add("dataNastere", OleDbType.Char, 30).Value = dtNastere.Value.ToString("d", culture);
                            comanda.Parameters.Add("parola", OleDbType.Char, 20).Value = ca.Parola;
                            comanda.Parameters.Add("universitate", OleDbType.Char, 20).Value = universitate;
                            comanda.Parameters.Add("titlu", OleDbType.Char, 20).Value = titlu;

                            comanda.ExecuteNonQuery();
                            MessageBox.Show("Utilizator nou adaugat cu succes!");
                        }
                    }
                }
                else
                    if (rbAcademic.Checked == true)
                {
                    if (tbUni.Text == "")
                    {
                        errorProvider1.SetError(tbUni, "Acest câmp este obligatoriu!");
                        error = true;
                    }
                    else
                    {
                        errorProvider1.SetError(tbUni, "");
                        error = false;
                    }

                    if (cbTitlu.SelectedItem == null)
                    {
                        errorProvider1.SetError(cbTitlu, "Acest câmp este obligatoriu!");
                        error = true;
                    }
                    else
                    {
                        errorProvider1.SetError(cbTitlu, "");
                        error = false;
                    }


                    if (!error)
                    {
                        string nume = tbNume.Text;
                        string adresa = tbAdresa.Text;
                        string telefon = tbTelefon.Text;
                        string email = tbEmail.Text;
                        DateTime data = dtNastere.Value;
                        string parola = tbParola.Text;
                        string CNP = tbCNP.Text;
                        string universitate = tbUni.Text;
                        string titlu = cbTitlu.Text;

                        int cod = Convert.ToInt32(CNP.Substring(7, 6));

                        CititorAcadem ca = new CititorAcadem(cod, adresa, nume, telefon, email, data, parola, CNP, universitate, titlu);

                        int nrUseri = 0;
                        OleDbCommand checkUniqueUser = new OleDbCommand("SELECT email FROM cititor WHERE email='" + ca.Email + "'", conn);
                        OleDbDataReader readUsers = checkUniqueUser.ExecuteReader();
                        while (readUsers.Read())
                        {
                            nrUseri++;
                        }

                        if (nrUseri > 0)
                        {
                            MessageBox.Show("Exista deja un utilizator cu acest username!");
                        }
                        else
                        {
                            comanda.CommandText = "INSERT INTO Cititor VALUES(?,?,?,?,?,?,?,?,?,?,?)";

                            comanda.Parameters.Add("cod", OleDbType.Integer).Value = ca.CodCititor;
                            comanda.Parameters.Add("tip", OleDbType.Char, 10).Value = ca.Tip;
                            comanda.Parameters.Add("nume", OleDbType.Char, 30).Value = ca.Nume;
                            comanda.Parameters.Add("cnp", OleDbType.Char, 13).Value = ca.CodNumericPersonal;
                            comanda.Parameters.Add("adresa", OleDbType.Char, 30).Value = ca.Adresa;
                            comanda.Parameters.Add("telefon", OleDbType.Char, 10).Value = ca.NrTelefon;
                            comanda.Parameters.Add("email", OleDbType.Char, 20).Value = ca.Email;
                            comanda.Parameters.Add("dataNastere", OleDbType.Char, 30).Value = dtNastere.Value.ToString("d", culture);
                            comanda.Parameters.Add("parola", OleDbType.Char, 20).Value = ca.Parola;
                            comanda.Parameters.Add("universitate", OleDbType.Char, 20).Value = ca.Universitate;
                            comanda.Parameters.Add("titlu", OleDbType.Char, 20).Value = ca.Titlu;

                            comanda.ExecuteNonQuery();
                            MessageBox.Show("Utilizator nou adaugat cu succes!");
                        }
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
                tbAdresa.Clear();
                tbCNP.Clear();
                tbEmail.Clear();
                tbNume.Clear();
                tbParola.Clear();
                tbRepetare.Clear();
                tbTelefon.Clear();
                tbUni.Clear();
                cbTitlu.Text = "";
                rbClasic.Checked = false;
                rbAcademic.Checked = false;
            }
        }

        private void tbCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8 || char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void rbClasic_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label19.Visible = false;
            label20.Visible = false;
            label15.Visible = true;
            label16.Visible = true;

            tbAdresa.Visible = true;
            tbCNP.Visible = true;
            tbEmail.Visible = true;
            tbNume.Visible = true;
            tbParola.Visible = true;
            tbRepetare.Visible = true;
            tbTelefon.Visible = true;
            dtNastere.Visible = true;
            tbUni.Visible = false;
            cbTitlu.Visible = false;

            btnInregistrare.Visible = true;
        }

        private void rbAcademic_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            tbAdresa.Visible = true;
            tbCNP.Visible = true;
            tbEmail.Visible = true;
            tbNume.Visible = true;
            tbParola.Visible = true;
            tbRepetare.Visible = true;
            tbTelefon.Visible = true;
            dtNastere.Visible = true;
            tbUni.Visible = true;
            cbTitlu.Visible = true;

            btnInregistrare.Visible = true;
        }

    }
}
