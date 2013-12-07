
use GD2C2013
go
CREATE SCHEMA Free_Running AUTHORIZATION gd
GO

--///////////////////////////////////////////CREACION TABLAS///////////////////////////////////////////--


--TABLA PACIENTES: Tabla de todos los Pacientes de la Clinica - esten o no activos 

CREATE TABLE Free_Running.Paciente(
Nro_Afiliado numeric(18,0) NOT NULL,
Nombre	varchar(255) NOT NULL,
Apellido	varchar(255) NOT NULL,
Documento	numeric(18, 0) NOT NULL,
Direccion	varchar(255) NOT NULL,
Telefono	numeric(18, 0) NOT NULL,
Mail	varchar(255) NOT NULL,
Fecha_Nac	datetime NOT NULL,
Sexo varchar(255) NULL,
Tipo_Documento varchar(255) NULL,
Estado_Civil  varchar(255) NULL,
Cant_Familiares numeric(18, 0) NULL,
Plan_Medico numeric(18, 0) NOT NULL,
Estado varchar(255) NOT NULL,  --Activo | noActivo
Username  varchar(255) NULL,                                                  
CONSTRAINT PK_Paciente PRIMARY KEY CLUSTERED (Nro_Afiliado ASC)
)
GO


--TABLA PLAN MEDICO: Tabla de todos los Planes que Ofrece la Clinica 
CREATE TABLE Free_Running.Plan_Medico (
Codigo	numeric(18, 0) NOT NULL,
Descripcion	varchar(255) NOT NULL,
Precio_Bono_Consulta	numeric(18, 0) NOT NULL,
Precio_Bono_Farmacia	numeric(18, 0) NOT NULL,
CONSTRAINT PK_Plan_Medico PRIMARY KEY CLUSTERED (Codigo ASC)
)
GO


--TABLA HISTORIAL PLAN MEDICO: Tabla que muentra cada cambio de plan de cada Paciente  */
CREATE TABLE Free_Running.Historial_Plan_Med (
Id numeric(18, 0) NOT NULL identity(1,1),
Plan_Med_Codigo	numeric(18, 0) NOT NULL,
Fecha datetime NOT NULL,
Motivo	varchar(255) NOT NULL,
Nro_Afiliado	numeric(18, 0) NOT NULL,
CONSTRAINT PK_Plan_Medico_Hist PRIMARY KEY CLUSTERED (Id ASC)
)
GO


--TABLA TURNO: En esta Tabla se Registran TODOS los turnos que se dan
CREATE TABLE Free_Running.Turno (
Numero	numeric(18, 0) NOT NULL,
Fecha	datetime NOT NULL,
Nro_Afiliado numeric(18, 0) NOT NULL,
Especialidad_Codigo	numeric(18, 0) NOT NULL,
Medico_Id numeric(18, 0) NOT NULL
CONSTRAINT PK_Turno PRIMARY KEY CLUSTERED (Numero ASC)
)
GO


--TABLA CONSULTA: Tabla que Registra una Consulta que se realizo satisfactoriamente
CREATE TABLE Free_Running.Consulta (
Id numeric(18, 0) NOT NULL identity(1,1),
Id_Atencion_Medica numeric(18, 0)NOT NULL,
Sintomas	varchar(255) NOT NULL,
Enfermedades	varchar(255) NOT NULL,
CONSTRAINT PK_Consulta PRIMARY KEY CLUSTERED (Id ASC)
)
GO

--TABLA MEDICOS: Contiene todos los Profecionales de la Clinica
CREATE TABLE Free_Running.Medico (
Id numeric(18, 0) NOT NULL identity(1,1),
Nombre	varchar(255) NOT NULL,
Apellido	varchar(255) NOT NULL,
Sexo varchar(255) NULL,
Tipo_Documento varchar(255) NULL,
Documento	numeric(18, 0) NOT NULL,
Direccion	varchar(255) NOT NULL,
Telefono	numeric(18, 0) NOT NULL,
Mail	varchar(255) NOT NULL,
Fecha_Nac	datetime NOT NULL,
Matricula numeric(18, 0) NULL,
Username varchar(255) NULL,
CONSTRAINT PK_Medico PRIMARY KEY CLUSTERED (Id ASC)
) 
GO

--TABLA ESPECIALEDADES: Muestra cada una de las Especialidades de los Medicos
CREATE TABLE Free_Running.Especialidad (
Codigo	numeric(18, 0) NOT NULL,
Descripcion	varchar(255) NOT NULL,
Tipo_Codigo	numeric(18, 0) NOT NULL,
CONSTRAINT PK_Especialidad PRIMARY KEY CLUSTERED (Codigo ASC)
)
GO

--TABLA TIPO ESPECIALIDAD: Muestra el Tipo de cada Especialidad
CREATE TABLE Free_Running.Tipo_Especialidad (
Codigo	numeric(18, 0) NOT NULL,
Descripcion	varchar(255) NOT NULL,
CONSTRAINT PK_Tipo_Especialidad PRIMARY KEY CLUSTERED (Codigo ASC)
)
GO


--TABLA ESPECIALIDAD POR MEDICO: Relaciona un Medico con sus Especialidades
CREATE TABLE Free_Running.Especialidad_Por_Med (
Id numeric(18, 0) NOT NULL,
Especialidad_Codigo	numeric(18, 0) NOT NULL,
CONSTRAINT PK_Esp_Por_Med PRIMARY KEY CLUSTERED (Id ASC,Especialidad_Codigo ASC)
)
GO


--TABLA AGENDA: Mustra las Agendas que tubo y tiene cada Medico y el Intervalo que es Valida dicha Agenda
CREATE TABLE Free_Running.Agenda (
Id numeric(18, 0) NOT NULL identity(1,1),
Medico numeric(18, 0) NOT NULL ,
FechaHora_Turno datetime NOT NULL,
CONSTRAINT PK_Agenda PRIMARY KEY CLUSTERED (Id ASC)
)
GO



--TABLA COMPRA BONO CONSULTA: Muestra todas las compras que se hicieron de los Bonos Consulta
CREATE TABLE Free_Running.Compra_Bono_Consulta (
Id numeric(18, 0) NOT NULL identity(1,1),
Fecha_Compra	datetime NOT NULL, 
Afiliado_Compra numeric(18, 0) NOT NULL,
Bono_Consulta numeric(18,0) NOT NULL
CONSTRAINT PK__Compra_Bono_Consulta PRIMARY KEY CLUSTERED (Id ASC)
)
GO

--TABLA BONO CONSULTA: Contiene TODOS los Bonos Consulta Comprados Cancelados o No, Utilizados o No
CREATE TABLE Free_Running.Bono_Consulta (
Id numeric(18, 0) NOT NULL identity(1,1),
Numero	numeric(18, 0) NULL,
Afiliado_Utiliza numeric(18, 0) NULL,
Precio numeric(18, 0) NULL,
Plan_Correspondiente numeric(18, 0) NOT NULL,
CONSTRAINT PK_Bono_Consulta PRIMARY KEY CLUSTERED (Id ASC)
)
GO

--TABLA BONO CONSULTA CANSELADO: Representa un Bono Consulta que se Utilizo al momento de Llegar a la Clinica pero que No se pudo realizar la Consulta
CREATE TABLE Free_Running.Bono_Consulta_Cancelado (
Id	numeric(18, 0) NOT NULL identity(1,1),
Bono_Consulta numeric(18, 0) NOT NULL,
CONSTRAINT PK_Bono_Consulta_Cancelado PRIMARY KEY CLUSTERED (Id ASC)
)
GO

--TABLA COMPRA BONO FARMACIA: Muestra todas las compras que se hicieron de los Bonos Farmacia
CREATE TABLE Free_Running.Compra_Bono_Farmacia (
Id numeric(18, 0) NOT NULL identity(1,1),
Fecha_Compra	datetime NOT NULL, 
Afiliado_Compra numeric(18, 0) NOT NULL,
Bono_Farmacia numeric(18, 0) NOT NULL
CONSTRAINT PK__Compra_Bono_Farmacia PRIMARY KEY CLUSTERED (Id ASC)
)
GO

