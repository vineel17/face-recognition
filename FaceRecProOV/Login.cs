using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace MultiFaceRec
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Transparent;
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {


        }
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        private void start_Click(object sender, EventArgs e)
        {
            
            long x = 1;
        if (x == 1)
        {

            int y = 0;

            progressBar1.Visible = true;
           

            progressBar1.Minimum = 1;

            progressBar1.Maximum = 1000000;

            progressBar1.Value = 1;

            progressBar1.Step = 1;

            for (y = 1; y <= 1000000; y++)
            {

                progressBar1.PerformStep();
                
            }
            loginform s = new loginform();
            s.Show();
            this.Hide();
        }
        else
        {

        }
           
        }
    }
}
