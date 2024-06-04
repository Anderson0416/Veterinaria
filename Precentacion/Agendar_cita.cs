using BLL;
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
        Veterinario_Repositorio veterinario_repositorio = new Veterinario_Repositorio();
        Veterinario veterinario = new Veterinario();
        List<Veterinario> veterinarios;
        public Agendar_cita()
        {
            InitializeComponent();

        }
        
        private void Agendar_cita_Load(object sender, EventArgs e)
        {
            Mostrar_Veterinario_cmb();
        }
        private void Mostrar_Veterinario_cmb()
        {
            veterinarios = veterinario_repositorio.ObtenerVeterinarios();
            cmb_Veterinario.DataSource = veterinarios;
            cmb_Veterinario.DisplayMember = "nombre";
            cmb_Veterinario.ValueMember = "documento";
        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Consultar_CLiente();
        }

       private void Mostrar_Mascota_cmb()
        {
            Mascota_Repositorio mascota_repositorio = new Mascota_Repositorio();
            List<Mascota> mascotas = mascota_repositorio.Consulta_Mascota_Cliente(txt_Documento.Text);
            cmb_Nombre_Mascota.DataSource = mascotas;
            cmb_Nombre_Mascota.DisplayMember = "nombre";
            cmb_Nombre_Mascota.ValueMember = "id";
        }
       private void Consultar_CLiente ()
        {
            Cliente_Repositorio cliente_repositorio = new Cliente_Repositorio();
            Cliente cliente = new Cliente();
            string cedula = txt_Documento.Text;
            cliente = cliente_repositorio.Consulta_Documento_Cliente(cedula);
            if (cliente != null)
            {
                txt_Nombre_Cliente.Text = cliente.nombre;
                Mostrar_Mascota_cmb();
            }
            else
            {
                MessageBox.Show("el usuario no a sido registrado, en el boton resgistrar lo puede hacer");
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Citas cita = new Citas();

            cita.fecha_consulta = dtp_Fecha_Cita.Text;
            cita.descripcion = rtb_Descripcion.Text;
            cita.documento_veterinario = (string)cmb_Veterinario.SelectedValue;
            cita.id_mascota = (int)cmb_Nombre_Mascota.SelectedValue;


            try
            {
                Controladores control = new Controladores();
                string respuesta = control.Validacion_Cita(cita);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente registrado");
                    Menu_Recepcio recepcio = new Menu_Recepcio();
                    recepcio.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Llenar_Datos_Mascota()
        {
            if (cmb_Nombre_Mascota.SelectedItem != null)
            {
                Mascota mascota = (Mascota)cmb_Nombre_Mascota.SelectedItem;
                txt_Especie.Text = mascota.especie;
                txt_Raza.Text = mascota.raza;
                txt_Sexo_Mascota.Text = mascota.sexo;
                txt_Edad.Text = mascota.edad;
                cmb_Edad.Text = mascota.edad2;
            }
        }

        private void cmb_Nombre_Mascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            Llenar_Datos_Mascota();
        }
    }
}
