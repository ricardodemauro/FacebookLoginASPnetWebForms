﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace FacebookLoginASPnetWebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "https://www.facebook.com/v2.0/dialog/oauth/?client_id=" + ConfigurationManager.AppSettings["FacebookAppId"]  + "&redirect_uri=http://localhost:32851/account/user.aspx&response_type=code&state=1";
            HyperLink1.Text = "Login with Facebook";
        }
    }
}