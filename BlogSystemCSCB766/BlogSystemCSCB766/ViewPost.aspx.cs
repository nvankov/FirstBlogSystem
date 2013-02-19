using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blog.Data;

namespace BlogSystemCSCB766
{
    public partial class ViewPost : System.Web.UI.Page
    {
        protected int postId;
        protected int multyViewActiveIndex = 0;
 
        protected void Page_Load(object sender, EventArgs e)
        {
            string requestPostId = Request.Params["id"];
            postId = Int32.Parse(requestPostId);

            Post viewedPost = BlogDAL.FindPostById(postId);

            this.LabelPostTitle.Text = viewedPost.PostTitle;
            this.LabelPostContent.Text = viewedPost.PostContent;
            this.LabelPostDate.Text = viewedPost.PostDate.ToString();
            this.HyperLinkEdit.NavigateUrl = "Admin/EditPost.aspx?id=" + postId.ToString();
            this.HyperLinkDelete.NavigateUrl = "Admin/DeletePost.aspx?id=" + postId.ToString();

            string str = postId.ToString();

            if (!Page.IsPostBack)
            {
                if (viewedPost.Comments.Count > 0)
                {
                    MultiViewComments.ActiveViewIndex += 1;
                }

                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    this.MultiViewEditDelete.ActiveViewIndex += 1;
                }
                else
                {
                    this.MultiViewEditDelete.ActiveViewIndex -= 1;
                }
            }

            CSCB766BlogDBEntities blogDB = new CSCB766BlogDBEntities();

            EntityDataSourceComments.WhereParameters.Add(new Parameter("PageId", TypeCode.Int32, postId.ToString()));
        }

        protected Post GetPost()
        { 
            Post post = BlogDAL.FindPostById(postId);
            return post;
        }

        protected void ButtonSubmitComment_Click(object sender, EventArgs e)
        {
            int postId = Int32.Parse(Request.Params["id"]);
            string author = this.TextBoxCommentAuthor.Text;
            string text = this.TextBoxCommentText.Text;

            BlogDAL.AddComment(postId, author, text);

            Response.Redirect("~/ViewPost.aspx?id=" + postId);
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
            string formattedString = escapedString.Replace("\n", "<br />");

            return formattedString;
        }

        protected int GetPostID()
        {
            return postId;
        }

    }
}