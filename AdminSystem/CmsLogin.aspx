<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CmsLogin.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Log In</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f3f3f3;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .main {
            background-color: #fff;
            border-radius: 15px;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.2);
            padding: 20px;
            width: 300px;
        }

        .main h2 {
            color: blue;
            margin-bottom: 20px;
        }

        label {
            display: block;
            margin-bottom: 5px;
            color: #555;
            font-weight: bold;
        }

        input[type="text"],
        input[type="password"],
        input[type="email"],
        input[type="number"] {
            width: 100%;
            margin-bottom: 15px;
            padding: 10px;
            box-sizing: border-box;
            border: 1px solid #ddd;
            border-radius: 5px;
        }

        select {
            width: 100%;
            margin-bottom: 15px;
            padding: 10px;
            box-sizing: border-box;
            border: 1px solid #ddd;
            border-radius: 5px;
        }

        button[type="submit"] {
            padding: 15px;
            border-radius: 10px;
            border: none;
            background-color: blue;
            color: white;
            cursor: pointer;
            width: 100%;
            font-size: 16px;
        }
        
        button[type="register"] {
            padding: 15px;
            border-radius: 10px;
            border: none;
            background-color: blue;
            color: white;
            cursor: pointer;
            width: 100%;
            font-size: 16px;
        }
    </style>
</head>
<body>
    <form action="action_page.php" method="post" class="main">
        <h2>&nbsp;Sign In</h2>
        <label for="name">Name:</label>
        <input type="text" id="name" name="name" required>

       

        <label for="password">Password:</label>
        <input type="password" id="password" name="password" required>

   
    </style>
</head>
<body>

        <button type="submit">Log In</button>
       
                <p>I don't have an account</p>

            <button type="register">Register</button>
        </form>
        <p>
</body>
</html>