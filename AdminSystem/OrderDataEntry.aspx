<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" style="z-index: 1; left: 681px; top: 52px; position: absolute" Text="Search" />
            <asp:Button ID="Cart" runat="server" OnClick="Cart_Click" style="z-index: 1; left: 819px; top: 15px; position: absolute; width: 55px; right: 411px;" Text="Cart" height="26px" />
        </div>
        <asp:TextBox ID="Searchbox" runat="server" style="z-index: 1; left: 265px; top: 55px; position: absolute; width: 384px"></asp:TextBox>
        <p>
            <asp:Button ID="Login" runat="server" OnClick="Login_Click" style="z-index: 1; left: 895px; top: 14px; position: absolute; width: 55px; height: 26px;" Text="Login" />
        </p>
        <p>
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Mac3.jpeg" style="z-index: 1; left: 774px; top: 79px; position: absolute; height: 170px; width: 165px" />
        </p>
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Mac2.jpeg" style="z-index: 1; left: 484px; top: 108px; position: absolute; height: 129px; width: 149px" />
        <asp:Button ID="Add1" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 222px; top: 251px; position: absolute" Text="Add to Cart" />
        <asp:Button ID="Add2" runat="server" height="26px" OnClick="Add2_Click" style="z-index: 1; left: 508px; top: 254px; position: absolute" Text="Add to Cart" width="100px" />
        <asp:Button ID="Add6" runat="server" height="26px" OnClick="Button1_Click" style="z-index: 1; left: 811px; top: 488px; position: absolute" Text="Add to Cart" width="100px" />
        <asp:Button ID="Add5" runat="server" height="26px" style="z-index: 1; left: 521px; top: 487px; position: absolute" Text="Add to Cart" width="100px" />
        <asp:Button ID="Add3" runat="server" height="26px" OnClick="Add3_Click" style="z-index: 1; left: 810px; top: 253px; position: absolute; right: 375px" Text="Add to Cart" width="100px" />
        <p>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Mac Air.jpeg" style="z-index: 1; left: 197px; top: 85px; position: absolute; height: 153px; width: 159px" />
        </p>
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Mac5.jpeg" style="z-index: 1; left: 478px; top: 293px; position: absolute; height: 180px; width: 184px; margin-top: 0px" />
        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/Mac6.jpeg" style="z-index: 1; left: 725px; top: 296px; position: absolute; height: 174px; width: 264px" />
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Mac4.jpeg" style="z-index: 1; left: 180px; top: 325px; position: absolute; height: 140px; width: 188px" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Add4" runat="server" height="26px" style="z-index: 1; left: 222px; top: 487px; position: absolute; margin-top: 0px" Text="Add to Cart" width="100px" />
        </p>
    </form>
</body>
</html>
