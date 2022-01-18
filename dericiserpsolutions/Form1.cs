using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace dericiserpsolutions
{
    public partial class Form1 : Form
    {
        public string path = Path.GetDirectoryName("Debug");
        public  List<PictureBox> pB = new List<PictureBox>();
        public Rectangle pbRect;
        public int pbNumber;
        Design Design = new Design();

        #region Form sending
        static Form1 form1;
        public static Form1 form
        {
            get { return form1; }
            set { form1 = value; }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            form = this;

        }


       
        private void Form1_Load(object sender, EventArgs e)
        {

            Design.pB_Design();
        }


        private void iadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i <= 14; i++)
                if (pbRect.IntersectsWith(pB[i].Bounds))
                {

                }
        }

      
        private void tanımlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Design = new Design(0); 


        }
    }
}