--TABLA BONO FARMACIA: Contiene TODOS los Bonos Farmacia Comprados, Vencidos o No, Utilizados o No
CREATE TABLE Free_Running.Bono_Farmacia (
Id	numeric(18, 0) NOT NULL identity(1,1),
Fecha_Vencimiento	datetime NOT NULL,
Fecha_Preinscripcion_Medicamento	varchar(255) NULL,
Plan_Correspondiente numeric(18, 0) NOT NULL,
Afiliado_Utiliza numeric(18, 0) NULL,
Precio numeric(18, 0) NOT NULL,
Consulta_Id numeric(18, 0) NULL,
CONSTRAINT PK_Bono_Farmacia PRIMARY KEY CLUSTERED (Id ASC)
)
GO



--TABLA BONO FARMACIA VENCIDO: Representa los Bonos Farmacia NO utilizados antes de los 60 Dias
CREATE TABLE Free_Running.Bono_Farmacia_Vencido (
Id numeric(18, 0) NOT NULL,
Bono_Farmacia_Id	numeric(18, 0) NOT NULL,
CONSTRAINT PK_Bono_Farmacia_Vencido PRIMARY KEY CLUSTERED (Id ASC)
)
GO


--TABLA LLEGADA ATENCION MEDICA: Cada Registro de esta Tabla Representa la Llegada de un Paciente a la clinica en Horario
CREATE TABLE Free_Running.Llegada_Atencion_Medica (
Id	numeric(18, 0) NOT NULL identity(1,1),
Fecha_Hs_Llegada	datetime NOT NULL,
Nro_Afiliado numeric(18, 0) NOT NULL,
Turno_Numero numeric(18, 0) NOT NULL,
Bono_Consulta numeric(18, 0) NOT NULL,
CONSTRAINT PK_Llegada_Atencion_Medica PRIMARY KEY CLUSTERED (Id ASC)
)
GO


--TABLA ATENCION MEDICA: Representa la Confirmacion de que un Paciente Entro al Consultorio con el Medico
CREATE TABLE Free_Running.Atencion_Medica (
Id	numeric(18, 0) NOT NULL identity(1,1),
Llegada_Id numeric(18, 0) NOT NULL,
Fecha_Hs datetime NOT NULL,
Confirmacion varchar(255) NOT NULL, --confirmado | no confirmado
CONSTRAINT PK_Atencion_Medica PRIMARY KEY CLUSTERED (Id ASC)
)
GO



--TABLA TURNO CANCELADO: Turnos que Fueron Cancelados por el Medico o Paciente  1 dia antes o +
CREATE TABLE Free_Running.Turno_Cancelado(
Id	numeric(18, 0) NOT NULL identity(1,1),
Turno_Numero numeric(18, 0) NOT NULL,
Cancelado_Por varchar(255) NULL,
Motivo varchar(255) NULL,
Tipo varchar(255) NULL,
CONSTRAINT PK_Turno_Cancelado PRIMARY KEY CLUSTERED (Id ASC)
)
GO

CREATE TABLE Free_Running.Tipo_Cancelado(
Tipo varchar(255) NOT NULL,
CONSTRAINT PK_Tipo_Cancelado PRIMARY KEY CLUSTERED (Tipo ASC)
)
GO


--TABLA MEDICAMENTO x BONO FARMACIA:
CREATE TABLE Free_Running.Medicamento_por_BonoFarmacia (
Medicamento	varchar(255) NOT NULL,
Bono_Farmacia numeric(18, 0) NOT NULL,
Cantidad numeric(18, 0) NULL,
Aclaracion_Cantidad varchar(255) NULL,
CONSTRAINT PK_Medicamento_x_BF PRIMARY KEY CLUSTERED (Medicamento ASC,Bono_Farmacia ASC )
)
GO

--TABLA Medicamento:
CREATE TABLE Free_Running.Medicamento (
Medicamento varchar(255) NOT NULL,
CONSTRAINT PK_Medicamento PRIMARY KEY CLUSTERED (Medicamento ASC)
)
GO




--TABLA FUNCIONALIDADES: Tabla que muestra las Funcionalidades que puede tener un Rol
CREATE TABLE Free_Running.Funcionalidad(
Id varchar(255) NOT NULL,
CONSTRAINT PK_Funcionalidad PRIMARY KEY CLUSTERED (Id ASC)
)
GO



--TABLA ROL: Tabla que muestra los Roles que puede Pertenecer un Usuario
CREATE TABLE Free_Running.Rol(
Id varchar(255) NOT NULL,
Habilitado bit NOT NULL,
CONSTRAINT PK_Rol PRIMARY KEY CLUSTERED (Id ASC)
)
GO


--TABLA FUNCIONALIDAD POR ROL: Tabla que relaciona un rol con una/s determinada/s funcionalidad/es
CREATE TABLE Free_Running.Funcionalidad_por_Rol(
Rol_Id 	varchar(255) NOT NULL,
Funcionalidad_Id	varchar(255) NOT NULL,
CONSTRAINT PK_Funcionalidad_por_Rol PRIMARY KEY CLUSTERED (Rol_Id ASC, Funcionalidad_Id ASC)
)
GO

--TABLA INTENTOS FALLIDOS: Tabla que registra cada intento fallido de un determinado Usuario
CREATE TABLE Free_Running.Intentos_Fallidos(
Id numeric(18, 0) NOT NULL identity(1,1),
Fecha	datetime NOT NULL,
Username	varchar(255) NOT NULL,
CONSTRAINT PK_Intentos_Fallidos PRIMARY KEY CLUSTERED (Id ASC)
)
GO

--TABLA USUARIOS: Tabla que Muestra los Usuarios que pueden acceder al sistema
CREATE TABLE Free_Running.Usuario(
Username	varchar(255) NOT NULL,
Usuario_Password varchar(256) NOT NULL, 
Habilitado bit NOT NULL,
CONSTRAINT PK_Usuario_Username PRIMARY KEY CLUSTERED (Username ASC)
)
GO

--TABLA USUARIOS POR ROL: Tabla que relaciona un Username con un/unos Rol/Roles
CREATE TABLE Free_Running.Usuario_por_Rol(
Username	varchar(255) NOT NULL,
Rol_Id	varchar(255) NOT NULL,
CONSTRAINT PK_Usuario_por_Rol PRIMARY KEY CLUSTERED (Username ASC, Rol_Id ASC)
)
GO






--///////////////////////////////////////////CREACION FK///////////////////////////////////////////--


 --Relaciono un Paciente con un Plan Medico
 ALTER TABLE Free_Running.Paciente ADD CONSTRAINT FK_Plan_Medico FOREIGN KEY (Plan_Medico) 
 REFERENCES Free_Running.Plan_Medico(Codigo) 
 GO
 
 ALTER TABLE Free_Running.Paciente ADD CONSTRAINT FK_Usuario_Paciente  FOREIGN KEY (Username) 
 REFERENCES Free_Running.Usuario(Username) 
 ON update cascade
 GO

 
 ALTER TABLE Free_Running.Medico ADD CONSTRAINT FK_Usuario_Medico  FOREIGN KEY (Username) 
 REFERENCES Free_Running.Usuario(Username) 
 ON update cascade
 GO
 
 
 
  --Relaciono un Registro del Historial con un Plan Medico
 ALTER TABLE Free_Running.Historial_Plan_Med ADD CONSTRAINT FK_HistPlanMed_PlanMedCodigo FOREIGN KEY (Plan_Med_Codigo) 
 REFERENCES Free_Running.Plan_Medico(Codigo) 
 GO
 
 
 
 
 
 ALTER TABLE Free_Running.Historial_Plan_Med ADD CONSTRAINT FK_HistPlanMed_NroAfiliado FOREIGN KEY (Nro_Afiliado) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 

 ALTER TABLE Free_Running.Medicamento_por_BonoFarmacia ADD CONSTRAINT FK_MxF_BonoFarmacia FOREIGN KEY (Bono_Farmacia) 
 REFERENCES Free_Running.Bono_Farmacia(Id) 
 GO
 
 ALTER TABLE Free_Running.Medicamento_por_BonoFarmacia ADD CONSTRAINT FK_MxF_Medicamento FOREIGN KEY (Medicamento) 
 REFERENCES Free_Running.Medicamento(Medicamento) 
 GO

  
 
 
 ALTER TABLE Free_Running.Consulta ADD CONSTRAINT FK_Id_Atencion_Medica  FOREIGN KEY (Id_Atencion_Medica) 
 REFERENCES Free_Running.Atencion_Medica(Id) 
 GO
 
 
