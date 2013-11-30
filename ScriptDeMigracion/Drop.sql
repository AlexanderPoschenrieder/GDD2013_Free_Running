------ELIMINAR TODO


DROP TABLE Free_Running.Agenda_Dia
DROP TABLE Free_Running.Agenda
DROP TABLE Free_Running.Bono_Consulta_Cancelado
DROP TABLE Free_Running.Bono_Farmacia_Vencido
DROP TABLE Free_Running.Funcionalidad_por_Rol
DROP TABLE Free_Running.Historial_Plan_Med
DROP TABLE Free_Running.Intentos_Fallidos
DROP TABLE Free_Running.Turno_Cancelado
DROP TABLE Free_Running.Medicamento
DROP TABLE Free_Running.Usuario_por_Rol
DROP TABLE Free_Running.Funcionalidad
DROP TABLE Free_Running.Rol
DROP TABLE Free_Running.Especialidad_Por_Med
DROP TABLE Free_Running.Medicamento
DROP TABLE Free_Running.Consulta
DROP TABLE Free_Running.Atencion_Medica
DROP TABLE Free_Running.Llegada_Atencion_Medica
DROP TABLE Free_Running.Turno
DROP TABLE Free_Running.Medico
DROP TABLE Free_Running.Especialidad
DROP TABLE Free_Running.Tipo_Especialidad
DROP TABLE Free_Running.Bono_Consulta
DROP TABLE Free_Running.Bono_Farmacia
DROP TABLE Free_Running.Paciente
DROP TABLE Free_Running.Usuario
DROP TABLE Free_Running.Plan_Medico
DROP TABLE Free_Running.Tipo_Cancelado
DROP TABLE Free_Running.Compra_Bono_Consulta
DROP TABLE Free_Running.Compra_Bono_Farmacia
DROP TABLE Free_Running.Medicamento_por_BonoFarmacia


DROP FUNCTION Free_Running.CantIntentosActual
DROP PROCEDURE Free_Running.agregarIntentoFallido
DROP PROCEDURE Free_Running.borrarIntentoFallido
DROP FUNCTION Free_Running.calcula_fecha_vencimiento
DROP FUNCTION Free_Running.suNroAfiliado
DROP FUNCTION Free_Running.suNroAtencion
DROP PROCEDURE Free_Running.existeAgenda 
DROP PROCEDURE Free_Running.EspeMasCanceladas 
DROP PROCEDURE Free_Running.AfiliadoBFvenc 
DROP PROCEDURE Free_Running.AfiliadoUsoDist
DROP PROCEDURE Free_Running.EspMasCanc
DROP VIEW Free_Running.turnosPendientes
DROP PROCEDURE Free_Running.cancelarTurno
DROP PROCEDURE Free_Running.cancelarTurnosDelDia
DROP FUNCTION Free_Running.calcula_plan_y_precio
DROP FUNCTION Free_Running.turnosDePaciente
DROP FUNCTION Free_Running.turnoLibre
DROP FUNCTION Free_Running.calcularNroAfiliado
DROP PROCEDURE Free_Running.InsertarPrincipal
DROP PROCEDURE Free_Running.usuarioExisteActivo
DROP FUNCTION Free_Running.suIdAfiliado
DROP PROCEDURE Free_Running.puedeUsarBC
DROP schema Free_Running