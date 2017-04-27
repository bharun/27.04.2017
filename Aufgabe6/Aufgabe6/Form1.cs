using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Aufgabe6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Items.Add(e.KeyCode);
            StreamWriter sw = new StreamWriter(@"C:\Users\Harun\Documents\Visual Studio 2017\Projects\Aufgabe6\keyLog.txt", true);
            sw.WriteLine(e.KeyCode);
            sw.Close();
        }
    }
}
