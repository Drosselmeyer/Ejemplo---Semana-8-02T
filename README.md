# Ejemplo---Semana-8-02T

SQL para base de datos
CREATE DATABASE Colegio;
USE Colegio;

CREATE TABLE Alumno(
	Id INT PRIMARY KEY,
	Carnet VARCHAR(MAX) NOT NULL,
	Nombre VARCHAR(MAX) NOT NULL,
	Carrera VARCHAR(MAX) NOT NULL
);

INSERT INTO  Alumno(Id, Carnet, Nombre, Carrera) VALUES
(1,'EG161132','Jonathan Escalante','Ing. En CC de la Computacion');

SELECT TOP 1 * FROM Alumno;
