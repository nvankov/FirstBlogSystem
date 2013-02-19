<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="NewPost.aspx.cs" Inherits="BlogSystemCSCB766.Admin.NewPost" ValidateRequest="false"%>



<%@ Register src="~/Controls/AddEditPostControl.ascx" tagname="AddEditPostControl" tagprefix="uc" %>



<asp:Content ID="ContentHead" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <h2>New Post</h2>
    <section id="new-post">
        <uc:AddEditPostControl ID="AddEditPostControl" runat="server" 
            OnSubmitButtonClick = "AddEditPostControl_SubmitButtonClick"/>
    </section>


</asp:Content>
