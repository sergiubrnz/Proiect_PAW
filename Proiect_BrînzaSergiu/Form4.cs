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
using System.Globalization;
using System.Xml;
using System.IO;

namespace Proiect_BrînzaSergiu
{
    public partial class Form4 : Form
    {

        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = biblioteca.accdb";
        CititorAdult citAdult;
        CititorAcadem citAcadem;
        string tip;
        int codcit;

        private void initializareListă(string tip)
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
                if (tip == "Adult")
                {
                    comanda.CommandText = "SELECT * FROM Carti WHERE academic=0";
                }
                else
                {
                    comanda.CommandText = "SELECT * FROM Carti WHERE academic=-1";
                }

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

        private void initializareListăCititor(int cod, string tip)
        {

            OleDbConnection conn = new OleDbConnection(connString);
            List<Carte> carti = new List<Carte>();
            try
            {
                conn.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conn;

                comanda.CommandText = "SELECT * FROM Carti c, Imprumuturi i WHERE c.cod=i.codcarte AND i.codcit=" + cod;


                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    Carte c = new Carte();
                    c.Categorie = reader["categoria"].ToString();
                    c.Denumire = reader["denumire"].ToString();
                    c.Autor = reader["autor"].ToString();
                    c.Isbn = reader["ISBN"].ToString();
                    c.Editura = reader["editura"].ToString();
                    c.An = Convert.ToInt32(reader["an"].ToString());

                    if (reader["academic"].ToString() == "-1")
                    {
                        c.Academ = true;
                    }
                    else
                        c.Academ = false;
                    carti.Add(c);
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
                if (tip == "Academic")
                {
                    citAcadem.CartiImprumutate = carti;
                }
                else if (tip == "Adult")
                {
                    citAdult.CartiImprumutate = carti;
                }

            }
        }

        private void populare_carti(CititorAdult user)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            List<Carte> carti = new List<Carte>();
            try
            {
                conn.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conn;
                comanda.CommandText = "select * from Carti c, Imprumuturi i where c.cod=i.cod_carte and i.cod_cit=" + user.CodCititor;


                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    Carte c = new Carte();
                    c.Categorie = reader["categoria"].ToString();
                    c.Denumire = reader["denumire"].ToString();
                    c.Autor = reader["autor"].ToString();
                    c.Isbn = reader["ISBN"].ToString();
                    c.Editura = reader["editura"].ToString();
                    c.An = Convert.ToInt32(reader["an"].ToString());

                    if (reader["academic"].ToString() == "-1")
                    {
                        c.Academ = true;
                    }
                    else
                        c.Academ = false;
                    user.CartiImprumutate.Add(c);

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

        public Form4(CititorAdult c)
        {
            tip = "Adult";
            InitializeComponent();
            initializareListă(tip);
            citAdult = c;
            c.CartiImprumutate = new List<Carte>();
            codcit = c.CodCititor;
            initializareListăCititor(codcit, tip);
        }

        public Form4(CititorAcadem c)
        {
            tip = "Academic";
            InitializeComponent();
            initializareListă(tip);
            citAcadem = c;
            c.CartiImprumutate = new List<Carte>();
            codcit = c.CodCititor;
            initializareListăCititor(codcit, tip);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            listViewCarti.Clear();
            initializareListă(tip);
        }

        private void informațiiContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tip == "Academic")
                MessageBox.Show(citAcadem.ToString());
            else if (tip == "Adult")
                MessageBox.Show(citAdult.ToString());
        }

