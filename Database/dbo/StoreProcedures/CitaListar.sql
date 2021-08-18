CREATE PROCEDURE [dbo].[CitaListar]
	@IdCita INT=NULL,
    @Fecha date=NULL
AS BEGIN
	SET NOCOUNT ON

	if   IsNull(@IdCita,-1)=-1 --Consulta por fecha
	  begin
	SELECT c.[IdCita]
		  ,d.[Nombre] + ' ' + d.PrimerApellido + ' ' + d.SegundoApellido Doctor
		  ,e.Especialidad
		  ,p.[Nombre] + ' ' + p.PrimerApellido + ' ' + p.SegundoApellido as Paciente
		  ,p.Cedula
		  ,p.Telefono
		  ,s.[Servicio] as Consulta
		  ,s.Procedimiento
		  ,c.[Fecha]
		  ,h.Inicio
		  ,s.Precio
	FROM 
	  [dbo].[Cita] c
		inner join
	  [dbo].[Horario] h
	    on c.idHorario = h.IdHorario
	    inner join 
	  [dbo].[Doctor] d
		on c.idDoctor = d.Cedula
		inner join 
	  [dbo].[Especialidad] e
	    on d.IdEspecialidad = e.IdEspecialidad
		inner join
	  [dbo].[Paciente] p
		on c.idPaciente = p.Pasaporte
		inner join 
	  [dbo].[Servicio] s
		on c.idServicio = s.IdServicio
	WHERE
	  c.fecha = @Fecha;

	  end else begin

	  --Consulta por ID
	SELECT c.[IdCita]
		  ,d.[Nombre] + ' ' + d.PrimerApellido + ' ' + d.SegundoApellido Doctor
		  ,e.Especialidad
		  ,p.[Nombre] + ' ' + p.PrimerApellido + ' ' + p.SegundoApellido as Paciente
		  ,p.Cedula
		  ,p.Telefono
		  ,s.[Servicio] as Consulta
		  ,s.Procedimiento
		  ,c.[Fecha]
		  ,h.Inicio
		  ,s.Precio
	FROM 
	  [dbo].[Cita] c
		inner join
	  [dbo].[Horario] h
	    on c.idHorario = h.IdHorario
	    inner join 
	  [dbo].[Doctor] d
		on c.idDoctor = d.Cedula
		inner join 
	  [dbo].[Especialidad] e
	    on d.IdEspecialidad = e.IdEspecialidad
		inner join
	  [dbo].[Paciente] p
		on c.idPaciente = p.Pasaporte
		inner join 
	  [dbo].[Servicio] s
		on c.idServicio = s.IdServicio
	WHERE
	  c.IdCita=@IdCita;

	  end

END