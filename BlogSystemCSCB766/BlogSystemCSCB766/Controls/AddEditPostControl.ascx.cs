using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogSystemCSCB766.Controls
{
    public partial class AddEditPostControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string PostTitle
        {
            get
            {
                return this.TextBoxPostTitle.Text;
            }
            set
            {
                this.TextBoxPostContent.Text = value;
            }
        }

        public string PostContent
        {
            get
            {
                return this.TextBoxPostContent.Text;
            }
            set 
            { 
                this.TextBoxPostContent.Text = value; 
            }
        }

        public event EventHandler SubmitButtonClick
        {
            add 
            { 
                this.ButtonSubmitPost.Click += value; 
            }
            remove 
            {
               this.ButtonSubmitPost.Click -= value; 
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.TextBoxPostTitle.Text = "";
            this.TextBoxPostContent.Text = "";
            Response.Redirect("~/Default.aspx");
        }
    }
}