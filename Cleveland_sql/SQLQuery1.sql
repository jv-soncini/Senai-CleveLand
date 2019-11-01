create database T_Cleveland

use T_Cleveland


select * from Medicos
create table Medicos
(
	IdMedico		int primary key identity not null
	,Nome			varchar(255) not null
	,DataNascimento	date not null
	,crm			int not null unique
);

insert into Medicos

