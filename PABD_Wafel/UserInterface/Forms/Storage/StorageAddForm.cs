using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PABD.UserInterface.Forms.Storage
{
     partial class StorageAddForm : Form
    {
        public StorageAddForm()
        {
            InitializeComponent();
        }

        private void StorageAddForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
             string sConnectionString = "Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Produkcja; Data Source =.\\DESKTOP-V5O7J68";

            //Utworzenie obiektu SqlConnection
            SqlConnection objConn = new SqlConnection(sConnectionString);
            //Otrwarcie połączenia z bazą danych
            objConn.Open();

            // Utworzenie wystąpienia obiektu DataAdapter.
            SqlDataAdapter daStudenci = new SqlDataAdapter("SELECT *  FROM[Produkcja].[dbo].[Magazyn]", objConn);

            // Utworzenie wystąpienia obiektu DataSet 
            DataSet dsMagazynZestaw = new DataSet("zestaw");
            //Wypełnienie obiektu DataSet  schematem danych
            daStudenci.FillSchema(dsMagazynZestaw, SchemaType.Source, "Magazyn");

            //Wypełnienie obiektu DataSet  danymi z tabeli
            daStudenci.Fill(dsMagazynZestaw, "Magazyn");

            //****************
            // ROZPOCZĘCIE KODU DODAWANIA 
            // Utworzenie nowego wystąpienia obiektu DataTable.
            DataTable dtNowaTabela;
            dtNowaTabela = dsMagazynZestaw.Tables["Magazyn"];

            DataRow drWiersz;
            // Uzyskanie nowego obiektu DataRow z obiektu DataTable.
            drWiersz = dtNowaTabela.NewRow();

            // Ustawienie potrzebnych wartości pól obiektu DataRow.
            drWiersz["Nazwa"] = tbNazwa.Text;
            drWiersz["Kategoria"] = cbGrupaM.SelectedIndex+1; // +1 bo różnica w indeksowaniu 

            drWiersz["MIN"] = tbMin.Text;
            drWiersz["MAX"] = tbMax.Text;
            drWiersz["JEST"] = 0;
            drWiersz["Jednostka"] = cbJednostka.Text;
            // Przekazanie tego nowego obiektu do metody Add obiektu DataTable.
            dtNowaTabela.Rows.Add(drWiersz);


            // ZAKOŃCZENIE KODU DODAWANIA   

            // ROZPOCZĘCIE PRZESYŁANIA ZMIAN DO SERWERA SQL 

            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(daStudenci);

            // Ustawienie parametru gwarantującego kontynuację zapisu pomimo błędu
            daStudenci.ContinueUpdateOnError = true;

            //Przesłanie zmian do serwera SQL
            daStudenci.Update(dsMagazynZestaw, "Magazyn");


            // ZAKOŃCZENIE PRZESYŁANIA ZMIAN DO SERWERA SQL 


            // Zapisanie wartości obiektu DataSet do pliku XML
            //dsStudenci.WriteXml("test.xml", XmlWriteMode.WriteSchema);


            //Odświeżenie zawartości głównego DataGrid w aplikacji
            //wypelnijTabeleDanymi();

            objConn.Close();
            Close();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
