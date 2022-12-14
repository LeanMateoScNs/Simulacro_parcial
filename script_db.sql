Create database [recetas_db]
USE [recetas_db]
GO
/****** Object:  Table [dbo].[Recetas]    Script Date: 09/18/2022 19:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Recetas](
	[id_receta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cheff] [varchar](100) NULL,
	[tipo_receta] [int] NOT NULL,
 CONSTRAINT [PK_Recetas] PRIMARY KEY CLUSTERED 
(
	[id_receta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ingredientes]    Script Date: 09/18/2022 19:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ingredientes](
	[id_ingrediente] [int] NOT NULL,
	[n_ingrediente] [varchar](50) NOT NULL,
	[unidad_medida] [varchar](50) NULL,
 CONSTRAINT [PK_Ingredientes] PRIMARY KEY CLUSTERED 
(
	[id_ingrediente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (1, N'Sal', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (2, N'Pimienta', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (3, N'Agua', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (4, N'Aceite', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (5, N'carne', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (6, N'caldo', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (7, N'Azucar', N'gramos')
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLES]    Script Date: 09/18/2022 19:27:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLES] 
	@id_receta int,
	@id_ingrediente int, 
	@cantidad int
AS
BEGIN
	INSERT INTO T_DETALLES_RECETA(id_receta,id_ingrediente,cantidad)
    VALUES (@id_receta, @id_ingrediente, @cantidad);
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_RECETA]    Script Date: 09/18/2022 19:27:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_RECETA] 
	@tipo_receta int,
	@nombre varchar(50),
	@cheff varchar(100)
AS
BEGIN
	INSERT INTO Recetas (nombre, cheff , tipo_receta)
    VALUES (@nombre, @cheff, @tipo_receta );

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_INGREDIENTES]    Script Date: 09/18/2022 19:27:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_INGREDIENTES]
AS
BEGIN
	
	SELECT * from Ingredientes ORDER BY 2;
END
GO
/****** Object:  Table [dbo].[Detalles_Receta]    Script Date: 09/18/2022 19:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Receta](
	[id_receta] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
	[cantidad] [numeric](5, 2) NOT NULL,
 CONSTRAINT [PK_Detalles_Receta] PRIMARY KEY CLUSTERED 
(
	[id_receta] ASC,
	[id_ingrediente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Detalles_Receta_Ingredientes]    Script Date: 09/18/2022 19:27:28 ******/
ALTER TABLE [dbo].[Detalles_Receta]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Receta_Ingredientes] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingredientes] ([id_ingrediente])
GO
ALTER TABLE [dbo].[Detalles_Receta] CHECK CONSTRAINT [FK_Detalles_Receta_Ingredientes]
GO
/****** Object:  ForeignKey [FK_Ingredientes_Ingredientes]    Script Date: 09/18/2022 19:27:28 ******/
ALTER TABLE [dbo].[Ingredientes]  WITH CHECK ADD  CONSTRAINT [FK_Ingredientes_Ingredientes] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingredientes] ([id_ingrediente])
GO
ALTER TABLE [dbo].[Ingredientes] CHECK CONSTRAINT [FK_Ingredientes_Ingredientes]
GO

--Resolucion:

create table TipoReceta(
id_tipo int,
tipo varchar(50)
constraint pk_id_tipo primary key (id_tipo))

alter table Recetas
add constraint fk_tipo_receta foreign key (tipo_receta) references TipoReceta(id_tipo)


create proc sp_insert_receta(

	@tipo_receta int,
	@nombre varchar(50),
	@cheff varchar(50))
as
	insert into Recetas(tipo_receta,nombre,cheff)values (@tipo_receta, @nombre, @cheff)

create proc sp_insert_detalles(
	@id_receta int,
	@id_ingrediente int,
	@cantidad numeric)
as 
	insert into Detalles_Receta(id_receta,id_ingrediente, cantidad ) values(@id_receta,@id_ingrediente,@cantidad)


	Create proc sp_sig_nro_receta(
	@next int output)
as
	select @next= (MAX(id_receta)+ 1)
	from Recetas


create proc sp_return_tipo_receta
as
select * from TipoReceta

create proc sp_return_ingredientes
as
select * from Ingredientes

insert into Recetas values ('pancho','luis',1)

insert into TipoReceta values (1,'postre')