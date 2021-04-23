using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VizeNTP
{
    public partial class Form1 : Form
    {
        String hava_durumu_link =  "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHavaDurumuBilgiAl_Click(object sender, EventArgs e)
        {
            
            
                
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Hava Durumu");

        }
    }
}
