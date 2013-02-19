using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogSystemCSCB766
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MultiViewEditDelete.ActiveViewIndex += 1;

        }

        protected string HtmlEval(string text)
        {
            string newText = (string)Eval(text);
            string newEscapedText = Server.HtmlEncode(newText);

            return newEscapedText;
        }
        protected string ContentEval(string textValue)
        {
            string escapedString = HtmlEval(textValue);
            string formattedString = escapedString.Replace("\n","<br />");

            return formattedString;
        }

        protected int CheckIfLogged()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
