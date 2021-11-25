using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ReadXLM
{
    public partial class Form1 : Form
    {
        public DataSet listaXml;
        public Assembly assembObj;
        public Form1()
        {
            InitializeComponent();
            listaXml = new DataSet();
        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            listaXml.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "lista.xml");
            int Tables = listaXml.Tables.Count;
            MessageBox.Show("Tables " + Tables);
        }
    }
}
