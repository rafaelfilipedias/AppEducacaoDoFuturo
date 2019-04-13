using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEducaçãoDoFuturo
{
    public partial class frmVerFrequenciaProf : Form
    {
        public frmVerFrequenciaProf()
        {
            InitializeComponent();
        }
        ClassFrequenciaProf prof = new ClassFrequenciaProf();
        private void frmVerFrequenciaProf_Load(object sender, EventArgs e)
        {
            dgvProf.DataSource = prof.RetFrequenciaProf();
        }
    }
}
