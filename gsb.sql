-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 20 mai 2022 à 16:16
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gsb`
--

-- --------------------------------------------------------

--
-- Structure de la table `correspondre`
--

DROP TABLE IF EXISTS `correspondre`;
CREATE TABLE IF NOT EXISTS `correspondre` (
  `matricule_technicien` varchar(7) NOT NULL,
  `n__region` varchar(2) NOT NULL,
  PRIMARY KEY (`matricule_technicien`,`n__region`),
  KEY `n__region` (`n__region`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

DROP TABLE IF EXISTS `materiel`;
CREATE TABLE IF NOT EXISTS `materiel` (
  `IdMat` varchar(50) NOT NULL,
  `processeur` varchar(50) DEFAULT NULL,
  `memoire` varchar(50) DEFAULT NULL,
  `disque` varchar(50) DEFAULT NULL,
  `dateAchat` varchar(50) DEFAULT NULL,
  `garantie` varchar(50) DEFAULT NULL,
  `fournisseur` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdMat`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`IdMat`, `processeur`, `memoire`, `disque`, `dateAchat`, `garantie`, `fournisseur`) VALUES
('31', 'AX21', '500GO', 'qdfqsd', '02/02/2022', '5ans', 'asus');

-- --------------------------------------------------------

--
-- Structure de la table `membrepersonnel`
--

DROP TABLE IF EXISTS `membrepersonnel`;
CREATE TABLE IF NOT EXISTS `membrepersonnel` (
  `matriculePersonnel` varchar(50) NOT NULL,
  `poste` varchar(50) DEFAULT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `dateEmbauchePersonnel` date DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `cp` varchar(50) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `IdMat` varchar(50) NOT NULL,
  `matriculeResponsable` smallint(6) NOT NULL,
  PRIMARY KEY (`matriculePersonnel`),
  KEY `IdMat` (`IdMat`),
  KEY `matricule_Responsable` (`matriculeResponsable`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `membrepersonnel`
--

INSERT INTO `membrepersonnel` (`matriculePersonnel`, `poste`, `nom`, `prenom`, `dateEmbauchePersonnel`, `adresse`, `cp`, `ville`, `IdMat`, `matriculeResponsable`) VALUES
('2', 'comptable', 'BARTHE', 'Simon', '2022-03-07', '54 boulevard de cugnaux', '31300', 'Toulouse', '31', 1);

-- --------------------------------------------------------

--
-- Structure de la table `passer`
--

DROP TABLE IF EXISTS `passer`;
CREATE TABLE IF NOT EXISTS `passer` (
  `nRegion` varchar(2) NOT NULL,
  `matriculeResponsable` smallint(6) NOT NULL,
  PRIMARY KEY (`nRegion`,`matriculeResponsable`),
  KEY `matricule_Responsable` (`matriculeResponsable`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE IF NOT EXISTS `region` (
  `nRegion` varchar(2) NOT NULL,
  `nomRegion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`nRegion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `reparer`
--

DROP TABLE IF EXISTS `reparer`;
CREATE TABLE IF NOT EXISTS `reparer` (
  `matriculeTechnicien` varchar(7) NOT NULL,
  `IdMat` varchar(50) NOT NULL,
  `DateReparation` date DEFAULT NULL,
  `heuresDebut` time DEFAULT NULL,
  `heuresFin` time DEFAULT NULL,
  `travailRealisé` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`matriculeTechnicien`,`IdMat`),
  KEY `IdMat` (`IdMat`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `resoudre`
--

DROP TABLE IF EXISTS `resoudre`;
CREATE TABLE IF NOT EXISTS `resoudre` (
  `matriculeTechnicien` varchar(7) NOT NULL,
  `numeroTicket` smallint(6) NOT NULL,
  PRIMARY KEY (`matriculeTechnicien`,`numeroTicket`),
  KEY `numeroTicket` (`numeroTicket`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `matriculeResponsable` smallint(6) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `cp` int(11) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `dateEmbaucheResponsable` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`matriculeResponsable`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`matriculeResponsable`, `nom`, `prenom`, `adresse`, `cp`, `ville`, `dateEmbaucheResponsable`) VALUES
(1, 'Lantiat', 'Clement', '54 boulevard de cugneau', 31300, 'Toulouse', '01/01/2022');

-- --------------------------------------------------------

--
-- Structure de la table `technicien`
--

DROP TABLE IF EXISTS `technicien`;
CREATE TABLE IF NOT EXISTS `technicien` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `matriculeTechnicien` varchar(7) NOT NULL,
  `nom` varchar(20) DEFAULT NULL,
  `prenom` varchar(20) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `cp` int(11) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `dateEmbaucheTechnicien` date DEFAULT NULL,
  `niveauIntervention` varchar(50) DEFAULT NULL,
  `formation` varchar(50) DEFAULT NULL,
  `matriculeResponsable` smallint(6) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `matricule_Responsable` (`matriculeResponsable`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
CREATE TABLE IF NOT EXISTS `ticket` (
  `numeroTicket` smallint(6) NOT NULL AUTO_INCREMENT,
  `objet` varchar(50) DEFAULT NULL,
  `niveauUrgence` varchar(50) DEFAULT NULL,
  `dateHeure` datetime DEFAULT NULL,
  `idMat` varchar(50) NOT NULL,
  `matriculePersonnel` varchar(50) NOT NULL,
  PRIMARY KEY (`numeroTicket`),
  KEY `IdMat` (`idMat`),
  KEY `matricule_personnel` (`matriculePersonnel`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `venir`
--

DROP TABLE IF EXISTS `venir`;
CREATE TABLE IF NOT EXISTS `venir` (
  `matriculePersonnel` varchar(50) NOT NULL,
  `nRegion` varchar(2) NOT NULL,
  PRIMARY KEY (`matriculePersonnel`,`nRegion`),
  KEY `n__region` (`nRegion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
