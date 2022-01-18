using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Threading;

namespace dericiserpsolutions
{
    class Design
    {
        public Design()
        {

        }


        public string path = Path.GetDirectoryName("Debug");
        public static List<PictureBox> pB = new List<PictureBox>();
        public Rectangle pbRect;
        public int pbNumber;

        public void pB_Design()
        {
            addModuleLayout(0, 200, 50);
            addModuleLayout(1, 330, 50);
            addModuleLayout(2, 460, 50);
            addModuleLayout(3, 590, 50);
            addModuleLayout(4, 720, 50);
            addModuleLayout(5, 200, 170);
            addModuleLayout(6, 330, 170);
            addModuleLayout(7, 460, 170);
            addModuleLayout(8, 590, 170);
            addModuleLayout(9, 720, 170);
            addModuleLayout(10, 200, 290);
            addModuleLayout(11, 330, 290);
            addModuleLayout(12, 460, 290);
            addModuleLayout(13, 590, 290);
            addModuleLayout(14, 720, 290);
            pB[0].Visible = true;
            pB[1].Visible = true;
            pB[2].Visible = true;
            pB[3].Visible = true;
            pB[4].Visible = true;
        }

        public Design(int x)
        {
            
            switch(x)
            {
                case 0:

                    pB[0].Visible = true;
                    pB[1].Visible = true;
                    pB[2].Visible = true;
                    pB[3].Visible = true;
                    pB[4].Visible = true;
                    pB[0].Image = Image.FromFile(path + "urun_bilgileri.png");
                    

                    break;
            }
        }

        private void addModuleLayout(int number, int x, int y)
        {
            pB.Add(new PictureBox
            {
                Name = "pB" + number,
                Size = new Size(110, 100),
                Location = new Point(x, y),
                BackColor = Color.Blue,
                Visible = false,
                //Image = Image.FromFile(path + Path.GetFileName(_ImgName)),
                BackgroundImageLayout = ImageLayout.Stretch,
                SizeMode = PictureBoxSizeMode.StretchImage,
             
                // SizeMode = PictureBoxSizeMode.AutoSize,
            }); 

            Form1.form.Controls.Add(pB[number]);
            pB[number].BringToFront();
            pB[number].MouseEnter += pb_MouseEnter;
            pB[number].MouseLeave += pb_MouseLeave;

            // pbRect = new Rectangle(x, y, 110, 100);



        }
        private void pb_MouseEnter(object sender, EventArgs e)
        {
            Form1.form.Cursor = Cursors.Hand;

        }
        private void pb_MouseLeave(object sender, EventArgs e)
        {
            Form1.form.Cursor = Cursors.Arrow;

        }
    }
}
