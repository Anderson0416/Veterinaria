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
        public string Generar_Pdf_Historiales_Mascota(int idMascota, string rutaDirectorio)
        {
            string respuesta = "";

            Hitoriales_Repositorio hitoriales_Repositorio = new Hitoriales_Repositorio();
            List<Hitoriales> historiales = hitoriales_Repositorio.Consultar_Historial_Mascota(idMascota);

            if (historiales.Count == 0)
            {
                respuesta = "No se encontraron historiales para la mascota";
                return respuesta;
            }

            try
            {
             
                if (!Directory.Exists(rutaDirectorio))
                {
                    Directory.CreateDirectory(rutaDirectorio);
                }


                Mascota_Repositorio mascota_Repositorio = new Mascota_Repositorio();
                Mascota mascota = mascota_Repositorio.Consulta_Mascota_Id(idMascota);
                if (mascota == null)
                {
                    respuesta = "No se encontró la mascota con el ID especificado";
                    return respuesta;
                }

                Document document = new Document();
                string nombreMascota = mascota.nombre;

                string nombreArchivo = $"Historial {nombreMascota}.pdf";
                string pdfPath = Path.Combine(rutaDirectorio, nombreArchivo);
                PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
                document.Open();

               
                string rutaImagen = @"C:\Users\HOME\OneDrive\Escritorio\SISTEMAS\Vet\Veterinaria\Imagenes\Imagen de WhatsApp 2024-04-19 a las 19.52.20_14fcb214.png"; 
                Image imagen = null;
                if (File.Exists(rutaImagen))
                {
                    imagen = Image.GetInstance(rutaImagen);
                    imagen.ScaleToFit(100f, 100f);
                }

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                var boldTextFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

         
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                float[] headerWidths = new float[] { 1f, 3f };
                table.SetWidths(headerWidths);

         
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

                PdfPCell cellTitle = new PdfPCell(new Phrase($"Historial de la Mascota {nombreMascota}", titleFont));
                cellTitle.HorizontalAlignment = Element.ALIGN_CENTER;
                cellTitle.VerticalAlignment = Element.ALIGN_MIDDLE;
                cellTitle.Border = PdfPCell.NO_BORDER;
                table.AddCell(cellTitle);

                PdfPCell lineCellBottom = new PdfPCell(new Phrase(""));
                lineCellBottom.Colspan = 2;
                lineCellBottom.BorderWidthTop = 1;
                table.AddCell(lineCellBottom);

                document.Add(table);

                document.Add(new Paragraph("\n\n\n"));

             
                var subTitleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                Paragraph subtitleDatosMascota = new Paragraph("Datos de la Mascota", subTitleFont);
                subtitleDatosMascota.Alignment = Element.ALIGN_CENTER;  
                subtitleDatosMascota.SpacingAfter = 10f;
                document.Add(subtitleDatosMascota);

       
                PdfPTable tableDatosMascota = new PdfPTable(2);
                tableDatosMascota.WidthPercentage = 100;
                tableDatosMascota.SpacingBefore = 10f;
                tableDatosMascota.SpacingAfter = 10f;

       
                tableDatosMascota.AddCell(new PdfPCell(new Phrase("ID de la Mascota:", boldTextFont)));
                tableDatosMascota.AddCell(new PdfPCell(new Phrase(mascota.id.ToString(), textFont)));

                tableDatosMascota.AddCell(new PdfPCell(new Phrase("Nombre de la Mascota:", boldTextFont)));
                tableDatosMascota.AddCell(new PdfPCell(new Phrase(mascota.nombre, textFont)));

                tableDatosMascota.AddCell(new PdfPCell(new Phrase("Especie:", boldTextFont)));
                tableDatosMascota.AddCell(new PdfPCell(new Phrase(mascota.especie, textFont)));

                tableDatosMascota.AddCell(new PdfPCell(new Phrase("Raza:", boldTextFont)));
                tableDatosMascota.AddCell(new PdfPCell(new Phrase(mascota.raza, textFont)));

                tableDatosMascota.AddCell(new PdfPCell(new Phrase("Sexo:", boldTextFont)));
                tableDatosMascota.AddCell(new PdfPCell(new Phrase(mascota.sexo, textFont)));

                tableDatosMascota.AddCell(new PdfPCell(new Phrase("Edad:", boldTextFont)));
                tableDatosMascota.AddCell(new PdfPCell(new Phrase($"{mascota.edad} {mascota.edad2}", textFont)));

                document.Add(tableDatosMascota);

             
                document.Add(new Paragraph("\n\n"));

              
                string textoIntroduccion = "En la Clínica Veterinaria Agenda Peluda, nos enorgullecemos de ofrecer el mejor cuidado para tu mascota. Aquí encontrarás un historial detallado de todas las visitas y tratamientos que ha recibido tu peludo amigo, asegurando así su bienestar y salud a largo plazo.";
                Paragraph paragraphIntroduccion = new Paragraph(textoIntroduccion, textFont);
                paragraphIntroduccion.Alignment = Element.ALIGN_CENTER;
                paragraphIntroduccion.SpacingAfter = 20f;
                document.Add(paragraphIntroduccion);

                
                Paragraph subtitleHistorialClinico = new Paragraph("Historial Clínico Veterinaria", subTitleFont);
                subtitleHistorialClinico.Alignment = Element.ALIGN_CENTER; 
                subtitleHistorialClinico.SpacingAfter = 10f;
                document.Add(subtitleHistorialClinico);

                PdfPTable table2 = new PdfPTable(5);
                table2.WidthPercentage = 100;
                table2.SetWidths(new float[] { 1f, 2f, 2f, 3f, 3f });

           
                table2.AddCell(new PdfPCell(new Phrase("ID Historial", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))));
                table2.AddCell(new PdfPCell(new Phrase("Fecha de Consulta", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))));
                table2.AddCell(new PdfPCell(new Phrase("ID de Mascota", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))));
                table2.AddCell(new PdfPCell(new Phrase("Nombre de Mascota", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))));
                table2.AddCell(new PdfPCell(new Phrase("Observaciones", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))));

             
                foreach (var historial in historiales)
                {
                    table2.AddCell(new PdfPCell(new Phrase(historial.id.ToString(), textFont)));
                    table2.AddCell(new PdfPCell(new Phrase(historial.fecha_consulta, textFont)));
                    table2.AddCell(new PdfPCell(new Phrase(historial.mascota.id.ToString(), textFont)));
                    table2.AddCell(new PdfPCell(new Phrase(historial.mascota.nombre, textFont)));
                    table2.AddCell(new PdfPCell(new Phrase(historial.anamnesis != null ? historial.anamnesis.observaciones : "N/A", textFont)));
                }

                
                document.Add(table2);

            
                document.Close();

                respuesta = "PDF generado exitosamente en " + pdfPath;
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