ALTER TABLE Free_Running.Bono_Farmacia ADD CONSTRAINT FK_Bono_Farmacia FOREIGN KEY (Consulta_Id) 
 REFERENCES Free_Running.Consulta(Id) 
 GO

 ALTER TABLE Free_Running.Bono_Farmacia ADD CONSTRAINT FK_Bono_Farmacia_Afiliado_Utiliza FOREIGN KEY (Afiliado_Utiliza) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 ALTER TABLE Free_Running.Bono_Farmacia ADD CONSTRAINT FK_Bono_Farmacia_Plan_Correspondiente FOREIGN KEY (Plan_Correspondiente) 
 REFERENCES Free_Running.Plan_Medico(Codigo) 
 GO

 
 
 ALTER TABLE Free_Running.Compra_Bono_Farmacia ADD CONSTRAINT FK_Compra_BF_Afiliado_Compra FOREIGN KEY (Afiliado_Compra) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 ALTER TABLE Free_Running.Compra_Bono_Farmacia ADD CONSTRAINT FK_Compra_BF_BonoFarmacia FOREIGN KEY (Bono_Farmacia) 
 REFERENCES Free_Running.Bono_Farmacia(Id) 
 GO
 
 
 
 
 

 
 
 ALTER TABLE Free_Running.Compra_Bono_Consulta ADD CONSTRAINT FK_Compra_BC_Afiliado_Compra FOREIGN KEY (Afiliado_Compra) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 ALTER TABLE Free_Running.Compra_Bono_Consulta ADD CONSTRAINT FK_Compra_BC_BonoConsulta FOREIGN KEY (Bono_Consulta) 
 REFERENCES Free_Running.Bono_Consulta(Id) 
 GO
 
 
 
 ALTER TABLE Free_Running.Bono_Consulta ADD CONSTRAINT FK_Bono_Consulta_Afiliado_Utiliza FOREIGN KEY (Afiliado_Utiliza) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 ALTER TABLE Free_Running.Bono_Consulta ADD CONSTRAINT FK_Bono_Consulta_Plan_Correspondiente FOREIGN KEY (Plan_Correspondiente) 
 REFERENCES Free_Running.Plan_Medico(Codigo) 
 GO
 
 





 
 ALTER TABLE Free_Running.Bono_Consulta_Cancelado ADD CONSTRAINT FK_Bono_Consulta FOREIGN KEY (Bono_Consulta) 
 REFERENCES Free_Running.Bono_Consulta(Id) 
 GO
 
 
 ALTER TABLE Free_Running.Bono_Farmacia_Vencido ADD CONSTRAINT FK_Bono_Farmacia_Id FOREIGN KEY (Bono_Farmacia_Id) 
 REFERENCES Free_Running.Bono_Farmacia(Id) 
 GO
 



 ALTER TABLE Free_Running.Especialidad_Por_Med ADD CONSTRAINT FK_Esp_Por_Medico_Id FOREIGN KEY (Id) 
 REFERENCES Free_Running.Medico(Id) 
 GO
 ALTER TABLE Free_Running.Especialidad_Por_Med ADD CONSTRAINT FK_Esp_Por_Med_Especialidad_Codigo FOREIGN KEY ( Especialidad_Codigo) 
 REFERENCES Free_Running.Especialidad(Codigo) 
 GO
 
 
 
  
 
 ALTER TABLE Free_Running.Especialidad ADD CONSTRAINT FK_Especialidad_Tipo_Codigo FOREIGN KEY (Tipo_Codigo) 
 REFERENCES Free_Running.Tipo_Especialidad(Codigo) 
 GO
 
 


 ALTER TABLE Free_Running.Turno ADD CONSTRAINT FK_Medico_Id FOREIGN KEY (Medico_Id) 
 REFERENCES Free_Running.Medico(Id) 
 GO
 ALTER TABLE Free_Running.Turno ADD CONSTRAINT FK_Nro_Afiliado FOREIGN KEY (Nro_Afiliado) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 ALTER TABLE Free_Running.Turno ADD CONSTRAINT FK_Especialidad_Codigo FOREIGN KEY (Especialidad_Codigo) 
 REFERENCES Free_Running.Especialidad(Codigo) 
 GO



 ALTER TABLE Free_Running.Llegada_Atencion_Medica ADD CONSTRAINT FK_Llegada_Atencion_Medica_Nro_Afiliado FOREIGN KEY (Nro_Afiliado) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 ALTER TABLE Free_Running.Llegada_Atencion_Medica ADD CONSTRAINT FK_Llegada_Atencion_Medica_Turno_Numero FOREIGN KEY (Turno_Numero) 
 REFERENCES Free_Running.Turno(Numero) 
 GO
 ALTER TABLE Free_Running.Llegada_Atencion_Medica ADD CONSTRAINT FK_Llegada_Atencion_Medica_Bono_Consulta  FOREIGN KEY (Bono_Consulta ) 
 REFERENCES Free_Running.Bono_Consulta(Id) 
 GO
 
 
 
 ALTER TABLE Free_Running.Atencion_Medica ADD CONSTRAINT FK_Atencion_Medica_Llegada_Id  FOREIGN KEY (Llegada_Id) 
 REFERENCES Free_Running.Llegada_Atencion_Medica(Id) 
 GO



 
 ALTER TABLE Free_Running.Turno_Cancelado ADD CONSTRAINT FK_Turno_Cancelado_Turno_Numero  FOREIGN KEY (Turno_Numero) 
 REFERENCES Free_Running.Turno(Numero) 
 GO
 
 
 
 
 ALTER TABLE Free_Running.Funcionalidad_por_Rol ADD CONSTRAINT FK_Func_por_Rol_Rol_Id  FOREIGN KEY (Rol_Id) 
 REFERENCES Free_Running.Rol(Id) 
 ON update cascade
 ON delete cascade
 GO 
 ALTER TABLE Free_Running.Funcionalidad_por_Rol ADD CONSTRAINT FK_Func_por_Rol_Funcionalidad_Id  FOREIGN KEY (Funcionalidad_Id) 
 REFERENCES Free_Running.Funcionalidad(Id)
 GO
 
 
 
 
 ALTER TABLE Free_Running.Usuario_por_Rol ADD CONSTRAINT FK_Usuario_Username  FOREIGN KEY (Username) 
 REFERENCES Free_Running.Usuario(Username) 
 GO
 
 ALTER TABLE Free_Running.Usuario_por_Rol ADD CONSTRAINT FK_Rol_Id  FOREIGN KEY (Rol_Id) 
 REFERENCES Free_Running.Rol(Id) 
 ON update cascade
 ON delete cascade
 GO
 
 
 

 
 
 ALTER TABLE Free_Running.Intentos_Fallidos ADD CONSTRAINT FK_Intentos_Fallidos_Username  FOREIGN KEY (Username) 
 REFERENCES Free_Running.Usuario(Username) 
 ON update cascade
 GO

 
 ALTER TABLE Free_Running.Agenda ADD CONSTRAINT FK_Agenda_Medico_Id FOREIGN KEY (Medico) 
 REFERENCES Free_Running.Medico(Id) 
 ON update cascade
 GO


 ALTER TABLE Free_Running.Turno_Cancelado ADD CONSTRAINT FK_Tipo FOREIGN KEY (Tipo) 
 REFERENCES Free_Running.Tipo_Cancelado(Tipo) 
 GO








--///////////////////////////////////////////MIGRACION///////////////////////////////////////////--




