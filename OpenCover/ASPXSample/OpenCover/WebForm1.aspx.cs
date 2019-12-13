using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OpenCoverDemoLib;

namespace OpenCoverDemoASPX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            cls.ifConditiontest(true);
            cls.ifConditiontest(false);
            lblsujith.Text = "You Hit Both True and False";
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            lblsujith.Text = "You Hit Add 1 + 2 = " + cls.Add(1, 2);
                    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            cls.ifConditiontest(true);
            lblsujith.Text ="You Hit Only True";               

        }
    }
}