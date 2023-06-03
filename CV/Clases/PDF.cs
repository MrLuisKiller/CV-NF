using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Drawing2D;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.Kernel.Colors;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Borders;
using iText.IO.Font;
using iText.IO.Image;
using System.IO;
using System.Drawing;

namespace CV.Clases
{
    public class PDF
    {
        private static iText.Kernel.Colors.Color RoyalBlue;
        private static PdfFont JetBrains, JetBrainsBold, JetBrainsItalic;
        private static Border NO_BORDER = Border.NO_BORDER;
        private static iText.Layout.Properties.HorizontalAlignment HorizontalCenter = iText.Layout.Properties.HorizontalAlignment.CENTER;
        private static iText.Layout.Properties.TextAlignment CENTER = iText.Layout.Properties.TextAlignment.CENTER, JUSTIFIED = iText.Layout.Properties.TextAlignment.JUSTIFIED;

        public PDF()
        {
            RoyalBlue = new DeviceRgb(System.Drawing.Color.RoyalBlue);
            JetBrains = PdfFontFactory.CreateFont(Properties.Resources.JetBrains_Mono_Regular_Nerd_Font_Complete, PdfEncodings.WINANSI);
            JetBrainsBold = PdfFontFactory.CreateFont(Properties.Resources.JetBrains_Mono_Bold_Nerd_Font_Complete, PdfEncodings.WINANSI);
            JetBrainsItalic = PdfFontFactory.CreateFont(Properties.Resources.JetBrains_Mono_Italic_Nerd_Font_Complete, PdfEncodings.WINANSI);
        }

