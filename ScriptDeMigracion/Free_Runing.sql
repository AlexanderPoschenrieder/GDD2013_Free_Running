--///////////////////////////////////////////SELECCION BdD///////////////////////////////////////////--

use GD2C2013
go

--///////////////////////////////////////////CREACION ESQUEMA///////////////////////////////////////////--

CREATE SCHEMA Free_Running AUTHORIZATION gd
GO


--///////////////////////////////////////////CREACION TABLAS///////////////////////////////////////////--

go

--TABLA PACIENTES: Tabla de todos los Pacientes de la Clinica - esten o no activos 

CREATE TABLE Free_Running.Paciente (
Nro_Afiliado numeric(18, 0) NOT NULL identity(100,100),
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
Medico_Id numeric(18, 0) NOT NULL,
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
Fecha_Inicio date NOT NULL,
Fecha_Fin date NOT NULL,
CONSTRAINT PK_Agenda PRIMARY KEY CLUSTERED (Id ASC)
)
GO


--TABLA AGENDA DIA: Relaciona una Agenda de un determinado Medico con los Dias que Atiene este
CREATE TABLE Free_Running.Agenda_Dia(
Agenda numeric(18, 0) NOT NULL,
Id numeric(18, 0) NOT NULL identity(1,1),
Dia_Semana varchar(255) NOT NULL,
Hora_Inicio	time NOT NULL,
Hora_Fin	time NOT NULL,
CONSTRAINT PK_Agenda_Dia PRIMARY KEY CLUSTERED (Id ASC)
)
GO

