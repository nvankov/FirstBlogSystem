using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blog.Data;

namespace BlogSystemCSCB766.Admin
{
    public partial class DeletePost : System.Web.UI.Page
    {
        private int postId;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string requestPostId = Request.Params["id"];
            postId = Int32.Parse(requestPostId);

            Post deletedPost = BlogDAL.FindPostById(this.postId);

            this.LabelPostTitle.Text = deletedPost.PostTitle;
            this.LabelPostContent.Text = deletedPost.PostContent;

            //this.TextBoxPostTitle.Text = deletedPost.PostTitle;
            //this.TextBoxPostContent.Text = deletedPost.PostContent;

        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            BlogDAL.DeletePost(this.postId);

            Response.Redirect("~/Default.aspx");
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}