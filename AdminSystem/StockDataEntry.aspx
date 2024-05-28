<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 248px;
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
            left: 17px;
            top: 294px;
            position: absolute;
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
            top: 373px;
            left: 23px;
            z-index: 1;
            width: 135px;
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
            top: 288px;
            left: 213px;
            z-index: 1;
            width: 336px;
            height: 35px;
        }
        .auto-style29 {
            position: absolute;
            top: 229px;
            left: 19px;
            z-index: 1;
            width: 111px;
            height: 22px;
        }
        .auto-style30 {
            position: absolute;
            top: 221px;
            z-index: 1;
            width: 299px;
            bottom: 504px;
        }
        .auto-style31 {
            width: 1597px;
            height: 351px;
            position: absolute;
            top: 467px;
            left: 14px;
            z-index: 1;
        }
        .auto-style32 {
            position: absolute;
            top: 373px;
            left: 188px;
            z-index: 1;
        }
        .auto-style33 {
            position: absolute;
            top: 27px;
            left: 560px;
            z-index: 1;
        }
        .auto-style34 {
            position: absolute;
            top: 369px;
            left: 275px;
            z-index: 1;
        }
        .auto-style35 {
            width: 100%;
        }
        .auto-style36 {
            position: absolute;
            top: 2px;
            left: 77px;
            z-index: 1;
        }
        .auto-style37 {
            position: absolute;
            top: 470px;
            left: 280px;
            z-index: 1;
        }
        .auto-style39 {
            width: 225px;
        }
        .auto-style40 {
            position: absolute;
            top: 2px;
            left: 512px;
            z-index: 1;
        }
        .auto-style41 {
            position: absolute;
            top: 0px;
            left: 790px;
            z-index: 1;
        }
        .auto-style43 {
            position: absolute;
            top: 3px;
            left: 980px;
            z-index: 1;
        }
        .auto-style44 {
            position: absolute;
            top: 1px;
            left: 1456px;
            z-index: 1;
        }
        .auto-style45 {
            position: absolute;
            top: 4px;
            left: 1194px;
            z-index: 1;
            width: 137px;
        }
        .auto-style47 {
            width: 223px;
        }
        .auto-style48 {
            width: 224px;
        }
        .auto-style49 {
            width: 215px;
        }
        .auto-style50 {
            position: absolute;
            top: 368px;
            left: 402px;
            z-index: 1;
        }
    </style>
</head>
<body style="height: 321px; width: 1231px">
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
                        <asp:TextBox ID="TxtQuantity" runat="server" CssClass="auto-style30" height="30px" width="322px"></asp:TextBox>
                    </td>
                    <td class="auto-style24"></td>
                </tr>
            </table>
        </div>
        <p class="auto-style24">

            <asp:Label ID="Label5" runat="server" CssClass="auto-style18" height="27px" Text="Upload Image" width="139px"></asp:Label>

        </p>
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style31">
            <table class="auto-style35">
                <tr>
                    <td class="auto-style39">
                        <asp:Label ID="Label8" runat="server" CssClass="auto-style36" Text="ProductID"></asp:Label>
                    </td>
                    <td></td>
                    <td class="auto-style48">
                        <asp:Label ID="Label10" runat="server" CssClass="auto-style40" Text="Description"></asp:Label>
                        <asp:Label ID="Label11" runat="server" CssClass="auto-style41" Text="Price"></asp:Label>
                    </td>
                    <td></td>
                    <td class="auto-style49">
                        <asp:Label ID="Label12" runat="server" CssClass="auto-style43" Text="Quantity"></asp:Label>
                    </td>
                    <td class="auto-style47">
                        <asp:Label ID="Label13" runat="server" CssClass="auto-style44" Text="Active"></asp:Label>
                        <asp:Label ID="Label14" runat="server" CssClass="auto-style45" Text="Upload Image"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style48">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style48">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style48">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style48">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style48">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style48">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style48">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <p>
        <asp:Button ID="BtnAddProduct" runat="server" CssClass="auto-style26" OnClick="BtnAddProduct_Click1" Text="Add Product" ForeColor="#00CC00" />
            <asp:Button ID="BtnEdit" runat="server" CssClass="auto-style32" ForeColor="#0066FF" Text="Edit" />
            <asp:Button ID="BtnFind" runat="server" CssClass="auto-style33" ForeColor="#0066FF" Text="Find" OnClick="BtnFind_Click" />
        </p>
        <asp:Button ID="Btnupdate" runat="server" CssClass="auto-style34" ForeColor="#0066FF" Text="Update" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style50" ForeColor="#CC0000" Text="Delete" />
        <asp:Label ID="Label9" runat="server" CssClass="auto-style37" Text="Product Name"></asp:Label>
    </form>
</body>
</html>