<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPost.aspx.cs" Inherits="BlogSystemCSCB766.ViewPost" %>
<asp:Content ID="ContentHead" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <article class="viewPost, blog-post">
        <header>
            <h2><asp:Label ID="LabelPostTitle" runat="server"></asp:Label></h2> 
            <span class="postDate">
                Posted on: <asp:Label ID="LabelPostDate" runat="server"></asp:Label>

            </span>
            <asp:MultiView ID="MultiViewEditDelete" runat="server" ActiveViewIndex="0">
                <asp:View ID="ViewNotLogged" runat="server">
                    
                </asp:View>
                <asp:View ID="ViewLogged" runat="server">  
                    <div class="EditDeleteDiv">
                        <ul>
                            <li><asp:HyperLink ID="HyperLinkEdit" runat="server" 
                                NavigateUrl="Admin/EditPost.aspx?id=" Enabled="true">[Edit]</asp:HyperLink></li>
                            <li><asp:HyperLink ID="HyperLinkDelete" runat="server" 
                                NavigateUrl="Admin/EditPost.aspx?id=" Enabled="true">[Delete]</asp:HyperLink></li>
                        </ul>
                    </div>
                </asp:View>
            </asp:MultiView>
        </header>
        <p>
            <asp:Label ID="LabelPostContent" runat="server"></asp:Label>
        </p>

    </article>
    <section class="postComments">

        <asp:MultiView ID="MultiViewComments" runat="server" ActiveViewIndex="0">
            <asp:View runat="server">
                <h4>No Comments</h4>
            </asp:View>
            <asp:View runat="server">
                <h4>Comments</h4>
                <asp:ListView ID="ListViewComments" runat="server" DataSourceID="EntityDataSourceComments" >
                    <ItemTemplate>
                        <div class="singleCommentDiv">
                            <div class="commentAutor"> <%# ContentEval("Author") %> </div>
                            <div class="commentText"><%# ContentEval("CommentText") %> </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </asp:View>
        </asp:MultiView>

        <asp:EntityDataSource ID="EntityDataSourceComments" runat="server" ConnectionString="name=CSCB766BlogDBEntities" 
            DefaultContainerName="CSCB766BlogDBEntities" EnableFlattening="False" EntitySetName="Comments" Where='it.PostId == @PageId'>
        </asp:EntityDataSource>
       
    </section>
    <section id="addComment">
        <h4>Add a comment:</h4>
        <br />
        Author: <asp:TextBox ID="TextBoxCommentAuthor" runat="server" MaxLength="50"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCommentAuthor" 
            runat="server" ControlToValidate="TextBoxCommentAuthor" 
            ErrorMessage="<span class='error-message'>Author field should not be empty.</span>">
        </asp:RequiredFieldValidator>
        <br />
        Comment: <asp:TextBox ID="TextBoxCommentText" runat="server" TextMode="MultiLine" MaxLength="500"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCommentText" 
            runat="server" ControlToValidate="TextBoxCommentText" 
            ErrorMessage="<span class='error-message'>Text field should not be empty.</span>">
        </asp:RequiredFieldValidator>
        <br />
        <footer>
            <asp:Button ID="ButtonSubmitComment" runat="server" Text="Submit" OnClick="ButtonSubmitComment_Click" />
        </footer>


    </section>
</asp:Content>