        public Task CrearPDF(Estructura E, String Path)
        {
            Crear(E, Path);
            return Task.CompletedTask;
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
            Table tabla = new Table(new float[] { 170F, 450F });
            Cell celda = new Cell(2, 1).Add(Imagen(new ConvertirImagen().ByteAImagen(E.Personal.Perfil.Imagen), E.Personal.Perfil.Style, E.Personal.Perfil.Cap, System.Drawing.Color.RoyalBlue).SetHorizontalAlignment(HorizontalCenter));
            celda.Add(new Paragraph($"{E.Personal.Nombre}\n{E.Personal.Apellidos}").SetTextAlignment(CENTER).SetFont(JetBrainsBold).SetFontSize(14F));
            celda.SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(RoyalBlue, 1));
            tabla.AddCell(celda);
            celda = new Cell(2, 1).Add(new Paragraph("Resumen").SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
            celda.Add(new Paragraph($"{E.Personal.Resumen}\n\n").SetTextAlignment(JUSTIFIED).SetFont(JetBrains).SetFontSize(10F));
            celda.SetBorder(NO_BORDER).SetBorderBottom(new SolidBorder(RoyalBlue, 1));
            tabla.AddCell(celda);
            doc.Add(tabla);
            tabla = new Table(new float[] { 190F, 430F });
            int Cant = 3 * E.Habilidades.Count;
            celda = new Cell(Cant, 1);
            foreach (String Key in E.Habilidades.Keys)
            {
                String X = "";
                celda.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
                celda.Add(new Paragraph(Key).SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
                foreach (String L in E.Habilidades[Key])
                    X += $"{L} ";
                celda.Add(new Paragraph(X).SetFont(JetBrains).SetFontSize(10F));
            }
            tabla.AddCell(celda);
            Cant = 8;
            Cant += 1 + (3 * E.Educacion.Count);
            Cant += 1 + (4 * E.Experiencia.Count);
            celda = new Cell(Cant, 1).Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(10F));
            celda.Add(new Paragraph("Contacto").SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
            Table _tabla = new Table(new float[] { 17F, 423F });
            Cell _celda = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Telefono))).SetHorizontalAlignment(HorizontalCenter).SetWidth(16F)).SetBorder(NO_BORDER);
            _tabla.AddCell(_celda);
            _celda = new Cell().Add(new Paragraph(E.Personal.Telefono).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
            _tabla.AddCell(_celda);
            celda.Add(_tabla);
            _tabla = new Table(new float[] { 17F, 423F });
            _celda = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Correo))).SetHorizontalAlignment(HorizontalCenter).SetWidth(16F)).SetBorder(NO_BORDER);
            _tabla.AddCell(_celda);
            _celda = new Cell().Add(new Paragraph(E.Personal.Correo).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
            _tabla.AddCell(_celda);
            celda.Add(_tabla);
            _tabla = new Table(new float[] { 17F, 423F });
            _celda = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Mapa))).SetHorizontalAlignment(HorizontalCenter).SetWidth(16F)).SetBorder(NO_BORDER);
            _tabla.AddCell(_celda);
            _celda = new Cell().Add(new Paragraph(E.Personal.Direccion).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
            _tabla.AddCell(_celda);
            celda.Add(_tabla);
            if (!String.IsNullOrWhiteSpace(E.Personal.Pagina))
            {
                _tabla = new Table(new float[] { 17F, 423F });
                _celda = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Web))).SetHorizontalAlignment(HorizontalCenter).SetWidth(16F)).SetBorder(NO_BORDER);
                _tabla.AddCell(_celda);
                _celda = new Cell().Add(new Paragraph(E.Personal.Pagina).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
                _tabla.AddCell(_celda);
                celda.Add(_tabla);
            }
            celda.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
            celda.Add(new Paragraph("Educación").SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
            for (int i = 0; i < E.Educacion.Count; i++)
            {
                String F = $"{new Mes().Abreviar(E.Educacion[i].FInicio.ToString("MM/yyyy"))} - {new Mes().Abreviar(E.Educacion[i].FFinal.ToString("MM/yyyy"))}";
                celda.Add(new Paragraph(F).SetFont(JetBrainsItalic)).SetFontSize(9F);
                celda.Add(new Paragraph(E.Educacion[i].Institucion).SetFont(JetBrainsBold).SetFontSize(10F));
                celda.Add(new Paragraph(E.Educacion[i].Carrera).SetFont(JetBrains).SetFontSize(10F));
                celda.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(5F));
            }
            celda.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(5F));
            celda.Add(new Paragraph("Experiencia").SetFont(JetBrainsBold).SetFontSize(14F).SetFontColor(RoyalBlue));
            for (int i = 0; i < E.Experiencia.Count; i++)
            {
                String F = E.Experiencia[i].Trabajo ? $"{new Mes().Abreviar(E.Experiencia[i].FInicio.ToString("MM/yyyy"))} - Actualmente" : $"{new Mes().Abreviar(E.Experiencia[i].FInicio.ToString("MM/yyyy"))} - {new Mes().Abreviar(E.Experiencia[i].FFinal.ToString("MM/yyyy"))}";
                _tabla = new Table(new float[] { 17F, 423F });
                _celda = new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create(new ConvertirImagen().ImagenAByte(Properties.Resources.Flecha))).SetHorizontalAlignment(HorizontalCenter).SetWidth(16F)).SetBorder(NO_BORDER);
                _tabla.AddCell(_celda);
                _celda = new Cell().Add(new Paragraph($"{E.Experiencia[i].Nombre} | {F} | {E.Experiencia[i].Compania}").SetFont(JetBrainsItalic).SetFontSize(10F)).SetBorder(NO_BORDER);
                _tabla.AddCell(_celda);
                celda.Add(_tabla);
                _tabla = new Table(new float[] { 17F, 423F });
                _tabla.AddCell(new Cell().SetBorder(NO_BORDER));
                _celda = new Cell().Add(new Paragraph(E.Experiencia[i].Descripcion).SetFont(JetBrains).SetFontSize(10F)).SetBorder(NO_BORDER);
                _tabla.AddCell(_celda);
                celda.Add(_tabla);
                _tabla = new Table(new float[] { 17F, 423F });
                _tabla.AddCell(new Cell().SetBorder(NO_BORDER));
                _celda = new Cell().Add(new Paragraph(E.Experiencia[i].Habilidades).SetFont(JetBrainsBold).SetFontSize(10F)).SetBorder(NO_BORDER);
                _tabla.AddCell(_celda);
                celda.Add(_tabla);
                celda.Add(new Paragraph("\n").SetFont(JetBrains).SetFontSize(5F)).SetBorder(NO_BORDER);
            }
            celda.SetBorder(NO_BORDER);
            tabla.AddCell(celda);
            doc.Add(tabla);
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
