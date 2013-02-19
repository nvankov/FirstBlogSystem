using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blog.Data;


namespace BlogSystemCSCB766.Admin
{
    public partial class NewPost : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void AddEditPostControl_SubmitButtonClick(object sender, EventArgs e)
        {
            string title = this.AddEditPostControl.PostTitle;
            string postContent = this.AddEditPostControl.PostContent;

            BlogDAL.CreatePost(title, postContent);

            Response.Redirect("~/Default.aspx");
        }
    }
}