--Migrar Planes Medicos
INSERT INTO Free_Running.Plan_Medico (Codigo,Descripcion,Precio_Bono_Consulta,Precio_Bono_Farmacia)
SELECT distinct Plan_Med_Codigo,Plan_Med_Descripcion,Plan_Med_Precio_Bono_Consulta,Plan_Med_Precio_Bono_Farmacia
FROM gd_esquema.Maestra

		--Creo Indices
		CREATE INDEX iNDICE_DOCUMENTO ON Free_Running.Plan_Medico(Codigo)



--Migrar Pacientes
INSERT INTO Free_Running.Paciente(Nombre,Apellido,Documento,Direccion,Telefono,Mail,Fecha_Nac,Sexo,Tipo_Documento,Estado_Civil,Cant_Familiares,Plan_Medico,Estado,Nro_Afiliado)

SELECT distinct
g1.Paciente_Nombre,g1.Paciente_Apellido,g1.Paciente_Dni,g1.Paciente_Direccion,g1.Paciente_Telefono,g1.Paciente_Mail,g1.Paciente_Fecha_Nac,'F','DNI','Soltero',0,g1.Plan_Med_Codigo,'Activo',
(( ROW_NUMBER() OVER(ORDER BY g1.Paciente_Dni DESC))*100)

FROM gd_esquema.Maestra g1
where not((( g1.Turno_Fecha is null) and ( g1.Compra_Bono_Fecha is null)))
group by g1.Paciente_Nombre,g1.Paciente_Apellido,g1.Paciente_Dni,g1.Paciente_Direccion,g1.Paciente_Telefono,g1.Paciente_Mail,g1.Paciente_Fecha_Nac,g1.Plan_Med_Codigo
go



		--Creo Indices
		CREATE INDEX iNDICE_DOCUMENTO ON Free_Running.Paciente (Documento);
		--CREATE INDEX iNDICE_NroAfiliado ON Free_Running.Paciente (Nro_Afiliado);
		
		go

		--Creo Funcion suNroAfiliado: dado un DNI me devuelve su Nro de Afiliado
		create function Free_Running.suNroAfiliado(@DNI numeric(18,0))
		returns numeric(18,0)
		as
		begin
			declare @NroAfiliado numeric(18,0)
			SET @NroAfiliado = (select top 1 P.Nro_Afiliado
								from Free_Running.Paciente P 
								where @DNI = P.Documento)
			return @NroAfiliado 
		end
		go





--Migrar Tipos de  Especialidad
INSERT INTO Free_Running.Tipo_Especialidad (Codigo,Descripcion)
SELECT distinct g2.Tipo_Especialidad_Codigo,g2.Tipo_Especialidad_Descripcion
FROM gd_esquema.Maestra g2
where g2.Tipo_Especialidad_Codigo is not null





--Migrar Especialidad
INSERT INTO Free_Running.Especialidad(Codigo,Descripcion,Tipo_Codigo)
SELECT distinct g2.Especialidad_Codigo,g2.Especialidad_Descripcion, g2.Tipo_Especialidad_Codigo
FROM gd_esquema.Maestra g2
where g2.Especialidad_Codigo is not null






--Migrar Medicos
INSERT INTO Free_Running.Medico(Nombre,Apellido,Tipo_Documento,Documento,Direccion,Telefono,Mail,Fecha_Nac,Matricula)
SELECT distinct g2.Medico_Nombre,Medico_Apellido,'DNI',Medico_Dni,Medico_Direccion,Medico_Telefono,Medico_Mail,Medico_Fecha_Nac,00
FROM gd_esquema.Maestra g2
where g2.Medico_Dni is not null





--Migrar Especialidad Medicos
INSERT INTO Free_Running.Especialidad_Por_Med(Id,Especialidad_Codigo)
Select distinct m1.Id,gdm.Especialidad_Codigo
From Free_Running.Medico m1 
	 join gd_esquema.Maestra gdm on (gdm.Medico_Dni=m1.Documento)





--Migrar Turnos
-- TODOS LOS TURNOS, Incluido Cancelados

INSERT INTO Free_Running.Turno(Numero,Fecha,Especialidad_Codigo,Medico_Id,Nro_Afiliado)
select distinct M.Turno_Numero,M.Turno_Fecha,M.Especialidad_Codigo,
				(select med.Id 
				from Free_Running.Medico med 
				where med.Documento=m.Medico_Dni), 
				
				(select distinct P.Nro_Afiliado 
				from Free_Running.Paciente P 
				where P.Documento=m.Paciente_Dni)
from gd_esquema.Maestra M
where M.Turno_Numero is not null





INSERT INTO Free_Running.Tipo_Cancelado(Tipo)
values
('Salud'),
('Viaje'),
('Otros'),
('Sistema')



--Migrar Turnos cancelados
--UN TURNO ESTA CANCELADO SI SOLO APARECE UNA VEZ EN LA TABLA MAESTRA y SI LA FECHA DE ESA VEZ ES MENOR A HOY (por q si es mayor entonces puede ser q no lo haya tomado todavia)
--Tambien si alguno de los turnos pendientes cae domingo o... si hay turnos superiores a los 120 dias ya que superarian la validez de la agenda creada
-- Lo tomo Como CANSELADO xq NO PIERDE EL BONO

INSERT INTO Free_Running.Turno_Cancelado(Turno_Numero,Tipo,Motivo)
select M.Turno_numero,'Otros','No se realizo la consulta'
from gd_esquema.Maestra M
where Turno_Fecha is not null 
Group by M.Turno_Numero,M.Turno_Fecha
Having (COUNT(M.Turno_Numero)=1 and M.Turno_Fecha < GETDATE())


INSERT INTO Free_Running.Turno_Cancelado(Turno_Numero,Tipo,Motivo)
select M.Turno_numero,'Sistema','la Fecha del nuevo Turno es Invalida'
from gd_esquema.Maestra M
where Turno_Fecha is not null and  M.Turno_Fecha > GETDATE()
Group by M.Turno_Numero,M.Turno_Fecha
Having (COUNT(M.Turno_Numero)=1 and (datename(dw,DATEADD(D, 0, DATEDIFF(D, 0, M.Turno_Fecha)))= 'Domingo')) 
	

/*
INSERT INTO Free_Running.Turno_Cancelado(Turno_Numero,Tipo,Motivo)
select M.Turno_numero, 'Sistema','Fecha del Turno Superior al permitido'
from gd_esquema.Maestra M
where Turno_Fecha is not null 
Group by M.Turno_Numero,M.Turno_Fecha
Having (COUNT(M.Turno_Numero)=1 and M.Turno_Fecha > GETDATE()+120 )
*/


--Rol
INSERT INTO Free_Running.Rol(Id,Habilitado)
Values
('Afiliado',1),
('Administrativo',1),
('Profesional',1),
('Admnistrador Gerencial',1)








--Funcionalidad
INSERT INTO Free_Running.Funcionalidad(Id)
Values
('ROL'),
('AFILIADO'),
('PROFESIONAL'),
('AGENDA'),
('COMPRA_BONO'),
('PEDIDO_TURNO'),
('LLEGADA_ATENCION_MEDICA'),
('REGISTRO_RESULTADO'),
('CANCELACION_TURNO'),
('RECETA_MEDICA'),
('LISTADO_ESTADISTICO')







--Funcionalidad x Rol
INSERT INTO Free_Running.Funcionalidad_por_Rol(Rol_Id,Funcionalidad_Id)
Values
('Afiliado','COMPRA_BONO'),('Afiliado','CANCELACION_TURNO'),
('Administrativo','ROL'),('Administrativo','AFILIADO'),('Administrativo','PROFESIONAL'),('Administrativo','COMPRA_BONO'),
('Administrativo','PEDIDO_TURNO'),('Administrativo','LLEGADA_ATENCION_MEDICA'),('Administrativo','LISTADO_ESTADISTICO'),
('Profesional','AGENDA'),('Profesional','REGISTRO_RESULTADO'),('Profesional','CANCELACION_TURNO'),('Profesional','RECETA_MEDICA'),
('Admnistrador Gerencial','ROL'),('Admnistrador Gerencial','AFILIADO'),
('Admnistrador Gerencial','PROFESIONAL'),('Admnistrador Gerencial','AGENDA'),
('Admnistrador Gerencial','COMPRA_BONO'),('Admnistrador Gerencial','PEDIDO_TURNO'),
('Admnistrador Gerencial','LLEGADA_ATENCION_MEDICA'),('Admnistrador Gerencial','REGISTRO_RESULTADO'),
('Admnistrador Gerencial','CANCELACION_TURNO'),('Admnistrador Gerencial','RECETA_MEDICA'),('Admnistrador Gerencial','LISTADO_ESTADISTICO')



