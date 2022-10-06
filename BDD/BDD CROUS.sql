create database CrousS;
use Crous;

CREATE TABLE Depense(
	id integer unsigned(11) auto-increment,
	date DateTime,
	text Varchar(50),
    justificatif varchar (256),
    montant numeric(10,2),
    reparti boolean,
    idColoc integer,
	Primary key (id)
    Foreign key idColoc references Colocataire(id)
	)ENGINE = innodb;
	

CREATE TABLE Colocataire (
	id integer auto-increment,
	nom VARCHAR(50),
	prenom VARCHAR(50),
	mail varchar(50),
	telephone varchar(20),
	primary key (id),
	)ENGINE = innodb ;