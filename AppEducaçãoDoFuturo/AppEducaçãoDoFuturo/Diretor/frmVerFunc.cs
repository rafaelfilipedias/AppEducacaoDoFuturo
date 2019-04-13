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
    public partial class frmVerFunc : Form
    {
        public frmVerFunc()
        {
            InitializeComponent();
        }
        ClassFuncionario func = new ClassFuncionario();
        private void frmVerFunc_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = func.RetFuncionario();
        }

        
    }
}
