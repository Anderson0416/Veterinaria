using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Document = iTextSharp.text.Document;
using DAL;

namespace BLL
{
    public class pdf_Anamnesis
    {
        public string Generar_Pdf_Anamnesis(int idHistorial, string rutaDirectorio)
        {
            Hitoriales_Repositorio hitoriales_Repositorio = new Hitoriales_Repositorio();
            Anamnesis_Repositorio anamnesis_Repositorio = new Anamnesis_Repositorio();
            Hitoriales historial = hitoriales_Repositorio.Consultar_Historial_Id(idHistorial);
            Anamnesis anamnesis = anamnesis_Repositorio.Consulta_Anamnesis_id_Historial(idHistorial);
            string respuesta = "";

            if (historial == null || anamnesis == null)
            {
                respuesta ="No se encontraron los datos necesarios.";
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
                string nombreArchivo = $"{historial.mascota.nombre}_{historial.fecha_consulta.Replace(":", "").Replace("/", "-")}.pdf";
                string rutaArchivo = Path.Combine(rutaDirectorio, nombreArchivo);

                // Crear el documento PDF
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(rutaArchivo, FileMode.Create));
                document.Open();

               
                // Añadir una imagen
                string rutaImagen = @"C:\Users\RYZEN\Desktop\c#\Veterinaria_2\Veterinaria\Imagenes\descarga.png"; // Cambia esta ruta por la ruta real de la imagen
                Image imagen = null;
                if (File.Exists(rutaImagen))
                {
                    imagen = Image.GetInstance(rutaImagen);
                    imagen.ScaleToFit(100f, 100f);
                }

                // Agregar título
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var subTitleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                var boldTextFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                // Crear una tabla para la imagen y el título
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                float[] headerWidths = new float[] { 1f, 3f };
                table.SetWidths(headerWidths);
                
                // Línea superior
                PdfPCell lineCellTop = new PdfPCell(new Phrase(""));
                lineCellTop.Colspan = 2;
                lineCellTop.BorderWidthBottom = 1;
                table.AddCell(lineCellTop);

                if (imagen != null)
                {
                    PdfPCell cellImage = new PdfPCell(imagen);
                    cellImage.Border = PdfPCell.NO_BORDER;
                    table.AddCell(cellImage);
                }
                else
                {
                    table.AddCell("");
                }

                PdfPCell cellTitle = new PdfPCell(new Phrase("Reporte de Historial y Anamnesis", titleFont));
                cellTitle.HorizontalAlignment = Element.ALIGN_CENTER;
                cellTitle.VerticalAlignment = Element.ALIGN_MIDDLE;
                cellTitle.Border = PdfPCell.NO_BORDER;
                table.AddCell(cellTitle);

                // Línea inferior
                PdfPCell lineCellBottom = new PdfPCell(new Phrase(""));
                lineCellBottom.Colspan = 2;
                lineCellBottom.BorderWidthTop = 1;
                table.AddCell(lineCellBottom);

                document.Add(table);

                //document.Add(new Paragraph("Reporte de Historial y Anamnesis", titleFont) { Alignment = Element.ALIGN_CENTER });

                // Agregar espacio
                document.Add(new Paragraph("\n\n\n"));

                // Crear una tabla para los datos del historial
                PdfPTable table2 = new PdfPTable(2);
                table2.WidthPercentage = 100;
                table2.SpacingBefore = 10f;
                table2.SpacingAfter = 10f;

                Paragraph subTitle1 = new Paragraph("Datos Del Paciente", subTitleFont);
                subTitle1.Alignment = Element.ALIGN_CENTER;
                document.Add(subTitle1);
                // Añadir filas a la tabla
                table2.AddCell(new PdfPCell(new Phrase("ID del Historial:", boldTextFont)));
                table2.AddCell(new PdfPCell(new Phrase(historial.id.ToString(), textFont)));

                

                table2.AddCell(new PdfPCell(new Phrase("ID de la Mascota:", boldTextFont)));
                table2.AddCell(new PdfPCell(new Phrase(historial.mascota.id.ToString(), textFont)));

                table2.AddCell(new PdfPCell(new Phrase("Nombre de la Mascota:", boldTextFont)));
                table2.AddCell(new PdfPCell(new Phrase(historial.mascota.nombre, textFont)));

                table2.AddCell(new PdfPCell(new Phrase("Especie:", boldTextFont)));
                table2.AddCell(new PdfPCell(new Phrase(historial.mascota.especie, textFont)));

                table2.AddCell(new PdfPCell(new Phrase("Raza:", boldTextFont)));
                table2.AddCell(new PdfPCell(new Phrase(historial.mascota.raza, textFont)));

                table2.AddCell(new PdfPCell(new Phrase("Sexo:", boldTextFont)));
                table2.AddCell(new PdfPCell(new Phrase(historial.mascota.sexo, textFont)));

                table2.AddCell(new PdfPCell(new Phrase("Edad:", boldTextFont)));
                table2.AddCell(new PdfPCell(new Phrase($"{historial.mascota.edad} {historial.mascota.edad2}", textFont)));

                document.Add(table2);
                
                // Agregar espacio entre secciones
                document.Add(new Paragraph("\n"));

                // Agregar sección de Anamnesis
                Paragraph subTitle2 = new Paragraph("Datos de Anamnesis", subTitleFont);
                subTitle2.Alignment = Element.ALIGN_CENTER;
                document.Add(subTitle2);

                document.Add(new Paragraph($"ID de Anamnesis: {anamnesis.id}", textFont));
                PdfPTable table3 = new PdfPTable(2);
                table3.WidthPercentage = 100;
                table3.SpacingBefore = 10f;
                table3.SpacingAfter = 10f;

                table3.AddCell(new PdfPCell(new Phrase("Fecha de la consulta:", boldTextFont)));
                table3.AddCell(new PdfPCell(new Phrase(historial.fecha_consulta, textFont)));

                table3.AddCell(new PdfPCell(new Phrase("Peso", boldTextFont)));
                table3.AddCell(new PdfPCell(new Phrase($"{anamnesis.peso} {anamnesis.peso2}", textFont)));

                table3.AddCell(new PdfPCell(new Phrase("Estado Reproductivo", boldTextFont)));
                table3.AddCell(new PdfPCell(new Phrase($"{anamnesis.estado_reproductivo}", textFont)));

                table3.AddCell(new PdfPCell(new Phrase("Tipo de Vivienda", boldTextFont)));
                table3.AddCell(new PdfPCell(new Phrase($"{anamnesis.tipo_vivienda}", textFont)));

                table3.AddCell(new PdfPCell(new Phrase("Actividad Física", boldTextFont)));
                table3.AddCell(new PdfPCell(new Phrase($"{anamnesis.actividad_fisica}", textFont)));

                document.Add(table3);

                PdfPTable table4 = new PdfPTable(2);
                table4.WidthPercentage = 100;
                table4.SpacingBefore = 10f;
                table4.SpacingAfter = 10f;

                table4.AddCell(new PdfPCell(new Phrase("Vacunas Previas", boldTextFont)));
                table4.AddCell(new PdfPCell(new Phrase($"{anamnesis.vacunas_previas}", textFont)));

                table4.AddCell(new PdfPCell(new Phrase("Vacunas Previas Desparasitacion", boldTextFont)));
                table4.AddCell(new PdfPCell(new Phrase($"{anamnesis.vacunas_precias_desparecitacion}", textFont)));

                document.Add(table4);

                // Agregar título
                Chunk motivoDeConsulta = new Chunk("Motivo de Consulta: ", boldTextFont);
                Chunk sintomasDeMascota = new Chunk("Síntomas de la Mascota: ", boldTextFont);
                Chunk observaciones = new Chunk("Observaciones: ", boldTextFont);
                Chunk dietaAlimenticia = new Chunk("Dieta Alimenticia: ", boldTextFont);

                // Agregar información
                Phrase frase = new Phrase();
                frase.Add(motivoDeConsulta);
                frase.Add(new Chunk(anamnesis.motivos_consulta, textFont));
                document.Add(new Paragraph(frase));

                frase = new Phrase();
                frase.Add(sintomasDeMascota);
                frase.Add(new Chunk(anamnesis.sintomas_mascota, textFont));
                document.Add(new Paragraph(frase));

                frase = new Phrase();
                frase.Add(observaciones);
                frase.Add(new Chunk(anamnesis.observaciones, textFont));
                document.Add(new Paragraph(frase));

                frase = new Phrase();
                frase.Add(dietaAlimenticia);
                frase.Add(new Chunk(anamnesis.dieta, textFont));
                document.Add(new Paragraph(frase));

                // Cerrar el documento
                document.Close();

                respuesta= $"PDF generado exitosamente";
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
