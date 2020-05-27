-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-05-2020 a las 02:31:53
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mtis_final`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `demandante`
--

CREATE TABLE `demandante` (
  `id` int(11) NOT NULL,
  `dni` varchar(40) NOT NULL,
  `pass` varchar(40) DEFAULT NULL,
  `nombre` varchar(40) NOT NULL,
  `apellidos` varchar(40) NOT NULL,
  `direccion` varchar(40) NOT NULL,
  `poblacion` varchar(40) NOT NULL,
  `telefono` varchar(40) NOT NULL,
  `email` varchar(40) NOT NULL,
  `fecha_nacimiento` varchar(40) NOT NULL,
  `fecha_renovacion` varchar(40) DEFAULT NULL,
  `iban` varchar(40) NOT NULL,
  `situacion_laboral` tinyint(1) NOT NULL,
  `edad` int(11) NOT NULL,
  `titulos` varchar(40) NOT NULL,
  `experiencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `demandante`
--

INSERT INTO `demandante` (`id`, `dni`, `pass`, `nombre`, `apellidos`, `direccion`, `poblacion`, `telefono`, `email`, `fecha_nacimiento`, `fecha_renovacion`, `iban`, `situacion_laboral`, `edad`, `titulos`, `experiencia`) VALUES
(1, '48628778R', 'password', 'german', 'german', 'german', 'german', '999999999', 'german', '01/01/1991', '01/01/1991', 'german', 0, 75, 'grado universitario', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lista_candidatos`
--

CREATE TABLE `lista_candidatos` (
  `id_oferta` varchar(50) NOT NULL,
  `dni_demandante` varchar(50) NOT NULL,
  `puntuacion` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `lista_candidatos`
--

INSERT INTO `lista_candidatos` (`id_oferta`, `dni_demandante`, `puntuacion`) VALUES
('2', '48628778E', '5'),
('3', '48628778E', '0'),
('4', '48628778E', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `oferta`
--

CREATE TABLE `oferta` (
  `id` int(11) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `titulos` varchar(40) NOT NULL,
  `experiencia` int(11) NOT NULL,
  `edad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `oferta`
--

INSERT INTO `oferta` (`id`, `nombre`, `titulos`, `experiencia`, `edad`) VALUES
(1, 'Experto en bases de datos Postgre y SQL', 'grado universitario', 2, 30);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `demandante`
--
ALTER TABLE `demandante`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `dni` (`dni`);

--
-- Indices de la tabla `lista_candidatos`
--
ALTER TABLE `lista_candidatos`
  ADD PRIMARY KEY (`id_oferta`,`dni_demandante`);

--
-- Indices de la tabla `oferta`
--
ALTER TABLE `oferta`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `demandante`
--
ALTER TABLE `demandante`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `oferta`
--
ALTER TABLE `oferta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
