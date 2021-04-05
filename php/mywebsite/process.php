<?php

$con = mysqli_connect("localhost","root","","login");


$dbname = "login";
$username = mysqli_real_escape_string($con, $_POST['user']);
$password = mysqli_real_escape_string($con, $_POST['pass']);


$query = "select * from users where username = '$username' and password = '$password'";
$result = mysqli_query($con,$query);


$row = mysqli_fetch_array($result);
if($row['username'] == $username && $row['password'] == $password){
  echo "Login succesfull! Welcome ".$row['username'];
}
else{
  echo "Failed to login";
}
mysqli_close($con);
 ?>
