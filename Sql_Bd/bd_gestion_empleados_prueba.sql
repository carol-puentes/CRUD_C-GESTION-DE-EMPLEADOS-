/* =====================================================
   CREACIÓN DE BASE DE DATOS + ESTRUCTURA COMPLETA
   bd_gestion_empleados_prueba
   ===================================================== */

USE master;
GO

IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = 'bd_gestion_empleados_prueba')
BEGIN
    CREATE DATABASE bd_gestion_empleados_prueba;
END
GO

USE bd_gestion_empleados_prueba;
GO

/* =========================
   TABLA: cargos
   ========================= */
CREATE TABLE cargos (
    id_cargo INT IDENTITY(1,1) PRIMARY KEY,
    nombre_cargo VARCHAR(50),
    activo_cargo BIT
);
GO

/* =========================
   TABLA: departamentos
   ========================= */
CREATE TABLE departamentos (
    id_departamento INT IDENTITY(1,1) PRIMARY KEY,
    nombre_departamente VARCHAR(50),
    activo_departamento BIT
);
GO

/* =========================
   TABLA: empleados
   ========================= */
CREATE TABLE empleados (
    id_empleado INT IDENTITY(1,1) PRIMARY KEY,
    nombre_empleado VARCHAR(100),
    direccion_empleado VARCHAR(150),
    fecha_nacimiento_empleado DATE,
    telefono_empleado VARCHAR(20),
    salario_empleado MONEY,
    id_departamento INT,
    id_cargo INT,
    activo_empleado BIT
);
GO

/* =========================
   RELACIONES
   ========================= */
ALTER TABLE empleados
ADD CONSTRAINT fk_empleado_departamento
FOREIGN KEY (id_departamento)
REFERENCES departamentos(id_departamento);
GO

ALTER TABLE empleados
ADD CONSTRAINT fk_empleado_cargo
FOREIGN KEY (id_cargo)
REFERENCES cargos(id_cargo);
GO