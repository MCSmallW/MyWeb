using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Check
{
    public class AddSQL
    {
        public void AddBug(string JobNum,string Bug)
        {
            string sql = "";
            SQLHelper helper = new SQLHelper();
            helper.OperateSql(sql);
        }
    }
}
