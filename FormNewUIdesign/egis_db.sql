-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-03-2019 a las 19:23:34
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
-- Estructura de tabla para la tabla `accion`
--

CREATE TABLE `accion` (
  `id_accion` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `icono` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

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
(1, 'ruta_fotos_perfil', 'Ruta por defecto en la que se guardarán las fotos de perfil que suba cada usuario.', '../../fotos_perfil/'),
(2, 'ruta_iconos_sistema', 'Ruta base para obtener los iconos del sistema.', '../../iconos/');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `etapas`
--

CREATE TABLE `etapas` (
  `id_etapa` int(11) NOT NULL,
  `nombre` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `id_modulo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `etapas`
--

INSERT INTO `etapas` (`id_etapa`, `nombre`, `descripcion`, `id_modulo`) VALUES
(1, 'Crear Grupo Postulantes', 'Primera etapa del módulo de familia, se crea el grupo con todos los datos del grupo postulante.', 1),
(2, 'Registrar Postulantes', 'En esta etapa se registran todos los postulantes asignados al grupo creado en la primera etapa.', 1),
(3, 'Agregar Documentación', 'Una vez que se hayan registrado todos los postulantes al grupo, se procede a registrar toda la documentación obligatoria que ellos deben presentar.', 1),
(4, 'Generar Formatos', 'Cuando la documentación obligatoria esté ingresada, se pueden generar los formatos para todos los postulantes registrados en el grupo.', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupos`
--

CREATE TABLE `grupos` (
  `id_grupo` int(11) NOT NULL,
  `identificador` varchar(20) COLLATE latin1_spanish_ci NOT NULL,
  `nombre` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `razon_social` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `personalidad_juridica` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `nombre_presidente` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `contacto_presidente` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `id_proyecto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `grupos`
--

INSERT INTO `grupos` (`id_grupo`, `identificador`, `nombre`, `razon_social`, `personalidad_juridica`, `nombre_presidente`, `contacto_presidente`, `id_proyecto`) VALUES
(4, '97873433152454657', 'Grupo postulación A032', 'Egis talca', 'Martín Hernández', 'Marta Donoso', 'marta.donoso@dominio.com', 1),
(5, '97875166289199105', 'asd', 'asd', 'asd', 'asd', 'asd', 1),
(6, '97875166289199119', 'asd', 'asd', 'asd', 'asd', 'asd', 1),
(7, '97875166289199122', 'ad', 'sdf1', 'wer', 'wer', 'wqer', 2),
(11, '97875166289199133', 'dfdfgd', 'dfg', 'dfg', 'dfg', 'dfg', 5),
(13, '98084069706825735', 'zdsdf', 'dfsdf', 'sdfsdf', 'sdfsd', 'sdfsdf', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupos_etapas`
--

CREATE TABLE `grupos_etapas` (
  `id_grupo_etapa` int(11) NOT NULL,
  `id_etapa` int(11) NOT NULL,
  `id_grupo` int(11) NOT NULL,
  `estado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `grupos_etapas`
--

INSERT INTO `grupos_etapas` (`id_grupo_etapa`, `id_etapa`, `id_grupo`, `estado`) VALUES
(1, 1, 4, 1),
(3, 1, 5, 1),
(4, 1, 6, 1),
(5, 1, 7, 1),
(7, 1, 9, 1),
(9, 1, 11, 1),
(11, 1, 13, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `menu`
--

CREATE TABLE `menu` (
  `id_menu` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `identificador` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `icono` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `orden` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `menu`
--

INSERT INTO `menu` (`id_menu`, `nombre`, `identificador`, `icono`, `orden`) VALUES
(1, 'Dashboard', 'btnDashboard', 'dashboard/white.png', 1),
(2, 'Postulantes', 'btnPostulantes', 'clients/grey.png', 2),
(3, 'Postulación', 'btnPostulacion', 'projects/grey.png', 3),
(4, 'Grupos Ingresados', 'btnGrupos', 'groups/grey.png', 4),
(5, 'Sistema', 'btnSystem', 'system/grey.png', 5),
(6, 'Configuración', 'btnConfig', 'settings/grey.png', 6),
(7, 'Reportes', 'btnReportes', 'reports/grey.png', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulos`
--

CREATE TABLE `modulos` (
  `id_modulo` int(11) NOT NULL,
  `nombre` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `modulos`
--

INSERT INTO `modulos` (`id_modulo`, `nombre`, `descripcion`) VALUES
(1, 'Módulo Familia', 'Módulo familia'),
(2, 'Módulo Legal', 'Módulo legal'),
(3, 'Módulo Social', 'Módulo social'),
(4, 'Módulo Técnico', 'Módulo técnico');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfiles`
--

CREATE TABLE `perfiles` (
  `id_perfil` int(11) NOT NULL,
  `nombre` varchar(200) COLLATE latin1_spanish_ci NOT NULL,
  `descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `perfiles`
--

INSERT INTO `perfiles` (`id_perfil`, `nombre`, `descripcion`) VALUES
(1, 'Administrador', 'Tiene permisos para cualquier funcionalidad del sistema.'),
(2, 'Normal', 'Solo tiene permisos para ciertas funcionalidades del sistema.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `postulantes`
--

CREATE TABLE `postulantes` (
  `rut` varchar(9) COLLATE latin1_spanish_ci NOT NULL,
  `nombre` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `apellido` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `direccion` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `numero_casa` varchar(10) COLLATE latin1_spanish_ci NOT NULL,
  `nombre_conyuge` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `apellido_conyuge` varchar(300) COLLATE latin1_spanish_ci NOT NULL,
  `rut_conyuge` varchar(9) COLLATE latin1_spanish_ci NOT NULL,
  `nro_cta_ahorro` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `anio_recepcion` int(4) NOT NULL,
  `metros_cuad` varchar(10) COLLATE latin1_spanish_ci NOT NULL,
  `anio_recep_ampl` int(4) NOT NULL,
  `metros_cuad_con_ampl` varchar(10) COLLATE latin1_spanish_ci NOT NULL,
  `id_grupo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proyectos`
--

CREATE TABLE `proyectos` (
  `id_proyecto` int(11) NOT NULL,
  `nombre` varchar(500) COLLATE latin1_spanish_ci NOT NULL,
  `descripcion` varchar(500) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `proyectos`
--

INSERT INTO `proyectos` (`id_proyecto`, `nombre`, `descripcion`) VALUES
(1, 'Mejoramiento Regular', 'Mejoramiento Regular'),
(2, 'Mejoramiento Térmico', 'Mejoramiento Térmico'),
(3, 'PDA', 'PDA'),
(4, 'Ampliación', 'Ampliación'),
(5, 'Panel Solar', 'Panel Solar');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `submenu`
--

CREATE TABLE `submenu` (
  `id_submenu` int(11) NOT NULL,
  `nombre` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `identificador` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `icono` varchar(50) COLLATE latin1_spanish_ci NOT NULL,
  `orden` int(11) NOT NULL,
  `id_menu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `submenu`
--

INSERT INTO `submenu` (`id_submenu`, `nombre`, `identificador`, `icono`, `orden`, `id_menu`) VALUES
(1, 'Usuarios', 'btnUsers', 'account_group/grey.png', 1, 5),
(2, 'Perfiles', 'btnPerfiles', 'account_group/grey.png', 2, 5),
(3, 'Constantes', 'btnConstantes', 'account_group/grey.png', 3, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `rut` varchar(9) COLLATE latin1_spanish_ci NOT NULL,
  `nombre` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  `apellidos` varchar(300) COLLATE latin1_spanish_ci DEFAULT NULL,
  `username` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `password` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `telefono` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `mail` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  `sexo` char(1) COLLATE latin1_spanish_ci DEFAULT NULL,
  `edad` int(11) DEFAULT NULL,
  `imagen` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`rut`, `nombre`, `apellidos`, `username`, `password`, `telefono`, `mail`, `sexo`, `edad`, `imagen`, `id_perfil`) VALUES
('10214564K', 'Viviana Jacqueline', 'Alarcón Cáceres', 'valarcon', 'valarcon', '978987656', 'viviana.alarcon@dominio.cl', 'F', 45, 'user_default.png', 2),
('107267921', 'Cecilia de las Nieves', 'Carrasco Muñoz', 'ccarrasco', 'ccarrasco', '987891738', 'cecilia.carrasco@dominio.cl', 'F', 46, 'user_default.png', 2),
('12766479K', 'María Pilar', 'Arroyo Escobar', 'marroyo', 'marroyo', '966574656', 'maria.arroyo@dominio.cl', 'F', 44, 'user_default.png', 2),
('175498737', 'Arnaldo', 'Quezada Gómez', 'aquezada', 'admin', '948856096', 'arnaldo.mail2808@gmail.com', 'M', 27, '341445-cool-wallpaper-4k-3840x2160-computer.jpg', 1),
('30662563', 'Olga', 'Belmar Lamilla', 'obelmar', 'obelmar', '987638723', 'olga.belmar@dominio.cl', 'F', 78, 'user_default.png', 2),
('34334447', 'María Inés', 'Araneda Araneda', 'maraneda', 'maraneda', '918797236', 'maria.araneda@dominio.cl', 'F', 74, 'user_default.png', 2),
('3562788K', 'Norma', 'Araneda Araneda', 'naraneda', 'naraneda', '978382736', 'norma.araneda@dominio.cl', 'F', 72, 'user_default.png', 2),
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
-- Indices de la tabla `accion`
--
ALTER TABLE `accion`
  ADD PRIMARY KEY (`id_accion`);

--
-- Indices de la tabla `constantes`
--
ALTER TABLE `constantes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `etapas`
--
ALTER TABLE `etapas`
  ADD PRIMARY KEY (`id_etapa`),
  ADD KEY `Id_modulo` (`id_modulo`);

--
-- Indices de la tabla `grupos`
--
ALTER TABLE `grupos`
  ADD PRIMARY KEY (`id_grupo`),
  ADD KEY `Id_proyecto` (`id_proyecto`);

--
-- Indices de la tabla `grupos_etapas`
--
ALTER TABLE `grupos_etapas`
  ADD PRIMARY KEY (`id_grupo_etapa`),
  ADD KEY `FK_grupos_grupos_etapas` (`id_grupo`),
  ADD KEY `FK_etapas_grupos_etapas` (`id_etapa`);

--
-- Indices de la tabla `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id_menu`);

--
-- Indices de la tabla `modulos`
--
ALTER TABLE `modulos`
  ADD PRIMARY KEY (`id_modulo`);

--
-- Indices de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  ADD PRIMARY KEY (`id_perfil`);

--
-- Indices de la tabla `postulantes`
--
ALTER TABLE `postulantes`
  ADD PRIMARY KEY (`rut`),
  ADD KEY `Id_grupo` (`id_grupo`);

--
-- Indices de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  ADD PRIMARY KEY (`id_proyecto`);

--
-- Indices de la tabla `submenu`
--
ALTER TABLE `submenu`
  ADD PRIMARY KEY (`id_submenu`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`rut`),
  ADD KEY `Perfil` (`id_perfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `accion`
--
ALTER TABLE `accion`
  MODIFY `id_accion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `constantes`
--
ALTER TABLE `constantes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `etapas`
--
ALTER TABLE `etapas`
  MODIFY `id_etapa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `grupos`
--
ALTER TABLE `grupos`
  MODIFY `id_grupo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `grupos_etapas`
--
ALTER TABLE `grupos_etapas`
  MODIFY `id_grupo_etapa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `menu`
--
ALTER TABLE `menu`
  MODIFY `id_menu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `modulos`
--
ALTER TABLE `modulos`
  MODIFY `id_modulo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  MODIFY `id_proyecto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `submenu`
--
ALTER TABLE `submenu`
  MODIFY `id_submenu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

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
