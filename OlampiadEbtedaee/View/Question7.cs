using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlampiadEbtedaee.View
{
    public partial class Question7 : Form
    {
        public Question7()
        {
            InitializeComponent();
        }
        public int t1;
        public int t;
        public int questionId;
        public string s = ".";
        private void Question7_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            if (Session.currentGroupId == 1)
            {
                var q = (from c in Session.DB.WindowsTheorySet
                         where c.Level == "0" && c.Grade == 1 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                radioButton1.Text = q.ChoiceOne;
                radioButton2.Text = q.ChoiceTwo;
                radioButton3.Text = q.ChoiceThree;
                radioButton4.Text = q.ChoiceFour;
                pictureBox1.Image = Image.FromFile(q.PicOne);
                pictureBox2.Image = Image.FromFile(q.PicTwo);
                pictureBox3.Image = Image.FromFile(q.PicThree);
                pictureBox4.Image = Image.FromFile(q.PicFour);
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = 30;
                s = q.Voice;
                playSound(s);
            }
            if (Session.currentGroupId == 2)
            {
                var q = (from c in Session.DB.WindowsTheorySet
                         where c.Level == "0" && c.Grade == 2 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                radioButton1.Text = q.ChoiceOne;
                radioButton2.Text = q.ChoiceTwo;
                radioButton3.Text = q.ChoiceThree;
                radioButton4.Text = q.ChoiceFour;
                pictureBox1.Image = Image.FromFile(q.PicOne);
                pictureBox2.Image = Image.FromFile(q.PicTwo);
                pictureBox3.Image = Image.FromFile(q.PicThree);
                pictureBox4.Image = Image.FromFile(q.PicFour);
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = 30;
                s = q.Voice;
                playSound(s);
            }
            if (Session.currentGroupId == 3)
            {
                var q = (from c in Session.DB.WordTheorySet
                         where c.Level == "0" && c.Grade == 3 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                radioButton1.Text = q.ChoiceOne;
                radioButton2.Text = q.ChoiceTwo;
                radioButton3.Text = q.ChoiceThree;
                radioButton4.Text = q.ChoiceFour;
                pictureBox1.Image = Image.FromFile(q.PicOne);
                pictureBox2.Image = Image.FromFile(q.PicTwo);
                pictureBox3.Image = Image.FromFile(q.PicThree);
                pictureBox4.Image = Image.FromFile(q.PicFour);
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = 30;
            }


            if (Session.currentGroupId == 4)
            {
                var q = (from c in Session.DB.WindowsTheorySet
                         where c.Level == "0" && c.Grade == 4 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                radioButton1.Text = q.ChoiceOne;
                radioButton2.Text = q.ChoiceTwo;
                radioButton3.Text = q.ChoiceThree;
                radioButton4.Text = q.ChoiceFour;
                pictureBox1.Image = Image.FromFile(q.PicOne);
                pictureBox2.Image = Image.FromFile(q.PicTwo);
                pictureBox3.Image = Image.FromFile(q.PicThree);
                pictureBox4.Image = Image.FromFile(q.PicFour);
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = 30;
            }

            if (Session.currentGroupId == 5)
            {
                var q = (from c in Session.DB.WindowsTheorySet
                         where c.Level == "0" && c.Grade == 5 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                radioButton1.Text = q.ChoiceOne;
                radioButton2.Text = q.ChoiceTwo;
                radioButton3.Text = q.ChoiceThree;
                radioButton4.Text = q.ChoiceFour;
                pictureBox1.Image = Image.FromFile(q.PicOne);
                pictureBox2.Image = Image.FromFile(q.PicTwo);
                pictureBox3.Image = Image.FromFile(q.PicThree);
                pictureBox4.Image = Image.FromFile(q.PicFour);
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = 30;
            }
        
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1 < t)
            {

                t1++;

                label4.Text = (t - t1).ToString();
                if ((label4.Text) == "14")
                {
                    playSound(Application.StartupPath + @"\12.wav");
                }
                if ((label4.Text) == "11")
                {
                    playSound(Application.StartupPath + @"\12.wav");
                }
                if ((label4.Text) == "8")
                {
                    playSound(Application.StartupPath + @"\1.wav");
                }
                if ((label4.Text) == "1")
                {
                    StopSound();
                }
                if (t1 >= (t - (t / 3)))
                {
                    label4.BackColor = Color.Red;
                    label2.BackColor = Color.Red;
                    label3.BackColor = Color.Red;

                }
                if (t1 >= (t - (2 * (t / 3))) && t1 < (t - (t / 3)))
                {
                    label4.BackColor = Color.Yellow;
                    label2.BackColor = Color.Yellow;
                    label3.BackColor = Color.Yellow;
                }
                if (t1 < (t - (2 * (t / 3))))
                {
                    label4.BackColor = Color.Lime;
                    label2.BackColor = Color.Lime;
                    label3.BackColor = Color.Lime;
                }
            }
            else
            {
                StopSound();
                timer1.Enabled = false;
                string ch = "0";
                if (radioButton1.Checked)
                    ch = "1";
                if (radioButton2.Checked)
                    ch = "2";
                if (radioButton3.Checked)
                    ch = "3";
                if (radioButton4.Checked)
                    ch = "4";
                if (Session.currentGroupId == 1)
                {
                    Correction.WinTheory(questionId, 7, t1, ch);
                }
                if (Session.currentGroupId == 2)
                {
                    Correction.WinTheory(questionId, 7, t1, ch);
                }
                if (Session.currentGroupId == 3)
                {
                    Correction.WordTheory(questionId, 7, t1, ch);
                }
                if (Session.currentGroupId == 4)
                {
                    Correction.WinTheory(questionId, 7, t1, ch);
                }
                if (Session.currentGroupId == 5)
                {
                    Correction.WinTheory(questionId, 7, t1, ch);
                }


                Question8 f = new Question8();
                f.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopSound();
            timer1.Enabled = false;
            string ch = "0";
            if (radioButton1.Checked)
                ch = "1";
            if (radioButton2.Checked)
                ch = "2";
            if (radioButton3.Checked)
                ch = "3";
            if (radioButton4.Checked)
                ch = "4";
            if (Session.currentGroupId == 1)
            {
                Correction.WinTheory(questionId, 7, t1, ch);
            }
            if (Session.currentGroupId == 2)
            {
                Correction.WinTheory(questionId, 7, t1, ch);
            }
            if (Session.currentGroupId == 3)
            {
                Correction.WordTheory(questionId, 7, t1, ch);
            }
            if (Session.currentGroupId == 4)
            {
                Correction.WinTheory(questionId, 7, t1, ch);
            }
            if (Session.currentGroupId == 5)
            {
                Correction.WinTheory(questionId, 7, t1, ch);
            }


            Question8 f = new Question8();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void playSound(string path)
        {
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        private void StopSound()
        {
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();
            player.Stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            playSound(s);
        }
    }
}
