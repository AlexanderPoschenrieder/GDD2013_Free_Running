
CREATE FUNCTION Free_Running.turnosLibresMedico(@medico int)

RETURNS TABLE 
AS
RETURN 
(
--un turno puede ser tomado cuando..
-- no esta relacionado con ningun turno y la fecha es mayor a hoy o...
-- cuando esta cancelado por el Afiliado y la fecha es mayor a hoy
	  select A.FechaHora_Turno 
	  from Free_Running.Agenda A left join Free_Running.Turno T on (T.Fecha = A.FechaHora_Turno)
	  where (T.Numero is null or 
      exists (select * from Free_Running.Turno_Cancelado TC where TC.Turno_Numero = T.Numero and TC.Cancelado_Por = 'Afiliado'))
      and getdate() < A.FechaHora_Turno 
      and A.Medico = @medico
     /* 
	select a.FechaHora_Turno from Free_Running.Agenda a
	where
	a.FechaHora_Turno <> all (select t.Numero --Los turnos no cancelados
		from Free_Running.Turno t left join Free_Running.Turno_Cancelado tc1 on tc1.Turno_Numero=t.Numero
		where t.Numero <> all(select tc.Turno_Numero from  Free_Running.Turno_Cancelado tc ) )
	and
	GETDATE()< a.FechaHora_Turno
	and
	a.Medico=@medico
	*/
)
GO

