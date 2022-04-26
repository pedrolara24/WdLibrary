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

namespace wLibreria2
{
    public partial class FrmHijo : Form
    {
        public FrmHijo()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formhijo = this.ActiveMdiChild;
            if (formhijo != null)
            {
                formhijo.Close();
            }
        }
    }
}
