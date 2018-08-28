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
    public partial class HelpPageFrm : Form
    {
        public HelpPageFrm()
        {
            InitializeComponent();
        }

        private void HelpPageFrm_Load(object sender, EventArgs e)
        {
            var q = (from c in Session.DB.UserSet
                     where c.Id == Session.currentUserId
                     select c).Single();
            label1.Text = q.Name + "  کلاس   " + q.ClassName + " گروه " + q.GroupId;
            textBox1.Text = "دانش آموز عزیز در این آزمون، 5 سوال عملی، 5 سوال چهار گزینه ای و 5 سوال سخت افزار به شما ارائه می شود. شما برای سوالات عملی 90 ثانیه، سوالات چهار گزینه ای 30 ثانیه و سوالات سخت افزار 20 ثانیه زمان دارید. با شروع آزمون پوشه ای در درایو D  به شماره داوطلبی شما ساخته می شود که در این پوشه، سه زیر ساخه ی ورد، اکسل و پاورپوینت وجود دارد. برای سوالات عملی مجموعه آفیس، شما باید هر سوال را در پوشه ی خودش، با نام مشخص شده در قسمت پایین هر سوال و با پسوند XML ذخیره کنید. پس از اتمام هر سوال و کلیک روی دکمه بعدی، سوال شما تصحیح می شود و شما امکان بازگشت به سوال را نخواهید داشت. لطفا از ذخیره ی صحیح فایل خود با نام و پسوند مشخص شده در پوشه ی مربوط اطمینان حاصل کنید. در صورتیکه مشخصات شما صحیح است روی دکمه شروع کلیک کنید.";
            playSound(@"D:\Sound\Main\Main.wav");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StopSound();
            Question1 t = new Question1();
            t.Show();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playSound(@"D:\Sound\Main\Main.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StopSound();
            Application.Restart();
        }
    }
}