        private void exportăListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tip == "Adult")
            {
                MemoryStream memStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();

                writer.WriteStartElement(citAdult.Nume);
                writer.WriteStartElement(citAdult.CodNumericPersonal);
                writer.WriteStartElement(citAdult.DataNastere.ToString());

                if (citAdult.CartiImprumutate != null)
                {
                    int nrCarte = 1;
                    foreach (Carte c in citAdult.CartiImprumutate)
                    {
                        writer.WriteStartElement("Cartea " + nrCarte++);
                        writer.WriteAttributeString("denumire ", c.Denumire);
                        writer.WriteAttributeString("autor ", c.Autor);
                        writer.WriteAttributeString("categoria ", c.Categorie);
                        writer.WriteAttributeString("an ", c.An.ToString());
                        writer.WriteAttributeString("ISBN ", c.Isbn);
                        writer.WriteValue("Carte");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                string str = Encoding.UTF8.GetString(memStream.ToArray());
                memStream.Close();

                StreamWriter sw = new StreamWriter("fisier.xml");
                sw.WriteLine(str);
                sw.Close();
            }
            else if (tip == "Academic")
            {
                MemoryStream memStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();

                writer.WriteStartElement(citAcadem.Nume);

                if (citAcadem.CartiImprumutate != null)
                {
                    int nrCarte = 1;
                    foreach (Carte c in citAcadem.CartiImprumutate)
                    {
                        writer.WriteStartElement("Cartea " + nrCarte++);
                        writer.WriteAttributeString("denumire ", c.Denumire);
                        writer.WriteAttributeString("autor ", c.Autor);
                        writer.WriteAttributeString("categoria ", c.Categorie);
                        writer.WriteAttributeString("an ", c.An.ToString());
                        writer.WriteAttributeString("ISBN ", c.Isbn);
                        writer.WriteValue("Carte");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                string str = Encoding.UTF8.GetString(memStream.ToArray());
                memStream.Close();

                StreamWriter sw = new StreamWriter("fisier.xml");
                sw.WriteLine(str);
                sw.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewCarti.Items)
                if (item.Selected)
                {
                    int cant = Convert.ToInt32(item.ListView.SelectedItems[0].SubItems[8].Text);
                    if (cant == 0)
                    {
                        MessageBox.Show("Cantitate indisponibila!");
                    }
                    else
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
                                    string denumire = itm.ListView.SelectedItems[0].SubItems[2].Text;
                                    comanda.CommandText = "INSERT INTO Imprumuturi VALUES(?,?,?)";
                                    comanda.Parameters.Add("codcarte", OleDbType.Integer).Value = cod;
                                    comanda.Parameters.Add("denumire", OleDbType.Char, 30).Value = denumire;
                                    comanda.Parameters.Add("codcit", OleDbType.Integer).Value = codcit;
                                    comanda.ExecuteNonQuery();
                                    comanda.CommandText = "UPDATE Carti SET cantitate=cantitate-1 WHERE cod=" + cod;
                                    comanda.ExecuteNonQuery();
                                    MessageBox.Show("Împrumut efectuat cu succes!");

                                    Carte ca = new Carte();
                                    comanda.CommandText = "SELECT * FROM Carti WHERE cod=" + cod;
                                    OleDbDataReader reader = comanda.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        ca.Categorie = reader["categoria"].ToString();
                                        ca.Denumire = reader["denumire"].ToString();
                                        ca.Autor = reader["autor"].ToString();
                                        ca.Isbn = reader["ISBN"].ToString();
                                        ca.Editura = reader["editura"].ToString();
                                        ca.An = Convert.ToInt32(reader["an"].ToString());
                                        if (reader["academic"].ToString() == "-1")
                                        {
                                            ca.Academ = true;
                                        }
                                        else
                                            ca.Academ = false;
                                    }
                                    if (tip == "Academic")
                                        citAcadem.CartiImprumutate.Add(ca);
                                    else if (tip == "Adult")
                                        citAdult.CartiImprumutate.Add(ca);
                                }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                            initializareListă(tip);
                        }
                    }
                }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tip == "Academic")
            {
                Form7 form7 = new Form7(citAcadem);
                this.Hide();
                form7.ShowDialog();
            }
            else if (tip == "Adult")
            {
                Form7 form7 = new Form7(citAdult);
                this.Hide();
                form7.ShowDialog();
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tip == "Academic")
            {
                Form8 form8 = new Form8(citAcadem);
                this.Hide();
                form8.ShowDialog();
                this.Close();
            }
            else if (tip == "Adult")
            {
                Form8 form8 = new Form8(citAdult);
                this.Hide();
                form8.ShowDialog();
                this.Close();
            }
        }
    }
}
