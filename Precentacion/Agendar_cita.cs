using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class Agendar_cita : Form
    {
        public Agendar_cita()
        {
            InitializeComponent();

        }

        private void Agendar_cita_Load(object sender, EventArgs e)
        {
            Veterinario_Repositorio veterinario_repositorio = new Veterinario_Repositorio();
            Veterinario veterinario = new Veterinario();
            List<Veterinario> veterinarios = veterinario_repositorio.ObtenerVeterinarios();

            cmb_Veterinario.DataSource = veterinarios;
            cmb_Veterinario.DisplayMember = "Nombre";
            //cmb_Veterinario.ValueMember = "Documento";
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Cliente_Repositorio cliente_repositorio = new Cliente_Repositorio();
            Mascota_Repositorio mascota_repositorio = new Mascota_Repositorio();

            Cliente cliente = new Cliente();

            string cedula = txt_Documento.Text;
            cliente = cliente_repositorio.Consulta_Documento_Cliente(cedula);
            if (cliente != null)
            {
                txt_Nombre_Cliente.Text = cliente.nombre;
                List<Mascota> mascotas = mascota_repositorio.Consulta_Mascota_Cliente(txt_Documento.Text);
                List<string> nombres_Mascotas = mascotas.Select(m => m.nombre_mascota).ToList();
                cmb_Nombre_Mascota.DataSource = nombres_Mascotas;
                cmb_Nombre_Mascota.DisplayMember = "Nombre";
                //cmb_Nombre_Mascota.ValueMember = "id";
            }
            else
            {
                MessageBox.Show("el usuario no a sido registrado, en el boton resgistrar lo puede hacer");
            }-
        }

        private void cmb_Nombre_Mascota_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
