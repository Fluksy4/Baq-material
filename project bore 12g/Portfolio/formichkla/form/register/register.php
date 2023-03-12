<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Register</title>
    <link rel="stylesheet" href="register.css">
</head>

<body>

    <div>
        <form action="/action_page.php">

            <p>Register FORM!!!</p>

            <label for="fname">First Name</label>
            <input type="text" id="fname" name="firstname" placeholder="Your name.." required>

            <label for="lname">Last Name</label>
            <input type="text" id="lname" name="lastname" placeholder="Your last name.." required>

            <label for="lname">Password</label>
            <input type="text" id="Password" name="Password" placeholder="Your Password.." required>

            <label for="lname">Confirm Password</label>
            <input type="text" id="Password" name="Password" placeholder="Confirm Password.." required>

            <label for="lname">Sex</label>
            <input type="text" id="Sex" name="Sex" placeholder="Your Sex.." required>
            <select name="Sex" id="sex">
                <option value="Male">Male</option>
                <option value="Female">Female</option>

            </select>

            <label for="lname">Hobby</label>
            <input type="text" id="lname" name="lastname" placeholder="Your last name.." required>

            <label for="lname">Last Name</label>
            <input type="text" id="lname" name="lastname" placeholder="Your last name.." required>

            <label for="country">Country</label>
            <select id="country" name="country">
                <option value="Bulgaria">Bulgaria</option>
                <option value="Serbia">Serbia</option>
                <option value="Macedonia">Macedonia</option>
                <option value="Romania">Romania</option>
                <option value="Greece">Greece</option>
            </select>

            <input type="submit" value="Register">
        </form>



        <a href="C:\Users\Student\Desktop\Portfolio\formichkla\login\login.php">Log In</a>
    </div>



</body>

</html>