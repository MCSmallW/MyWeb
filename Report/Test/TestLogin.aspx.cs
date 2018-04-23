using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Report.Test
{
    public partial class TestLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var action = Request["action"];
            if (!string.IsNullOrWhiteSpace(action))
            {
                Response.Clear();
                switch (action)
                {
                    case "ToWCFAndReturnName":
                        Response.Write(GetName());
                        break;
                }
                Response.End();
            }

        }

        private string GetName()
        {
            var name = Request["name"];
            return "密码为" + name;
        }
    }
}