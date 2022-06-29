<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datalist-image-gallary.aspx.cs" Inherits="MultipleProjectApp.Datalist_image_gallary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" CellPadding="2">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>Product Name</td>
                        <br />
                        <td><%#Eval("ProductName")%></td>
                    </tr>
                    <tr>
                        <hr />
                        <td>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ProductImg") %>' Width="120" Height="120" /></td>
                    </tr>
                    <tr>
                        <td>Product Description</td>
                        <td><%#Eval("ProductDesc") %></td>
                    </tr>
                    <tr>
                        <td>Price</td>
                        <td><%#Eval("ProductPrice") %></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</body>
</html>
