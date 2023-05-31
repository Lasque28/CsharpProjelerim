<link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
<div class="container">
        <div class="row centered-form">
        <div class="col-xs-12 col-sm-8 col-md-4 col-sm-offset-2 col-md-offset-4">
        	<div class="panel panel-default">
        		<div class="panel-heading ">
			    		<p class="h3 ">YükselenGaming'e Üye Olun</p>
			 			</div>
			 			<div class="panel-body ">
                            <form action="" method="POST">
        
                                <div class="form-group ">
                                <input type="text" class="form-control" name="newname" id="newname" placeholder="Kullanıcı Adı"><br>
                                <input type="text" class="form-control" name="newrealname" id="newrealname" placeholder="Adınız Soyadınız"><br>
                               <input type="email" class="form-control" name="newemail" id="newemail" placeholder="E-mail"><br>
                               <input type="password" class="form-control" name="newpassword" id="newpassword" placeholder="Şifre"><br>
                               <input type="number" class="form-control" name="newnumber" id="newnumber"min="5000000000"max="5999999999" placeholder="Telefon numarası "><br>
                               <button type="submit" class="btn btn-info btn-block" >Üye Ol</button>
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
                                    $kullanici=$_POST["newname"];
                                    $kullaniciad=$_POST["newrealname"];
                                    $sifre=$_POST["newpassword"];
                                    $email=$_POST["newemail"];
                                    $numbers=$_POST["newnumber"];
                                  
                                    $sql="INSERT INTO users(kullaniciadi,gercekadi,sifre,mail,numara) VALUES('$kullanici', '$kullaniciad' ,'$sifre' , '$email' ,'$numbers')";
                                    
                                    $sorgu=mysqli_query($baglanti,$sql);
                                    if($sorgu)
                                    {
                                        echo "Başrıyla üye oldunuz.";
                                    }
                                    else{
                                        echo "giris bilgilerinizi kontrol ediniz.";
                                      
                                    }
                                }
                                ?>
			    	</div>
	    		</div>
    		</div>
    	</div>
    </div>