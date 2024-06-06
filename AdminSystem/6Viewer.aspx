<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6Viewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
    



body {
    font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    margin: 0;
    padding: 0;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

.container {
    background: #fff;
    padding: 20px;
    box-shadow: 0 0 10px rgba(0,0,0,0.1);
    border-radius: 8px;
}

h1 {
    text-align: center;
    color: #333;
}

.product-list {
    list-style: none;
    padding: 0;
}

.product-item {
    display: flex;
    align-items: center;
    margin-bottom: 20px;
    padding: 10px;
    border: 1px solid #ddd;
    border-radius: 8px;
    background-color: #f9f9f9;
}

.product-item:last-child {
    margin-bottom: 0;
}

.product-image img {
    width: 100px;
    height: 100px;
    object-fit: cover;
    border-radius: 8px;
    margin-right: 20px;
}

.product-details h2 {
    margin: 0;
    color: #333;
}

.product-details p {
    margin: 5px 0;
    color: #666;
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

    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Purchased Products</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="container">
        <h1>Purchased Products</h1>
        <ul class="product-list">
            <li class="product-item">
                <div class="product-image">
                    <img src="product1.jpg" alt="Product 1">
                </div>
                <div class="product-details">
                    <h2>Product 1</h2>
                    <p>Price: $100</p>
                    <p>Quantity: 2</p>
                </div>
            </li>
            <li class="product-item">
                <div class="product-image">
                    <img src="product2.jpg" alt="Product 2">
                </div>
                <div class="product-details">
                    <h2>Product 2</h2>
                    <p>Price: $50</p>
                    <p>Quantity: 1</p>
                </div>
            </li>
            <li class="product-item">
                <div class="product-image">
                    <img src="product3.jpg" alt="Product 3">
                </div>
                <div class="product-details">
                    <h2>Product 3</h2>
                    <p>Price: $200</p>
                    <p>Quantity: 3</p>
                </div>
            </li>
        </ul>
    </div>
</body>
</html>
</body>
</html>
