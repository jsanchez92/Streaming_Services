use master
create database streaming

use streaming
CREATE TABLE Servicios (
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Nombre NVARCHAR(60) NOT NULL,
	FechaCreacion date default(getdate()),
	FechaModificacion date default(getdate())
);

CREATE TABLE [dbo].[TipoServicio](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY CLUSTERED,
	[ServiciosId] [int] NOT NULL,
	[Tipo] [nvarchar](30) NOT NULL,
	[Costo] [int] NOT NULL,
	[Cant_Dispositivos] [int] NULL DEFAULT ((1)),
	[FechaCreacion] [date] NULL DEFAULT (getdate()),
	[FechaModificacion] [date] NULL DEFAULT (getdate()),
	FOREIGN KEY([ServiciosId])
	REFERENCES [dbo].[Servicios] ([Id])
);

CREATE TABLE Usuarios(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY CLUSTERED,
	Nombres nvarchar(50) NOT NULL,
	Apellidos nvarchar(50) NOT NULL,
	Telefono nvarchar(20) NULL,
	Direccion nvarchar(max) NULL,
	Email nvarchar(20) NULL,
	UserName nvarchar(60) not null,
	Pass nvarchar(max) NULL,
	FechaCreacion date NULL DEFAULT (getdate()),
	FechaModificacion date NULL DEFAULT (getdate())
);

CREATE TABLE Clientes(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY CLUSTERED,
	UsuariosId int  NOT NULL,	-- para saber que usuario crea a determinado cliente
	Nombres nvarchar(50) NOT NULL,
	Apellidos nvarchar(50) NOT NULL,
	Telefono nvarchar(20) NULL,
	Direccion nvarchar(max) NULL,
	FechaCreacion date NULL DEFAULT (getdate()),
	FechaModificacion date NULL DEFAULT (getdate()),
	FOREIGN KEY(UsuariosId)
	REFERENCES Usuarios (Id)
);
