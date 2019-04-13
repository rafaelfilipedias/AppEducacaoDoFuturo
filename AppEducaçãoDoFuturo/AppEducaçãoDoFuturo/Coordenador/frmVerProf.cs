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
    public partial class frmVerProf : Form
    {
        public frmVerProf()
        {
            InitializeComponent();
        }
        ClassProfessor prof = new ClassProfessor();
        private void frmVerProf_Load(object sender, EventArgs e)
        {
            dgvProf.DataSource = prof.RetProfessor();
        }
    }
}
