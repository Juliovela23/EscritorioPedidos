-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 24-06-2022 a las 05:17:46
-- Versión del servidor: 5.7.33
-- Versión de PHP: 7.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_pedidosweb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria_productos`
--

CREATE TABLE `categoria_productos` (
  `Id_categoriaP` int(11) NOT NULL,
  `Nombre_cat` varchar(50) NOT NULL,
  `Descripcion_categoria` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `categoria_productos`
--

INSERT INTO `categoria_productos` (`Id_categoriaP`, `Nombre_cat`, `Descripcion_categoria`) VALUES
(1, 'Alarmas', 'Esta categoria organiza las alarmas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ciudades`
--

CREATE TABLE `ciudades` (
  `Id_ciudad` int(11) NOT NULL,
  `Nombre_ciudad` varchar(50) NOT NULL,
  `Pais` varchar(50) NOT NULL,
  `Region_O_Departamento` varchar(80) NOT NULL,
  `Elevacion_sobre_Mar` varchar(100) DEFAULT NULL,
  `Indice_robos` varchar(50) DEFAULT NULL,
  `Ingresos_promedio` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ciudades`
--

INSERT INTO `ciudades` (`Id_ciudad`, `Nombre_ciudad`, `Pais`, `Region_O_Departamento`, `Elevacion_sobre_Mar`, `Indice_robos`, `Ingresos_promedio`) VALUES
(1, 'Acatenango', 'Guatemala', 'Chimaltenango', '3.976 m', ' 11.5%', '3500');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `Id_cliente` int(11) NOT NULL,
  `Estado_cliente` smallint(6) NOT NULL,
  `NIT` varchar(20) NOT NULL,
  `Id_personas` int(11) DEFAULT NULL,
  `Id_ciudad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`Id_cliente`, `Estado_cliente`, `NIT`, `Id_personas`, `Id_ciudad`) VALUES
(1, 1, '12457896', 11, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido`
--

CREATE TABLE `detalle_pedido` (
  `Id_detalle` int(11) NOT NULL,
  `Cantidad_pedida` int(11) NOT NULL,
  `Precio_producto` decimal(8,2) NOT NULL,
  `Id_pedidos` int(11) DEFAULT NULL,
  `Id_productos` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `detalle_pedido`
--

INSERT INTO `detalle_pedido` (`Id_detalle`, `Cantidad_pedida`, `Precio_producto`, `Id_pedidos`, `Id_productos`) VALUES
(1, 2, '300.00', 1, 1),
(2, 5, '750.00', 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `Id_empleado` int(11) NOT NULL,
  `Estado` smallint(6) NOT NULL,
  `Id_personas` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`Id_empleado`, `Estado`, `Id_personas`) VALUES
(1, 1, 1),
(8, 0, 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `Id_pedidos` int(11) NOT NULL,
  `Numero_de_orden` varchar(50) NOT NULL,
  `Fecha_pedido` date NOT NULL,
  `Estado_pedido` varchar(30) NOT NULL,
  `Monto_total` decimal(8,2) NOT NULL,
  `Id_usuarios` int(11) DEFAULT NULL,
  `Id_cliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pedidos`
--

INSERT INTO `pedidos` (`Id_pedidos`, `Numero_de_orden`, `Fecha_pedido`, `Estado_pedido`, `Monto_total`, `Id_usuarios`, `Id_cliente`) VALUES
(1, 'a1', '2022-06-23', 'En proceso', '300.00', 1, 1),
(2, 'a2', '2022-06-23', 'Completado', '750.00', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personas`
--

CREATE TABLE `personas` (
  `Id_personas` int(11) NOT NULL,
  `Nombres` varchar(50) NOT NULL,
  `Apellidos` varchar(50) NOT NULL,
  `Genero` smallint(6) DEFAULT NULL,
  `Fecha_nacimiento` date DEFAULT NULL,
  `CUI` varchar(13) DEFAULT NULL,
  `Telefono` varchar(40) NOT NULL,
  `Direccion` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `personas`
--

INSERT INTO `personas` (`Id_personas`, `Nombres`, `Apellidos`, `Genero`, `Fecha_nacimiento`, `CUI`, `Telefono`, `Direccion`) VALUES
(1, 'Julio Isabel', 'Vela Flores', 1, '2000-10-23', '2919701680411', '40332568', 'Acatenango'),
(10, 'Julio Marcello', 'Vela Flores', 0, '2022-06-23', '2018080241212', '25251313', 'Acatenango'),
(11, 'Julio Mauricio', 'Vela Flores', 0, '2022-06-23', '2025367896465', '30028933', 'Acatenango');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `Id_productos` int(11) NOT NULL,
  `Nombre_producto` varchar(150) NOT NULL,
  `Descripcion_producto` varchar(255) DEFAULT NULL,
  `Precio_p` decimal(8,2) NOT NULL,
  `Marca` varchar(50) DEFAULT NULL,
  `Id_categoriaP` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`Id_productos`, `Nombre_producto`, `Descripcion_producto`, `Precio_p`, `Marca`, `Id_categoriaP`) VALUES
(1, 'Alarma de fuego', 'Esta alarma permite detectar el minimo comienzo de incendio', '150.00', 'Logitech', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Id_usuarios` int(11) NOT NULL,
  `Usuario` varchar(50) NOT NULL,
  `Password` varchar(16) NOT NULL,
  `Correo_electronico` varchar(100) NOT NULL,
  `Id_empleado` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Id_usuarios`, `Usuario`, `Password`, `Correo_electronico`, `Id_empleado`) VALUES
(1, 'Juliove', 'admin', 'juliovel86@gmail.com', 1),
(2, 'MarcelloVela', 'admin', 'juliovel86@gmail.com', 8);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categoria_productos`
--
ALTER TABLE `categoria_productos`
  ADD PRIMARY KEY (`Id_categoriaP`);

--
-- Indices de la tabla `ciudades`
--
ALTER TABLE `ciudades`
  ADD PRIMARY KEY (`Id_ciudad`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Id_cliente`),
  ADD KEY `IX_Relationship2` (`Id_personas`),
  ADD KEY `IX_Relationship3` (`Id_ciudad`);

