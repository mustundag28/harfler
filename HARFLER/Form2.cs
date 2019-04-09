using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HARFLER
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'harflerDataSet.UCLU' table. You can move, or remove it, as needed.
            this.uCLUTableAdapter.Fill(harflerDataSet.UCLU);

        }

        private void button2_Click(object sender, EventArgs e)
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
        private void ikiliHarf(string girdi)
        {
            //girdimiz abcd olsun a b c yi, sonra b c d yi işleyeceği için döngüsayısı Length -2 oldu 
            //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\harfler.mdb;Persist Security Info=True
            IDBManager mng = new DBManager(DataProvider.OleDb, DBManager.cnnStr);
            Cursor.Current = Cursors.WaitCursor;


            string cmdText = "";

            int ihtimal = 0;

            for (int i = 0; i < girdi.Length - 2; i++)
            {
                // index i ile i+1 i kaydedeceğiz
                // harfDeger(girdi[i]) harfDeger(girdi[i+1])
                //maxımumu alacaz
                try
                {
                    cmdText = "select OLASILIK from UCLU WHERE HARF1 = '" + girdi[i] + "' AND HARF2 = '" + girdi[i + 1] + "' AND HARF3 = '" + girdi[i + 2] + "'";
                    mng.Open();

                    DataSet ds = mng.ExecuteDataSet(CommandType.Text, cmdText);
                    DataTable dt = ds.Tables[0];
                    mng.Close();

                    ihtimal = Int32.Parse(dt.Rows[0][0].ToString());
                    ihtimal++;

                    cmdText = "UPDATE UCLU SET OLASILIK = " + ihtimal + " WHERE HARF1='" + girdi[i] + "' AND HARF2='" + girdi[i + 1] + "' AND HARF3='" + girdi[i + 2] + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IDBManager mng = new DBManager(DataProvider.OleDb, DBManager.cnnStr);
            Cursor.Current = Cursors.WaitCursor;


            string cmdText = "";

            //DELETE işlemi
            try
            {
                mng.Open();

                cmdText = "UPDATE UCLU SET OLASILIK = 0";
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
//INSERT
//IDBManager mng = new DBManager(DataProvider.OleDb, DBManager.cnnStr);
//            Cursor.Current = Cursors.WaitCursor;


//            string cmdText = "";

//            //insert işlemi
//            string deger = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ0123456789";
//            try
//            {
//                mng.Open();
//                for (int i = 0; i < deger.Length; i++)
//                {                                       
//                    for (int j = 0; j < deger.Length; j++)
//                    {
//                        for (int k = 0; k < deger.Length; k++ )
//                        {
//                            cmdText = "INSERT INTO UCLU(HARF1,HARF2,HARF3) VALUES ('" + deger[i] + "','" + deger[j] + "','" + deger[k] + "')";
//                            mng.ExecuteNonQuery(CommandType.Text, cmdText);                            
//                        }
//                    }                    
//                }
//                mng.Close();
//            }
//            catch (Exception exp)
//            {
//                //MessageBox.Show(exp.Message + "\n" + exp.StackTrace);
//            }
//            finally
//            {
//                if (mng.Connection.State != ConnectionState.Closed)
//                    mng.Close();

//                Cursor.Current = Cursors.Default;
//            }