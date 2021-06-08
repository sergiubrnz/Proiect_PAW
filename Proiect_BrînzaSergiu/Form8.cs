using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BrînzaSergiu
{
    
    public partial class Form8 : Form
    {
        string tip;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biblioteca.accdb";
        CititorAcadem cAc = new CititorAcadem();
        CititorAdult cA = new CititorAdult();

        private void populareGrafic()
        {
            chart1.Series["Categorie"].Points.AddXY("Aventura", 10);
            chart1.Series["Categorie"].Points.AddXY("Istorie", 7);
            chart1.Series["Categorie"].Points.AddXY("Memorii", 3);
            chart1.Series["Categorie"].Points.AddXY("Manuale", 9);



            /*OleDbConnection conn = new OleDbConnection(connString);
            List<string> categorii = new List<string>();
            try
            {
                conn.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conn;
                comanda.CommandText = "SELECT DISTINCT categoria FROM Carti";
                
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    categorii.Add(reader["categorie"].ToString());
                }
                reader.Close();

                foreach (string cat in categorii)
                {
                    comanda.CommandText = "SELECT COUNT(categoria) FROM Carti WHERE categoria='"+cat+"'";
                    OleDbDataReader reader1 = comanda.ExecuteReader();
                    while (reader1.Read())
                    {
                        chart1.Series["Categorie"].Points.AddXY(cat, reader["COUNT(categoria)"].ToString());
                    }
                    reader1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }*/



        }
        public Form8()
        {
            
            InitializeComponent();
            populareGrafic();
        }
        public Form8(CititorAcadem c)
        {
            cAc = c;
            tip = c.Tip;
            InitializeComponent();
            populareGrafic();
        }
        public Form8(CititorAdult c)
        {
            cA = c;
            tip = c.Tip;
            InitializeComponent();
            populareGrafic();
        }

        private void button1_Click(object sender, EventArgs e)
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
