<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <title>Document</title>
</head>
<body>

   <div class="container-fluid">
<img src="kapak4.jpg">

   </div>
<nav class="navbar navbar-inverse">
    <div class="container-fluid">
      <div class="navbar-header">
        <a class="navbar-brand" href="#">YükselenGaming</a>
      </div>
      <ul class="nav navbar-nav">
        <li class="active"><a href="#">Anasayfa</a></li>
        <li><a href="index.php?git=about">Hakkımda</a></li>
        
      </ul>
      <ul class="nav navbar-nav navbar-right">
      <li>
      <?php
      $hostumuz="localhost";
                                $veritabani_Adi="ykslngame";
                                $kullanici_Adi="root";
                                $sifre="";
                                $gta5price="0";
                                $baglanti=mysqli_connect($hostumuz,$kullanici_Adi,$sifre,$veritabani_Adi);
                                mysqli_select_db($baglanti,"ykslngame");
                                $sql="SELECT * from users";
                               echo "<center><b><font size='3' color='Orange'>";
                               echo $_POST["name"];
                               echo '</center></b></font>';
      echo '</li><li><a href="index.php"><span class="btn btn-secondary btn-lg active"></span> Çıkış yap</a></li>';
        ?>
      </ul>
    </div>
  </nav>
  <div class="container-fluid">
  <?php
if($_GET)
 { switch( $_GET["git"]){
    case"":
      include("content.php");
      break;}
                                $hostumuz="localhost";
                                $veritabani_Adi="vize";
                                $kullanici_Adi="root";
                                $sifre="";
                                $baglanti=mysqli_connect($hostumuz,$kullanici_Adi,$sifre,$veritabani_Adi);
                                mysqli_select_db($baglanti,"ykslngame");
                                if(isset($_POST["name"])&&isset($_POST["password"]))
                                {
                                   
                                    
                                }}
else{include("content.php");};                            
                                ?>


  </div>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js'></script>

</body>
</html>