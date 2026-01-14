CREATE PROC SP_ACTUALIZAR_EMPLEADOS
@nIdEmpleado INT,
@cNombre VARCHAR(100),
@cDireccion VARCHAR(150),
@dFechaNacimiento DATE,
@cTelefono VARCHAR(80),
@nSalario MONEY,
@nIdDepartamento INT,
@nIdCargo INT
AS
UPDATE empleados
SET nombre_empleado = @cNombre,
    direccion_empleado = @cDireccion,
    fecha_nacimiento_empleado = @dFechaNacimiento,
    telefono_empleado = @cTelefono,
    salario_empleado = @nSalario,
    id_departamento = @nIdDepartamento,
    id_cargo = @nIdCargo
WHERE id_empleado = @nIdEmpleado;
GO