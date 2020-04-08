using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTareaListDGV_MamiferosAcuaticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<MamiferosAcuaticos> ListaDGVMamiferosacuaticos = new List<MamiferosAcuaticos>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void agregarregistro()
        {
            MamiferosAcuaticos mamifero1 = new MamiferosAcuaticos(int.Parse(txtid.Text), txtnombre.Text, txtespecie.Text, txtlocalizacion.Text);
            ListaDGVMamiferosacuaticos.Add(mamifero1);
            DGVmamiferosacuaticos.DataSource = null;
            DGVmamiferosacuaticos.DataSource = ListaDGVMamiferosacuaticos;
        }
        private void btnagregarregistro_Click(object sender, EventArgs e)
        {
            agregarregistro();
        }
    }
}
