using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlampiadEbtedaee.Controller
{
  public static  class UserController
    {
    public static bool CheckRepUser(int id)
      {
          try
          {
              var q = (from c in Session.DB.ExamSet
                       where c.UserId == id
                       select c).First();
              return true;
          }
          catch { return false; }
          
      }

    }
}
