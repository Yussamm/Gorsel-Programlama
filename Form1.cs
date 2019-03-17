using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics dama = this.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.LightSkyBlue);
            SolidBrush sb1 = new SolidBrush(Color.LightSalmon);
            Pen kalem = new Pen(Color.Purple);
            dama.DrawRectangle(kalem, 10, 10, 400, 400);
            for (int i = 10; i < 400; i += 50)
            {
                for (int j = 10; j < 400; j += 50)//x =i y=j koordinatlar
                {
                    
                    dama.FillEllipse(sb, i, j, 50, 50);
                }
            }
            for (int i = 10; i <400; i += 50)
            {
                for (int j = 10; j < 400; j += 50)
                {
                    //dama.FillRectangle(sb1, i, j, 50, 50);
                    dama.FillEllipse(sb1, i, j, 70, 70);
                }
            }
            for (int i = 10; i < 400; i += 50)
            {
                for (int j = 10; j < 400; j += 50)
                {
                    //dama.FillRectangle(sb1, i, j, 50, 50);
                    dama.FillEllipse(sb1, i, j, 70, 70);
                }
            }

        }
    }
}
