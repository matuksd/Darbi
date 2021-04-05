<?php
require_once("config.php");
echo "<meta charset='utf-8 '>";
echo "<a href='triggeru_saraksts.php'> Atpakaļ</a>";
$table=$_POST["tabula"];

$sql = "SHOW CREATE trigger $table";
$result = $conn->query($sql);
$row = $result->fetch_fields();
echo '<table style="width:100%" border="1">';

if(isset($table)) {
    $sh = $conn->query($sql);
}
while ($row = $sh->fetch_assoc()) {
        echo '</br><tr>';
        echo '<th>';
        echo $row["Trigger"];

        echo '</th>';
        echo '<th>';
        echo $row["SQL Original Statement"];
        echo '</th>';
        echo '</br></tr>';

}
/*
if ($table == "upper_case") {
    echo '<table style="width:60%" border="1">';
    echo '<tr>';
    echo '<th>';
    echo $table. ' saturs';
    echo '</th>';
    echo '</tr>';
    echo '<tr>';
    echo '<th>';
    echo 'CREATE DEFINER=`root`@`localhost` TRIGGER upper_case
 BEFORE INSERT ON valoda
 FOR EACH ROW SET new.Valoda = UPPER(NEW.Valoda)';
    echo '</th>';
    echo '</tr>';
    echo '</table';
}
else if ($table == "Dzimums_nav_noradits") {
    echo '<table style="width:60%" border="1">';
    echo '<tr>';
    echo '<th>';
    echo $table. ' saturs';
    echo '</th>';
    echo '</tr>';
    echo '<tr>';
    echo '<th>';
    echo 'CREATE DEFINER=`root`@`localhost` TRIGGER Dzimums_nav_noradits
 BEFORE INSERT ON autors
 FOR EACH ROW
 begin
  if (NEW.Dzimums IS NULL OR NEW.Dzimums= \'\')
 	then set new.Dzimums = \'Nav nodarits\';
  end if;
 end';
    echo '</th>';
    echo '</tr>';
    echo '</table';
}
else if ($table == "Add_number_371") {
    echo '<table style="width:60%" border="1">';
    echo '<tr>';
    echo '<th>';
    echo $table. ' saturs';
    echo '</th>';
    echo '</tr>';
    echo '<tr>';
    echo '<th>';
    echo 'CREATE DEFINER=`root`@`localhost` TRIGGER Add_number_371
 BEFORE INSERT ON izdevejs
 FOR EACH ROW
     begin set new.telefons=concat("371"+new.telefons);
 end';
    echo '</th>';
    echo '</tr>';
    echo '</table';
}


else echo "<br>Tabula neeksistē!";
*/

?>