go
create function Free_Running.calcula_fecha_vencimiento(@fecha smalldatetime)
returns smalldatetime
as 
begin
declare @fecha_final smalldatetime
set @fecha_final = DATEADD(DAY,60,@fecha)
return @fecha_final
end
go








--Bono Consulta
--TODOS LOS BONO COLSUTA COMPRADOS utilizados o NO
SET IDENTITY_INSERT Free_Running.Bono_Consulta ON
go
INSERT INTO Free_Running.Bono_Consulta(Id,Afiliado_Utiliza,Precio,Plan_Correspondiente)--,Numero)

select  M.Bono_Consulta_Numero,

	 (select P.Nro_Afiliado 
	 from gd_esquema.Maestra M3 
	 join Free_Running.Paciente P on M3.Paciente_Dni=P.Documento 
	 where  M.Bono_Consulta_Numero = M3.Bono_Consulta_Numero and 
			M3.Turno_Numero is not null and 
			M3.Bono_Consulta_Numero is not null) Afiliado_Utiliza,
	 
	((select top 1 P.Precio_Bono_Consulta
	from Free_Running.Plan_Medico P
	where M.Plan_Med_Codigo = P.Codigo)) Precio,
	
	M.Plan_Med_Codigo Plan_Correspondiente
	
	/*,
	
	(select  Count(distinct M2.Bono_Consulta_Numero)
	 from gd_esquema.Maestra M2
	 where (M.Compra_Bono_Fecha is not null and 
			M.Bono_Consulta_Numero is not null and 
			M.Paciente_Dni = M2.Paciente_Dni and 
			M.Bono_Consulta_Numero >= M2.Bono_Consulta_Numero )) Numero*/

from gd_esquema.Maestra M
where (M.Compra_Bono_Fecha is not null and M.Bono_Consulta_Numero is not null)
SET IDENTITY_INSERT Free_Running.Bono_Consulta OFF
go


INSERT INTO Free_Running.Compra_Bono_Consulta(Fecha_Compra,Afiliado_Compra,Bono_Consulta)
select M.Compra_Bono_Fecha,Free_Running.suNroAfiliado(M.Paciente_Dni),M.Bono_Consulta_Numero
from gd_esquema.Maestra M
where (M.Compra_Bono_Fecha is not null and M.Bono_Consulta_Numero is not null)




--llegada Atencion Medica
--REPRESENTA CUANDO UN PACIENTE LLEGA AL MOSTRADOR donde Registra Su BONO CONSULTA
--un paciente auq haya llegado, se puede ir

INSERT INTO Free_Running.Llegada_Atencion_Medica(Fecha_Hs_Llegada,Nro_Afiliado,Turno_Numero,Bono_Consulta)
select M.Turno_Fecha,Free_Running.suNroAfiliado(M.Paciente_Dni),M.Turno_Numero,M.Bono_Consulta_Numero
from gd_esquema.Maestra M
where Consulta_Sintomas is not null








--Atencion Medica 
--REPRESENRA LA CONFIRMACION o NO de q Un paciente se quedo y fue atendido por el Medico
--EN CASO DE Q NO SE QUEDE, PIERDE EL BONO, Por eso los de la tabla los puse en CANCELADOS

INSERT INTO Free_Running.Atencion_Medica(Llegada_Id,Fecha_Hs,Confirmacion)
select LAM.Id,LAM.Fecha_Hs_Llegada,'Confirmado'
from Free_Running.Llegada_Atencion_Medica LAM

go
		--Creo Funcion suNroAtencion que dado un turno me retorna su Nro Atencion Medica
		create function Free_Running.suNroAtencion(@turno numeric(18,0))
		returns numeric(18,0)
		as 
		begin
			declare @NroAtencion numeric(18,0)
			set @NroAtencion = (select AM.Id
								from Free_Running.Atencion_Medica AM 
								join Free_Running.Llegada_Atencion_Medica LAM on (AM.Llegada_Id=LAM.Id)
								where @turno = LAM.Turno_Numero)
			return @NroAtencion
		end

		go

		--Creo Indices
		CREATE INDEX iNDICE_LAM ON Free_Running.Llegada_Atencion_Medica(Turno_Numero)
		CREATE INDEX iNDICE_AM ON Free_Running.Atencion_Medica(Llegada_Id)



--Consulta
--Representa el Diagnostico para una determinada Atencion Medica
INSERT INTO Free_Running.Consulta(Id_Atencion_Medica,Sintomas,Enfermedades)
select Free_Running.suNroAtencion(M.Turno_Numero),M.Consulta_Sintomas,M.Consulta_Enfermedades
from gd_esquema.Maestra M
where M.Consulta_Sintomas is not null








--BONO FARMACIA
CREATE INDEX iNDICE_AdM3 ON Free_Running.Consulta(Id_Atencion_Medica)

SET IDENTITY_INSERT Free_Running.Bono_Farmacia ON
INSERT INTO Free_Running.Bono_Farmacia(Id,Fecha_Vencimiento,Afiliado_Utiliza,Precio,Consulta_Id,Plan_Correspondiente)
select M.Bono_Farmacia_Numero,M.Bono_Farmacia_Fecha_Vencimiento,
		
		(select P.Nro_Afiliado 
		from gd_esquema.Maestra M3 
		join Free_Running.Paciente P on M3.Paciente_Dni=P.Documento 
		where  M.Bono_Farmacia_Numero = M3.Bono_Farmacia_Numero and 
		M3.Turno_Numero is not null and 
		M3.Bono_Farmacia_Numero is not null) UTILIZA,
		
		(select top 1 P.Precio_Bono_Farmacia
		from Free_Running.Plan_Medico P
		where M.Plan_Med_Codigo = P.Codigo) PRECIO,
		
		(select C.Id 
		from Free_Running.Consulta C 
		join Free_Running.Atencion_Medica AM on C.Id_Atencion_Medica=AM.Id
		join Free_Running.Llegada_Atencion_Medica Ll on Am.Llegada_Id= Ll.Id
		join gd_esquema.Maestra MC on (MC.Turno_Numero = Ll.Turno_Numero)
		where MC.Turno_Numero is not null and M.Bono_Farmacia_Numero = MC.Bono_Farmacia_Numero) CONSULTA,
		
		M.Plan_Med_Codigo
		
from gd_esquema.Maestra M
where M.Bono_Farmacia_Numero is not null and M.Compra_Bono_Fecha is not null
SET IDENTITY_INSERT Free_Running.Bono_Farmacia OFF



INSERT INTO Free_Running.Compra_Bono_Farmacia(Fecha_Compra,Afiliado_Compra,Bono_Farmacia)
select M.Compra_Bono_Fecha,Free_Running.suNroAfiliado(M.Paciente_Dni),M.Bono_Farmacia_Numero
from gd_esquema.Maestra M
where M.Bono_Farmacia_Numero is not null and M.Compra_Bono_Fecha is not null


INSERT INTO Free_Running.Medicamento(Medicamento)
select distinct M.Bono_Farmacia_Medicamento
from gd_esquema.Maestra M
where M.Bono_Farmacia_Medicamento is not null



INSERT INTO Free_Running.Medicamento_por_BonoFarmacia(Bono_Farmacia,Medicamento)
select BF.Id,M.Bono_Farmacia_Medicamento
from Free_Running.Bono_Farmacia BF join Free_Running.Consulta C on C.Id = BF.Consulta_Id
	 join Free_Running.Atencion_Medica AM on C.Id_Atencion_Medica=AM.Id
	 join Free_Running.Llegada_Atencion_Medica LAM on LAM.Id=AM.Llegada_Id
	 join gd_esquema.Maestra M on M.Bono_Farmacia_Numero = LAM.Bono_Consulta
