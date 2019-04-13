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
    public partial class frmVerTurmas : Form
    {
        public frmVerTurmas()
        {
            InitializeComponent();
        }
        ClassTurma turma = new ClassTurma();
        
        private void frmVerTurmas_Load(object sender, EventArgs e)
        {
            dgvTurma.DataSource = turma.RetTurma();
        }
    }
}
