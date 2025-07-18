CREATE DATABASE PruebaSD;
GO

USE PruebaSD;
GO

CREATE TABLE Usuario (
    usuID NUMERIC(18,2) NOT NULL PRIMARY KEY,
    nombre VARCHAR(100),
    apellido VARCHAR(100)
);
GO

INSERT INTO Usuario (usuID, nombre, apellido) VALUES
(1, 'Juan', 'Pérez'),
(2, 'María', 'Gómez'),
(3, 'Carlos', 'Ramírez'),
(4, 'Ana', 'Martínez'),
(5, 'Luis', 'Torres');
