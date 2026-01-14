CREATE PROC SP_LISTAR_DEPARTAMENTOS
AS
SELECT id_departamento, nombre_departamente
FROM departamentos
WHERE activo_departamento = 1;
GO
