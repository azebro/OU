<?php
$runnerID = $_POST['RunnerID'];
$eventID = $_POST['EventID'];
$date = $_POST['Date'];
$finishTime = $_POST['FinishTime'];
$position = $_POST['Position'];
$categoryID = $_POST['CategoryID'];
$ageGrade = $_POST['AgeGrade'];
$personalBest = $_POST['PB'];



$host='az2267.tt284.open.ac.uk';
$uid='az2267';
$password='CknaCFnD';
$database='az2267_db';
$connection = connect_db($host, $uid, $password, $database);

if (!$connection)
{
    print ("internal error " . mysql_errno() );
}
else{
    $insertQueryTemplate="insert into Results(RunnerID,EventID,Date,FinishTime,Position,CategoryID,AgeGrade,PB) values (%d,%d,'%s','%s',%d,%d,%f,%d)";
    $insertQuery = sprintf($insertQueryTemplate, $runnerID, $eventID, $date, $finishTime, $position, $categoryID, $ageGrade, $personalBest);
    
    //echo $insertQuery;
    $insertResult = mysql_query($insertQuery, $connection);
    if($insertResult == 1){
        echo "<h1>Success! Saving data:</h1>";
        echo sprintf("<p>RunnerId= %s</p>", $runnerID);
        echo sprintf("<p>EventId= %s</p>", $eventID);
        echo sprintf("<p>Date= %s</p>", $date);
        echo sprintf("<p>Finish time= %s</p>",  $finishTime);
        echo sprintf("<p>Position= %s</p>",  $position);
        echo sprintf("<p>Category id= %s</p>",  $categoryID);
        echo sprintf("<p>Age grade= %s</p>",  $ageGrade);
        echo sprintf("<p>PB= %s</p>",  $personalBest);
    }
    else
    {
    	echo "Error has occured!";
    }
    
    
    
    
    //$query = 'select * from Results';
    //$result = mysql_query($query, $connection);
    //   echo "<table>";
    //   while ( $row = mysql_fetch_array($result) )
    //   {
    //       echo "<tr><td>";
    //       echo $row['RunnerID'];
    //       echo "</td><td>";
    //       echo $row['EventID'];
    //      echo "</td></tr>";
    //  }
    //  echo "</table>";
    
}

function connect_db($host, $id, $pwd, $db)
{
    
    $connection = @mysql_connect($host, $id, $pwd)
        or die('connection problem:' . mysql_error());
    mysql_select_db($db)
        or die('db selection problem: ' . mysql_error());
    return $connection;
}


?>