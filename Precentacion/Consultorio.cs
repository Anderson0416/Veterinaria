using BLL;
using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class Consultorio : Form
    {
        int id_anamnesi;
        int id_historia;
        public Consultorio(int id_mascota, int id_cita, string nombre, string descripcion, int id_anamnesis, int id_historial)
        {
            InitializeComponent();
            txt_Id_Mascota.Text = id_mascota.ToString();
            txt_Nombre_Mascota.Text = nombre;
            txt_Descripcion.Text = descripcion;
            txt_Codigo_Cita.Text = id_cita.ToString();
            id_anamnesi = id_anamnesis;
            id_historia = id_historial;
            llenar_Datos_Anamnesis();
            llenar_Datos_Historial();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Agregar_Historial();
            Guardar();
            Eliminar_Cita();
        }
        public void Agregar_Historial()
        {
            Hitoriales historial = new Hitoriales();
            historial.mascota = new Mascota { id = int.Parse(txt_Id_Mascota.Text) };
            historial.fecha_consulta = dtp_Fecha_Consulta.Text;
            Hitoriales_Repositorio historial_Repositorio = new Hitoriales_Repositorio();
            id_historia = historial_Repositorio.Registrar_Historial(historial);
        }
        public void Eliminar_Cita()
        {
            string Id = txt_Codigo_Cita.Text;
            Cita_Repositorio cita_Repositorio = new Cita_Repositorio();
            cita_Repositorio.Eliminar_Cita(Id);
        }
        public void Guardar()
        {
            Anamnesis anamnesis = new Anamnesis();
        
            anamnesis.peso = int.Parse(txt_Peso.Text);
            anamnesis.peso2 = txt_Peso2.Text;
            anamnesis.estado_reproductivo = cmb_Estado_Reproductivo.Text;
            anamnesis.actividad_fisica = cmb_Actividad_Fisica.Text;
            anamnesis.tipo_vivienda = cmb_Tipo_Vivienda.Text;
            anamnesis.vacunas_previas = rtb_Vacunas_Previas.Text;
            anamnesis.vacunas_precias_desparecitacion = rtb_Vacumas_Precias_Desparasitacion.Text;
            anamnesis.motivos_consulta = rtb_Motivo_Consulta.Text;
            anamnesis.sintomas_mascota = rtb_Sintomas_Mascota.Text;
            anamnesis.observaciones = rtb_Observaciones_Adicionales.Text;
            anamnesis.dieta = rtb_Dieta_Alimentacion.Text;
            anamnesis.hitoriales = new Hitoriales { id = id_historia };



            try
            {
                Controladores control = new Controladores();
                string respuesta = control.Validacion_Anamnesis(anamnesis);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente registrado");
                    Menu_Veterinario menu_veterinario = new Menu_Veterinario();
                    menu_veterinario.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " holaaaa");
            }
        }
        private void cmb_Vacunas_Previas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmb_Vacunas_Previas.SelectedItem.ToString();
            if (!rtb_Vacunas_Previas.Text.Contains(seleccion))
            {
                rtb_Vacunas_Previas.AppendText(seleccion + Environment.NewLine);
            }
        }
        private void cmb_Vacunas_Desparasitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmb_Vacunas_Desparasitacion.SelectedItem.ToString();
            if (!rtb_Vacumas_Precias_Desparasitacion.Text.Contains(seleccion))
            {
                rtb_Vacumas_Precias_Desparasitacion.AppendText(seleccion + Environment.NewLine);
            }
        }
        public void llenar_Datos_Anamnesis()
        {
            if(id_anamnesi != 0)
            {
                Anamnesis anamnesis = new Anamnesis();
                Anamnesis_Repositorio anamnesis_Repositorio = new Anamnesis_Repositorio();
                anamnesis =  anamnesis_Repositorio.Consulta_Anamnesis_id(id_anamnesi);
                txt_Peso.Text = anamnesis.peso.ToString();
                rtb_Vacunas_Previas.Text = anamnesis.vacunas_previas;
                rtb_Vacumas_Precias_Desparasitacion.Text = anamnesis.vacunas_precias_desparecitacion;
                cmb_Actividad_Fisica.Text = anamnesis.actividad_fisica;
                cmb_Estado_Reproductivo.Text = anamnesis.estado_reproductivo;
                cmb_Tipo_Vivienda.Text = anamnesis.tipo_vivienda;
                rtb_Motivo_Consulta.Text = anamnesis.motivos_consulta;
                rtb_Sintomas_Mascota.Text = anamnesis.sintomas_mascota;
                rtb_Observaciones_Adicionales.Text = anamnesis.observaciones;
                rtb_Dieta_Alimentacion.Text = anamnesis.dieta;

            }
        }
        public void llenar_Datos_Historial()
        {
            if(id_historia != 0)
            {
                Hitoriales hitoriales = new Hitoriales();
                Hitoriales_Repositorio hitoriales_Repositorio = new Hitoriales_Repositorio();
                hitoriales = hitoriales_Repositorio.Consultar_Historial_Id(id_historia);
                dtp_Fecha_Consulta.Value = Convert.ToDateTime(hitoriales.fecha_consulta.ToString());
                txt_Id_Mascota.Text = hitoriales.mascota.id.ToString();
                txt_Nombre_Mascota.Text = hitoriales.mascota.nombre;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            int idHistorial = id_historia;
            string rutaDirectorio = @"C:\Users\RYZEN\Desktop\c#\Veterinaria_2\Veterinaria\pdf";
            pdf_Anamnesis pdf_Anamnesis = new pdf_Anamnesis();
            string respuesta = (pdf_Anamnesis.Generar_Pdf_Anamnesis(idHistorial, rutaDirectorio));
            MessageBox.Show(respuesta);
        }
        
    }
}
