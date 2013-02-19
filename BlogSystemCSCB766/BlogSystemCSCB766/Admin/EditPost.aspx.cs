using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blog.Data;


namespace BlogSystemCSCB766.Admin
{
    public partial class EditPost : System.Web.UI.Page
    {
        private int postId;

        protected void Page_Load(object sender, EventArgs e)
        {
            string requestedPostId = Request.Params["id"];
            postId = Int32.Parse(requestedPostId);

            if (!Page.IsPostBack)
            {
                Post editedPost = BlogDAL.FindPostById(this.postId);
                if (editedPost != null)
                {
                    this.TextBoxPostTitle.Text = editedPost.PostTitle;
                    this.TextBoxPostContent.Text = editedPost.PostContent;
                }

            }

            
        }

        //protected void AddEditPostControl_SubmitButtonClick(object sender, EventArgs e)
        //{
        //    string title = this.AddEditPostControl.PostTitle;
        //    string postContent = this.AddEditPostControl.PostContent;

        //    BlogDAL.EditPost(postId, title, postContent);

        //    Response.Redirect("~/Default.aspx");
        //}

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {

            string title = this.TextBoxPostTitle.Text;
            string content = this.TextBoxPostContent.Text;

            Post postToSave = BlogDAL.FindPostById(postId);
            postToSave.PostTitle = title;
            postToSave.PostContent = content;

            BlogDAL.EditPost(postId, title, content);

            Response.Redirect("~/Default.aspx");
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.TextBoxPostTitle.Text = "";
            this.TextBoxPostContent.Text = "";

            Response.Redirect("~/Default.aspx");
        }
    }
}