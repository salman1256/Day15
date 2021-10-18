using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAPPAsp.net
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                lblInfo.Visible = false;
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "Welcome to ASP.NET classic";
            lblInfo.Text += "<br/> User Name " + txtUserName.Text;
            lblInfo.Text += "<br/> User Email " + txtUserEmail.Text;
            lblInfo.Text += "<br/> User Password " + txtUserPwd.Text;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}