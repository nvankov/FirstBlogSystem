using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blog.Data;

namespace BlogSystemCSCB766.Admin
{
    public partial class AdminCP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object postCount = BlogDAL.PostCount();
            object commentsCount = BlogDAL.CommentCount();

            this.LabelPostCount.Text = postCount.ToString();
            this.LabelCommentCount.Text = commentsCount.ToString();

        }
    }
}