--TABLA BONO CONSULTA: Contiene TODOS los Bonos Consulta Comprados Cancelados o No, Utilizados o No
CREATE TABLE Free_Running.Bono_Consulta (  --Fecha Imprecion Va (en la tabla maestra esta?
Id numeric(18, 0) NOT NULL identity(1,1),
Fecha_Compra	datetime NOT NULL, 
Numero	numeric(18, 0) NULL, -- propio de cada paciente indica la cant de consultas de un paciente
Afiliado_Compra numeric(18, 0) NOT NULL,
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


--TABLA BONO FARMACIA: Contiene TODOS los Bonos Farmacia Comprados, Vencidos o No, Utilizados o No
CREATE TABLE Free_Running.Bono_Farmacia (
Fecha_Compra	datetime NOT NULL,
Id	numeric(18, 0) NOT NULL identity(1,1),
Fecha_Vencimiento	datetime NOT NULL,
Fecha_Preinscripcion_Medicamento	varchar(255) NULL,
Plan_Correspondiente numeric(18, 0) NOT NULL,
Afiliado_Compra numeric(18, 0) NOT NULL,
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



--TABLA RENGLON Medicamento:
CREATE TABLE Free_Running.Medicamento (
Id	numeric(18, 0) NOT NULL identity(1,1),
Bono_Farmacia numeric(18, 0) NOT NULL,
Medicamento varchar(255) NOT NULL,
Cantidad numeric(18, 0) NULL,
Aclaracion_Cantidad varchar(255) NULL,
CONSTRAINT PK_Renglon_Receta PRIMARY KEY CLUSTERED (Id ASC)
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
 
 
 
 
 
 ALTER TABLE Free_Running.Medicamento ADD CONSTRAINT FK_Medicamento_Bono FOREIGN KEY (Bono_Farmacia) 
 REFERENCES Free_Running.Bono_Farmacia(Id) 
 GO
 
 
  
 
 
 ALTER TABLE Free_Running.Consulta ADD CONSTRAINT FK_Id_Atencion_Medica  FOREIGN KEY (Id_Atencion_Medica) 
 REFERENCES Free_Running.Atencion_Medica(Id) 
 GO
 
 
 

 ALTER TABLE Free_Running.Bono_Farmacia ADD CONSTRAINT FK_Bono_Farmacia FOREIGN KEY (Consulta_Id) 
 REFERENCES Free_Running.Consulta(Id) 
 GO
 ALTER TABLE Free_Running.Bono_Farmacia ADD CONSTRAINT FK_Bono_Farmacia_Afiliado_Compra FOREIGN KEY (Afiliado_Compra) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 ALTER TABLE Free_Running.Bono_Farmacia ADD CONSTRAINT FK_Bono_Farmacia_Afiliado_Utiliza FOREIGN KEY (Afiliado_Utiliza) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
 GO
 ALTER TABLE Free_Running.Bono_Farmacia ADD CONSTRAINT FK_Bono_Farmacia_Plan_Correspondiente FOREIGN KEY (Plan_Correspondiente) 
 REFERENCES Free_Running.Plan_Medico(Codigo) 
 GO
 
 
 
 
 
 ALTER TABLE Free_Running.Bono_Consulta ADD CONSTRAINT FK_Bono_Consulta_Afiliado_Compra FOREIGN KEY (Afiliado_Compra) 
 REFERENCES Free_Running.Paciente(Nro_Afiliado) 
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
 GO
 
 ALTER TABLE Free_Running.Agenda_Dia ADD CONSTRAINT FK_Agenda FOREIGN KEY (Agenda) 
 REFERENCES Free_Running.Agenda(Id) 
 ON update cascade
 ON delete cascade
 go







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
INSERT INTO Free_Running.Paciente(Nombre,Apellido,Documento,Direccion,Telefono,Mail,Fecha_Nac,Sexo,Tipo_Documento,Estado_Civil,Cant_Familiares,Plan_Medico,Estado)
SELECT distinct g1.Paciente_Nombre,g1.Paciente_Apellido,g1.Paciente_Dni,g1.Paciente_Direccion,g1.Paciente_Telefono,g1.Paciente_Mail,g1.Paciente_Fecha_Nac,'F','DNI','Soltero',
	   0,
	   g1.Plan_Med_Codigo,'Activo'
FROM gd_esquema.Maestra g1
where not((( g1.Turno_Fecha is null) and ( g1.Compra_Bono_Fecha is null)))





		--Creo Indices
		CREATE INDEX iNDICE_DOCUMENTO ON Free_Running.Paciente (Documento);
		CREATE INDEX iNDICE_NroAfiliado ON Free_Running.Paciente (Nro_Afiliado);
		
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
select M.Turno_numero,'Sistema','No se realizo la consulta'
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
	


INSERT INTO Free_Running.Turno_Cancelado(Turno_Numero,Tipo,Motivo)
select M.Turno_numero, 'Sistema','Fecha del Turno Superior al permitido'
from gd_esquema.Maestra M
where Turno_Fecha is not null 
Group by M.Turno_Numero,M.Turno_Fecha
Having (COUNT(M.Turno_Numero)=1 and M.Turno_Fecha > GETDATE()+120 )



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
INSERT INTO Free_Running.Bono_Consulta(Id,Fecha_Compra,Numero,Afiliado_Compra,Afiliado_Utiliza,Precio,Plan_Correspondiente)

select  M.Bono_Consulta_Numero,M.Compra_Bono_Fecha,
	
	(select  Count(distinct M2.Bono_Consulta_Numero)
	 from gd_esquema.Maestra M2
	 where (M.Compra_Bono_Fecha is not null and 
			M.Bono_Consulta_Numero is not null and 
			M.Paciente_Dni = M2.Paciente_Dni and 
			M.Bono_Consulta_Numero >= M2.Bono_Consulta_Numero )),
	 
	Free_Running.suNroAfiliado(M.Paciente_Dni),
	 
	 (select P.Nro_Afiliado 
	 from gd_esquema.Maestra M3 
	 join Free_Running.Paciente P on M3.Paciente_Dni=P.Documento 
	 where  M.Bono_Consulta_Numero = M3.Bono_Consulta_Numero and 
			M3.Turno_Numero is not null and 
			M3.Bono_Consulta_Numero is not null),
	 
	((select top 1 P.Precio_Bono_Consulta
	from Free_Running.Plan_Medico P
	where M.Plan_Med_Codigo = P.Codigo)),
	
	M.Plan_Med_Codigo

from gd_esquema.Maestra M
where (M.Compra_Bono_Fecha is not null and M.Bono_Consulta_Numero is not null)
SET IDENTITY_INSERT Free_Running.Bono_Consulta OFF
go





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
		CREATE INDEX iNDICE_LAM2 ON Free_Running.Llegada_Atencion_Medica(Id)
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
go
INSERT INTO Free_Running.Bono_Farmacia(Id,Fecha_Compra,Fecha_Vencimiento,Afiliado_Compra,Afiliado_Utiliza,Precio,Consulta_Id,Plan_Correspondiente)
select M.Bono_Farmacia_Numero,M.Compra_Bono_Fecha,M.Bono_Farmacia_Fecha_Vencimiento,
		(Free_Running.suNroAfiliado(M.Paciente_Dni)) COMPRA,
		
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
go








INSERT INTO Free_Running.Medicamento(Bono_Farmacia,Medicamento)
select BF.Id,M.Bono_Farmacia_Medicamento
from Free_Running.Bono_Farmacia BF join Free_Running.Consulta C on C.Id = BF.Consulta_Id
	 join Free_Running.Atencion_Medica AM on C.Id_Atencion_Medica=AM.Id
	 join Free_Running.Llegada_Atencion_Medica LAM on LAM.Id=AM.Llegada_Id
	 join gd_esquema.Maestra M on M.Bono_Farmacia_Numero = LAM.Bono_Consulta
Where M.Bono_Farmacia_Numero is Not null and M.Compra_Bono_Fecha is null







--Agenda
--Cada Medico tiene una Adenda Actual (kedan registradas las anteriores). Cada Agenda es valida x un Periodo
--Actualmente Cada Medico Tiene una sola a partir del dia de migracio, tomando todos las fechas menores a 120 dias

INSERT INTO Free_Running.Agenda(Medico,Fecha_Inicio,Fecha_Fin)
select Me.Id,(SELECT DATEADD(dd, 0, DATEDIFF(dd, 0,MIN(T.Fecha)))), (SELECT DATEADD(dd, 0, DATEDIFF(dd, 0,MAX(T.Fecha))))
from Free_Running.Medico Me join Free_Running.Turno T on T.Medico_Id = Me.Id
where T.Fecha between getdate() and (getdate()+120)
Group by Me.Id




--Agenda dia
--x cada Agenda.... Muestra Cuando Empieza y Cuando Termina un Medico Su Horario de Trabajo x dia de semana.
--Puede ser que un dia de semana tenga 2 periodos (rangos)

INSERT INTO Free_Running.Agenda_Dia(Agenda,Dia_Semana,Hora_Inicio,Hora_Fin)
select distinct A.Id,datename(dw,DATEADD(D, 0, DATEDIFF(D, 0, Turno_Fecha))),MIN(convert(varchar, Turno_Fecha, 8)),MAX(convert(varchar, Turno_Fecha, 8))
From gd_esquema.Maestra M 
	 join Free_Running.Medico Me on Me.Documento=M.Medico_Dni
	 join  Free_Running.Agenda A on A.Medico=Me.Id
where M.Turno_Numero is not null and M.Turno_Fecha  between A.Fecha_Inicio and A.Fecha_Fin
Group by A.Id,datename(dw,DATEADD(D, 0, DATEDIFF(D, 0, Turno_Fecha)))
having datename(dw,DATEADD(D, 0, DATEDIFF(D, 0, Turno_Fecha))) <> 'Domingo'


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

CREATE PROCEDURE Free_Running.agregarIntentoFallido 
    --@Fecha datetime, 
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

CREATE PROCEDURE Free_Running.existeAgenda 
    @Medico numeric(18, 0)
AS 
BEGIN

		Select top 1 * 
		from Free_Running.Agenda A 
		where(A.Medico = @Medico)

END
GO




CREATE PROCEDURE Free_Running.EspeMasCanceladas 
    @Inicio DateTime,
    @Fin DateTime  
AS 
BEGIN
	select top 5 T.Especialidad_Codigo Especialidad, COUNT(*) Cantidad
	from Free_Running.Turno_Cancelado TC join Free_Running.Turno T on (TC.Turno_Numero = T.Numero)
	where ((T.Fecha >= @Inicio) and (T.Fecha <= @Fin))
	Group by T.Especialidad_Codigo
	order by 2 DESC
END
go


CREATE PROCEDURE Free_Running.AfiliadoBFvenc 
    @Inicio DateTime,
    @Fin DateTime  
AS 
BEGIN
	select top 5 P.Nro_Afiliado Afiliado, COUNT(*) Cantidad
	from Free_Running.Bono_Farmacia BF join Free_Running.Bono_Farmacia_Vencido V on (V.Bono_Farmacia_Id = BF.Id)
		 join Free_Running.Paciente P on (BF.Afiliado_Compra = P.Nro_Afiliado)
	where ((BF.Fecha_Compra >= @Inicio) and (BF.Fecha_Compra <= @Fin))
	Group by P.Nro_Afiliado
	order by 2 DESC
END
go



CREATE PROCEDURE Free_Running.EspMasCanc
    @Inicio DateTime,
    @Fin DateTime  
AS 
BEGIN
select top 5 T.Especialidad_Codigo,Count(BF.Id)
From Free_Running.Bono_Farmacia BF join Free_Running.Consulta C on (C.Id = BF.Consulta_Id)
	 join Free_Running.Atencion_Medica AM on (Am.Id = C.Id_Atencion_Medica)
	 join Free_Running.Llegada_Atencion_Medica LAM on (LAM.Id = AM.Llegada_Id)
	 join Free_Running.Turno T on (LAM.Turno_Numero=T.Numero)
where ((BF.Fecha_Compra >= @Inicio) and (BF.Fecha_Compra <= @Fin))
group by T.Especialidad_Codigo
Order by 2 DESC
end


go
CREATE PROCEDURE Free_Running.AfiliadoUsoDist
    @Inicio DateTime,
    @Fin DateTime  
AS 
BEGIN
select top 10 A.Afiliado_Compra, cant
from(
select Bc.Afiliado_Compra,Count(Bc.Afiliado_Utiliza) cant
from Free_Running.Bono_Consulta Bc
where Bc.Afiliado_Compra<>Bc.Afiliado_Utiliza and ((Bc.Fecha_Compra >= @Inicio) and (Bc.Fecha_Compra <= @Fin))
group by Bc.Afiliado_Compra
UNION
select B.Afiliado_Compra,Count(B.Afiliado_Utiliza) cant
from Free_Running.Bono_Farmacia B
where B.Afiliado_Compra<>B.Afiliado_Utiliza and ((B.Fecha_Compra >= @Inicio) and (B.Fecha_Compra <= @Fin))
group by B.Afiliado_Compra
)
 A
end




go
/*FUNCION PARA LA COMPRA DE BONOS */
CREATE function [Free_Running].[calcula_plan_y_precio](@idCliente int)
returns TABLE
as 
return
(
select select p.Plan_Medico as PlanMedico,pm.Precio_Bono_Consulta as PrecioBonoConsulta,pm.Precio_Bono_Farmacia as PrecioBonoFarmacia
	 from Free_Running.Paciente p left join Free_Running.Plan_Medico pm on
		p.Plan_Medico=pm.Codigo
	 where p.Nro_Afiliado= @idCliente
);


go


--Trigger para calcular la fecha actual
CREATE TRIGGER insteadInsertTriggerConsulta
   ON  Free_Running.Bono_Consulta
   instead of INSERT
AS 
BEGIN
	insert into Free_Running.Bono_Consulta(Fecha_Compra,Plan_Correspondiente,Afiliado_Compra,Precio)
	select GETDATE(),i.Plan_Correspondiente,i.Afiliado_Compra,i.Precio
	from inserted i
END
GO
					
					
					--Guarda la fecha de vencimiento al momento de hacer el insert
CREATE TRIGGER insteadInsertTriggerFarmacias
   ON  Free_Running.Bono_Farmacia
   Instead of INSERT
AS 
BEGIN
	insert into Free_Running.Bono_Farmacia
	(Fecha_Compra,Fecha_Vencimiento,Plan_Correspondiente,Afiliado_Compra,Precio)
	select GETDATE(),Free_Running.calcula_fecha_vencimiento(GETDATE()),i.Plan_Correspondiente,i.Afiliado_Compra,i.Precio
	from inserted i
END
GO
