<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="DeletePost.aspx.cs" Inherits="BlogSystemCSCB766.Admin.DeletePost" %>


<asp:Content ID="ContentHead" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Do you want to permanently delete this post and all related comments?</h2>
    <article class="viewPost">
        <header>
            <h2><asp:Label ID="LabelPostTitle" runat="server"></asp:Label></h2>
        </header>
        <p>
            <asp:Label ID="LabelPostContent" runat="server"></asp:Label>
        </p>

    </article>

    <footer>
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" OnClick="ButtonDelete_Click" />
        <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
    </footer>
    
</asp:Content>
