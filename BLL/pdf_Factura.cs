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
               
                if (!Directory.Exists(rutaDirectorio))
                {
                    Directory.CreateDirectory(rutaDirectorio);
                }

                Random random = new Random();
                int codigo = random.Next(10000, 99999);

            
                string nombreArchivo = $"Productos_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}_{codigo}.pdf";
                string rutaArchivo = Path.Combine(rutaDirectorio, nombreArchivo);

             
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(rutaArchivo, FileMode.Create));
                document.Open();

                
                string rutaImagen = @"C:\Users\HOME\OneDrive\Escritorio\SISTEMAS\Vet\Veterinaria\Imagenes\Imagen de WhatsApp 2024-04-19 a las 19.52.20_14fcb214.png";
                Image imagen = null;
                if (File.Exists(rutaImagen))
                {
                    imagen = Image.GetInstance(rutaImagen);
                    imagen.ScaleToFit(100f, 100f);
                }

             
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var boldTextFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var normalTextFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                PdfPTable headerTable = new PdfPTable(2);
                headerTable.WidthPercentage = 100;
                float[] headerWidths = new float[] { 1f, 3f };
                headerTable.SetWidths(headerWidths);

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

                PdfPCell lineCellBottom = new PdfPCell(new Phrase(""));
                lineCellBottom.Colspan = 2;
                lineCellBottom.BorderWidthTop = 1;
                headerTable.AddCell(lineCellBottom);

                document.Add(headerTable);

   
                document.Add(new Paragraph("\n"));

           
                var gratitudeFont = FontFactory.GetFont(FontFactory.HELVETICA, 9);
                Paragraph gratitudeParagraph = new Paragraph();
                gratitudeParagraph.Add("¡Gracias por realizar la compra en la veterinaria que siempre está a un clic de distancia!\n\n");
                gratitudeParagraph.Add($"Fecha de impresión: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}\n\n");
                gratitudeParagraph.Alignment = Element.ALIGN_CENTER;
                document.Add(gratitudeParagraph);

                var codeFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                Paragraph codeParagraph = new Paragraph();
                codeParagraph.Add($"Código único: {codigo}\n\n");
                codeParagraph.Alignment = Element.ALIGN_CENTER;
                document.Add(codeParagraph);

               
                PdfPTable productTable = new PdfPTable(dgv_Compra.Columns.Count);
                productTable.WidthPercentage = 100;
                productTable.SpacingBefore = 10f;
                productTable.SpacingAfter = 10f;

               
                foreach (DataGridViewColumn column in dgv_Compra.Columns)
                {
                    productTable.AddCell(new PdfPCell(new Phrase(column.HeaderText, boldTextFont)));
                }

    
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

                PdfPCell totalCellLabel = new PdfPCell(new Phrase("TOTAL A PAGAR", boldTextFont));
                totalCellLabel.Colspan = dgv_Compra.Columns.Count - 1;
                totalCellLabel.Border = PdfPCell.NO_BORDER;
                totalCellLabel.HorizontalAlignment = Element.ALIGN_RIGHT;
                productTable.AddCell(totalCellLabel);

              
                decimal totalAPagar = 0;
                foreach (DataGridViewRow row in dgv_Compra.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        
                        decimal precioProducto = Convert.ToDecimal(row.Cells[row.Cells.Count - 1].Value);
                        totalAPagar += precioProducto;
                    }
                }

                PdfPCell totalCellAmount = new PdfPCell(new Phrase(totalAPagar.ToString("C"), boldTextFont));
                totalCellAmount.Border = PdfPCell.NO_BORDER;
                totalCellAmount.HorizontalAlignment = Element.ALIGN_RIGHT;
                productTable.AddCell(totalCellAmount);

                document.Add(productTable);

               
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
