using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Exp6
{
    public partial class OyunAyarları : Form
    {
        public OyunAyarları()
        {
            InitializeComponent();
        }
        public event EventHandler<bool> IpucuGorunurlukDegisti;

        private void radioButtonEvet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEvet.Checked)
            {
                IpucuGorunurlukDegisti?.Invoke(this, true);
            }
        }

       

        private void OyunAyarları_Load(object sender, EventArgs e)
        {
            Formoyun formOyun = new Formoyun();
            
        }

        private void Hayır_CheckedChanged(object sender, EventArgs e)
        {
            if (Hayır.Checked)
            {
                IpucuGorunurlukDegisti?.Invoke(this, false);
            }
        }
    }
}