Where M.Bono_Farmacia_Numero is Not null and M.Compra_Bono_Fecha is null



--Agenda
--Cada Medico tiene una Adenda en donde se registran todos los horarios, actualmente la agenda se armo con los turnos futuros q no han sido canceldos

insert into Free_Running.Agenda(Medico,FechaHora_Turno)
select Me.Id,T.Fecha
from Free_Running.Medico Me join Free_Running.Turno T on T.Medico_Id = Me.Id
where T.Fecha between getdate() and (getdate()+120) and not exists (select * from Free_Running.Turno_Cancelado TC where TC.Turno_Numero = T.Numero)


INSERT INTO Free_Running.Usuario(Username,Usuario_Password,Habilitado) values('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',1)
INSERT INTO Free_Running.Usuario_por_Rol(Username,Rol_Id) values('admin','Administrativo')



--PROCEDIMIENTOS

go
CREATE FUNCTION Free_Running.CantIntentosActual(@Username varchar(255))
RETURNS int
AS
BEGIN
DECLARE @Return int
SET @Return = (select COUNT(InF.Id) from Free_Running.Intentos_Fallidos InF where InF.Username=@Username group by InF.Username)
RETURN @Return
END
GO




CREATE FUNCTION Free_Running.especialidadCod(@espNombre varchar(255))
RETURNS numeric(18,8)
AS
BEGIN
DECLARE @Cod numeric(18,8)
SET @Cod = (select E.Codigo from Free_Running.Especialidad E where E.Descripcion = @espNombre)
RETURN @Cod
END
Go



CREATE PROCEDURE Free_Running.agregarIntentoFallido  
    @User varchar(255) 
AS 
BEGIN
	INSERT INTO Free_Running.Intentos_Fallidos(Username,Fecha) values(@User,GETDATE())
	if(Free_Running.CantIntentosActual(@User)= 3)
	BEGIN
		UPDATE Free_Running.Usuario
		SET  Habilitado = 0
		WHERE Username = @User;
	END
END
GO



CREATE PROCEDURE Free_Running.borrarIntentoFallido 
    @Username varchar(255) 
AS 
BEGIN

		DELETE Free_Running.Intentos_Fallidos
		WHERE Username = @Username;
END
GO




CREATE PROCEDURE Free_Running.puedeUsarBC @NroAfiliado numeric(18,0), @BC numeric(18,0)
AS 
BEGIN
declare @rta int, @afilidoCompro numeric(18,0)

set @afilidoCompro = (select CBC.Afiliado_Compra from Free_Running.Compra_Bono_Consulta CBC where CBC.Bono_Consulta = @BC)

set @rta = (select COUNT(*) 
		   from Free_Running.Bono_Consulta BC 
where BC.Id = @BC and BC.Afiliado_Utiliza is null and
	  BC.Plan_Correspondiente = (select P.Plan_Medico from Free_Running.Paciente P where P.Nro_Afiliado = @NroAfiliado) and
	   @afilidoCompro - (@afilidoCompro % 100)= @NroAfiliado - (@NroAfiliado % 100))
	   
return @rta
END
GO



CREATE PROCEDURE Free_Running.existeAgenda 
    @Medico numeric(18, 0)
AS 
BEGIN

		Select top 1 * 
		from Free_Running.Agenda A 
		where(A.Medico = @Medico)
		order by A.FechaHora_Turno DESC
END
GO





CREATE FUNCTION Free_Running.mesVencido(@mes1 varchar(255) , @mes2 varchar(255),@Inicio DateTime,@Fin DateTime,@Esp numeric(18,8))
RETURNS numeric(18,8)
AS
BEGIN
DECLARE @Cant numeric(18,8)
SET @Cant = (select COUNT(*) Cantidad 
from Free_Running.Turno_Cancelado TC 
join Free_Running.Turno T on (TC.Turno_Numero = T.Numero)
where ((T.Fecha >= @Inicio) and (T.Fecha <= @Fin)) 
and T.Especialidad_Codigo = @Esp 
and (DATENAME(month,T.Fecha) = @mes1 or DATENAME(month,T.Fecha) = @mes2))
RETURN @Cant
END
Go


CREATE PROCEDURE Free_Running.EspeMasCanceladas 
    @Inicio DateTime,
    @Fin DateTime  
AS 
BEGIN
	select top 5 E.Descripcion,Free_Running.mesVencido('Enero','Julio',@Inicio,@Fin,E.Codigo)
							  ,Free_Running.mesVencido('Febrero','Agosto',@Inicio,@Fin,E.Codigo) 
							  ,Free_Running.mesVencido('Marzo','Septiembre',@Inicio,@Fin,E.Codigo) 
							  ,Free_Running.mesVencido('Abril','Octubre',@Inicio,@Fin,E.Codigo) 
							  ,Free_Running.mesVencido('Mayo','Noviembre',@Inicio,@Fin,E.Codigo) 
							  ,Free_Running.mesVencido('Junio','Diciembre',@Inicio,@Fin,E.Codigo) 
	from Free_Running.Especialidad E
	order by (select COUNT(*) Total from Free_Running.Turno_Cancelado TC 
								join Free_Running.Turno T on (TC.Turno_Numero = T.Numero)
								where ((T.Fecha >= @Inicio) and (T.Fecha <= @Fin)) 
								and T.Especialidad_Codigo = E.Codigo) DESC
END
go








CREATE FUNCTION Free_Running.BFVenc(@mes1 varchar(255) , @mes2 varchar(255),@Inicio DateTime,@Fin DateTime,@Afiliado numeric(18,8))
RETURNS numeric(18,8)
AS
BEGIN
DECLARE @Cant numeric(18,8)
SET @Cant = (select COUNT(*) Cantidad 
from Free_Running.Bono_Farmacia BF 
	 join Free_Running.Bono_Farmacia_Vencido V on (V.Bono_Farmacia_Id = BF.Id)
	 join Free_Running.Compra_Bono_Farmacia CBF on (CBF.Bono_Farmacia = BF.Id)
where ((BF.Fecha_Vencimiento >= @Inicio) and (BF.Fecha_Vencimiento <= @Fin))
and @Afiliado = CBF.Afiliado_Compra
and (DATENAME(month,BF.Fecha_Vencimiento) = @mes1 or DATENAME(month,BF.Fecha_Vencimiento) = @mes2))
RETURN @Cant
END
Go


CREATE PROCEDURE Free_Running.AfiliadoBFvenc 
    @Inicio DateTime,
    @Fin DateTime  
AS 
BEGIN
	
	select top 5 P.Nro_Afiliado,P.Apellido,P.Nombre,Free_Running.BFVenc('Enero','Julio',@Inicio,@Fin,P.Nro_Afiliado)
											 ,Free_Running.BFVenc('Febrero','Agosto',@Inicio,@Fin,P.Nro_Afiliado) 
											 ,Free_Running.BFVenc('Marzo','Septiembre',@Inicio,@Fin,P.Nro_Afiliado) 
											 ,Free_Running.BFVenc('Abril','Octubre',@Inicio,@Fin,P.Nro_Afiliado) 
											 ,Free_Running.BFVenc('Mayo','Noviembre',@Inicio,@Fin,P.Nro_Afiliado) 
											 ,Free_Running.BFVenc('Junio','Diciembre',@Inicio,@Fin,P.Nro_Afiliado) 
	from Free_Running.Paciente p
	
	order by (select COUNT(*) from Free_Running.Bono_Farmacia BF  join Free_Running.Bono_Farmacia_Vencido V on (V.Bono_Farmacia_Id = BF.Id)
	 join Free_Running.Compra_Bono_Farmacia CBF on (CBF.Bono_Farmacia = BF.Id) where ((BF.Fecha_Vencimiento >= @Inicio) and (BF.Fecha_Vencimiento <= @Fin))
	 and  P.Nro_Afiliado = CBF.Afiliado_Compra) DESC
END
go








