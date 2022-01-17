/*
SQLyog Enterprise v13.1.1 (64 bit)
MySQL - 5.6.34 : Database - aims
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`aims` /*!40100 DEFAULT CHARACTER SET utf32 COLLATE utf32_spanish2_ci */;

USE `aims`;

/*Table structure for table `auxiliar` */

DROP TABLE IF EXISTS `auxiliar`;

CREATE TABLE `auxiliar` (
  `id_aux` int(10) NOT NULL AUTO_INCREMENT COMMENT 'CODIGO UNICO DE LA TABLA',
  `codigo` varchar(3) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'TIPO DEL CODIGO',
  `nombre` varchar(20) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'NOMBRE DEL CODIGO',
  `estado` int(1) NOT NULL COMMENT 'ESTADO 1:ACTIVO, 2:INACTIVO',
  PRIMARY KEY (`id_aux`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

/*Data for the table `auxiliar` */

insert  into `auxiliar`(`id_aux`,`codigo`,`nombre`,`estado`) values 
(1,'SEX','Masculino',1),
(2,'SEX','Femenino',1),
(3,'TDU','Cliente',1),
(4,'TDU','Ventas',1),
(5,'TDU','Engine',1),
(6,'TDU','Administrador',1),
(7,'TEM','White',1),
(8,'TEM','Dark',1),
(9,'TDU','Employer',1),
(10,'TDU','SUPERUSE',1);

/*Table structure for table `consecutivo` */

DROP TABLE IF EXISTS `consecutivo`;

CREATE TABLE `consecutivo` (
  `id` int(10) NOT NULL,
  `ultimo` int(10) DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

/*Data for the table `consecutivo` */

insert  into `consecutivo`(`id`,`ultimo`) values 
(234,2),
(555,2),
(517,3);

/*Table structure for table `productos` */

DROP TABLE IF EXISTS `productos`;

CREATE TABLE `productos` (
  `id` int(5) NOT NULL COMMENT 'CODIGO UNICO DE LA TABLA',
  `nombre` varchar(20) CHARACTER SET utf32 COLLATE utf32_spanish2_ci NOT NULL COMMENT 'NOMBRE DEL PRODUCTO',
  `foto` text CHARACTER SET utf32 COLLATE utf32_spanish2_ci NOT NULL COMMENT 'IMAGEN DEL PRODUCTO',
  `estado` int(1) NOT NULL COMMENT 'ESTADO 1:ACTIVO, 2:INACTIVO',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

/*Data for the table `productos` */

insert  into `productos`(`id`,`nombre`,`foto`,`estado`) values 
(2,'xvf','../media/pro_2.png',1);

/*Table structure for table `registros` */

DROP TABLE IF EXISTS `registros`;

CREATE TABLE `registros` (
  `id` int(10) NOT NULL COMMENT 'CODIGO UNICO DE LA TABLA',
  `id_cod_producto` int(10) DEFAULT NULL COMMENT 'ID DEL PRODUCTO QUE SE CREÓ, ELIMINÓ O EDITÓ',
  `id_cod_usuario` int(10) DEFAULT NULL COMMENT 'ID DEL USUARIO QUE CREÓ, ELIMINÓ O EDITÓ',
  `id_cod_testimonio` int(10) DEFAULT NULL COMMENT 'ID DEL TESTIMONIO QUE SE CREÓ, ELIMINÓ O EDITÓ',
  `ip` varchar(40) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'IP DEL USUARIO QUE CREÓ, ELIMINÓ O EDITÓ',
  `fecha` date NOT NULL COMMENT 'FECHA DE CREACION DEL REGISTRO',
  `que_hizo` varchar(150) COLLATE utf8_spanish2_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_cod_usuario` (`id_cod_usuario`),
  KEY `id_cod_testimonio` (`id_cod_testimonio`),
  CONSTRAINT `registros_ibfk_2` FOREIGN KEY (`id_cod_usuario`) REFERENCES `usuarios` (`id`),
  CONSTRAINT `registros_ibfk_3` FOREIGN KEY (`id_cod_testimonio`) REFERENCES `testimonios` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

/*Data for the table `registros` */

insert  into `registros`(`id`,`id_cod_producto`,`id_cod_usuario`,`id_cod_testimonio`,`ip`,`fecha`,`que_hizo`) values 
(1,1,1,1,'::1','2019-10-03','INSERT INTO productos ../media/pro_1.jpg-MOUSE'),
(2,1,1,1,'::1','2019-10-06','DELETE FROM productos ../media/pro_1.jpg-MOUSE'),
(3,2,1,1,'::1','2019-10-06','INSERT INTO productos ../media/pro_2.png-xvf');

/*Table structure for table `testimonios` */

DROP TABLE IF EXISTS `testimonios`;

CREATE TABLE `testimonios` (
  `id` int(10) NOT NULL AUTO_INCREMENT COMMENT 'CODIGO UNICO DE LA TABLA',
  `email` varchar(100) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'CORREO DEL CLIENTE',
  `texto` varchar(100) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'CONTENIDO DEL TESTIMONIO',
  `titulo` varchar(30) COLLATE utf8_spanish2_ci DEFAULT NULL COMMENT 'TITULO DEL TESTIMONIO',
  `nombre` varchar(20) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'NOMBRE DEL CLIENTE',
  `fecha` date NOT NULL COMMENT 'FECHA MODIFICACION DEL TESTIMONIO',
  `estado` int(1) NOT NULL COMMENT 'ESTADO 1:ACTIVO, 2:INACTIVO',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

/*Data for the table `testimonios` */

insert  into `testimonios`(`id`,`email`,`texto`,`titulo`,`nombre`,`fecha`,`estado`) values 
(1,'o','o','o','o','0000-00-00',0);

/*Table structure for table `usuarios` */

DROP TABLE IF EXISTS `usuarios`;

CREATE TABLE `usuarios` (
  `id` int(10) NOT NULL AUTO_INCREMENT COMMENT 'CODIGO UNICO DE LA TABLA',
  `tipo_use` int(1) NOT NULL COMMENT 'TIPO DE EMPLEADO 1:ADMIN, 2:VENTAS, 3:',
  `usuario` varchar(20) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'USUARIO UNICO DEL EMPELADO',
  `contrasena` varchar(40) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'CONTRASEÑA ENCRIPTACION=''MD5''',
  `nombres` varchar(70) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'NOMBRES DEL EMPLEADO',
  `telefono` int(15) DEFAULT NULL COMMENT 'TELEFONO DEL EMPLEADO',
  `email` varchar(200) COLLATE utf8_spanish2_ci NOT NULL COMMENT 'CORREO DEL EMPLEADO',
  `tema` int(1) NOT NULL COMMENT 'TEMA 1:DARK, 2:LIGHT',
  `estado` int(1) NOT NULL COMMENT 'ESTADO 1:ACTIVO, 2:INACTIVO',
  `sexo` int(1) NOT NULL COMMENT 'SEXO 1:MASCULINO, 2:FEMENINO',
  PRIMARY KEY (`id`),
  KEY `tipo_use` (`tipo_use`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`tipo_use`) REFERENCES `auxiliar` (`id_aux`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

/*Data for the table `usuarios` */

insert  into `usuarios`(`id`,`tipo_use`,`usuario`,`contrasena`,`nombres`,`telefono`,`email`,`tema`,`estado`,`sexo`) values 
(1,6,'TONY','cc20f43c8c24dbc0b2539489b113277a','ANTONIO',36000000,'ortega@gmail.com',7,1,1),
(2,9,'EDWIN','c5e98f6c6e5b134c267d913b4b5fbd95','EDWIN',2147483647,'ermontes7@misena.edu.co',7,1,1),
(4,10,'SUPERUSER','d8578edf8458ce06fbc5bb76a58c5ca4','SUPERUSER',0,'',7,1,1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
