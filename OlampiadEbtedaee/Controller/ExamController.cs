using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlampiadEbtedaee.Controller
{
   public static class ExamController
    {
       public static bool AddExam(int qId,int n,int mark,int time,int userId)
       {
           try
           {
               Exam t = new Exam();
               t.QId = qId;
               t.QNumber = n;
               t.Mark = mark;
               t.Time = time;
               t.UserId = userId;
               Session.DB.ExamSet.Add(t);
               Session.DB.SaveChanges();
               return true;
           }
           catch
           {
               return false;
           }
       }
    }
}
