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
    public partial class frmVerFrequencia : Form
    {
        public frmVerFrequencia()
        {
            InitializeComponent();
        }
        ClassFrequenciaFunc func = new ClassFrequenciaFunc();
        private void frmVerFrequencia_Load(object sender, EventArgs e)
        {
            dgvFrequencia.DataSource = func.RetFrequenciaFunc();
        }
    }
}