--
-- Indices de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  ADD PRIMARY KEY (`Id_detalle`),
  ADD KEY `IX_Relationship4` (`Id_pedidos`),
  ADD KEY `IX_Relationship5` (`Id_productos`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`Id_empleado`),
  ADD KEY `IX_Relationship1` (`Id_personas`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`Id_pedidos`),
  ADD KEY `IX_Relationship6` (`Id_usuarios`),
  ADD KEY `IX_Relationship7` (`Id_cliente`);

--
-- Indices de la tabla `personas`
--
ALTER TABLE `personas`
  ADD PRIMARY KEY (`Id_personas`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`Id_productos`),
  ADD KEY `IX_Relationship1` (`Id_categoriaP`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id_usuarios`),
  ADD KEY `IX_Relationship2` (`Id_empleado`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `categoria_productos`
--
ALTER TABLE `categoria_productos`
  MODIFY `Id_categoriaP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `ciudades`
--
ALTER TABLE `ciudades`
  MODIFY `Id_ciudad` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `Id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  MODIFY `Id_detalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `Id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `Id_pedidos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `personas`
--
ALTER TABLE `personas`
  MODIFY `Id_personas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `Id_productos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id_usuarios` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `fk_ciudadXcliente` FOREIGN KEY (`Id_ciudad`) REFERENCES `ciudades` (`Id_ciudad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_personaXclientes` FOREIGN KEY (`Id_personas`) REFERENCES `personas` (`Id_personas`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  ADD CONSTRAINT `fk_predidoXdetalle` FOREIGN KEY (`Id_pedidos`) REFERENCES `pedidos` (`Id_pedidos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_productoXdetalle` FOREIGN KEY (`Id_productos`) REFERENCES `productos` (`Id_productos`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `fk_empleadosXpersonas` FOREIGN KEY (`Id_personas`) REFERENCES `personas` (`Id_personas`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `fk_clienteXpedido` FOREIGN KEY (`Id_cliente`) REFERENCES `clientes` (`Id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_usuarioXpedido` FOREIGN KEY (`Id_usuarios`) REFERENCES `usuarios` (`Id_usuarios`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `FK_catXproducto` FOREIGN KEY (`Id_categoriaP`) REFERENCES `categoria_productos` (`Id_categoriaP`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `fk_usuariosXempleados` FOREIGN KEY (`Id_empleado`) REFERENCES `empleados` (`Id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
