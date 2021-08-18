CREATE PROCEDURE [dbo].[CitaObtener]
	@IdCita INT=NULL,
    @Fecha date=NULL
AS BEGIN
	SET NOCOUNT ON

	if   IsNull(@IdCita,-1)=-1 --Consulta por fecha
	  begin
		SELECT
			C.IdCita,
			h.[idHorario],
			@Fecha Fecha,
			h.[Inicio],
			h.[Fin],
			c.[IdDoctor],
			c.[Doctor],
			c.[IdPaciente],
			c.[Paciente],
			c.[IdServicio],
			c.[Servicio]
		FROM 
		  [dbo].[Horario] h
			left join 
		  [dbo].[vCita] c
			on h.IdHorario = c.IdHorario
			and c.fecha = @Fecha
		WHERE
		   h.[Estado] = 1;

	  end else begin

	  --Consulta por ID
		SELECT
			C.IdCita,
			h.[idHorario],
			c.[Fecha],
			h.[Inicio],
			h.[Fin],
			c.[IdDoctor],
			c.[Doctor],
			c.[IdPaciente],
			c.[Paciente],
			c.[IdServicio],
			c.[Servicio]
		FROM 
		  [dbo].[Horario] h
			left join 
		  [dbo].[vCita] c
			on h.IdHorario = c.IdHorario
		WHERE
		   h.[Estado] = 1
		   and (@IdCita IS NULL OR IdCita=@IdCita);

	  end

END