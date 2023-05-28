using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Drawing2D;
using System.Diagnostics;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.Kernel.Colors;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Borders;
using iText.IO.Font;
using iText.IO.Image;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace CV.Clases
{
    public class PDF
    {
        private static iText.Kernel.Colors.Color RoyalBlue;
        private static PdfFont JetBrains, JetBrainsBold, JetBrainsItalic;
        private static Border NO_BORDER = Border.NO_BORDER;
        private static iText.Layout.Properties.HorizontalAlignment HorizontalAlignmentCenter = iText.Layout.Properties.HorizontalAlignment.CENTER;
        private static iText.Layout.Properties.TextAlignment Center = iText.Layout.Properties.TextAlignment.CENTER, Justified = iText.Layout.Properties.TextAlignment.JUSTIFIED;

        public PDF()
        {
            RoyalBlue = new DeviceRgb(System.Drawing.Color.RoyalBlue);
            JetBrains = PdfFontFactory.CreateFont(Properties.Resources.JetBrains_Mono_Regular_Nerd_Font_Complete, PdfEncodings.WINANSI);
            JetBrainsBold = PdfFontFactory.CreateFont(Properties.Resources.JetBrains_Mono_Bold_Nerd_Font_Complete, PdfEncodings.WINANSI);
            JetBrainsItalic = PdfFontFactory.CreateFont(Properties.Resources.JetBrains_Mono_Italic_Nerd_Font_Complete, PdfEncodings.WINANSI);
        }

        public Task<PDF> CrearPDF(Estructura E, String K)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF|*.pdf";
                saveFileDialog.InitialDirectory = "C://Documentos";
                saveFileDialog.FileName = $"{K} Curriculum";
                saveFileDialog.DefaultExt = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Task.Run(() => Crear(E, saveFileDialog.FileName)).GetAwaiter().GetResult();
                    Process.Start(saveFileDialog.FileName);
                }
                return null;
            }
        }

        private void Crear(Estructura E, String Path)
        {
            PdfWriter pdfWriter = new PdfWriter(new FileStream(Path, FileMode.Create, FileAccess.Write), new WriterProperties().AddXmpMetadata().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            PdfDocumentInfo info = pdfDocument.GetDocumentInfo();
            info.SetTitle($"Curriculum de {E.Personal.Nombre} {E.Personal.Apellidos}");
            info.SetAuthor("CV by MrLuisKiller");
            info.SetSubject("Curriculum Vitae");
            Document doc = new Document(pdfDocument, PageSize.LETTER);
            doc.SetMargins(15, 40, 15, 40);
            Table table = new Table(new float[] { 170F, 450F });
            Cell cell = new Cell(2, 1).Add(Imagen(new ConvertirImagen().ByteAImagen(E.Personal.Perfil.Imagen), E.Personal.Perfil.Style, E.Personal.Perfil.Cap, System.Drawing.Color.RoyalBlue).SetHorizontalAlignment(HorizontalAlignmentCenter));
            cell.Add(new Paragraph($"{E.Personal.Nombre}\n{E.Personal.Apellidos}").SetTextAlignment(Center).SetFont(JetBrainsBold).SetFontSize(14F));
            cell.SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(RoyalBlue, 1));
            table.AddCell(cell);
            cell = new Cell(2, 1).Add(new Paragraph("Resumen").SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
            cell.Add(new Paragraph($"{E.Personal.Resumen}\n\n").SetTextAlignment(Justified).SetFont(JetBrains).SetFontSize(10F));
            cell.SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(RoyalBlue, 1));
            table.AddCell(cell);
            doc.Add(table);
            table = new Table(new float[] { 190F, 430F });
            int Qua = 3 * E.Habilidades.Count;
            cell = new Cell(Qua, 1);
            foreach (String Key in E.Habilidades.Keys)
            {
                String X = "";
                cell.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
                cell.Add(new Paragraph(Key).SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
                foreach (String L in E.Habilidades[Key])
                    X += L;
                cell.Add(new Paragraph(X).SetFont(JetBrains).SetFontSize(10F));
            }
            table.AddCell(cell);
            Qua = 8;
            Qua += 1 + (3 * E.Educacion.Count);
            Qua += 1 + (4 * E.Experiencia.Count);
            cell = new Cell(Qua, 1).Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(10F));
            cell.Add(new Paragraph("Contacto").SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
            Table _table = new Table(new float[] { 17F, 423F });
            Cell _cell = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Telefono))).SetHorizontalAlignment(HorizontalAlignmentCenter).SetWidth(16F)).SetBorder(NO_BORDER);
            _table.AddCell(_cell);
            _cell = new Cell().Add(new Paragraph(E.Personal.Telefono).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
            _table.AddCell(_cell);
            cell.Add(_table);
            _table = new Table(new float[] { 17F, 423F });
            _cell = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Correo))).SetHorizontalAlignment(HorizontalAlignmentCenter).SetWidth(16F)).SetBorder(NO_BORDER);
            _table.AddCell(_cell);
            _cell = new Cell().Add(new Paragraph(E.Personal.Correo).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
            _table.AddCell(_cell);
            cell.Add(_table);
            _table = new Table(new float[] { 17F, 423F });
            _cell = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Mapa))).SetHorizontalAlignment(HorizontalAlignmentCenter).SetWidth(16F)).SetBorder(NO_BORDER);
            _table.AddCell(_cell);
            _cell = new Cell().Add(new Paragraph(E.Personal.Direccion).SetFont(JetBrains).SetFontSize(10F).SetBorder(NO_BORDER));
            _table.AddCell(_cell);
            cell.Add(_table);
            _table = new Table(new float[] { 17F, 423F });
            _cell = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Web))).SetHorizontalAlignment(HorizontalAlignmentCenter).SetWidth(16F)).SetBorder(NO_BORDER);
            _table.AddCell(_cell);
            _cell = new Cell().Add(new Paragraph(E.Personal.Pagina).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
            _table.AddCell(_cell);
            cell.Add(_table);
            cell.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
            cell.Add(new Paragraph("Educación").SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
            for (int i = 0; i < E.Educacion.Count; i++)
            {
                cell.Add(new Paragraph(E.Educacion[i].Institucion).SetFont(JetBrainsBold).SetFontSize(10F));
                cell.Add(new Paragraph(E.Educacion[i].Carrera).SetFont(JetBrains).SetFontSize(5F));
                cell.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(5F));
            }
            cell.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(5F));
            cell.Add(new Paragraph("Experiencia").SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
            for (int i = 0; i < E.Experiencia.Count; i++)
            {
                String D = E.Experiencia[i].Trabajo ? $"{new Mes().Abreviar(E.Experiencia[i].FInicio.ToString("MM/yyyy"))} - Actualmente" : $"{new Mes().Abreviar(E.Experiencia[i].FInicio.ToString("MM/yyyy"))} - {new Mes().Abreviar(E.Experiencia[i].FFinal.ToString("MM/yyyy"))}";
                _table = new Table(new float[] { 17F, 423F });
                _cell = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Flecha))).SetHorizontalAlignment(HorizontalAlignmentCenter).SetWidth(16F)).SetBorder(NO_BORDER);
                _table.AddCell(_cell);
                _cell = new Cell().Add(new Paragraph($"{E.Experiencia[i].Nombre} | {D} | {E.Experiencia[i].Compania}").SetFont(JetBrainsItalic).SetFontSize(10F)).SetBorder(NO_BORDER);
                _table.AddCell(_cell);
                cell.Add(_table);
                _table = new Table(new float[] { 17F, 423F });
                _table.AddCell(new Cell().SetBorder(NO_BORDER));
                _cell = new Cell().Add(new Paragraph(E.Experiencia[i].Descripcion).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
                _table.AddCell(_cell);
                cell.Add(_table);
                _table = new Table(new float[] { 17F, 423F });
                _table.AddCell(new Cell().SetBorder(NO_BORDER));
                _cell = new Cell().Add(new Paragraph(E.Experiencia[i].Habilidades).SetFont(JetBrainsBold).SetFontSize(10F)).SetBorder(NO_BORDER);
                _table.AddCell(_cell);
                cell.Add(_table);
                cell.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(5F)).SetBorder(NO_BORDER);
            }
            cell.SetBorder(NO_BORDER);
            table.AddCell(cell);
            doc.Add(table);
            doc.Close();
        }

        private static iText.Layout.Element.Image Imagen(System.Drawing.Image Img, String DS, String DC, System.Drawing.Color Color)
        {
            using (GraphicsPath path = new GraphicsPath())
            using (Bitmap Image = (Bitmap)Img)
            {
                int Tam = Img.Width < Img.Height ? Img.Width : Img.Height;
                float Borde = (float)(2.4 * Tam / 100);
                path.AddEllipse(0, 0, Tam, Tam);
                Bitmap newImagen = new Bitmap(Tam, Tam);
                using (Graphics g = Graphics.FromImage(newImagen))
                using (Pen pen = new Pen(Color, Borde))
                {
                    pen.DashStyle = (DashStyle)new ConvertirImagen().Dash(1, DS);
                    pen.DashCap = (DashCap)new ConvertirImagen().Dash(2, DC);
                    g.Clip = new Region(path);
                    g.DrawImage(Image, 0, 0, Tam, Tam);
                    g.DrawEllipse(pen, 0, 0, Tam, Tam);
                    return new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(newImagen))).ScaleAbsolute(130, 130);
                }
            }
        }
    }
}
