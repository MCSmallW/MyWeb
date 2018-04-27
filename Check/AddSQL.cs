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
            string ip = HelpInfo.GetIP.GetLocalIP();
            if (JobNum!=null && Bug!=null)
            {
                string sql = "";
                SQLHelper helper = new SQLHelper();
                helper.OperateSql(sql);
                return;
            }
            else if(JobNum==null)
            {
                //页面显示弹窗 请输入工号

                return;
            }
            else if(Bug==null)
            {
                //弹窗显示 你的反馈内容为空

                return;
            }
            else
            {
                //弹窗显示错误

                return;
            }
        }
    }
}
