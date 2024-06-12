using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class pdf_Factura
    {
        public string Generar_Pdf_Factura(DataGridView dgv_Compra, string rutaDirectorio)
        {
            string respuesta = "";

            try
            {
                // Verifica si la carpeta existe, si no, crea la carpeta
                if (!Directory.Exists(rutaDirectorio))
                {
                    Directory.CreateDirectory(rutaDirectorio);
                }

                // Generar un código único de 5 dígitos
                Random random = new Random();
                int codigo = random.Next(10000, 99999);

                // Crear el nombre del archivo basado en la fecha y hora actual y el código único
                string nombreArchivo = $"Productos_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}_{codigo}.pdf";
                string rutaArchivo = Path.Combine(rutaDirectorio, nombreArchivo);

                // Crear el documento PDF
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(rutaArchivo, FileMode.Create));
                document.Open();

                // Añadir una imagen y título
                string rutaImagen = @"C:\ruta\a\tu\imagen.png"; // Cambia esta ruta por la ruta real de la imagen
                Image imagen = null;
                if (File.Exists(rutaImagen))
                {
                    imagen = Image.GetInstance(rutaImagen);
                    imagen.ScaleToFit(100f, 100f);
                }

                // Agregar título
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var boldTextFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var normalTextFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                // Crear una tabla para la imagen y el título
                PdfPTable headerTable = new PdfPTable(2);
                headerTable.WidthPercentage = 100;
                float[] headerWidths = new float[] { 1f, 3f };
                headerTable.SetWidths(headerWidths);

                // Línea superior
                PdfPCell lineCellTop = new PdfPCell(new Phrase(""));
                lineCellTop.Colspan = 2;
                lineCellTop.BorderWidthBottom = 1;
                headerTable.AddCell(lineCellTop);

                if (imagen != null)
                {
                    PdfPCell cellImage = new PdfPCell(imagen);
                    cellImage.Border = PdfPCell.NO_BORDER;
                    headerTable.AddCell(cellImage);
                }
                else
                {
                    headerTable.AddCell("");
                }

                PdfPCell cellTitle = new PdfPCell(new Phrase("Agenda Peluda \n Factura", titleFont));
                cellTitle.HorizontalAlignment = Element.ALIGN_CENTER;
                cellTitle.VerticalAlignment = Element.ALIGN_MIDDLE;
                cellTitle.Border = PdfPCell.NO_BORDER;
                headerTable.AddCell(cellTitle);

                // Línea inferior
                PdfPCell lineCellBottom = new PdfPCell(new Phrase(""));
                lineCellBottom.Colspan = 2;
                lineCellBottom.BorderWidthTop = 1;
                headerTable.AddCell(lineCellBottom);

                document.Add(headerTable);

                // Añadir espacio
                document.Add(new Paragraph("\n"));

                // Añadir mensaje de agradecimiento y fecha
                var gratitudeFont = FontFactory.GetFont(FontFactory.HELVETICA, 9);
                Paragraph gratitudeParagraph = new Paragraph();
                gratitudeParagraph.Add("¡Gracias por realizar la compra en la veterinaria que siempre está a un clic de distancia!\n\n");
                gratitudeParagraph.Add($"Fecha de impresión: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}\n\n");
                gratitudeParagraph.Alignment = Element.ALIGN_CENTER;
                document.Add(gratitudeParagraph);

                // Agregar el código único en negrita
                var codeFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                Paragraph codeParagraph = new Paragraph();
                codeParagraph.Add($"Código único: {codigo}\n\n");
                codeParagraph.Alignment = Element.ALIGN_CENTER;
                document.Add(codeParagraph);

                // Crear una tabla para los datos de los productos
                PdfPTable productTable = new PdfPTable(dgv_Compra.Columns.Count);
                productTable.WidthPercentage = 100;
                productTable.SpacingBefore = 10f;
                productTable.SpacingAfter = 10f;

                // Añadir encabezados de columna
                foreach (DataGridViewColumn column in dgv_Compra.Columns)
                {
                    productTable.AddCell(new PdfPCell(new Phrase(column.HeaderText, boldTextFont)));
                }

                // Añadir filas de datos
                foreach (DataGridViewRow row in dgv_Compra.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            productTable.AddCell(new PdfPCell(new Phrase(cell.Value?.ToString(), normalTextFont)));
                        }
                    }
                }

                // Agregar la fila para el total a pagar
                PdfPCell totalCellLabel = new PdfPCell(new Phrase("TOTAL A PAGAR", boldTextFont));
                totalCellLabel.Colspan = dgv_Compra.Columns.Count - 1; // Utiliza todas las columnas menos la última
                totalCellLabel.Border = PdfPCell.NO_BORDER;
                totalCellLabel.HorizontalAlignment = Element.ALIGN_RIGHT;
                productTable.AddCell(totalCellLabel);

                // Calcular el total a pagar
                decimal totalAPagar = 0;
                foreach (DataGridViewRow row in dgv_Compra.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Suponiendo que la columna del precio se encuentra en la última posición
                        decimal precioProducto = Convert.ToDecimal(row.Cells[row.Cells.Count - 1].Value);
                        totalAPagar += precioProducto;
                    }
                }

                PdfPCell totalCellAmount = new PdfPCell(new Phrase(totalAPagar.ToString("C"), boldTextFont));
                totalCellAmount.Border = PdfPCell.NO_BORDER;
                totalCellAmount.HorizontalAlignment = Element.ALIGN_RIGHT;
                productTable.AddCell(totalCellAmount);

                document.Add(productTable);

                // Cerrar el documento
                document.Close();

                respuesta = "PDF generado exitosamente";
            }
            catch (UnauthorizedAccessException)
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
