<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CmsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            margin-left: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 513px">
            <asp:Panel ID="Panel1" runat="server" Height="139px" style="margin-left: 207px" Width="301px">
                <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
                <br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            <asp:Button ID="BtnYes" runat="server" Height="25px" OnClick="BtnYes_Click" Text="Yes" Width="80px" />
                        </td>
                        <td>
                            <asp:Button ID="BtnNo" runat="server" CssClass="auto-style3" Height="25px" OnClick="BtnNo_Click" Text="No" Width="80px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
