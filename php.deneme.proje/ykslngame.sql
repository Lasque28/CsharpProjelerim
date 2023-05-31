-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 12 Haz 2021, 18:20:48
-- Sunucu sürümü: 10.4.11-MariaDB
-- PHP Sürümü: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ykslngame`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `game`
--

CREATE TABLE `game` (
  `gameID` int(11) NOT NULL,
  `gameName` text NOT NULL,
  `gameStock` int(11) NOT NULL,
  `gameCmpy` text NOT NULL,
  `gamePrice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `game`
--

INSERT INTO `game` (`gameID`, `gameName`, `gameStock`, `gameCmpy`, `gamePrice`) VALUES
(1, 'Grand Theft Auto V', 500, 'Rockstar', 149),
(3, 'Battlefield 1', 500, 'DICE', 200),
(4, 'Farcry 5 ', 600, 'Ubisoft', 260),
(5, 'Red Dead Redemption 2', 545, 'Rockstar', 100),
(6, 'Space Engineers', 333, 'Keen Software House', 50),
(7, 'P.U.B.G', 444, 'PUBG', 50),
(8, 'The Witcher 3: Wild Hunt\r\n\r\n', 444, 'CD Projekt', 60),
(9, 'PES 2020\r\n\r\n', 434, 'Konami', 250),
(10, 'FİFA 2021', 500, 'Electronic Arts', 250),
(11, 'The Elder Scrolls V: Skyrim', 343, 'Bethesda Game Studios', 43);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sellrecord`
--

CREATE TABLE `sellrecord` (
  `ıd` int(11) NOT NULL,
  `adSoyad` text NOT NULL,
  `address` text NOT NULL,
  `directions` text NOT NULL,
  `city` text NOT NULL,
  `cardName` text NOT NULL,
  `cardNo` bigint(11) NOT NULL,
  `cardDate` text NOT NULL,
  `cardCvv` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `sellrecord`
--

INSERT INTO `sellrecord` (`ıd`, `adSoyad`, `address`, `directions`, `city`, `cardName`, `cardNo`, `cardDate`, `cardCvv`) VALUES
(1, 'emre', 'yenikent ', 'bakkal', 'kocaeli/gebze', 'emre yksln', 1111111111, '08/30', 434);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `Kullaniciadi` text NOT NULL,
  `gercekadi` text NOT NULL,
  `mail` text NOT NULL,
  `sifre` text NOT NULL,
  `numara` bigint(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`ID`, `Kullaniciadi`, `gercekadi`, `mail`, `sifre`, `numara`) VALUES
(1, 'Admin', 'Admin', 'admin@gmail.com', 'admin123', 111111),
(3, 'emre28', 'emre', 'emre@gmail.com', '321654', 5000000000),
(4, 'emre28', 'emre', '321654', 'emre@gmail.com', 5000000000),
(5, 'emre28', 'emre', '321654', 'emre@gmail.com', 5000000000);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `game`
--
ALTER TABLE `game`
  ADD PRIMARY KEY (`gameID`);

--
-- Tablo için indeksler `sellrecord`
--
ALTER TABLE `sellrecord`
  ADD PRIMARY KEY (`ıd`);

--
-- Tablo için indeksler `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `game`
--
ALTER TABLE `game`
  MODIFY `gameID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `sellrecord`
--
ALTER TABLE `sellrecord`
  MODIFY `ıd` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
