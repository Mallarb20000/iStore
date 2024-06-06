<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CmsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 132px;
        }
        .auto-style3 {
            width: 129px;
        }
    </style>
</head>
<body style="height: 563px; width: 448px">
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Width="445px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Customer Registration</asp:Panel>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Customer Id</td>
                    <td>
                        <asp:TextBox ID="TxtCustomerId" runat="server"></asp:TextBox>
                        <asp:Button ID="BtnFind" runat="server" Text="Find" OnClick="BtnFind_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date of Registration</td>
                    <td>
                        <asp:TextBox ID="TxtDateAdded" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="TxtCustomerName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td>
                        <asp:TextBox ID="TxtCustomerEmail" runat="server" OnTextChanged="TxtCustomerEmail_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="TxtCustomerPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Post Code</td>
                    <td>
                        <asp:TextBox ID="TxtPostCode" runat="server" OnTextChanged="TxtPostCode_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Premium Member</td>
                    <td>
                        <asp:CheckBox ID="ChkActive" runat="server" OnCheckedChanged="ChkActive_CheckedChanged" AutoPostBack="true" Text="Premium" />
                    </td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="BtnOk" runat="server" Text="Ok" OnClick="BtnOk_Click" style="width: 31px" />
                    </td>
                    <td>
                        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblError" runat="server" Text="."></asp:Label>

        </div>
    </form>
</body>
</html>