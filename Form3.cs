using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_game
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        bool sus = false, jos = false, st = false, dr = false;
        int viteza = 5;
        int vieti = 3;
        int v_inamic = 3;
        int v_inamic2 = 3;

        int puncte = 0;

        private void inamic2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                sus = true;
            if (e.KeyCode == Keys.Down)
                jos = true;
            if (e.KeyCode == Keys.Left)
                st = true;
            if (e.KeyCode == Keys.Right)
                dr = true;
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                sus = false;
            if (e.KeyCode == Keys.Down)
                jos = false;
            if (e.KeyCode == Keys.Left)
                st = false;
            if (e.KeyCode == Keys.Right)
                dr = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            poarta.Visible = false;
            printesa.Visible = false;
            inamic1.Left = inamic1.Left + v_inamic;
            if (inamic1.Left < 275)
            {
                Bitmap img = (Bitmap)Bitmap.FromFile(@"..\..\Resources\dragonreverse.png");
                inamic1.Image = img;
                v_inamic = v_inamic * (-1);
                
            }
            if (inamic1.Left > 15)
            {
                Bitmap img = (Bitmap)Bitmap.FromFile(@"..\..\Resources\toppng.com-dragon-celeste-dragon-city-498x384.png");
                inamic1.Image = img;
                v_inamic = v_inamic * (-1);
               
            }

            inamic2.Top = inamic2.Top + v_inamic2;
            if (inamic2.Top < 140)
                v_inamic2 = v_inamic2 * (-1);
            if (inamic2.Top > 385)
                v_inamic2 = v_inamic2 * (-1);
            if (sus)
            {

                Bitmap img = (Bitmap)Bitmap.FromFile(@"..\..\Resources\NicePng_knight-png_4332514reversesus.png");
                p.Image = img;
                if (p.Top > 5)
                    p.Top = p.Top - viteza;
                else
                    p.Top = p.Top + viteza;
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "ziduri")
                    {
                        if (p.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);

                            p.Top = p.Top + 20;
                        }
                        if (vieti == 0)
                        {
                            timer1.Stop();
                           
                            Final1 f = new Final1();
                            this.Visible = false;
                            f.ShowDialog();
                            this.Hide();
                        }
                    }
                }
            }
            if (jos)
            {
                Bitmap img = (Bitmap)Bitmap.FromFile(@"..\..\Resources\NicePng_knight-png_4332514reverse1.png");
                p.Image = img;
                if (p.Top < this.Height - p.Height - 40)
                    p.Top = p.Top + viteza;
                else
                    p.Top = p.Top - viteza;
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "ziduri")
                    {
                        if (p.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);

                            p.Top = p.Top - 20;
                        }
                        if (vieti == 0)
                        {
                            timer1.Stop();
                         
                            Final1 f = new Final1();
                            this.Visible = false;
                            f.ShowDialog();
                        }
                    }
                }
            }
            if (st)
            {
                Bitmap img = (Bitmap)Bitmap.FromFile(@"..\..\Resources\NicePng_knight-png_4332514reverse.png");
                p.Image = img;
                if (p.Left > 0)
                    p.Left = p.Left - viteza;
                else
                    p.Left = p.Left + viteza;
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "ziduri")
                    {
                        if (p.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            p.Left = p.Left + 20;
                        }
                        if (vieti == 0)
                        {
                            timer1.Stop();
                            
                            Final1 f = new Final1();
                            this.Visible = false;
                            f.ShowDialog();
                            this.Hide();

                        }
                    }
                }

            }
            if (dr)
            {
               
                Bitmap img = (Bitmap)Bitmap.FromFile(@"..\..\Resources\NicePng_knight-png_4332514.png");
    
                p.Image = img;
                if (p.Left < this.Width - p.Width - 20)
                    p.Left = p.Left + viteza;
                else
                    p.Left = p.Left - viteza;
                foreach (Control x in this.Controls)
                {
                    if ((string)x.Tag == "ziduri")
                    {
                        if (p.Bounds.IntersectsWith(x.Bounds))
                        {
                            vieti--;
                            lbl_vieti.Text = Convert.ToString(vieti);
                            p.Left = p.Left - 20;
                        }
                        if (vieti == 0)
                        {
                            timer1.Stop();
                            //this.Visible = false;
                            Final1 f = new Final1();
                            this.Visible = false;
                            f.ShowDialog();
                            this.Hide();
                            //timer1.Stop();
                        }
                    }
                }
            }
            if (p.Bounds.IntersectsWith(pot1.Bounds))
            {
                puncte++;
                lbl_puncte.Text = Convert.ToString(puncte);
                pot1.Visible = false;
                pot1.Location = new Point(3, -1);
            }
            if (p.Bounds.IntersectsWith(pot3.Bounds))
            {
                puncte++;
                lbl_puncte.Text = Convert.ToString(puncte);
                pot3.Visible = false;
                pot3.Location = new Point(3, -1);
            }
            if (p.Bounds.IntersectsWith(pot2.Bounds))
            {
                puncte++;
                lbl_puncte.Text = Convert.ToString(puncte);
                pot2.Visible = false;
                pot2.Location = new Point(3, -1);
            }
            if (p.Bounds.IntersectsWith(inamic1.Bounds))
            {
                timer1.Stop();
                this.Visible = false;
                Final1 f = new Final1();
                f.ShowDialog();
                this.Hide();
                //timer1.Stop();
            }
            if (p.Bounds.IntersectsWith(inamic2.Bounds))
            {
                timer1.Stop();
                this.Visible = false;
                Final1 f = new Final1();
                f.ShowDialog();
                this.Hide();
                //timer1.Stop();
            }
            if (p.Bounds.IntersectsWith(poarta.Bounds))
            {
                timer1.Stop();
                Form x = new Felicitarics();
                this.Visible=false;
                x.ShowDialog();
                this.Hide();
            }
            if (puncte == 3)
            {
                poarta.Visible = true;
                printesa.Visible = false;
            }
        }
    }
}
