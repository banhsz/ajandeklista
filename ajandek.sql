-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Nov 24. 12:19
-- Kiszolgáló verziója: 10.4.11-MariaDB
-- PHP verzió: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `ajandek`
--
create database ajandek;
use ajandek;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ajandek`
--

CREATE TABLE `ajandek` (
  `id` int(11) NOT NULL,
  `nev` varchar(1000) COLLATE utf8_hungarian_ci NOT NULL,
  `uzlet` varchar(1000) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ajandek`
--

INSERT INTO `ajandek` (`id`, `nev`, `uzlet`) VALUES
(1, 'Csokitorta', ''),
(2, 'Babaház', 'Játékbolt'),
(9, 'PS5', 'Euronics'),
(10, 'Kabát', NULL),
(16, 'RTX 3080', 'iPon'),
(20, 'BMW M8', 'BMW Wallis'),
(21, 'Laptop', 'laptop.hu');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `ajandek`
--
ALTER TABLE `ajandek`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ajandek`
--
ALTER TABLE `ajandek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
