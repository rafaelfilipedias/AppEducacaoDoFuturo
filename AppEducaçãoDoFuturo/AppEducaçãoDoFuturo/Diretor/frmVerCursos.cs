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
    public partial class frmVerCursos : Form
    {
        public frmVerCursos()
        {
            InitializeComponent();
        }
        ClassCurso curso = new ClassCurso();
        private void frmVerCursos_Load(object sender, EventArgs e)
        {
            dgvCursos.DataSource = curso.RetCurso();
        }
    }
}
