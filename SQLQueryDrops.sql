USE [GD1C2019]
GO

-- BORRAR LOS DATOS DE LAS TABLAS
DELETE FROM ZAFFA_TEAM.Auditoria_estado_cruceros
DELETE FROM ZAFFA_TEAM.Administrativo
DELETE FROM ZAFFA_TEAM.Funcionalidad
DBCC CHECKIDENT('ZAFFA_TEAM.Funcionalidad', RESEED, 0)
DELETE FROM ZAFFA_TEAM.[Funcionalidad x Rol]
DELETE FROM ZAFFA_TEAM.Rol
DELETE FROM ZAFFA_TEAM.Tramo
DELETE FROM ZAFFA_TEAM.Puerto
DBCC CHECKIDENT('ZAFFA_TEAM.Puerto', RESEED, 0)
DELETE FROM ZAFFA_TEAM.Recorrido_Unico
DELETE FROM ZAFFA_TEAM.Pasaje
DELETE FROM ZAFFA_TEAM.Viaje
DBCC CHECKIDENT('ZAFFA_TEAM.Viaje', RESEED, 0)
DELETE FROM ZAFFA_TEAM.Cabina
DELETE FROM ZAFFA_TEAM.Tipo_Cabina
DELETE FROM ZAFFA_TEAM.Cliente
DBCC CHECKIDENT('ZAFFA_TEAM.Cliente', RESEED, 0)
DELETE FROM ZAFFA_TEAM.Crucero
DELETE FROM ZAFFA_TEAM.Marca
DBCC CHECKIDENT('ZAFFA_TEAM.Marca', RESEED, 0)
DELETE FROM ZAFFA_TEAM.Reserva

-- ELIMINAR LAS TABLAS
/****** Object:  Table [ZAFFA_TEAM].[Pasaje]    Script Date: 25/5/2019 4:50:55 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Reserva]
GO

/****** Object:  Table [ZAFFA_TEAM].[Pasaje]    Script Date: 25/5/2019 4:50:55 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Pasaje]
GO


/****** Object:  Table [ZAFFA_TEAM].[Cliente]    Script Date: 25/5/2019 4:49:32 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Cliente]
GO


/****** Object:  Table [ZAFFA_TEAM].[Viaje]    Script Date: 25/5/2019 4:52:05 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Viaje]
GO


/****** Object:  Table [ZAFFA_TEAM].[Cabina]    Script Date: 25/5/2019 4:49:01 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Cabina]
GO


/****** Object:  Table [ZAFFA_TEAM].[Crucero]    Script Date: 25/5/2019 4:49:53 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Crucero]
GO


/****** Object:  Table [ZAFFA_TEAM].[Marca]    Script Date: 25/5/2019 4:50:38 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Marca]
GO


/****** Object:  Table [ZAFFA_TEAM].[Tipo_Cabina]    Script Date: 25/5/2019 4:51:41 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Tipo_Cabina]
GO


/****** Object:  Table [ZAFFA_TEAM].[Tramo]    Script Date: 25/5/2019 4:51:54 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Tramo]
GO



/****** Object:  Table [ZAFFA_TEAM].[Recorrido_Unico]    Script Date: 25/5/2019 4:51:21 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Recorrido_Unico]
GO



/****** Object:  Table [ZAFFA_TEAM].[Puerto]    Script Date: 25/5/2019 4:51:11 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Puerto]
GO


/****** Object:  Table [ZAFFA_TEAM].[Funcionalidad x Rol]    Script Date: 25/5/2019 4:50:28 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Funcionalidad x Rol]
GO


/****** Object:  Table [ZAFFA_TEAM].[Administrativo]    Script Date: 25/5/2019 4:48:40 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Administrativo]
GO


/****** Object:  Table [ZAFFA_TEAM].[Funcionalidad]    Script Date: 25/5/2019 4:50:09 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Funcionalidad]
GO


/****** Object:  Table [ZAFFA_TEAM].[Rol]    Script Date: 25/5/2019 4:51:29 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Rol]
GO

/****** Object:  Table [ZAFFA_TEAM].[Rol]    Script Date: 25/5/2019 4:51:29 p. m. ******/
DROP TABLE [ZAFFA_TEAM].[Auditoria_estado_cruceros]
GO


DROP TRIGGER ZAFFA_TEAM.Borrar_Reservas_Mayores_A_Tres_Dias


DROP TRIGGER ZAFFA_TEAM.Auditoria_de_estado_cruceros