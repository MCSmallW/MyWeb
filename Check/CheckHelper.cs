using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class CheckHelper
    {
        public bool IfAdmin(string sql,string Admin)
        {
            bool isRight = false;
            SQLHelper helper = new SQLHelper();
            try
            {
                if (helper.IfAdmin(sql,Admin).Rows.Count==1)
                {
                    isRight = true;
                    return isRight;
                }
                else
                {
                    return isRight;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("判断出错：" + ex.Message);
            }
        }
    }
}
