CREATE PROC SP_LISTAR_EMPLEADOS
@cBusqueda VARCHAR(100) = ''
AS
SELECT
    e.id_empleado AS ID,
    e.nombre_empleado AS Nombre,
    d.nombre_departamente AS Departamento,
    c.nombre_cargo AS Cargo,
    e.salario_empleado AS Salario,
    e.direccion_empleado AS Direccion,
    e.telefono_empleado AS Telefono,
    e.fecha_nacimiento_empleado AS [Fecha Nacimiento]
FROM empleados e
INNER JOIN departamentos d ON e.id_departamento = d.id_departamento
INNER JOIN cargos c ON e.id_cargo = c.id_cargo
WHERE e.activo_empleado = 1
AND UPPER(
    e.nombre_empleado +
    d.nombre_departamente +
    c.nombre_cargo
) LIKE '%' + UPPER(@cBusqueda) + '%';
GO