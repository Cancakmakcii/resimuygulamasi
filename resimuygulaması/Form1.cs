using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resimuygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        string[] neredekifotolar;
        int hangiresim = 0;
        int i;




        private void Form1_Load(object sender, EventArgs e)
        {
            neredekifotolar = Directory.GetFiles("../../resimler","*.jpg");
            foreach(string myPictures in neredekifotolar)
            {
                Button btn=new Button();
                btn.Width=btn.Height=68;
                btn.Margin=new Padding(0);
            }

        }
    }
}
