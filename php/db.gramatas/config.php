<?php
$dblocation='localhost';
$dbuser='root';
$dbpasswd='';
$dbname = "gramatas3";
//komentars
$conn = new mysqli($dblocation, $dbuser, $dbpasswd, $dbname);//pieslegums
if ($conn->connect_error) 
	echo "Savienojuma kļūda: " . $conn->connect_error;
	else
	echo "<br/>Pieslēgums veiksmīgs!";

?>
