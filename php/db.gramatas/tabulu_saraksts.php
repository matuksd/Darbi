<?php

echo "<meta charset='utf-8'>";
echo "<li><a href='db_menu.php'>Back</a></li>";
require_once("config.php");
echo "<h3>Tabulu saraksts</h3>";
$conn->set_charset("utf8");//uzliek kodējumu utf8
//----------------------------------visas tabulas
// full table dod extra kollonu kas norāda view vai base table
$sql="show full tables where Table_Type != 'VIEW'";//sql komanda
$result =$conn->query($sql); //vaicājuma izpilde
$i=1;
while($row = $result->fetch_assoc()){
    echo $i.'. '.$row["Tables_in_gramatas3"]."<br/>";//izvadīt uz ekrāna
    $i++;
}
echo '
<form name="manaforma" action="tabulas_saturs.php" method="get">
<br/>Ievadiet tabulas nosaukumu:
<br/><input type="text" name="tabula">
<br/><input type="submit" value="Nosūtīt datus">
</form>';










?>