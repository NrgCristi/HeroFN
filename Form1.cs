using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace HeroFN
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

        private void button1_Click(object sender, EventArgs e)
        {
            string FNPath = textBox1.Text;
            string FNExePath = System.IO.Path.Combine(this.textBox1.Text, "FortniteGame/Binaries/Win64/FortniteLauncher.exe");
            System.Diagnostics.Process.Start(FNPath, FNExePath);
        }
    }
}
