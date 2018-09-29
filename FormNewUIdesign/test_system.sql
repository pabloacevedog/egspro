-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-09-2018 a las 21:54:52
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
-- Estructura de tabla para la tabla `constantes`
--

CREATE TABLE `constantes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `descripcion` varchar(150) COLLATE latin1_spanish_ci DEFAULT NULL,
  `valor` varchar(200) COLLATE latin1_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `constantes`
--

INSERT INTO `constantes` (`id`, `nombre`, `descripcion`, `valor`) VALUES
(1, 'ruta_fotos_perfil', 'Ruta por defecto en la que se guardarán las fotos de perfil que suba cada usuario.', '../../fotos_perfil/');

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
  `Imagen` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Rut`, `Nombre`, `Apellidos`, `Username`, `Password`, `Telefono`, `Mail`, `Sexo`, `Edad`, `Imagen`, `Perfil`) VALUES
('10214564K', 'Viviana Jacqueline', 'Alarcón Cáceres', 'valarcon', 'valarcon', '978987656', 'viviana.alarcon@dominio.cl', 'F', 45, 'user_default.png', 2),
('107267921', 'Cecilia de las Nieves', 'Carrasco Muñoz', 'ccarrasco', 'ccarrasco', '987891738', 'cecilia.carrasco@dominio.cl', 'F', 46, 'user_default.png', 2),
('108340398', 'José Alberto', 'Badilla Leal', 'jbadilla', 'jbadilla', '923923874', 'jose.badilla@dominio.cl', 'M', 47, 'user_default.png', 2),
('127658366', 'Manuel Gonzalo', 'Aravena Bobadilla', 'maravena', 'maravena', '932836827', 'manuel.aravena@dominio.cl', 'M', 45, 'user_default.png', 2),
('12766479K', 'María Pilar', 'Arroyo Escobar', 'marroyo', 'marroyo', '966574656', 'maria.arroyo@dominio.cl', 'F', 44, 'user_default.png', 2),
('15494012K', 'Arnaldo', 'Quezada Gómez', 'aquezada', 'admin', '982348273', 'arnaldo.quezada@dominio.cl', 'M', 27, 'LinkinPark.png', 1),
('175498737', 'aisudhaklsjh', 'alksjdhaslkd lashaslkdjh', 'asd', 'asd', '929387623', 'asd@asd.c', 'F', 23, 'user_default.png', 2),
('30662563', 'Olga', 'Belmar Lamilla', 'obelmar', 'obelmar', '987638723', 'olga.belmar@dominio.cl', 'F', 78, 'user_default.png', 2),
('34334447', 'María Inés', 'Araneda Araneda', 'maraneda', 'maraneda', '918797236', 'maria.araneda@dominio.cl', 'F', 74, 'user_default.png', 2),
('3562788K', 'Norma', 'Araneda Araneda', 'naraneda', 'naraneda', '978382736', 'norma.araneda@dominio.cl', 'F', 72, 'user_default.png', 2),
('3758049K', 'Hector René', 'Andrade Faúndez', 'handrade', 'handrade', '987293872', 'hector.andrade@dominio.cl', 'M', 70, 'user_default.png', 2),
('37815616', 'María Lucila', 'Alarcón Sepúlveda', 'malarcon', 'malarcon', '956345354', 'maria.alarcon@dominio.cl', 'F', 71, 'user_default.png', 2),
('48082580', 'Policarpo Hipolito', 'Urrutia Muñoz', 'purrutia', 'purrutia', '928379237', 'policarpo.urrutia@dominio.cl', 'M', 84, 'user_default.png', 2),
('4884829K', 'Flor María', 'Álvarez Cáceres', 'falvarez', 'falvarez', '982736423', 'flor.alvarez@dominio.cl', 'F', 67, 'user_default.png', 2),
('54125143', 'María Magdalena', 'Beltrán Jaña', 'mbeltran', 'mbeltran', '982736782', 'maria.beltran@dominio.cl', 'F', 64, 'user_default.png', 2),
('56491392', 'Prosperina de las Mercedes', 'Quiroz Valenzuela', 'pquiroz', 'pquiroz', '982379238', 'prosperina.quiroz@dominio.cl', 'F', 76, 'user_default.png', 2),
('65144158', 'Otoniel del Rosario', 'Cid Guevera', 'ocid', 'ocid', '987981732', 'otoniel.cid@dominio.cl', 'M', 53, 'user_default.png', 2),
('81625344', 'Honoria del Tránsito', 'Escobar Valenzuela', 'hescobar', 'hescobar', '988677126', 'honoria.escobar@dominio.cl', 'F', 68, 'user_default.png', 2),
('92714519', 'Elizabeth Graciana', 'Barrera Roa', 'ebarrera', 'ebarrera', '987983297', 'elizabeth.barrera@dominio.cl', 'F', 50, 'user_default.png', 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `constantes`
--
ALTER TABLE `constantes`
  ADD PRIMARY KEY (`id`);

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
-- AUTO_INCREMENT de la tabla `constantes`
--
ALTER TABLE `constantes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

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
