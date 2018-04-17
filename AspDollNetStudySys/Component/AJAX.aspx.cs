using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspDollNetStudySys.Component
{
    public partial class AJAX : System.Web.UI.Page
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
            return "回调数据" + name;
        }
    }
}