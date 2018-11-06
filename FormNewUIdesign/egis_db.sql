-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-10-2018 a las 04:44:10
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
-- Base de datos: `egis_db`
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
-- Estructura de tabla para la tabla `etapas`
--

CREATE TABLE `etapas` (
  `Id_etapa` int(11) NOT NULL,
  `Nombre` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Id_modulo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `etapas`
--

INSERT INTO `etapas` (`Id_etapa`, `Nombre`, `Descripcion`, `Id_modulo`) VALUES
(1, 'Crear Grupo', 'Primera etapa del módulo de familia, se crea el grupo con todos los datos del grupo postulante.', 1),
(2, 'Registrar Postulantes', 'En esta etapa se registran todos los postulantes asignados al grupo creado en la primera etapa.', 1),
(3, 'Agregar Documentación', 'Una vez que se hayan registrado todos los postulantes al grupo, se procede a registrar toda la documentación obligatoria que ellos deben presentar.', 1),
(4, 'Generar Formatos', 'Cuando la documentación obligatoria esté ingresada, se pueden generar los formatos para todos los postulantes registrados en el grupo.', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupos`
--

CREATE TABLE `grupos` (
  `Id_grupo` int(11) NOT NULL,
  `Identificador` varchar(20) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Razon_social` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Personalidad_juridica` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre_presidente` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Contacto_presidente` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Id_proyecto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupos_etapas`
--

CREATE TABLE `grupos_etapas` (
  `Id_grupo_etapa` int(11) NOT NULL,
  `Id_etapa` int(11) NOT NULL,
  `Id_grupo` int(11) NOT NULL,
  `Estado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulos`
--

CREATE TABLE `modulos` (
  `Id_modulo` int(11) NOT NULL,
  `Nombre` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `modulos`
--

INSERT INTO `modulos` (`Id_modulo`, `Nombre`, `Descripcion`) VALUES
(1, 'Módulo Familia', 'Módulo familia'),
(2, 'Módulo Legal', 'Módulo legal'),
(3, 'Módulo Social', 'Módulo social'),
(4, 'Módulo Técnico', 'Módulo técnico');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfiles`
--

CREATE TABLE `perfiles` (
  `Id_perfil` int(11) NOT NULL,
  `Nombre` varchar(200) COLLATE latin1_spanish_ci NOT NULL,
  `Descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `perfiles`
--

INSERT INTO `perfiles` (`Id_perfil`, `Nombre`, `Descripcion`) VALUES
(1, 'Administrador', 'Tiene permisos para cualquier funcionalidad del sistema.'),
(2, 'Normal', 'Solo tiene permisos para ciertas funcionalidades del sistema.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `postulantes`
--

CREATE TABLE `postulantes` (
  `Rut` varchar(9) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `Apellido` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `Direccion` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `Nro_Casa` varchar(10) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre_conyuge` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `Apellido_conyuge` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `Rut_conyuge` varchar(9) COLLATE latin1_spanish_ci NOT NULL,
  `Nro_cta_ahorro` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `Anio_recepcion` int(4) NOT NULL,
  `Metros_cuad` varchar(10) COLLATE latin1_spanish_ci NOT NULL,
  `Anio_recep_ampl` int(4) NOT NULL,
  `Metros_cuad_con_ampl` varchar(10) COLLATE latin1_spanish_ci NOT NULL,
  `Id_grupo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proyectos`
--

CREATE TABLE `proyectos` (
  `Id_proyecto` int(11) NOT NULL,
  `Nombre` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `Descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `proyectos`
--

INSERT INTO `proyectos` (`Id_proyecto`, `Nombre`, `Descripcion`) VALUES
(1, 'Mejoramiento Regular', 'Mejoramiento Regular'),
(2, 'Mejoramiento Térmico', 'Mejoramiento Térmico'),
(3, 'PDA', 'PDA'),
(4, 'Ampliación', 'Ampliación'),
(5, 'Panel Solar', 'Panel Solar');

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
  `Id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Rut`, `Nombre`, `Apellidos`, `Username`, `Password`, `Telefono`, `Mail`, `Sexo`, `Edad`, `Imagen`, `Id_perfil`) VALUES
('10214564K', 'Viviana Jacqueline', 'Alarcón Cáceres', 'valarcon', 'valarcon', '978987656', 'viviana.alarcon@dominio.cl', 'F', 45, 'user_default.png', 2),
('107267921', 'Cecilia de las Nieves', 'Carrasco Muñoz', 'ccarrasco', 'ccarrasco', '987891738', 'cecilia.carrasco@dominio.cl', 'F', 46, 'user_default.png', 2),
('108340398', 'José Alberto', 'Badilla Leal', 'jbadilla', 'jbadilla', '923923874', 'jose.badilla@dominio.cl', 'M', 47, 'user_default.png', 2),
('127658366', 'Manuel Gonzalo', 'Aravena Bobadilla', 'maravena', 'maravena', '932836827', 'manuel.aravena@dominio.cl', 'M', 45, 'user_default.png', 2),
('12766479K', 'María Pilar', 'Arroyo Escobar', 'marroyo', 'marroyo', '966574656', 'maria.arroyo@dominio.cl', 'F', 44, 'user_default.png', 2),
('15494012K', 'Arnaldo', 'Quezada Gómez', 'aquezada', 'admin', '982348273', 'arnaldo.quezada@dominio.cl', 'M', 27, 'LinkinPark.png', 1),
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
-- Indices de la tabla `etapas`
--
ALTER TABLE `etapas`
  ADD PRIMARY KEY (`Id_etapa`),
  ADD KEY `Id_modulo` (`Id_modulo`);

--
-- Indices de la tabla `grupos`
--
ALTER TABLE `grupos`
  ADD PRIMARY KEY (`Id_grupo`),
  ADD KEY `Id_proyecto` (`Id_proyecto`);

--
-- Indices de la tabla `grupos_etapas`
--
ALTER TABLE `grupos_etapas`
  ADD PRIMARY KEY (`Id_grupo_etapa`),
  ADD KEY `FK_grupos_grupos_etapas` (`Id_grupo`),
  ADD KEY `FK_etapas_grupos_etapas` (`Id_etapa`);

--
-- Indices de la tabla `modulos`
--
ALTER TABLE `modulos`
  ADD PRIMARY KEY (`Id_modulo`);

--
-- Indices de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  ADD PRIMARY KEY (`Id_perfil`);

--
-- Indices de la tabla `postulantes`
--
ALTER TABLE `postulantes`
  ADD PRIMARY KEY (`Rut`),
  ADD KEY `Id_grupo` (`Id_grupo`);

--
-- Indices de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  ADD PRIMARY KEY (`Id_proyecto`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Rut`),
  ADD KEY `Perfil` (`Id_perfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `constantes`
--
ALTER TABLE `constantes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `etapas`
--
ALTER TABLE `etapas`
  MODIFY `Id_etapa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `grupos`
--
ALTER TABLE `grupos`
  MODIFY `Id_grupo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `grupos_etapas`
--
ALTER TABLE `grupos_etapas`
  MODIFY `Id_grupo_etapa` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `modulos`
--
ALTER TABLE `modulos`
  MODIFY `Id_modulo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `Id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  MODIFY `Id_proyecto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `etapas`
--
ALTER TABLE `etapas`
  ADD CONSTRAINT `FK_etapas_modulos` FOREIGN KEY (`Id_modulo`) REFERENCES `modulos` (`Id_modulo`);

--
-- Filtros para la tabla `grupos`
--
ALTER TABLE `grupos`
  ADD CONSTRAINT `FK_grupos_proyectos` FOREIGN KEY (`Id_proyecto`) REFERENCES `proyectos` (`Id_proyecto`);

--
-- Filtros para la tabla `grupos_etapas`
--
ALTER TABLE `grupos_etapas`
  ADD CONSTRAINT `FK_etapas_grupos_etapas` FOREIGN KEY (`Id_etapa`) REFERENCES `etapas` (`Id_etapa`),
  ADD CONSTRAINT `FK_grupos_grupos_etapas` FOREIGN KEY (`Id_grupo`) REFERENCES `grupos` (`Id_grupo`);

--
-- Filtros para la tabla `postulantes`
--
ALTER TABLE `postulantes`
  ADD CONSTRAINT `FK_postulantes_grupos` FOREIGN KEY (`Id_grupo`) REFERENCES `grupos` (`Id_grupo`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `FK_usuarios_perfiles` FOREIGN KEY (`Id_perfil`) REFERENCES `perfiles` (`Id_perfil`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
