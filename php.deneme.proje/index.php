<!DOCTYPE html>
<html >
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <title>Document</title>
</head>
<body style="background-image: url('bg.png'); color:orange;">
   <div class="container-fluid">
<img class="row justify-content-md-center" src="kapak4.jpg">

   </div>
<nav class="navbar navbar-inverse">
    <div class="container-fluid">
      <div class="navbar-header">
        <a class="navbar-brand" href="index.php">YükselenGaming</a>
      </div>
      <ul class="nav navbar-nav">
        <li class="active"><a href="index.php">Anasayfa</a></li>
        <li><a href="index.php?git=about">Hakkımda</a></li>
        
      </ul>
      <ul class="nav navbar-nav navbar-right">
      <li><a href="index.php?git=register"><span class="glyphicon glyphicon-user"></span> Üye Ol</a></li>
        <li><a href="index.php?git=login"><span class="glyphicon glyphicon-log-in"></span> Giriş Yap</a></li>
      </ul>
    </div>
  </nav>
  <div class="container-fluid">
<?php
if($_GET){
switch($_GET["git"]){
  case"":
    include("content.php");
    break;

    case"register":
        include("register.php");
        break;
    case"login":
      include("login.php");
      break;
   case"sell":
      include("gamesell.php");
      break;
      case"about":
        include("about.php");
        break;
}
}
else { include("content.php");};
?>


  </div>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js'></script>

</body>
</html>