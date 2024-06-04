<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 115px;
        }
        .auto-style11 {
            position: absolute;
            top: 23px;
            left: 213px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 73px;
            left: 213px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 124px;
            left: 213px;
            z-index: 1;
            width: 299px;
            bottom: 602px;
        }
        .auto-style15 {
            z-index: 1;
            left: 19px;
            top: 76px;
            position: absolute;
        }
        .auto-style16 {
            z-index: 1;
            left: 19px;
            top: 127px;
            position: absolute;
        }
        .auto-style18 {
            z-index: 1;
            left: 20px;
            top: 271px;
            position: absolute;
            height: 38px;
        }
        .auto-style19 {
            z-index: 1;
            left: 19px;
            top: 26px;
            position: absolute;
        }
        .auto-style20 {
            position: absolute;
            top: 175px;
            left: 22px;
            z-index: 1;
            width: 111px;
        }
        .auto-style22 {
            width: 196px;
            height: 45px;
        }
        .auto-style23 {
            width: 624px;
            height: 45px;
        }
        .auto-style24 {
            height: 45px;
        }
        .auto-style26 {
            position: absolute;
            top: 393px;
            left: 21px;
            z-index: 1;
            width: 91px;
            height: 28px;
        }
        .auto-style27 {
            position: absolute;
            top: 169px;
            left: 213px;
            z-index: 1;
            width: 299px;
            bottom: 556px;
        }
        .auto-style28 {
            position: absolute;
            top: 258px;
            left: 210px;
            z-index: 1;
            width: 336px;
            height: 35px;
        }
        .auto-style29 {
            position: absolute;
            top: 218px;
            left: 17px;
            z-index: 1;
            height: 22px;
        }
        .auto-style30 {
            position: absolute;
            top: 211px;
            z-index: 1;
            width: 299px;
            bottom: 429px;
            left: 211px;
        }
        .auto-style33 {
            position: absolute;
            top: 27px;
            left: 560px;
            z-index: 1;
        }
        .auto-style50 {
            position: absolute;
            top: 392px;
            left: 128px;
            z-index: 1;
            width: 99px;
            height: 28px;
        }
    </style>
</head>
<body style="height: 456px; width: 1231px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style22">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style19" height="27px" Text="ProductID" width="139px"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="TxtProductID" runat="server" CssClass="auto-style11" height="30px" width="322px"></asp:TextBox>
                    </td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style22"></td>
                    <td class="auto-style23">
                        <asp:TextBox ID="TxtProductName" runat="server" CssClass="auto-style12" height="30px" width="322px"></asp:TextBox>
                    </td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        <asp:Label ID="Label2" runat="server" CssClass="auto-style15" Text="Product Name"></asp:Label>
                        <asp:Label ID="Label3" runat="server" CssClass="auto-style16" height="27px" Text="Description" width="139px"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:FileUpload ID="ImgProduct" runat="server" CssClass="auto-style28" ForeColor="#0066FF" AllowMultiple="True" />
                        <asp:TextBox ID="TxtPrice" runat="server" CssClass="auto-style27" height="30px" width="322px"></asp:TextBox>
                    </td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style20" height="27px" Text="Price" width="139px"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="TxtDescription" runat="server" CssClass="auto-style13" height="30px" width="322px"></asp:TextBox>
                    </td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        <asp:Label ID="Label7" runat="server" CssClass="auto-style29" Text="Quantity" width="139px"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="TxtQuantity" runat="server" CssClass="auto-style30" height="30px" width="322px" OnTextChanged="TxtQuantity_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style24"></td>
                </tr>
            </table>
        </div>
        <p class="auto-style24">

            <asp:Label ID="Label5" runat="server" CssClass="auto-style18" Text="Upload Image" width="139px"></asp:Label>

            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 22px; top: 353px; position: absolute" Text="Active" />

        </p>
        <p>
            <asp:Button ID="BtnFind" runat="server" CssClass="auto-style33" ForeColor="#0066FF" Text="Find" OnClick="BtnFind_Click" />
        </p>
        <p>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style50" ForeColor="#CC0000" Text="Cancel" />
        <asp:Button ID="BtnOK" runat="server" CssClass="auto-style26" OnClick ="BtnOK_Click1" Text="OK" ForeColor="#00CC00" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 150px; top: 354px; position: absolute; height: 19px" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>