using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaElectoral1.Models;
using System.Windows.Forms;

namespace SistemaElectoral1.Vistas
{
    public partial class frmUsuarios : Form
    {
        private Usuario _usuario;
        public frmUsuarios(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
    }
}