<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BlogSystemCSCB766._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h1>Welcome to the Blog!</h1>
    
    <asp:ListView ID="ListViewPosts" runat="server" DataSourceID="EntityDataSourcePosts">
        <ItemTemplate>
            <article class="blog-post">
                <header>
                    <h2><a href='ViewPost.aspx?id=<%#Eval("PostId") %>'><%# HtmlEval("PostTitle") %></a></h2>
                    <span class="postDate">Posted on: <%# Eval("PostDate") %></span>
                </header>

                <asp:MultiView ID="MultiViewEditDelete" runat="server" ActiveViewIndex="<%# CheckIfLogged() %>">
                    <asp:View ID="ViewNotLogged" runat="server">
                    </asp:View>
                    <asp:View ID="ViewLogged" runat="server">  
                        <div class="EditDeleteDiv">
                            <ul>
                                <li><a href='Admin/EditPost.aspx?id=<%# Eval("PostID") %>'>[Edit]</a></li>
                                <li><a href='Admin/DeletePost.aspx?id=<%# Eval("PostID") %>'>[Delete]</a></li>
                            </ul>
                        </div>
                    </asp:View>
                </asp:MultiView>

                <section>
                    <p>
                        <%# ContentEval("PostContent")%>
                    </p>
                </section>
            </article>
        </ItemTemplate>
    </asp:ListView>
    <asp:EntityDataSource ID="EntityDataSourcePosts" runat="server" 
        ConnectionString="name=CSCB766BlogDBEntities" 
        DefaultContainerName="CSCB766BlogDBEntities" EnableFlattening="False" 
        EntitySetName="Posts" OrderBy="it.PostID desc">
    </asp:EntityDataSource>
    
   
    <footer>
        <asp:DataPager ID="DataPagerPosts" runat="server" 
            PagedControlID="ListViewPosts" PageSize="5">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                    ShowLastPageButton="True" />
            </Fields>
        </asp:DataPager>
    </footer>
   
    
</asp:Content>
