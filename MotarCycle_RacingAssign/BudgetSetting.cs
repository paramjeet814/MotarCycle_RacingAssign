using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotarCycle_RacingAssign
{
   public  class BudgetSetting
    {
        public int budget(String recrd,int win,int budget) {
            
            String[] rec = recrd.Split(' ');
            if (Convert.ToInt32(rec[2].ToString()) == win)
            {
                return budget + Convert.ToInt32(rec[5].ToString());
            }
            else {
                return budget - Convert.ToInt32(rec[5].ToString());
            }
        }
    }
}
