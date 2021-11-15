CREATE TABLE Tipo(
id INTEGER PRIMARY KEY AUTO_INCREMENT,
tipo VARCHAR(15),
descripción VARCHAR(80)
);

CREATE TABLE Empresa(
id INTEGER PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(15) NOT NULL,
tipoId INTEGER NOT NULL,
CONSTRAINT fk_Tipo FOREIGN KEY (tipoId) REFERENCES Tipo(id)
);

CREATE TABLE Usuario(
id INTEGER PRIMARY KEY AUTO_INCREMENT,
username VARCHAR(20),
contrasena VARCHAR(20),
empresaId INTEGER NOT NULL,
CONSTRAINT fk_Empresa FOREIGN KEY (empresaId) REFERENCES Empresa(id),
permiso INTEGER NOT NULL,
nombre VARCHAR(30) NOT NULL
);

CREATE TABLE Catalogo(
id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
cuentaId INTEGER NOT NULL,
nombre VARCHAR(100) NOT NULL,
empresaId INTEGER NOT NULL,
FOREIGN KEY (empresaId) REFERENCES  Empresa(id)
);

CREATE TABLE Cuenta(
id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
cuenta INTEGER NOT NULL,
anio INTEGER NOT NULL,
saldo FLOAT NOT NULL,
FOREIGN KEY (cuenta) REFERENCES  Catalogo(id)
);


CREATE TABLE PromedioRatio(
id INTEGER PRIMARY KEY NOT NULL AUTO_INCREMENT,
empresaId INTEGER NOT NULL,
nombre VARCHAR(30) NOT NULL,
sector VARCHAR(30) NOT NULL,
anio INTEGER NOT NULL,
promedio FLOAT NOT NULL,
FOREIGN KEY (empresaID) REFERENCES Empresa(id)
);

CREATE TABLE Comportamiento(
id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
mensaje VARCHAR(100)
);

INSERT INTO Tipo(tipo, descripción) VALUES ('Administradores', 'Administradores');
INSERT INTO Empresa(nombre, tipoId) VALUES('Admnistradores', 1);
INSERT INTO Usuario(username, contrasena, empresaId, permiso, nombre) VALUES('oh18003', 'analisis', 1, 0, 'Alejandro Oliva');

INSERT INTO Usuario(username, contrasena, empresaId, permiso, nombre) VALUES('aa15020', 'analisis', 1, 0, 'Ludwin Abarca');
INSERT INTO Usuario(username, contrasena, empresaId, permiso, nombre) VALUES('cc17040', 'analisis', 1, 0, 'Jennifer Cruz');
INSERT INTO Usuario(username, contrasena, empresaId, permiso, nombre) VALUES('cm18036', 'analisis', 1, 0, 'Gabriel Cárcamo');


INSERT INTO Tipo(tipo, descripción) VALUES ('Sector Primario', 'Encargado de materias primas');
INSERT INTO Tipo(tipo, descripción) VALUES ('Sector Secundario', 'Encargado de recursos manufacturados');
INSERT INTO Tipo(tipo, descripción) VALUES ('Sector Terciario', 'Encargado de servicios');
INSERT INTO Empresa(nombre, tipoId) VALUES('Algodonera Peru S.A.', 2);
INSERT INTO Empresa(nombre, tipoId) VALUES('Batanecos S.A. de C.V.', 2);
INSERT INTO Usuario(username, contrasena, empresaId, permiso, nombre) VALUES('Algodon', 'analisis', 2, 1, 'Jorge Aragon');
INSERT INTO Usuario(username, contrasena, empresaId, permiso, nombre) VALUES('Batano', 'analisis', 2, 1, 'Bairon Quintanilla');