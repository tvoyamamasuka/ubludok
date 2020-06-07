using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FTP
{
    public partial class Form1 : Form
    {
        public string CmdText = "SELECT * FROM [Зарплата]";
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\github\\Project\\FTP\\FTP\\ДАТАБАСЕ21.mdb";


        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Зарплата]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дАТАБАСЕ21DataSet.Зарплата". При необходимости она может быть перемещена или удалена.
            this.зарплатаTableAdapter.Fill(this.дАТАБАСЕ21DataSet.Зарплата);

        }
    }
}