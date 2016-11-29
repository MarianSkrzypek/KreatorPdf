using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Formm;
namespace iTextSharp.pdf.Wygenerowane
{
    public class Example1
    {
        private readonly Form1 form;
        public Example1(Form1 form)
        {
            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            try
            {
                this.form = form;
                Document doc = new Document(PageSize.A4);
                var output = new FileStream((System.IO.Directory.GetCurrentDirectory()+"/Pdf/"+form.FirstName+".pdf"), FileMode.Create);
                using (PdfWriter writer = PdfWriter.GetInstance(doc, output))
                {
                    //pierwszy tekst
                    doc.Open();
                    doc.AddAuthor("Hosted.pl Creator by Tomasz Sadowski");

                    doc.AddCreator("Created by Hosted.pl Creator");

                    doc.AddTitle("Propozycja Fraz dla klienta Hosted.pl");
                    PdfContentByte cb = writer.DirectContent;
                    cb.BeginText();
                    //wymaga doinstalowania opensans(najlepiej spod instalatora)
                    BaseFont f_cn = BaseFont.CreateFont("c:\\windows\\fonts\\OpenSans-Light.ttf", BaseFont.CP1257, BaseFont.NOT_EMBEDDED);
                    cb.SetFontAndSize(f_cn, 10);
                    cb.SetTextMatrix(186, 772);  //(xPos, yPos)
                    cb.ShowText("http://"+form.FirstName);
                    cb.SetTextMatrix(186, 745);
                    cb.ShowText(form.SurName);
                    cb.EndText();
                    string imageFilePath = System.IO.Directory.GetCurrentDirectory() +"\\Images\\bg.jpg";
                    iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageFilePath);
                    jpg.ScaleToFit(1279, 850);
                    jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                    jpg.SetAbsolutePosition(0, 0);
                    doc.Add(jpg);
                    //druga strona
                    doc.NewPage();
                    //fraza1
                    cb.BeginText();
                    cb.SetTextMatrix(60, 730);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("1) "+form.fraza1);
                    cb.EndText();
                    //fraza2
                    cb.BeginText();
                    cb.SetTextMatrix(60, 705);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("2) " + form.fraza2);
                    cb.EndText();
                    //fraza3
                    cb.BeginText();
                    cb.SetTextMatrix(60, 680);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("3) " + form.fraza3);
                    cb.EndText();
                    //fraza4
                    cb.BeginText();
                    cb.SetTextMatrix(60, 655);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("4) " + form.fraza4);
                    cb.EndText();
                    //fraza5
                    cb.BeginText();
                    cb.SetTextMatrix(60, 630);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("5) " + form.fraza5);
                    cb.EndText();
                    //fraza6
                    cb.BeginText();
                    cb.SetTextMatrix(60, 605);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("6) " + form.fraza6);
                    cb.EndText();
                    //fraza7
                    cb.BeginText();
                    cb.SetTextMatrix(60, 580);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("7) " + form.fraza7);
                    cb.EndText();
                    //fraza8
                    cb.BeginText();
                    cb.SetTextMatrix(60, 555);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("8) " + form.fraza8);
                    cb.EndText();
                    //fraza9
                    cb.BeginText();
                    cb.SetTextMatrix(60, 530);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("9) " + form.fraza9);
                    cb.EndText();
                    //fraza10
                    cb.BeginText();
                    cb.SetTextMatrix(60, 505);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("10) " + form.fraza10);
                    cb.EndText();
                    //fraza11
                    cb.BeginText();
                    cb.SetTextMatrix(60, 480);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("11) " + form.fraza11);
                    cb.EndText();
                    //fraza12
                    cb.BeginText();
                    cb.SetTextMatrix(60, 455);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("12) " + form.fraza12);
                    cb.EndText();
                    //fraza13
                    cb.BeginText();
                    cb.SetTextMatrix(60, 430);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("13) " + form.fraza13);
                    cb.EndText();
                    //fraza14
                    cb.BeginText();
                    cb.SetTextMatrix(60, 405);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("14) " + form.fraza14);
                    cb.EndText();
                    //fraza15
                    cb.BeginText();
                    cb.SetTextMatrix(60, 380);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("15) " + form.fraza15);
                    cb.EndText();
                    //fraza16 czeœæ 2
                    cb.BeginText();
                    cb.SetTextMatrix(322, 730);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("16) " + form.fraza16);
                    cb.EndText();
                    //fraza17
                    cb.BeginText();
                    cb.SetTextMatrix(322, 705);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("17) " + form.fraza17);
                    cb.EndText();
                    //fraza18
                    cb.BeginText();
                    cb.SetTextMatrix(322, 680);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("18) " + form.fraza18);
                    cb.EndText();
                    //fraza19
                    cb.BeginText();
                    cb.SetTextMatrix(322, 655);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("18) " + form.fraza19);
                    cb.EndText();
                    //fraza20
                    cb.BeginText();
                    cb.SetTextMatrix(322, 630);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("20) " + form.fraza20);
                    cb.EndText();
                    //fraza21
                    cb.BeginText();
                    cb.SetTextMatrix(322, 605);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("21) " + form.fraza21);
                    cb.EndText();
                    //fraza22
                    cb.BeginText();
                    cb.SetTextMatrix(322, 580);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("22) " + form.fraza22);
                    cb.EndText();
                    //fraza23
                    cb.BeginText();
                    cb.SetTextMatrix(322, 555);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("23) " + form.fraza23);
                    cb.EndText();
                    //fraza24
                    cb.BeginText();
                    cb.SetTextMatrix(322, 530);  //(xPos, yPos)
                    cb.SetFontAndSize(f_cn, 15);
                    cb.ShowText("24) " + form.fraza24);
                    cb.EndText();
                    string imageFilePath2 = System.IO.Directory.GetCurrentDirectory() + "\\Images\\bg1.jpg";
                    iTextSharp.text.Image jpg2 = iTextSharp.text.Image.GetInstance(imageFilePath2);
                    jpg2.ScaleToFit(1279, 850);
                    jpg2.Alignment = iTextSharp.text.Image.UNDERLYING;
                    jpg2.SetAbsolutePosition(0, 0);
                    doc.Add(jpg2);
                    doc.Close();
                }
            }
            // Catching iTextSharp.text.DocumentException if any
            catch (DocumentException de)
            {
                throw de;
            }
            // Catching System.IO.IOException if any
            catch (IOException ioe)
            {
                throw ioe;
            }
        }
    }
}