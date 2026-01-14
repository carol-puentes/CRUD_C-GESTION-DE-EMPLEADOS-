CREATE PROC SP_GUARDAR_EMPLEADOS
@cNombre VARCHAR(100),
@cDireccion VARCHAR(150),
@dFechaNacimiento DATE,
@cTelefono VARCHAR(80),
@nSalario MONEY,
@nIdDepartamento INT,
@nIdCargo INT
AS
INSERT INTO empleados (
    nombre_empleado,
    direccion_empleado,
    fecha_nacimiento_empleado,
    telefono_empleado,
    salario_empleado,
    id_departamento,
    id_cargo,
    activo_empleado
)
VALUES (
    @cNombre,
    @cDireccion,
    @dFechaNacimiento,
    @cTelefono,
    @nSalario,
    @nIdDepartamento,
    @nIdCargo,
    1
);
GO