using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Computer Science");
            comboBox1.Items.Add("Electronics");
            comboBox1.Items.Add("Mechanical");
            comboBox1.Items.Add("IT");
            comboBox1.Items.Add("Civil");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGeneratePDF_click(object sender, EventArgs e)
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                string name = textBox1.Text;
                string department = comboBox1.SelectedItem?.ToString() ?? "N/A";
                string gender = radioButton1.Checked ? "Female" : radioButton2.Checked ? "Male" : "N/A";
                string comment = textBox3.Text;
                string suggestion = textBox2.Text;


                string path = @"C:\Users\Public\alumni.pdf";

                Document doc = new Document(PageSize.A4);

                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    Paragraph title = new Paragraph("ALUMNI MEET 2025", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);
                    doc.Add(new Paragraph("\n"));

                    doc.Add(new Paragraph($"Name: {name}"));
                    doc.Add(new Paragraph($"Department: {department}"));
                    doc.Add(new Paragraph($"Gender: {gender}"));
                    doc.Add(new Paragraph($"Comment: {comment}"));
                    doc.Add(new Paragraph($"Suggestion: {suggestion}"));

                    int starRating = radioButton3.Checked ? 1 :
                     radioButton4.Checked ? 2 :
                     radioButton5.Checked ? 3 :
                     radioButton6.Checked ? 4 :
                     radioButton7.Checked ? 5 : 0;
                    BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\seguisym.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                    iTextSharp.text.Font unicodeFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                    string stars = new string('★', starRating) + new string('☆', 5 - starRating);

                    doc.Add(new Paragraph("Rating: " + stars, unicodeFont));

                    doc.Close();

                    MessageBox.Show("PDF generated successfully on Desktop!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