CREATE FUNCTION Free_Running.BFRecetados(@mes1 varchar(255) , @mes2 varchar(255),@Inicio DateTime,@Fin DateTime,@Esp numeric(18,8))
RETURNS numeric(18,8)
AS
BEGIN
DECLARE @Cant numeric(18,8)
SET @Cant = (select COUNT(*) Cantidad 
from Free_Running.Bono_Farmacia BF join Free_Running.Consulta C on (C.Id = BF.Consulta_Id)
	 join Free_Running.Atencion_Medica AM on (Am.Id = C.Id_Atencion_Medica)
	 join Free_Running.Llegada_Atencion_Medica LAM on (LAM.Id = AM.Llegada_Id)
	 join Free_Running.Turno T on (LAM.Turno_Numero=T.Numero)
where ((T.Fecha >= @Inicio) and (T.Fecha <= @Fin))
and @Esp = T.Especialidad_Codigo
and (DATENAME(month,T.Fecha) = @mes1 or DATENAME(month,T.Fecha) = @mes2))
RETURN @Cant
END
Go


CREATE PROCEDURE Free_Running.EspMasBFRecetados
    @Inicio DateTime,
    @Fin DateTime  
AS 
BEGIN 
	select top 5 E.Descripcion,Free_Running.BFRecetados('Enero','Julio',@Inicio,@Fin,E.Codigo)
							  ,Free_Running.BFRecetados('Febrero','Agosto',@Inicio,@Fin,E.Codigo) 
							  ,Free_Running.BFRecetados('Marzo','Septiembre',@Inicio,@Fin,E.Codigo) 
							  ,Free_Running.BFRecetados('Abril','Octubre',@Inicio,@Fin,E.Codigo) 
							  ,Free_Running.BFRecetados('Mayo','Noviembre',@Inicio,@Fin,E.Codigo) 
							  ,Free_Running.BFRecetados('Junio','Diciembre',@Inicio,@Fin,E.Codigo) 
	from Free_Running.Especialidad E
	order by (select COUNT(*) Cantidad from Free_Running.Bono_Farmacia BF join Free_Running.Consulta C on (C.Id = BF.Consulta_Id)
										join Free_Running.Atencion_Medica AM on (Am.Id = C.Id_Atencion_Medica)
										join Free_Running.Llegada_Atencion_Medica LAM on (LAM.Id = AM.Llegada_Id)
										join Free_Running.Turno T on (LAM.Turno_Numero=T.Numero)
										where ((T.Fecha >= @Inicio) and (T.Fecha <= @Fin))and E.Codigo = T.Especialidad_Codigo
			) DESC
end
go





create view Free_Running.vistaAfiliadoUsoDist
as
select Bc.Afiliado_Utiliza,CBc.Fecha_Compra fecha
from Free_Running.Bono_Consulta Bc
	 join Free_Running.Compra_Bono_Consulta CBc on (BC.Id = CBc.Bono_Consulta)
	 join Free_Running.Paciente P on (P.Nro_Afiliado = Bc.Afiliado_Utiliza)
	 join Free_Running.Llegada_Atencion_Medica Lam on (lam.Bono_Consulta = Bc.Id)
where CBc.Afiliado_Compra<>Bc.Afiliado_Utiliza and Bc.Afiliado_Utiliza is not null
Union
select Bf.Afiliado_Utiliza,CBf.Fecha_Compra
from Free_Running.Bono_Farmacia Bf
	 join Free_Running.Compra_Bono_Farmacia CBf on (Bf.Id = CBf.Bono_Farmacia)
	 join Free_Running.Paciente P on (P.Nro_Afiliado = Bf.Afiliado_Utiliza)
	 join Free_Running.Consulta C on (C.Id = Bf.Consulta_Id)
	 join Free_Running.Atencion_Medica AM on (Am.Id = C.Id_Atencion_Medica)
where CBf.Afiliado_Compra<>Bf.Afiliado_Utiliza and Bf.Afiliado_Utiliza is not null
go

CREATE FUNCTION Free_Running.BonoUsoDist(@mes1 varchar(255) , @mes2 varchar(255),@Inicio DateTime,@Fin DateTime,@NroAfiliado numeric(18,8))
RETURNS numeric(18,8)
AS
BEGIN
DECLARE @Cant numeric(18,8)
SET @Cant = (select COUNT(*) Cantidad 
from Free_Running.vistaAfiliadoUsoDist vA
where ((vA.fecha >= @Inicio) and (vA.fecha <= @Fin))
and @NroAfiliado = vA.Afiliado_Utiliza
and (DATENAME(month,vA.fecha) = @mes1 or DATENAME(month,vA.fecha) = @mes2))
RETURN @Cant
END
Go



CREATE PROCEDURE Free_Running.AfiliadoUsoDist
    @Inicio DateTime,
    @Fin DateTime  
AS 
BEGIN
select top 10 P.Nro_Afiliado,P.Nombre,P.Apellido,Free_Running.BonoUsoDist('Enero','Julio',@Inicio,@Fin,P.Nro_Afiliado)
							  ,Free_Running.BonoUsoDist('Febrero','Agosto',@Inicio,@Fin,P.Nro_Afiliado) 
							  ,Free_Running.BonoUsoDist('Marzo','Septiembre',@Inicio,@Fin,P.Nro_Afiliado) 
							  ,Free_Running.BonoUsoDist('Abril','Octubre',@Inicio,@Fin,P.Nro_Afiliado) 
							  ,Free_Running.BonoUsoDist('Mayo','Noviembre',@Inicio,@Fin,P.Nro_Afiliado) 
							  ,Free_Running.BonoUsoDist('Junio','Diciembre',@Inicio,@Fin,P.Nro_Afiliado) 
from Free_Running.Paciente P
order by (select COUNT(*) from Free_Running.vistaAfiliadoUsoDist vA where ((vA.fecha >= @Inicio) and (vA.fecha <= @Fin)) and P.Nro_Afiliado = vA.Afiliado_Utiliza)
end
go



/*FUNCION PARA LA COMPRA DE BONOS */
CREATE FUNCTION [Free_Running].[calcula_plan_y_precio](@idCliente int)
returns TABLE
as
return
(
select p.Plan_Medico as PlanMedico,pm.Precio_Bono_Consulta as PrecioBonoConsulta,pm.Precio_Bono_Farmacia as PrecioBonoFarmacia
	 from Free_Running.Paciente p left join Free_Running.Plan_Medico pm on
		p.Plan_Medico=pm.Codigo
	 where p.Nro_Afiliado= @idCliente
)
GO


--cancelar turno------------------------------------------------------
CREATE PROCEDURE Free_Running.cancelarTurno(@idTurno int,@detalle varchar(255),@tipo varchar(255),@canceladoPor varchar(255))
AS
BEGIN
	insert into Free_Running.Turno_Cancelado(Turno_Numero,Cancelado_Por,Motivo,Tipo)
	values(@idTurno,@canceladoPor,@detalle,@tipo);
END
GO


--Vista que muestra los turnos no cancelados
create view Free_Running.turnosPendientes
as
(
select * from
	Free_Running.Turno t left join Free_Running.Turno_Cancelado tc 
	on (t.Numero=tc.Turno_Numero)
	where tc.id is null
 )
 GO
 
 
 
 --Funcion para la vista de cancelarTurnos
CREATE FUNCTION [Free_Running].[turnosDePaciente](@idPaciente int)
RETURNS TABLE    
AS
RETURN 
(
	select t.Numero,t.Fecha,e.Descripcion
	from Free_Running.turnosPendientes t right join Free_Running.Paciente p
		on (t.Nro_Afiliado=p.Nro_Afiliado)
		join Free_Running.Especialidad e on t.Especialidad_Codigo=e.Codigo
	where p.Nro_Afiliado=@idPaciente
	and t.fecha between GETDATE() and '01/01/2020'
)

GO
/*
CREATE FUNCTION Free_Running.diasAtencionMedico(@idMedico int)

RETURNS TABLE 
AS
RETURN 
(
	select a.Fecha_Inicio, a.Fecha_Fin,ad.Dia_Semana,ad.Hora_Inicio,ad.Hora_Fin
	from Free_Running.Agenda a left join Free_Running.Agenda_Dia ad on (a.Id=ad.Agenda)
		join Free_Running.Medico m on (a.Medico= m.Id)
	where m.Id=@idMedico
	
	
)
GO
*/

