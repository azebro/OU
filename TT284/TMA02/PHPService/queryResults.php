<?php
$sortBy = $_POST['SortBy'];
$sortIn = $_POST['SortIn'];
$includeAgeGrade = $_POST['IncludeAgeGrade'];

$host='az2267.tt284.open.ac.uk';
$uid='az2267';
$password='CknaCFnD';
$database='az2267_db';
$connection = connect_db($host, $uid, $password, $database);

if (!$connection)
{
    print ("internal error " . mysql_errno() );
}
else
{
    if($includeAgeGrade == 1)
    {
        $queryTemplate = 'select RunnerID, EventID, Date, FinishTime, Position, CategoryID, AgeGrade, PB from Results order by %s %s';
    }
    else
    {
    	$queryTemplate = 'select RunnerID, EventID, Date, FinishTime, Position, CategoryID, AgeGrade, PB from Results order by %s %s';
    }
    $query = sprintf($queryTemplate, $sortBy, $sortIn);
    
    
    
    $result = mysql_query($query, $connection);
    if($result == 0)
    {
        echo "Error!";
        
    }
    else
    {
        
        echo "<h1>Success!</h1>";
        echo "<p></p>";
        if($includeAgeGrade == 1)
        {
            
            echo "<TABLE><TR><TD><TABLE border='1' >
<TR><TH>RunnerID</TH><TH>EventID</TH><TH>Date</TH><TH>FinishTime</TH><TH>Position</TH><TH>CategoryID</TH><TH>AgeGrade</TH><TH>PB</TH></TR>
<TR ALIGN=LEFT VALIGN=TOP>";
        }
        else{
            echo "<TABLE><TR><TD><TABLE border='1' >
<TR><TH>RunnerID</TH><TH>EventID</TH><TH>Date</TH><TH>FinishTime</TH><TH>Position</TH><TH>CategoryID</TH><TH>PB</TH></TR>
<TR ALIGN=LEFT VALIGN=TOP>";
        }
        while ( $row = mysql_fetch_array($result) )
        {
            
            echo "<tr><td>";
            echo $row['RunnerID'];
            echo "</td><td>";
            echo $row['EventID'];
            echo "</td><td>";
            echo $row['Date'];
            echo "</td><td>";
            echo $row['FinishTime'];
            echo "</td><td>";
            echo $row['Position'];
            echo "</td><td>";
            echo $row['CategoryID'];
            if($includeAgeGrade==1)
            {
                echo "</td><td>";
                echo $row['AgeGrade'];
            }
            echo "</td><td>";
            echo $row['PB'];
            echo "</td></tr>";
        }
        echo "</table>";
    }
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