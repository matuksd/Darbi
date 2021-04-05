<?php
echo "<meta charset='utf-8'>";
echo "<li><a href='db_menu.php'>Back</a></li>";
echo "<h3>Informācija par DB tabulu sarakstu</h3>";
require_once("config.php");

$sql="show procedure status where db = 'gramatas3'";
$result =$conn->query($sql); //vaicājuma izpilde
echo "<br><br>DB Datorkursi tabulu saraksts: <br>";
$i=1;
while($row = $result->fetch_assoc())
{

    echo $i.'. '.$row["Name"]."<br/>";
    $i++;

}

echo '<br><form name="manaforma" action="proceduru_saturs.php" method="post">
Ievadiet tabulas nosaukumu:
<input type="text" name="tabula" >
<input type="submit" value="Nosūtīt datus">
</form>';



?>