<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6Viewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
        body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 20px;
}

.header {
    background-color: #333;
    color: white;
    padding: 20px 0;
    text-align: center;
}

.main-content {
    display: flex;
    justify-content: center;
    align-items: center;
    margin-top: 40px;
}

.product-view {
    display: flex;
    border: 1px solid #ccc;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.product-image img {
    width: 300px;
    height: auto;
    border-radius: 10px;
}

.product-details {
    margin-left: 20px;
}

.product-title {
    font-size: 24px;
    margin-bottom: 10px;
}

.product-description {
    font-size: 16px;
    color: #555;
    margin-bottom: 20px;
}

.product-price {
    font-size: 22px;
    color: #b12704;
    margin-bottom: 20px;
    display: block;
}

.add-to-cart-btn {
    background-color: #ff9900;
    color: white;
    border: none;
    padding: 10px 20px;
    font-size: 16px;
    cursor: pointer;
    border-radius: 5px;
}

.add-to-cart-btn:hover {
    background-color: #e68a00;
}
    </style>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
        <header class="header">
            <h1>Purchased products </h1>
        </header>
        <main class="main-content">
            <div class="product-view">
                <div class="product-image">
                    <img src="product-image.jpg" alt="Product Image">
                </div>
                <div class="product-details">
                    <h2 class="product-title">Product Name</h2>
                    <p class="product-description">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel velit lectus.</p>
                    <span class="product-price">$99.99</span>
                    <button class="add-to-cart-btn">View Product Details</button>
                </div>
            </div>
        </main>
    </div>
        </div>
    </form>
</body>
</html>
