<?php
require_once('config.php');
echo "<br><a href='tabulu_saraksts.php'>Back</a>";
$conn->set_charset('utf8');

echo $conn->connect_error ? 'Savienojuma errors: ' . $conn->connect_error : '';

$table=$_GET["tabula"];
$id=isset($_GET['id']) ? $_GET['id'] : null;
$darbiba=$_GET['darbiba'];
$table2 = $table;
if(isset($id) &&$darbiba=='delete')
{//vaicajums uz dzešanu
    $table2 .="ID";
    $table2 = ucfirst($table2);
    $sql="delete from $table where $table2"."=$id";
    $result =$conn->query($sql);
    echo "<br/>Ieraksts ar numuru $table $id izdzests!";
}
$table=$_GET["tabula"];

if(isset($table)) {
    $sql = "SHOW TABLES LIKE '$table'";
    $query = $conn->query($sql);

    if (!$query->num_rows) {
        echo '<h3 style="color:#ff0000">Tabula neeksistē</h3>';
        die();
    }

    echo '<table border="1"  style="width:100%">'; //page table
    echo '<tr>';
    echo '<th style="width:50%" rowspan="2">';
    echo '<h3> Tabulas "'.$table.'" saturs</h3>';
    $sql = "select * from ".$table;
    $result = $conn->query($sql);
    $row = $result->fetch_fields();
    echo '<table style="width:100%" border="1">'; // data table
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

    echo '</th>';
    echo '<th>';
    //scripti tabulas izveidei
    echo '<table border="1" align="center" style="width:100%">';
    if(isset($table)) {
        $sql = "SHOW CREATE TABLE $table";
        $sh = $conn->query($sql);
    }
    while ($row2 = $sh->fetch_assoc()) {
        foreach ($row2 as $item) {
            echo '</br><tr>';
            echo '<th>';
            echo $item;
            echo '</th>';
            echo '</br></tr>';
        }
    }
    echo '</table>';

    echo '</th>';
    echo '</tr>';
    echo '</table>';
    //===
    $darbiba=$_GET['darbiba'];
    if($darbiba=='sql'){
        if(!empty($_GET["vaicajums"])){

            $sql=$_GET["vaicajums"];
            $darbiba2=$_GET["darbiba"];
            $result = $conn->query($sql);
        }}
    //|//====================================

    echo "<br/><br/>Datu dzēšana pēc id";
    echo '
	<form name="manaforma" action="tabulas_saturs.php" method="get">
	<br/>Ievadiet ieraksta id:
	<br/><input type="text" name="id">
	<input type="hidden" name="tabula" value="'.$table.'">
	<input type="hidden" name="darbiba" value="delete">
    <input type="submit" value="Nodzēst ierakstu">
    </form>';
    echo "<br/><br/>Datu ievietošana";
    echo '
    <form name="manaforma2" action="tabulas_saturs.php" method="get">
    <br/>Ievadiet pievienojamos datus pēc piemēra:
    <br/><input type="text" name="vaicajums">
    <input type="hidden" name="tabula" value="'.$table.'">
	<input type="hidden" name="darbiba" value="sql">
	<input type="submit" value="Pievienot datus">
	</form>';

}



?>