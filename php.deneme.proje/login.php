<link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
<div class="container">
        <div class="row centered-form">
        <div class="col-xs-12 col-sm-8 col-md-4 col-sm-offset-2 col-md-offset-4">
        	<div class="panel panel-default">
        		<div class="panel-heading">
			    		<h3 class=" bg-gradient-warning">YükselenGaming'e Giriş Yap</h3>
			 			</div>
			 			<div class="panel-body">
                            <form action="loginindex.php" method="POST">
        
                                <div class="form-group">
                             
                               <input type="text" class="form-control" name="name" id="name" placeholder="Kullanıcı Adı">
                               <input type="password" class="form-control" name="password" id="password" placeholder="Şifre">
                               <button type="submit" class="btn btn-info btn-block" >Giriş Yap</button>
                                </div>
                                
                            
                            </form>
                            <?php
                                $hostumuz="localhost";
                                $veritabani_Adi="ykslngame";
                                $kullanici_Adi="root";
                                $sifre="";
                                $baglanti=mysqli_connect($hostumuz,$kullanici_Adi,$sifre,$veritabani_Adi);
                                mysqli_select_db($baglanti,"ykslngame");
                                if(isset($_POST["name"])&&isset($_POST["password"]))
                                {
                                    $kullanici=$_POST["name"];
                                    $sifre=$_POST["password"];
                                    $sql="SELECT kullaniciadi,sifre from users where kullaniciadi='$kullanici' and sifre='$sifre'";
                                    $sorgu=mysqli_query($baglanti,$sql);
                                    $dizi=mysqli_fetch_array($sorgu);
                                    if($dizi!=0)
                                    {
                                        echo "Başarıyla giriş yaptınız.";
                                        header("location:loginindex.php");
                                    }
                                    else{
                                        echo "giris bilgilerinizi kontrol ediniz.";
                                      echo "<a href='index.php?git=register' <button type='submit' class='btn btn-info btn-block' >üye değilmisiniz</button></a>";
                                    }
                                }
                                ?>
			    	</div>
	    		</div>
    		</div>
    	</div>
    </div>