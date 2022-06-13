using System;

using System.Windows.Forms;

namespace pdf2docx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var filename = openFileDialog1.FileName;
            var doc = new MyDocument(filename);
            doc.Save($"{filename}.Output.docx");
        }
    }
}
