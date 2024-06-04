<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CmsList.aspx.cs" Inherits="_1_List" %>


<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 625px;
            width: 586px;
        }
        .auto-style2 {
            width: 57%;
            height: 74px;
        }
        .auto-style3 {
            height: 36px;
        }
        .auto-style4 {
            height: 36px;
            width: 148px;
        }
        .auto-style5 {
            width: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
        </div>
        <asp:ListBox ID="lstCustomersList" runat="server" Height="435px" OnSelectedIndexChanged="lstCustomersList_SelectedIndexChanged" Width="587px"></asp:ListBox>
        <br />
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" />
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
        <br />
        <asp:Label ID="lblError" runat="server" Text="."></asp:Label>
        <br />
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblPostCode" runat="server" Text="Enter a Post Code"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtBoxPc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="BtnFltr" runat="server" OnClick="BtnFltr_Click" Text="Apply Filter" />
                </td>
                <td>
                    <asp:Button ID="BtnClr" runat="server" OnClick="BtnClr_Click" Text="Clear Filter" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
