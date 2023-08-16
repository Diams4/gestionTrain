-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 16 août 2023 à 18:53
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_train`
--

-- --------------------------------------------------------

--
-- Structure de la table `itineraire`
--

DROP TABLE IF EXISTS `itineraire`;
CREATE TABLE IF NOT EXISTS `itineraire` (
  `idIt` int NOT NULL AUTO_INCREMENT,
  `voyage` varchar(255) NOT NULL,
  `dateVoyage` date NOT NULL,
  `heure` time NOT NULL,
  `frais` int NOT NULL,
  `nbrPlaceDispo` int NOT NULL,
  `idTrain` int NOT NULL,
  PRIMARY KEY (`idIt`),
  KEY `idTrain` (`idTrain`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `itineraire`
--

INSERT INTO `itineraire` (`idIt`, `voyage`, `dateVoyage`, `heure`, `frais`, `nbrPlaceDispo`, `idTrain`) VALUES
(8, 'FIANARANTSOA-ANTSIRABE', '2023-08-25', '07:00:00', 20000, 200, 3),
(9, 'FIANARANTSOA-MANAKARA', '2023-08-20', '10:30:00', 25000, 200, 1);

-- --------------------------------------------------------

--
-- Structure de la table `paiement`
--

DROP TABLE IF EXISTS `paiement`;
CREATE TABLE IF NOT EXISTS `paiement` (
  `id` int NOT NULL AUTO_INCREMENT,
  `mode` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `paiement`
--

INSERT INTO `paiement` (`id`, `mode`) VALUES
(1, 'Tout payé'),
(2, 'avance 50%');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `idReserve` int NOT NULL AUTO_INCREMENT,
  `nomVoyageur` varchar(255) NOT NULL,
  `CIN` int NOT NULL,
  `telephone` int NOT NULL,
  `voyage` varchar(255) NOT NULL,
  `nbrPlaceReserve` int NOT NULL,
  `paiement` int NOT NULL,
  `reste` int NOT NULL,
  `netApayer` int NOT NULL,
  `idIt` int NOT NULL,
  PRIMARY KEY (`idReserve`),
  KEY `idIt` (`idIt`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Structure de la table `train`
--

DROP TABLE IF EXISTS `train`;
CREATE TABLE IF NOT EXISTS `train` (
  `idTrain` int NOT NULL AUTO_INCREMENT,
  `design` varchar(25) NOT NULL,
  `nbrPlace` int NOT NULL,
  PRIMARY KEY (`idTrain`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `train`
--

INSERT INTO `train` (`idTrain`, `design`, `nbrPlace`) VALUES
(1, 'TGV 1', 200),
(2, 'TGV 2', 150),
(3, 'TGV 3', 200),
(4, 'TGV 4', 100),
(5, 'TGV 5', 200),
(6, 'TGV 6', 150);

-- --------------------------------------------------------

--
-- Structure de la table `ville`
--

DROP TABLE IF EXISTS `ville`;
CREATE TABLE IF NOT EXISTS `ville` (
  `idVille` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  PRIMARY KEY (`idVille`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `ville`
--

INSERT INTO `ville` (`idVille`, `nom`) VALUES
(1, 'ANTANANARIVO'),
(2, 'FIANARANTSOA'),
(3, 'ANTSIRABE'),
(4, 'MANAKARA'),
(5, 'TOAMASINA');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `itineraire`
--
ALTER TABLE `itineraire`
  ADD CONSTRAINT `itineraire_ibfk_1` FOREIGN KEY (`idTrain`) REFERENCES `train` (`idTrain`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
