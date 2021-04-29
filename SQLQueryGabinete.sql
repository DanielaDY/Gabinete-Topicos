CREATE DATABASE Abogados;
CREATE TABLE Clientes(
DNI_Cliente varchar primary key not null,
Name_Cliente varchar (50),
Apellido_Cliente varchar (50),
Dir_Cliente varchar (50),
Fecha_nacc varchar (50)
);

CREATE TABLE Asuntos(
No_exp int primary key not null,
FInicio date,
FFinal date,
Estado_exp varchar(50),
DNI_Cliente varchar not null,
ID_proc int not null,
FOREIGN KEY (DNI_Cliente) REFERENCES Clientes (DNI_Cliente)
FOREIGN KEY (ID_proc) REFERENCES Clientes (ID_proc)
);

CREATE TABLE Procuradores(
ID_proc int primary key not null,
Name_proc varchar (50),
Apellido_proc varchar (50),
Dir_proc varchar (50),
Fecha_nacp varchar (50)
);

CREATE TABLE Asunto_Procurador(
No_exp int not null,
ID_proc int not null,
FOREIGN KEY (No_exp) REFERENCES Asuntos (No_exp),
FOREIGN KEY (ID_proc) REFERENCES Procuradores (ID_proc)
);