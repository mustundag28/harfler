using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HARFLER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader = new StreamReader(textBox1.Text);
                string text = streamReader.ReadToEnd();
                streamReader.Close();

                text = text.Trim();

                text = text.Replace("ı", "I");
                text = text.Replace("i", "İ");
                text = text.Replace("ğ", "Ğ");
                text = text.Replace("ü", "Ü");
                text = text.Replace("ö", "Ö");
                text = text.Replace("ş", "Ş");
                
                text = text.ToUpper();

                //yabancı ifadeleri stringten atacağız
                string gecerli = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ0123456789";
                for (int i = 0; i < text.Length; i++)
                {
                    if (gecerli.IndexOf(text[i]) == -1)
                    {
                        text = text.Replace(text[i].ToString(), " ");
                    }
                }

                textBox2.Text = text;
                
                string[] kelimeler = text.Split(' ');
                //elimizde kelimelerimiz var. şimdi algoritma zamanı...
                for (int i = 0; i < kelimeler.Length; i++)
                    ikiliHarf(kelimeler[i]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("dosya okunmasında hata oluştu: hata =" + ex.Message);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'harflerDataSet1.IKILI' table. You can move, or remove it, as needed.
            this.iKILITableAdapter1.Fill(this.harflerDataSet1.IKILI);

        }

        private void ikiliHarf(string girdi)
        {
            //girdimiz abc olsun a ile b yi, sonra b ile c yi işleyeceği için döngüsayısı Length -1 oldu 
            //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\harfler.mdb;Persist Security Info=True
            IDBManager mng = new DBManager(DataProvider.OleDb, DBManager.cnnStr);
            Cursor.Current = Cursors.WaitCursor;


            string cmdText = "";

            int ihtimal = 0;

            for (int i = 0; i < girdi.Length - 1; i++)
            {
                // index i ile i+1 i kaydedeceğiz
                // harfDeger(girdi[i]) harfDeger(girdi[i+1])
                //maxımumu alacaz
                try
                {
                    cmdText = "select OLASILIK from IKILI WHERE HARF1 = '" + girdi[i] + "' AND HARF2 = '" + girdi[i + 1] + "'";
                    mng.Open();

                    DataSet ds = mng.ExecuteDataSet(CommandType.Text, cmdText);
                    DataTable dt = ds.Tables[0];
                    mng.Close();

                    ihtimal = Int32.Parse(dt.Rows[0][0].ToString());
                    ihtimal++;

                    cmdText = "UPDATE IKILI SET OLASILIK = "+ ihtimal +" WHERE HARF1='" + girdi[i] + "' AND HARF2='" + girdi[i + 1] + "'";
                    mng.Open();
                    mng.ExecuteNonQuery(CommandType.Text, cmdText);
                    ihtimal = 0;
                    mng.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message + "\n" + exp.StackTrace);
                }
                finally
                {
                    if (mng.Connection.State != ConnectionState.Closed)
                        mng.Close();

                    Cursor.Current = Cursors.Default;
                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            IDBManager mng = new DBManager(DataProvider.OleDb, DBManager.cnnStr);
            Cursor.Current = Cursors.WaitCursor;


            string cmdText = "";

            //insert işlemi
            string deger = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ0123456789";
            try
            {
                for (int i = 0; i < deger.Length; i++)
                {

                    mng.Open();
                    for (int j = 0; j < deger.Length; j++)
                    {
                        if (i != j)
                        {


                            cmdText = "INSERT INTO IKILI(HARF1,HARF2) VALUES ('" + deger[i] + "','" + deger[j] + "')";



                            mng.ExecuteNonQuery(CommandType.Text, cmdText);




                        }
                    }
                    mng.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "\n" + exp.StackTrace);
            }
            finally
            {
                if (mng.Connection.State != ConnectionState.Closed)
                    mng.Close();

                Cursor.Current = Cursors.Default;
            }
            dataGridView1.Refresh();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            IDBManager mng = new DBManager(DataProvider.OleDb, DBManager.cnnStr);
            Cursor.Current = Cursors.WaitCursor;


            string cmdText = "";

            //DELETE işlemi
            try
            {
                mng.Open();

                cmdText = "UPDATE IKILI SET OLASILIK = 0";
                mng.ExecuteNonQuery(CommandType.Text, cmdText);

                mng.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message + "\n" + exp.StackTrace);
            }
            finally
            {
                if (mng.Connection.State != ConnectionState.Closed)
                    mng.Close();

                Cursor.Current = Cursors.Default;
            }
        }
    }
}
//            IDBManager mng = new DBManager(DataProvider.OleDb, DBManager.cnnStr);
//            Cursor.Current = Cursors.WaitCursor;


//            string cmdText = "";

//            //insert işlemi
//            string deger = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ0123456789";
//            try
//            {
//                for (int i = 0; i < deger.Length; i++)
//                {

//                    mng.Open();
//                    for (int j = 0; j < deger.Length; j++)
//                    {
//                        if (i != j)
//                        {


//                            cmdText = "INSERT INTO IKILI(HARF1,HARF2) VALUES ('" + deger[i] + "','" + deger[j] + "')";



//                            mng.ExecuteNonQuery(CommandType.Text, cmdText);




//                        }
//                    }
//                    mng.Close();
//                }
//            }
//            catch (Exception exp)
//            {
//                MessageBox.Show(exp.Message + "\n" + exp.StackTrace);
//            }
//            finally
//            {
//                if (mng.Connection.State != ConnectionState.Closed)
//                    mng.Close();

//                Cursor.Current = Cursors.Default;
//            }
//            dataGridView1.Refresh();