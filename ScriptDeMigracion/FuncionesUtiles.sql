
CREATE FUNCTION Free_Running.turnosLibresMedico(@medico int)

RETURNS TABLE 
AS
RETURN 
(
	select a.FechaHora_Turno from Free_Running.Agenda a
	where
	a.FechaHora_Turno <> all (select t.Numero --Los turnos no cancelados
		from Free_Running.Turno t left join Free_Running.Turno_Cancelado tc1 on tc1.Turno_Numero=t.Numero
		where t.Numero <> all(select tc.Turno_Numero from  Free_Running.Turno_Cancelado tc ) )
	and
	GETDATE()< a.FechaHora_Turno
	and
	a.Medico=@medico
	
)
GO
