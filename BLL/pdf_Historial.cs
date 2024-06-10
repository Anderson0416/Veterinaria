using Entity;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class pdf_Historial
    {
        public string Generar_Pdf_List_aHistorial(int idHistorial, string rutaDirectorio)
        {
            Hitoriales_Repositorio hitoriales_Repositorio = new Hitoriales_Repositorio();
            Hitoriales historial = hitoriales_Repositorio.Consultar_Historial_Id(idHistorial);
            string respuesta = "";

            if (historial == null)
            {
                respuesta = "No se encontraron los datos necesarios.";
                return respuesta;
            }

            try
            {
                // Verifica si la carpeta existe, si no, crea la carpeta
                if (!Directory.Exists(rutaDirectorio))
                {
                    Directory.CreateDirectory(rutaDirectorio);
                }

                // Crear el nombre del archivo basado en el nombre de la mascota y la fecha de consulta
                string nombreArchivo = $"Historial _{historial.mascota.nombre}_{historial.fecha_consulta.Replace(":", "").Replace("/", "-")}.pdf";
                string rutaArchivo = Path.Combine(rutaDirectorio, nombreArchivo);

                // Crear el documento PDF
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(rutaArchivo, FileMode.Create));
                document.Open();

                // Agregar título
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                Paragraph title = new Paragraph("Lista de Historiales", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Agregar espacio
                document.Add(new Paragraph("\n\n"));

                // Crear una tabla para mostrar los datos
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;

                // Añadir filas a la tabla
                table.AddCell(new PdfPCell(new Phrase("ID del Historial:", textFont)));
                table.AddCell(new PdfPCell(new Phrase(historial.id.ToString(), textFont)));

                table.AddCell(new PdfPCell(new Phrase("Fecha de Creación:", textFont)));
                table.AddCell(new PdfPCell(new Phrase(historial.fecha_consulta, textFont)));

                table.AddCell(new PdfPCell(new Phrase("ID de la Mascota:", textFont)));
                table.AddCell(new PdfPCell(new Phrase(historial.mascota.id.ToString(), textFont)));

                table.AddCell(new PdfPCell(new Phrase("Nombre de la Mascota:", textFont)));
                table.AddCell(new PdfPCell(new Phrase(historial.mascota.nombre, textFont)));

                table.AddCell(new PdfPCell(new Phrase("Especie:", textFont)));
                table.AddCell(new PdfPCell(new Phrase(historial.mascota.especie, textFont)));

                table.AddCell(new PdfPCell(new Phrase("Raza:", textFont)));
                table.AddCell(new PdfPCell(new Phrase(historial.mascota.raza, textFont)));

                table.AddCell(new PdfPCell(new Phrase("Sexo:", textFont)));
                table.AddCell(new PdfPCell(new Phrase(historial.mascota.sexo, textFont)));

                table.AddCell(new PdfPCell(new Phrase("Edad:", textFont)));
                table.AddCell(new PdfPCell(new Phrase($"{historial.mascota.edad} {historial.mascota.edad2}", textFont)));

                document.Add(table);

                // Cerrar el documento
                document.Close();

                respuesta = $"PDF generado exitosamente";
            }
            catch (UnauthorizedAccessException ex)
            {
                respuesta = $"No tienes permisos para escribir en la ruta especificada: {rutaDirectorio}";
            }
            catch (Exception ex)
            {
                respuesta = $"Se produjo un error al generar el PDF: {ex.Message}";
            }
            return respuesta;
        }
    }
}
