﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName.Equals("balram") && Login1.Password.Equals("chavan"))
            {
               FormsAuthentication.RedirectFromLoginPage(Login1.UserName,Login1.RememberMeSet);
            }
            else
            {
                Login1.FailureText = "Invalid user";
                Console.WriteLine("Invalid user");
            }
        }
    }
}