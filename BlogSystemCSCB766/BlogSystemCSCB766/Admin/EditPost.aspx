<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="EditPost.aspx.cs" Inherits="BlogSystemCSCB766.Admin.EditPost" ValidateRequest="false"%>



<%@ Register src="~/Controls/AddEditPostControl.ascx" tagname="AddEditPostControl" tagprefix="uc" %>



<asp:Content ID="ContentHead" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Post</h2>
    <div id="post-title">
        <label>Post Title</label>
        <asp:TextBox ID="TextBoxPostTitle" runat="server" MaxLength="200"></asp:TextBox>
    </div>

    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitle" runat="server" 
        ControlToValidate="TextBoxPostTitle" Display="Dynamic" 
        ErrorMessage="<span class='error-message'>Title field should not be empty.</span>">
    </asp:RequiredFieldValidator>


    <div id="post-content">
        <label>Post Content</label>
        <asp:TextBox ID="TextBoxPostContent" runat="server" Height="100px" 
            TextMode="MultiLine"></asp:TextBox>
    </div>

    <asp:RequiredFieldValidator ID="RequiredFieldValidatorContent" 
    runat="server" ControlToValidate="TextBoxPostContent" 
    ErrorMessage="<span class='error-message'>Post content should not be empty.</span>">
    </asp:RequiredFieldValidator>
    <br />

    <footer>
        <asp:Button ID="ButtonEdit" runat="server" Text="Save" OnClick="ButtonEdit_Click" />
        <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
    </footer>


</asp:Content>
