DROP DATABASE IF EXISTS Orange;
CREATE DATABASE Orange;

use Orange 

create table administradores(
	id int primary key identity (1,1),
	nombre varchar(50) not null, 
	apellido varchar(50)not null,
	contrasena varchar(50)not null
)
create table profesores(
	id int primary key identity(1,1), 
	nombre varchar(50)not null, 
	apellido varchar(50)not null, 
	salario int not null
)
create table alumnos(
	id int primary key identity(1,1), 
	nombre varchar(50)not null, 
	apellido varchar(50)not null, 
	matricula int not null, 
	bono int not null,
	adicional int not null, 
	fecha_ing date not null
)

insert into administradores (nombre, apellido, contrasena) values ('stotomas',' ', 'password123')