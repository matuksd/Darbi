<?php

$con = mysqli_connect("localhost","root","","login");


$dbname = "login";
$username = mysqli_real_escape_string($con, $_POST['user']);
$password = mysqli_real_escape_string($con, $_POST['pass']);


$query = "INSERT INTO users (username,password) VALUES ('$username','$password')";
$result = mysqli_query($con,$query);


if(mysqli_query($con,$query)){
  echo "New user created succesfully";
}
else {
  echo "Error: ". $query . "<br>" . mysqli_error($con);
}


mysqli_close($con);
 ?>
