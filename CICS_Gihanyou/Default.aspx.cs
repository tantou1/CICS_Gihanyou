using System;
using Common;

namespace CICS_Gihanyou
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (DBUtilitycs.Server == "")
                {
                    DBUtilitycs.get_connetion_ifo();
                }
            }
        }
    }
}