using System;
using System.Windows.Forms;
using System.IO;
using BL;
using System.Linq;

namespace TextFile1_1_3
{
    public partial class Form1 : Form
    {
        public OpenFileDialog inputOpenFileDialog = new OpenFileDialog();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void DeletelastButton_Click(object sender, EventArgs e)
        {
            WorkWF deletel = new WorkWF(inputOpenFileDialog.FileName);
            OutputTextBox.Lines = deletel.DeleteString(deletel.Lines.Count-1);
        }

        private void Delete1strButton_Click(object sender, EventArgs e)
        {
            WorkWF deletel = new WorkWF(inputOpenFileDialog.FileName);
            OutputTextBox.Lines = deletel.DeleteString(0);
        }

        private void DeleteNumber_Click(object sender, EventArgs e)
        {
            WorkWF deletel = new WorkWF(inputOpenFileDialog.FileName);
            OutputTextBox.Lines = deletel.DeleteString(Convert.ToInt16(DeleteTextBox.Text));
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            inputOpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    WorkWF f = new WorkWF(inputOpenFileDialog.FileName);
                    textBox1.Lines = f.Lines.ToArray();
                    inputOpenFileDialog.Dispose();
                }
                finally { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