CREATE PROCEDURE Free_Running.usuarioExisteActivo(@nroAfiliado int, @salida int output)
AS
BEGIN
	if (ISNULL((select top 1 COUNT(*) from Free_Running.Paciente where Nro_Afiliado=@nroAfiliado group by Nro_Afiliado),0)<1)
		begin
		set @salida=0
		end
	else
		begin
		if ('Activo'=(select top 1 Estado from Free_Running.Paciente where Nro_Afiliado=@nroAfiliado))
			begin
			set @salida=-1
			end
		else
			begin
			set @salida=1
			end
		end
END
GO

CREATE FUNCTION Free_Running.turnoLibre(@fechaHoraTurno DateTime,@idMedico int) 
RETURNS TinyInt
AS
BEGIN
	if ((select COUNT(*) from Free_Running.Turno t left join
			Free_Running.Turno_Cancelado tc on t.Numero=tc.Turno_Numero 
			where t. Fecha= @fechaHoraTurno
			and tc.Id is null
			and t.Medico_Id=@idMedico)<>0)
		begin
		return 0
		end
	return 1
END
GO

create PROCEDURE Free_Running.cancelarTurnosDelDia(@dia varchar(20),@idMedico int,@motivo varchar(255),@tipo varchar(255))
as
BEGIN
	declare @diaACancelar DateTime;
	set @diaACancelar= CAST(@dia as DateTime) 
	begin transaction
		insert into Free_Running.Turno_Cancelado(Cancelado_Por,Turno_Numero,Motivo,Tipo)
		select 'Médico',t.Numero,@motivo,@tipo
		from Free_Running.Turno t left join Free_Running.Turno_Cancelado tc
		on t.Numero=tc.Turno_Numero
		where datepart(Year,t.Fecha) =DATEPART(year,@diaACancelar)
		and DATEPART(MONTH,t.Fecha) = DATEPART(month,@diaACancelar)
		and DATEPART(day,t.Fecha) = DATEPART(day,@diaACancelar)
		and tc.Id is null
		and t.Medico_Id=@idMedico
	commit transaction
END
GO


create procedure controlar_cant_medicamentos
@bono numeric(18,0)
as begin
return (select COUNT(*) from Free_Running.Medicamento_por_BonoFarmacia  where (Bono_Farmacia= @bono))
end

go

create procedure afiliadoAtencionMedica
 @atencionMedica int
as begin
return (select L.Nro_Afiliado
from Free_Running.Atencion_Medica AM
	 join Free_Running.Llegada_Atencion_Medica L on (AM.Llegada_Id = L.Id)
where @atencionMedica = AM.Id)
end

go
CREATE PROCEDURE Free_Running.puedeUsarBF @NroAfiliado numeric(18,0), @Bf numeric(18,0)
AS 
BEGIN
declare @rta int, @afilidoCompro numeric(18,0)

set @afilidoCompro = (select CBf.Afiliado_Compra from Free_Running.Compra_Bono_Farmacia CBf where CBf.Bono_Farmacia = @Bf)

set @rta = (select COUNT(*) 
		   from Free_Running.Bono_Farmacia Bf 
where Bf.Id = @Bf and Bf.Afiliado_Utiliza is null and
	  Bf.Plan_Correspondiente = (select P.Plan_Medico from Free_Running.Paciente P where P.Nro_Afiliado = @NroAfiliado) and
	   @afilidoCompro - (@afilidoCompro % 100)= @NroAfiliado - (@NroAfiliado % 100))
	   
return @rta
END
GO



CREATE  procedure [dbo].[obtener_Id]
as 
begin
declare @Id numeric(18,0)
set @Id=(select top 1 Id from Free_Running.Medico order by Id desc)
return @Id
end
go




CREATE  procedure [dbo].[Cantidad_afiliados]
@Nro_Afiliado numeric (18,0)
as begin
declare @result int 
if(exists(select Nro_Afiliado from Free_Running.Paciente where Nro_Afiliado=@Nro_Afiliado))
begin
set @result=1
end
else set @result=0
return @result
end
go



CREATE  procedure [dbo].[Cantidad_profesionales]
@Id numeric(18,0)
as begin
declare @result int 
if(exists(select Id from Free_Running.Medico where Id=@Id))
begin
set @result=1
end
else set @result=0
return @result
end
go





CREATE  procedure [dbo].[profesional_cargado]
@Documento numeric(18,0),
@Tipo_Documento varchar(255)
as 
begin
if((select Id from Free_Running.Medico where Documento=@Documento and Tipo_Documento=@Tipo_Documento) is not null)
return 1
else return 0
end
go




CREATE  procedure [dbo].[unicidad_de_datos]
@Documento numeric(18,0),
@Tipo_Documento varchar(255)
as 
begin
if((select Nro_Afiliado from Free_Running.Paciente where Documento=@Documento and Tipo_Documento=@Tipo_Documento) is not null)
return 1
else return 0
end
go



create PROCEDURE [dbo].[Obtener_Nro_afiliado]
as 
begin

return (select top 1 Nro_Afiliado from Free_Running.Paciente order by Nro_Afiliado desc )
end
go


create procedure [dbo].[numero_principal]
as 
begin
declare @Nro_Anterior numeric(18,0)
declare @Retorno numeric(18,0)

set @Nro_Anterior=(select top 1 Nro_Afiliado from Free_Running.Paciente order by Nro_Afiliado desc)
set @Retorno = (@Nro_Anterior-(@Nro_Anterior%100)+100)
return @Retorno
end
go

create procedure [dbo].[get_NroAfiliado]
as 
begin
declare @Nro_afiliado numeric(18,0)
set @Nro_afiliado= (select top 1 Nro_Afiliado from Free_Running.Paciente order by Nro_Afiliado desc)

return @Nro_afiliado
end
go

CREATE FUNCTION Free_Running.turnosLibresMedico(@medico int)

RETURNS TABLE 
AS
RETURN 
(
--un turno puede ser tomado cuando..
-- no esta relacionado con ningun turno y la fecha es mayor a hoy o...
-- cuando esta cancelado por el Afiliado y la fecha es mayor a hoy
	  select A.FechaHora_Turno 
	  from Free_Running.Agenda A left join Free_Running.Turno T on (T.Fecha = A.FechaHora_Turno and t.Medico_Id= a.Medico)
	  where (T.Numero is null or 
      exists (select * from Free_Running.Turno_Cancelado TC where TC.Turno_Numero = T.Numero and TC.Cancelado_Por = 'Afiliado'))
      and getdate() < A.FechaHora_Turno 
      and A.Medico = @medico

)
GO


CREATE PROCEDURE Free_Running.comprarBonosConsulta(@Afiliado_Compra int,@precio int, @plan int, @cantidad int)
AS
BEGIN
	declare @contador int
	set @contador=0
	--begin transaction
	while (@contador<@cantidad)
		begin
		insert into Free_Running.Bono_Consulta(Plan_Correspondiente,Precio)
		values(@plan,@precio)
		insert into Free_Running.Compra_Bono_Consulta(Fecha_Compra,Afiliado_Compra,Bono_Consulta)
		values(GETDATE(),@Afiliado_Compra,@@IDENTITY)
		set @contador=@contador+1
		end
	--commit transaction
END
GO

CREATE PROCEDURE Free_Running.comprarBonosFarmacia(@Afiliado_Compra int,@precio int, @plan int, @cantidad int)
AS
BEGIN
	declare @contador int
	set @contador=0
	--begin transaction
	while (@contador<@cantidad)
		begin
		insert into Free_Running.Bono_Farmacia(Fecha_Vencimiento,Plan_Correspondiente,Precio)
		values(Free_Running.calcula_fecha_vencimiento(GETDATE()),@plan,@precio)
		insert into Free_Running.Compra_Bono_Farmacia(Fecha_Compra,Afiliado_Compra,Bono_Farmacia)
		values(GETDATE(),@Afiliado_Compra,@@IDENTITY)
		set @contador=@contador+1
		end
	--commit transaction
END
GO
