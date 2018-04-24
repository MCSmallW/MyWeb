using Check;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Report.Component
{
    public partial class SendBug : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var action = Request["action"];
            if (!string.IsNullOrWhiteSpace(action))
            {
                Response.Clear();
                switch (action)
                {
                    case "SendBug":
                        //方法
                        GetBug();
                        break;
                }
                Response.End();
            }
        }
        private void GetBug()
        {
            string JobNum = Request["JobNum"];
            string txtBug = Request["GetBug"];
            //执行 插入SQL 
            AddSQL addSQL = new AddSQL();
            addSQL.AddBug(JobNum,txtBug);
        }
    }
}