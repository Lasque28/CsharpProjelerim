<!DOCTYPE html>
<html >
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body style="background-image: url('bg.png');">
<?php
                                $hostumuz="localhost";
                                $veritabani_Adi="ykslngame";
                                $kullanici_Adi="root";
                                $sifre="";
                                $gta5price="0";
                                $baglanti=mysqli_connect($hostumuz,$kullanici_Adi,$sifre,$veritabani_Adi);
                                mysqli_select_db($baglanti,"ykslngame");
                                $sql="SELECT * from game";
                                $query=mysqli_query($baglanti,$sql) ;
                                $fiyat=array();
                                $isim=array();
                                while($show=mysqli_fetch_assoc($query)){
                                  $isim[]=$show["gameName"];
                                  $fiyat[]=$show["gamePrice"];
                                  
                                }

                                  echo '
                                  <div style="color:orange;">
                                   <table class="table   align-middle" method="POST">
                                    <thead>
                                      <tr>
                                      <td  width="100"></td>
                                      <td width="230"><label id="1" />'.$isim[0].'</label><img src="gta5.jpg" height="300" width="200"> <br/> '.$fiyat[0]."TL"
                                        .'<a href="index.php?git=sell" method="post"><input type="submit" onclick="post();" name="0" id="0" class="btn btn-info value="Satın al"  ></th>';
                                echo '
                                        <td width="230" ><label id="2">'.$isim[1].'</label><img src="bf1.jpg" height="300" width="200"> <br>'.$fiyat[1]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit" name="1" class="btn btn-info " >Satın Al</button></a></th></th>';
      
                                        echo '
                                        <td width="230" ><label id="3">'.$isim[2].'</label><img src="farcry5.jpg" height="300" width="200"> <br>'.$fiyat[2]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit" name="2" class="btn btn-info " >Satın Al</button></a></th></th>';
                                        echo '
                                        <td width="230" ><label id="4">'.$isim[3].'</label><img src="rdr2.jpg" height="300" width="200"> <br>'.$fiyat[3]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit" name="3" class="btn btn-info " >Satın Al</button></a></th></th>';
                                        echo '
                                        <td width="230" ><label id="4">'.$isim[4].'</label><img src="SE.jpg" height="300" width="200"> <br>'.$fiyat[4]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit"name="5" class="btn btn-info " >Satın Al</button></a></th></th>';
    echo' <td  width="100"></td></tr></thead><tbody><tr>';echo '<td  width="100"></td>
                                        <td ><label id="6">'.$isim[5].'</label><img src="pubg.jpg" height="300" width="200"> <br>'.$fiyat[5]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit" name="5" class="btn btn-info " >Satın Al</button></a></th></th>';
                                        echo '
                                        <td ><label id="7">'.$isim[6].'</label><img src="tw3.jpg" height="300" width="200"> <br>'.$fiyat[6]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit"name="6" class="btn btn-info " >Satın Al</button></a></th></th>';
                                        echo '
                                        <td ><label id="8">'.$isim[7].'</label><img src="pes20.jpg" height="300" width="200"> <br>'.$fiyat[7]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit" name="7" class="btn btn-info " >Satın Al</button></a></th></th>';
                                        echo '
                                        <td ><label id="9">'.$isim[8].'</label><img src="fifa211.jpg" height="300" width="200"> <br>'.$fiyat[8]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit" name="8"  class="btn btn-info " >Satın Al</button></a></th></th>';
                                        echo '
                                        <td ><label id="10">'.$isim[9].'</label><img src="skyrim.jpg" height="300" width="200"> <br>'.$fiyat[9]."TL".
                                        '<a href="index.php?git=sell" method="post"><button type="submit" name="9" class="btn btn-info " >Satın Al</button></a></th></th>';
     echo' <td  width="100"></td>
    </tr>
 
    
  </tbody>
</table>
';?>
</div>
    
</body>
</html>