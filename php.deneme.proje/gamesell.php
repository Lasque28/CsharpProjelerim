<link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
<div class="container">

<table width="1161" height="509" border="2">
  <tr>
  <td width="389" rowspan="5">
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
                                  $gameId[]=$show["gameID"];
                                  $isim[]=$show["gameName"];
                                  $fiyat[]=$show["gamePrice"];
                                  
                                }
                                
                                for($x=0;$x>10;$x++)
                                {
                                  if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[0].'</h1>';
                                    echo '<img src="gta5.jpg"height="400" width="350"></td>';
                                  }
                                  else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[1].'</h1>';
                                    echo '<img src="bf1.jpg"height="400" width="350"></td>';
                                  }
                                  else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[2].'</h1>';
                                    echo '<img src="farcry5.jpg"height="400" width="350"></td>';
                                  }
                                  else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[3].'</h1>';
                                    echo '<img src="SE.jpg"height="400" width="350"></td>';
                                  } else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[4].'</h1>';
                                    echo '<img src="pubg.jpg"height="400" width="350"></td>';
                                  } else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[5].'</h1>';
                                    echo '<img src="rdr2.jpg"height="400" width="350"></td>';
                                  } else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[6].'</h1>';
                                    echo '<img src="tw2.jpg"height="400" width="350"></td>';
                                  } else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[7].'</h1>';
                                    echo '<img src="pes20.jpg"height="400" width="350"></td>';
                                  } else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[8].'</h1>';
                                    echo '<img src="fifa211.jpg"height="400" width="350"></td>';
                                  }
                                  else if(in_array($_POST["0"],$gameId[$x],TRUE))
                                  {echo '<h1>'.$isim[9].'</h1>';
                                    echo '<img src="skyrim.jpg"height="400" width="350"></td>';
                                  }
                                  else{echo 'hatalı kod ';}
                                }
    
    ?>
    <td rowspan="3" colspan="3">
   <form method="POST">
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="name">Ad</label>
      <input type="text" class="form-control" name="name" placeholder="Ad">
    </div>
    <div class="form-group col-md-6">
      <label for="surrname">Soyad</label>
      <input type="text" class="form-control" name="surrname" placeholder="Soyad">
    </div>
  </div>
  <div class="form-group col-md-6"">
    <label for="address">&nbsp;Address</label>
    <input type="text" class="form-control" name="address" placeholder="açık adres">
  </div>
  <div class="form-group col-md-6"">
    <label for="address2">&nbsp; Address tarifi</label>
    <input type="text" class="form-control" name="address2" placeholder="bakkal yanı vs.">
  </div>
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="city">Şehir</label>
      <input type="text" class="form-control"name="city">
    </div>
    <div class="form-group col-md-6">
      <label for="city2">ilçe</label>
      <input type="text" class="form-control" name="city2">
    </div>
  
  </div>
</form>
   </td>
  </tr>
  <tr>
  </tr>

  <tr>
    
  </tr>
  <tr>
    <td height="23" rowspan="2" colspan="5">
    <form method="POST">
    <div class="form-row">
    <div class="form-group col-md-6">
      <label for="cardname">Kart Adı Soyadı</label>
      <input type="text" class="form-control" name="cardname" placeholder="Ad">
    </div>
    <div class="form-group col-md-6">
      <label for="inputPassword4">Kart numarası</label>
      <input name="cardno" type="tel" inputmode="numeric" class="form-control" pattern="[0-9\s]{13,19}" autocomplete="cc-number" maxlength="16" placeholder="xxxx xxxx xxxx xxxx">
    </div>
  </div>
  
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="carddate">Son K.Tarihi</label>
      <input type="text" class="form-control" name="carddate">
    </div>
    <div class="form-row">
    <div class="form-group col-md-6">
      <label for="cardcvv">CVV</label>
      <input type="text" class="form-control" name="cardcvv">
    </div>
   
  </div>
  
  <button type="submit" class="btn btn-info btn-block" >Satın Al</button>
  <button type="submit" class="btn btn-info btn-block" >Dijital Olarak Satın Al</button>
</form>
    
    
    
    </td>
   
  </tr>
  <tr>
    
    <td width="1">&nbsp;</td>
  </tr>
  
</table>
    
    </div>
    </form>
                            <?php
                                $hostumuz="localhost";
                                $veritabani_Adi="ykslngame";
                                $kullanici_Adi="root";
                                $sifre="";
                                $baglanti=mysqli_connect($hostumuz,$kullanici_Adi,$sifre,$veritabani_Adi);
                                mysqli_select_db($baglanti,"ykslngame");
                                if(isset($_POST["newname"])&&isset($_POST["newpassword"])&& isset($_POST["newemail"]) && isset($_POST["newnumber"]))
                                {
                                    $kullanici=$_POST["name"]+" "+$_POST["surrname"];
                                    $address=$_POST["address"];
                                    $address2=$_POST["address2"];
                                    $city=$_POST["city"]+"/"+$_POST["city2"];
                                    $cardname=$_POST["cardname"];
                                    $cardno=$_POST["cardno"];
                                    $carddate=$_POST["carddate"];
                                    $cardcvv=$_POST["cardcvv"];
                                  
                                    $sql="INSERT INTO sellrecord(adSoyad,address,directions,city,cardName,cardNo,cardDate,cartCvv) VALUES('$kullanici', '$address' ,'$address2' , '$city' ,'$cardname','$cardno','$carddate','$cardcvv')";
                                    
                                    $sorgu=mysqli_query($baglanti,$sql);
                                    if($sorgu)
                                    {
                                        echo "Başrıyla satın aldınız.";
                                    }
                                    else{
                                        echo "hatalı giriş.";
                                      
                                    }
                                }
                                ?>