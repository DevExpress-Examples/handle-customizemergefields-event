using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace handle_customizemergefields_event
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RE.ActiveTabIndex = 5;
            }
        }

        protected void RE_CustomizeMergeFields(object sender, DevExpress.XtraRichEdit.CustomizeMergeFieldsEventArgs e)
        {

            foreach (var field in e.MergeFieldsNames)
            {
                if (field.Name == "ProductID") field.DisplayName = "ID of Product";
                else if (field.Name == "ProductName") field.DisplayName = "Name of Product";
            }
        }
    }
}