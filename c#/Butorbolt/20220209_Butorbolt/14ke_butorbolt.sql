-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Feb 09. 17:29
-- Kiszolgáló verziója: 10.4.21-MariaDB-log
-- PHP verzió: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `14ke_butorbolt`
--
CREATE DATABASE IF NOT EXISTS `14ke_butorbolt` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `14ke_butorbolt`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `alapanyag`
--

CREATE TABLE `alapanyag` (
  `ID` int(11) NOT NULL,
  `Nev` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `alapanyag`
--

INSERT INTO `alapanyag` (`ID`, `Nev`) VALUES
(1, 'Bútorlap'),
(2, 'Fa');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `butor`
--

CREATE TABLE `butor` (
  `ID` int(11) NOT NULL,
  `Nev` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Ar` int(11) NOT NULL,
  `Szin` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Szallitas` date NOT NULL,
  `Alapanyag_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `butor`
--

INSERT INTO `butor` (`ID`, `Nev`, `Ar`, `Szin`, `Szallitas`, `Alapanyag_ID`) VALUES
(1, 'Asztal', 12345, 'Fehér', '2022-02-08', 2),
(2, 'Beépített szekrény', 123456, 'Mahagóni', '2022-03-23', 1),
(3, 'Konyhabútor', 1000000, 'Szürke', '2022-02-16', 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `alapanyag`
--
ALTER TABLE `alapanyag`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `butor`
--
ALTER TABLE `butor`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `AlapanyagForeignKey` (`Alapanyag_ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `alapanyag`
--
ALTER TABLE `alapanyag`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `butor`
--
ALTER TABLE `butor`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `butor`
--
ALTER TABLE `butor`
  ADD CONSTRAINT `AlapanyagForeignKey` FOREIGN KEY (`Alapanyag_ID`) REFERENCES `alapanyag` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
