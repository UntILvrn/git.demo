using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Utils;

namespace TextFile1_2_3
{

    public partial class Form : System.Windows.Forms.Form
    {
        public OpenFileDialog inputOpenFileDialog = new OpenFileDialog();
        public Form()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
            try
                {
                    IOUtils i = new IOUtils(inputOpenFileDialog.FileName);
                    textBox1.Text = Encoding.Default.GetString(i.Number);
                    inputOpenFileDialog.Dispose();
                }
                finally {}
            else MessageBox.Show("Не найден файл -1");
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            WorkWF r = new WorkWF(inputOpenFileDialog.FileName);
            ResultLabel.Text = Convert.ToString(r.HowMuch());
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
