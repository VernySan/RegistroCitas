CREATE VIEW [dbo].[vCita]
	AS 
SELECT c.[IdCita]
      ,c.[Fecha]
      ,c.[idHorario]
      ,c.[idDoctor]
      ,d.[Nombre] as Doctor
      ,c.[idPaciente]
	  ,p.[Nombre] as Paciente
      ,c.[idServicio]
	  ,s.[Servicio]
FROM 
  [dbo].[Cita] c
    inner join
  [dbo].[Doctor] d
    on c.idDoctor = d.Cedula
	inner join 
  [dbo].[Paciente] p
    on c.idPaciente = p.Pasaporte
	inner join 
  [dbo].[Servicio] s
    on c.idServicio = s.IdServicio
