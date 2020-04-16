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
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }
        int posicion;
        List<MamiferosAcuaticos> ListaDGVMamiferosacuaticos = new List<MamiferosAcuaticos>();
        private void Form1_Load(object sender, EventArgs e)
        {
            btnmodificarregistro.Enabled = false;
            btneliminarregistro.Enabled = false;
        }
        public void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtespecie.Text = "";
            txtlocalizacion.Text = "";
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
            int id;
            string nombre, especie, localizacion;
            id = int.Parse(txtid.Text);
            nombre = txtnombre.Text;
            especie = txtespecie.Text;
            localizacion = txtlocalizacion.Text;
            DGVmamiferosacuaticos.Rows.Add(i + "", nombre, especie, localizacion);
            i = i + 1;
            agregarregistro();
            limpiar();
            txtid.Focus();
        }
        private void DGVmamiferosacuaticos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = DGVmamiferosacuaticos.CurrentRow.Index;
            txtid.Text = DGVmamiferosacuaticos[0, posicion].Value.ToString();
            txtnombre.Text = DGVmamiferosacuaticos[1, posicion].Value.ToString();
            txtespecie.Text = DGVmamiferosacuaticos[2, posicion].Value.ToString();
            txtlocalizacion.Text = DGVmamiferosacuaticos[3, posicion].Value.ToString();
            btnagregarregistro.Enabled = false;
            btnmodificarregistro.Enabled = true;
            btneliminarregistro.Enabled = true;
        }
        private void btnnuevoregistro_Click(object sender, EventArgs e)
        {
            limpiar();
            btnagregarregistro.Enabled = true;
            btnmodificarregistro.Enabled = false;
            btneliminarregistro.Enabled = false;
            txtid.Focus();
        }
        private void btnmodificarregistro_Click(object sender, EventArgs e)
        {
            int identificacion;
            string nombre, especie, localizacion;
            identificacion = int.Parse(txtid.Text);
            nombre = txtnombre.Text;
            especie = txtespecie.Text;
            localizacion = txtlocalizacion.Text;
            DGVmamiferosacuaticos[0, posicion].Value = txtid.Text;
            DGVmamiferosacuaticos[1, posicion].Value = txtnombre.Text;
            DGVmamiferosacuaticos[2, posicion].Value = txtespecie.Text;
            DGVmamiferosacuaticos[3, posicion].Value = txtlocalizacion.Text;
            limpiar();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btneliminarregistro_Click(object sender, EventArgs e)
        {
            DGVmamiferosacuaticos.Rows.RemoveAt(posicion);
            MessageBox.Show("EL CAMPO SELECCIONADO FUE ELIMINADO EXITOSAMENTE");
        }
    }
}
