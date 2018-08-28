using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
namespace OlampiadEbtedaee.View
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            
            NeedFunctions.CreatePrequires();
            NeedFunctions.taskbarSizeMove = NeedFunctions.TaskbarsizeState();
            NeedFunctions.paintStatusBarState = NeedFunctions.PaintStatusBarState();

            var q1 = (from c in Session.DB.WindowsTheorySet
                     select c).ToList();
            foreach(var t in q1)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();

            var q2 = (from c in Session.DB.WinQuestionSet
                     select c).ToList();
            foreach (var t in q2)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();


            var q3 = (from c in Session.DB.WordQuestionSet
                      select c).ToList();
            foreach (var t in q3)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();


            var q4 = (from c in Session.DB.WordTheorySet
                       select c).ToList();
            foreach (var t in q4)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();


            var q5 = (from c in Session.DB.HardwareQuestionSet
                        select c).ToList();
            foreach (var t in q5)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();

            var q6 = (from c in Session.DB.ExcelQuestionSet
                      select c).ToList();
            foreach (var t in q6)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();
            var q7 = (from c in Session.DB.ExcelTheorySet
                      select c).ToList();
            foreach (var t in q7)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();
            var q8 = (from c in Session.DB.PowerPointQuestionSet
                      select c).ToList();
            foreach (var t in q8)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();
            var q9 = (from c in Session.DB.PowerPointTheorySet
                      select c).ToList();
            foreach (var t in q9)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();
            var q10 = (from c in Session.DB.PowerPointQuestionSet
                      select c).ToList();
            foreach (var t in q10)
            {
                t.Repeatitive = "0";
            }
            Session.DB.SaveChanges();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                var q = (from c in Session.DB.UserSet
                         where c.Id == a
                         select c).Single();
                if (!Controller.UserController.CheckRepUser(q.Id))
                {

                    MessageBox.Show(q.Name + q.LastName);
                    Session.currentUserId = q.Id;
                    Session.currentGroupId = q.GroupId;

                    if (!Directory.Exists(@"D:\" + Session.currentUserId))
                    {
                        Directory.CreateDirectory(@"D:\" + Session.currentUserId);
                        Directory.CreateDirectory(@"D:\" + Session.currentUserId + @"\Word");
                        Directory.CreateDirectory(@"D:\" + Session.currentUserId + @"\PowerPoint");
                        Directory.CreateDirectory(@"D:\" + Session.currentUserId + @"\Excel");
                    }
                    HelpPageFrm f = new HelpPageFrm();
                    f.Show();
                    this.Hide();
                }
                else
                { throw new Exception("این کاربر قبلا آزمون داده  است"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        
 
    }
}
