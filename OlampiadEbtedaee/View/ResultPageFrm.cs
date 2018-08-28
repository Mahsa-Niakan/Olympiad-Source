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
    public partial class ResultPageFrm : Form
    {
        public ResultPageFrm()
        {
            InitializeComponent();
        }

        private void ResultPageFrm_Load(object sender, EventArgs e)
        {
            var q = (from c in Session.DB.ExamSet
                     where c.UserId == Session.currentUserId
                     select c.Mark).Sum();
        
            var qq = (from c in Session.DB.ExamSet
                     where c.UserId == Session.currentUserId
                      select c.Time).Sum();

            label2.Text = q.ToString();
            label4.Text = qq.ToString();
            var qqq = (from c in Session.DB.UserSet
                       where c.Id == Session.currentUserId
                       select c).ToList();
            foreach (var t in qqq)
            {
                t.TotalMark = q;
                t.TotalTime = qq;
            }
            Session.DB.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
