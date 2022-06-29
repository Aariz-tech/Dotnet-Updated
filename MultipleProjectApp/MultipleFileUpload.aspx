<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultipleFileUpload.aspx.cs" Inherits="MultipleProjectApp.MultipleFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
        <h1>Uploading Multiple Images</h1>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
            <asp:Button ID="Btnupload" runat="server" Text="Save" OnClick="Btnupload_Click" />
        </div>
        <br />
        <asp:Label ID="LabMsg" runat="server" ></asp:Label>
    </form>
        </center>
</body>
</html>
