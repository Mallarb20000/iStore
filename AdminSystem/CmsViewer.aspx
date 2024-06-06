<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CmsViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Edit Profile</title>
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

        .profile-form {
            background-color: #fff;
            border-radius: 15px;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.2);
            padding: 20px;
            width: 300px;
        }

        .profile-form h2 {
            color: blue;
            margin-bottom: 20px;
        }

        label {
            display: block;
            margin-bottom: 5px;
            color: #555;
            font-weight: bold;
        }
        select {   
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
            border: 1px solid #ddd;
            border-radius: 5px;

             
        }


        input[type="text"],
        input[type="date"],
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
        .auto-style1 {
            margin-bottom: 16px;
        }
    </style>
</head>
<body>
    <div class="profile-form">
        <h2>Edit Profile</h2>
        <form action="update_profile.php" method="post">
            <label for="name">Name:</label>
            <input type="text" id="name" name="name" required>

            <label for="email">Email:</label>
            <input type="email" id="email" name="email" required>

            <label for="password">Password:</label>
            <input type="password" id="password" name="password" required>

            <label for="postcode">Postcode:</label>
            <input type="text" id="postcode" name="postcode" required>

            <label for="membership">Choose Membership:</label>
            <select id="membership" name="membership" class="auto-style1">   
               <option value="regular">Regular</option>
               <option value="premium">Premium</option>
                            </select>
 
            <button type="submit">Save Changes</button>

        </form>
    </div>
</body>
</html>
