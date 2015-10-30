<?php
if (isset($_POST)) {
  if (isset($_POST["score"])){
    $score = $_POST['score']; // pak de string en int vanuit unity
      
    $newline = $score;
    $file = "score.txt";
    $myfile = fopen($file, "r+");
    file_put_contents($file,"\r\n$score", FILE_APPEND); // stop string en int in nieuwe regel van score.txt
    $data = fread($myfile, filesize($file)); // haalt alle lines uit score.txt en stuurt ze bij echo
	  
    echo $data;
  }
}
?>