<?php
require_once('config.php');
echo "<br><a href='tabulu_saraksts.php'>Back</a>";
$conn->set_charset('utf8');

echo $conn->connect_error ? 'Savienojuma errors: ' . $conn->connect_error : '';

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

}



?>