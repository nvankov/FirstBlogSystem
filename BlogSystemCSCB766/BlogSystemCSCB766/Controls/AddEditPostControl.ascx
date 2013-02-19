<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddEditPostControl.ascx.cs" 
    Inherits="BlogSystemCSCB766.Controls.AddEditPostControl" %>

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
    <asp:Button ID="ButtonSubmitPost" runat="server" Height="26px" Text="Submit" 
                        Width="100px"/>
    <asp:Button ID="ButtonCancel" runat="server" Height="26px" Text="Cancel" 
                        Width="100px" OnClick="ButtonCancel_Click"/>
</footer>