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
    public partial class Form1 : Form
    {
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biblioteca.accdb";
        
        public Form1()
        {
            InitializeComponent();
        }



        private void btnContNou_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            BinaryFormatter bf = new BinaryFormatter();
            if (tbUser.Text == "admin" && tbPassword.Text=="admin")
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }else if (tbUser.Text == "" || tbPassword.Text == "")
                MessageBox.Show("Introduceti datele de conectare!");
            else
            {
                OleDbConnection conn = new OleDbConnection(connString);
                OleDbCommand comanda = new OleDbCommand();
                comanda.CommandText = "select * from Cititor where email like @Nume and parola like @Parola;";
                comanda.Parameters.AddWithValue("@Nume", tbUser.Text);
                comanda.Parameters.AddWithValue("@Parola", tbPassword.Text);
                comanda.Connection = conn;
                conn.Open();
                int nr = 0;

                try
                {
                    OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {

                    if (rbClasic.Checked == true)
                    {
                        nr = 1;
                        CititorAdult user = new CititorAdult();
                        user.Nume = reader["nume"].ToString();
                        user.Parola = reader["parola"].ToString();
                        user.DataNastere = Convert.ToDateTime(reader["dataNastere"].ToString());
                        user.Adresa = reader["adresa"].ToString();
                        user.CodNumericPersonal = reader["cnp"].ToString();
                        user.CodCititor = Convert.ToInt32(reader["cod"].ToString());
                        user.NrTelefon = reader["telefon"].ToString();
                        user.Email = reader["email"].ToString();
                        user.Tip = reader["tip"].ToString();

                        Form4 form4 = new Form4(user);
                        this.Hide();
                        form4.ShowDialog();
                        this.Close();
                    }
                    else if (rbAcademic.Checked == true)
                    {
                        nr = 1;
                        CititorAcadem user = new CititorAcadem();
                        user.Nume = reader["nume"].ToString();
                        user.Parola = reader["parola"].ToString();
                        user.DataNastere = Convert.ToDateTime(reader["dataNastere"].ToString());
                        user.Adresa = reader["adresa"].ToString();
                        user.CodNumericPersonal = reader["cnp"].ToString();
                        user.CodCititor = Convert.ToInt32(reader["cod"].ToString());
                        user.NrTelefon = reader["telefon"].ToString();
                        user.Email = reader["email"].ToString();
                        user.Universitate = reader["universitate"].ToString();
                        user.Titlu = reader["titlu"].ToString();
                        user.Tip = reader["tip"].ToString();

                        Form4 form4 = new Form4(user);
                        this.Hide();
                        form4.ShowDialog();
                        this.Close();
                    }
                }
                if(nr==0)
                {
                    MessageBox.Show("Ati introdus date incorecte!");
                }
                
                    if (rbClasic.Checked == false && rbAcademic.Checked == false)
                    {
                        errorProvider1.SetError(groupBox1, "Alegeți o obțiune!");
                    }
                    else
                    {
                        errorProvider1.SetError(groupBox1, "");
                    }
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
        }

    }
}
