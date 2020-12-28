IF NOT EXISTS(SELECT * FROM sysdatabases WHERE (name = 'iacym'))
BEGIN
	CREATE DATABASE iacym
END;

USE iacym
GO

CREATE TABLE iglesia (
	id int NOT NULL PRIMARY KEY,
	pais varchar(30) NOT NULL,
	departamento varchar(30) NOT NULL,
	provincia varchar(30) NOT NULL,
	distrito varchar(30) NOT NULL,
	direccion varchar(50) NOT NULL,
	nombre varchar(40) NOT NULL,
	telefono char(10) NOT NULL
);

CREATE TABLE ofrenda (
	id int NOT NULL PRIMARY KEY,
	culto varchar(50) NOT NULL,
	monto decimal(10,3) NOT NULL,
	fecha date NOT NULL,
	id_iglesia int FOREIGN KEY REFERENCES iglesia(id)
);

CREATE TABLE miembro (
	codigo int NOT NULL PRIMARY KEY,
	nombre varchar(20) NOT NULL,
	ap_paterno varchar(10) NOT NULL,
	ap_materno varchar(10) NOT NULL,
	dni char(8) NOT NULL,
	estado_civil int NOT NULL,
	provincia varchar(30) NOT NULL,
	distrito varchar(30) NOT NULL,
	direccion varchar(50) NOT NULL,
	referencia varchar(40),
	sexo bit NOT NULL,
	celular char(12),
	telefono char(10),
	email varchar(40),
	estudios varchar(50),
	fch_nacimiento date NOT NULL,
	fch_bautismo date NOT NULL,
	foto image,
	activo bit,
	id_iglesia int FOREIGN KEY REFERENCES iglesia(id)
);

CREATE TABLE vinculo (
	id int NOT NULL PRIMARY KEY,
	vinculo int NOT NULL,
	cod_vinculo int NOT NULL,
	cod_miembro int FOREIGN KEY REFERENCES miembro(codigo)
);

CREATE TABLE comentario (
	id int NOT NULL PRIMARY KEY,
	fecha datetime NOT NULL,
	comentario varchar(200) NOT NULL,
	cod_miembro int FOREIGN KEY REFERENCES miembro(codigo)
);

CREATE TABLE diezmo (
	id int NOT NULL PRIMARY KEY,
	monto decimal(10,3) NOT NULL,
	mes varchar(10) NOT NULL,
	año char(4) NOT NULL,
	fch_emision date NOT NULL,
	cod_miembro int FOREIGN KEY REFERENCES miembro(codigo)
);

CREATE TABLE ofrenda_misionera (
	id int NOT NULL PRIMARY KEY,
	monto decimal(10,3) NOT NULL,
	mes varchar(10) NOT NULL,
	año char(4) NOT NULL,
	fch_emision date NOT NULL,
	cod_miembro int FOREIGN KEY REFERENCES miembro(codigo)
);

CREATE TABLE ofrenda_pro_templo (
	id int NOT NULL PRIMARY KEY,
	monto decimal(10,3) NOT NULL,
	mes varchar(10) NOT NULL,
	año char(4) NOT NULL,
	fch_emision date NOT NULL,
	cod_miembro int FOREIGN KEY REFERENCES miembro(codigo)
);