<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginSupplier.aspx.cs" Inherits="LoginSupplier" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #2e004f;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background: rgba(255, 255, 255, 0.1);
            box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
            backdrop-filter: blur(10px);
            -webkit-backdrop-filter: blur(10px);
            border-radius: 10px;
            border: 1px solid rgba(255, 255, 255, 0.2);
            padding: 20px;
            width: 300px;
            text-align: center;
        }
        h2 {
            color: #ffffff;
            margin-bottom: 20px;
        }
        .input-label {
            color: #ffffff;
            display: block;
            margin: 10px 0 5px;
        }
        .input-field {
    width: 100%;
    padding: 10px;
    margin-bottom: 10px;
    border: none;
    border-radius: 5px;
    outline: none;
    background: rgba(255, 255, 255, 0.2);
    color: #ffffff;
    box-sizing: border-box;
}
        .button {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: none;
            border-radius: 5px;
            background: rgba(255, 255, 255, 0.2);
            color: #ffffff;
            cursor: pointer;
            transition: background 0.3s;
        }
        .button:hover {
            background: rgba(255, 255, 255, 0.3);
        }
        .message {
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Supplier Login</h2>
            <asp:Label ID="lblContactEmail" runat="server" CssClass="input-label" Text="Contact Email:"></asp:Label>
            <asp:TextBox ID="txtContactEmail" runat="server" CssClass="input-field"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" CssClass="input-label" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="input-field" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" CssClass="button" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button ID="BtnGoToSignup" runat="server" CssClass="button" Text="Go To Signup" OnClick="btnOpenSignup_Click" />
            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
        </div>
    </form>
</body>
</html>
