using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Report
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var action = Request["action"];
            if (!string.IsNullOrWhiteSpace(action))
            {
                Response.Clear();
                switch (action)
                {
                    case "ToWCFAndAdmin":
                        CheckName();
                        break;
                }
                Response.End();
            }

        }

        private bool CheckName()
        {
            string name = Request["name"];
            CheckHelper check = new CheckHelper();
            bool TF=check.IfAdmin("",name);
            return TF;
        }
    }
    
}