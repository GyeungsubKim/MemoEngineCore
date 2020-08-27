using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngineCore
{
    public partial class FrmHelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BnClick_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = txtInput.Text;
            txtInput.Text = string.Empty;
        }
    }
}