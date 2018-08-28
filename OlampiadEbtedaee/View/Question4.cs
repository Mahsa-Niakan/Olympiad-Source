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
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }
        public int t1;
        public int t;
        public int questionId;
        public string s = ".";
        private void QuestionFour_Load(object sender, EventArgs e)
        {
            if (Session.currentGroupId == 1 || Session.currentGroupId == 2)
                System.Diagnostics.Process.Start(@"D:\" + Session.currentUserId + @"\Word");
            else
                System.Diagnostics.Process.Start(@"D:\" + Session.currentUserId + @"\Excel");
            PlaceLowerRight();
            if (Session.currentGroupId == 1)
            {
                var q = (from c in Session.DB.WordQuestionSet
                         where c.Level == "0" && c.Grade == 1 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = Convert.ToInt32(q.Time);
                s = q.Voice;
                playSound(s);
            }

            if (Session.currentGroupId == 2)
            {
                var q = (from c in Session.DB.WordQuestionSet
                         where c.Level == "0" && c.Grade == 2 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = Convert.ToInt32(q.Time);
                s = q.Voice;
                playSound(s);
            }

            if (Session.currentGroupId == 3)
            {
                var q = (from c in Session.DB.ExcelQuestionSet
                         where c.Level == "0" && c.Grade == 3 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = Convert.ToInt32(q.Time);
            }
            if (Session.currentGroupId == 4)
            {
                var q = (from c in Session.DB.ExcelQuestionSet
                         where c.Level == "0" && c.Grade == 4 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = Convert.ToInt32(q.Time);
            }
            if (Session.currentGroupId == 5)
            {
                var q = (from c in Session.DB.ExcelQuestionSet
                         where c.Level == "0" && c.Grade == 5 && c.Repeatitive == "0"
                         select c).OrderBy(x => Guid.NewGuid()).Take(1).Single();
                textBox1.Text = q.Text;
                q.Repeatitive = "1";
                Session.DB.SaveChanges();
                timer1.Enabled = true;
                questionId = q.Id;
                t = Convert.ToInt32(q.Time);
            }
        }

        private void PlaceLowerRight()
        {
            //Determine "rightmost" screen
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
                textBox2.Text = "فایل را با نام " + questionId.ToString() + "-" + Session.currentUserId.ToString() + "در درایو D و پوشه ی خودتان با پسوند XML ذخیره کنید";

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
                if (Session.currentGroupId == 1)
                {
                    timer1.Enabled = false;
                    Correction.WordPracticalCorrection(questionId, 4, t1);


                    View.Question5 f = new Question5();
                    f.Show();
                    this.Hide();
                }
                if (Session.currentGroupId == 2)
                {
                    timer1.Enabled = false;
                    Correction.WordPracticalCorrection(questionId, 4, t1);


                    View.Question5 f = new Question5();
                    f.Show();
                    this.Hide();
                }
                if (Session.currentGroupId == 3)
                {
                    timer1.Enabled = false;
                    Correction.ExcelPracticalCorrection(questionId, 4, t1);


                    View.Question5 f = new Question5();
                    f.Show();
                    this.Hide();
                }
                if (Session.currentGroupId == 4)
                {
                    timer1.Enabled = false;
                    Correction.ExcelPracticalCorrection(questionId, 4, t1);


                    View.Question5 f = new Question5();
                    f.Show();
                    this.Hide();
                }
                if (Session.currentGroupId == 5)
                {
                    timer1.Enabled = false;
                    Correction.ExcelPracticalCorrection(questionId, 4, t1);


                    View.Question5 f = new Question5();
                    f.Show();
                    this.Hide();
                }
            }
        }

        public bool c = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            c = true;
            DialogResult dialogResult = MessageBox.Show("آیا از ذخیره صحیح فایل خود با پسوند XML مطمئن هستید و میخواهید به سوال بعد بروید؟", "یادآوری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            button1.Enabled = false;
            if (dialogResult == DialogResult.Yes)
            {
                StopSound();
                timer1.Enabled = false;
                if (Session.currentGroupId == 1)
                {
                    Correction.WordPracticalCorrection(questionId, 4, t1);
                }
                if (Session.currentGroupId == 2)
                {
                    Correction.WordPracticalCorrection(questionId, 4, t1);
                }
                if (Session.currentGroupId == 3)
                {
                    Correction.ExcelPracticalCorrection(questionId, 4, t1);
                }
                if (Session.currentGroupId == 4)
                {
                    Correction.ExcelPracticalCorrection(questionId, 4, t1);
                }
                if (Session.currentGroupId == 5)
                {
                    Correction.ExcelPracticalCorrection(questionId, 4, t1);
                }
                View.Question5 f = new Question5();
                f.Show();
                this.Hide();
            }
            else
            {
                button1.Enabled = true;
                c = false;
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            playSound(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Session.currentGroupId == 1 || Session.currentGroupId == 2)
                System.Diagnostics.Process.Start(@"D:\" + Session.currentUserId + @"\Word");
            if (Session.currentGroupId == 3 || Session.currentGroupId == 4 || Session.currentGroupId == 5)
                System.Diagnostics.Process.Start(@"D:\" + Session.currentUserId + @"\Exceel");
          
        }
    }
}
