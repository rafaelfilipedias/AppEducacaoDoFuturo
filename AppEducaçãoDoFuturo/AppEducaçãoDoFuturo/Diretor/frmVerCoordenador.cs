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
    public partial class frmVerCoordenador : Form
    {
        public frmVerCoordenador()
        {
            InitializeComponent();
        }
        ClassCoordenadorCurso c = new ClassCoordenadorCurso();
        private void frmVerCoordenador_Load(object sender, EventArgs e)
        {
            dgvCoordenador.DataSource = c.RetCoordenador();
        }
    }
}
