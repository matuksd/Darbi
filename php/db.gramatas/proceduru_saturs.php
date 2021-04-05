<?php
require_once("config.php");
echo "<meta charset='utf-8 '>";
echo "<a href='proceduru_saraksts.php'> Atpakaļ</a>";
$table=$_POST["tabula"];

$dbms = 'mysql';
echo $table;
echo "<br><br>Procedūru $table saraksts: <br>";

$host = 'localhost';
$db = 'gramatas3';
$user = 'root';
$dbh = new mysqli("$host","$user","","$db");
$qr = $dbh->query("CALL $table");
//print_r ($qr);
echo "<br>";
while ($row = $qr->fetch_object()) {
    echo "<pre>";
    print_r($row);
    echo "</pre>";
}
/*
if(isset($table)) {
    $sql = "call $table()";
    $query = $conn->query($sql);
    if (!$query->num_rows) {
        echo '<h3 style="color:red">Tabula neeksistē</h3>';
        die();
    }
    echo '<h3> Tabulas ' . $table . ' saturs</h3>';
    $result = $conn->query($sql);
        //$row = $result->call_object();
        echo '<table style="width:80%" border="1">';
        echo '<tr>';
        foreach ($row as $item) {
            echo '<th>';
            echo $item->name;
            echo '</th>';
        }
        echo '</tr>';
        while ($row2 = $result->fetch_assoc()) {
            echo '<tr>';
            foreach ($row2 as $item) {
                echo '<td>';
                echo $item;
                echo '</td>';
            }
            echo '</tr>';
        }
        echo '</table>';
        //}//

}
else echo "<br>Tabula neeksistē!";
*/
?>
