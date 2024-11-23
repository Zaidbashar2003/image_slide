using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_slide_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int escrol = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(escrol!=array.Length-1)
            ++escrol;
            photo.Image = Image.FromFile(array[escrol]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (escrol !=0)
                --escrol;
            photo.Image = Image.FromFile(array[escrol]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        string[] array;
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            array = openFileDialog1.FileNames;
            photo.Image = Image.FromFile(array[escrol]);
          
        }

    }
}
