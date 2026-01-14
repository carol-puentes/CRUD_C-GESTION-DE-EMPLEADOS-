CREATE PROC SP_DESACTIVAR_EMPLEADOS
@nIdEmpleado INT
AS
UPDATE empleados
SET activo_empleado = 0
WHERE id_empleado = @nIdEmpleado;
GO

CREATE PROC SP_LISTAR_CARGOS
AS
SELECT id_cargo, nombre_cargo
FROM cargos
WHERE activo_cargo = 1;
GO