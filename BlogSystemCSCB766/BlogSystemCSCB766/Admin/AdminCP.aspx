<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminCP.aspx.cs" 
    Inherits="BlogSystemCSCB766.Admin.AdminCP" %>
<asp:Content ID="ContentHead" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <nav id="adminSidePanel">
        <h3>Admin Tools</h3>
        <ul>
            <li>
                <div>Site Nav</div>
                <ul class="adminNav">
                    <li><a href="../Default.aspx">Home Page</a></li>
                    <li><a href="../About.aspx">About</a></li>
                </ul>
            </li>
            <li>
                <div>Manage Page</div>
                <ul class="adminNav">
                    <li><a href="NewPost.aspx">Add new post</a></li>
                </ul>
            </li>
        </ul>
    </nav>
    <section id="mainAdminPage">
        <h2>Welcome to the Admin Page</h2>
        <div>
            <div>What do you want to do?</div>
            <ul>
                <li><a href="../Default.aspx">Check Site</a></li>
                <li><a href="NewPost.aspx">Add a post</a></li>
            </ul>
        </div>
        <div>
            Currently there are:
            <div>Posts: 
                <asp:Label ID="LabelPostCount" runat="server" Text=""></asp:Label>
            </div>
            <div>Comments: 
                <asp:Label ID="LabelCommentCount" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </section>
</asp:Content>
