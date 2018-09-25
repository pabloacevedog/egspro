-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-09-2018 a las 15:26:56
-- Versión del servidor: 10.1.35-MariaDB
-- Versión de PHP: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `test_system`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfiles`
--

CREATE TABLE `perfiles` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(100) COLLATE latin1_spanish_ci NOT NULL,
  `Descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `perfiles`
--

INSERT INTO `perfiles` (`Id`, `Nombre`, `Descripcion`) VALUES
(1, 'Administrador', 'El perfil administrador no tiene accesos restringidos al sistema, es capaz de visualizar y realizar cualquier acción en el mismo.'),
(2, 'Normal', 'Éste perfil tiene acceso límitado a las funcionalidades del sistema.'),
(3, 'Área Técnica', 'Éste perfil tiene acceso límitado a las funcionalidades del sistema.'),
(4, 'Área Familiar', 'Éste perfil tiene acceso límitado a las funcionalidades del sistema.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Rut` varchar(9) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Apellidos` varchar(300) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Username` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Password` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Telefono` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Mail` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Sexo` char(1) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Edad` int(11) DEFAULT NULL,
  `Perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Rut`, `Nombre`, `Apellidos`, `Username`, `Password`, `Telefono`, `Mail`, `Sexo`, `Edad`, `Perfil`) VALUES
('104863213', 'Erika', 'Galindo Parada', 'egalindo', 'egalindo', '983472834', 'erika.galindo@gmail.com', 'F', 34, 2),
('165407180', 'Sevelinda', 'Parada', 'sparada', 'sparada', '9238749287', 'sparada@gmail.com', 'F', 38, 2),
('175498737', 'Arnaldo', 'Quezada Gómez', 'aquezada', 'admin', '+56948856096', 'arnaldo.mail2808@gmail.com', 'M', 27, 1),
('191065808', 'Aquiles', 'Baeza Parada', 'abaeza', 'abaeza', '87982734', 'aquiles.baeza@gmail.com', 'M', 36, 3),
('222222222', 'Zacarías', 'Flores del Campo', 'zflores', 'zflores', '+56922222222', 'zflores@gmail.com', 'M', 25, 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Rut`),
  ADD KEY `Perfil` (`Perfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `FK_usuarios_perfiles` FOREIGN KEY (`Perfil`) REFERENCES `perfiles` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
