drop database if exists dbCrous;
create database dbCrous;
use dbCrous;

CREATE TABLE Colocataire (
	id int(11) unsigned not null auto_increment,
	nom VARCHAR(50),
	prenom VARCHAR(50),
	mail varchar(50),
	telephone varchar(20),
	primary key (id)
	);

CREATE TABLE Depense(
	id int(11) unsigned not null auto_increment,
	ladate DateTime,
	texte Varchar(50),
    justificatif varchar (256),
    montant Decimal(10,2),
    reparti boolean,
    idColoc int(11) unsigned not null,
	Primary key (id),
    Foreign key (idColoc) REFERENCES Colocataire(id)
	);
	

insert into Colocataire(nom,prenom,mail,telephone)values("Edwin","Perl","mail@mail.com","0601020304");
insert into Colocataire(nom,prenom,mail,telephone)values("Nofa","grain","mamail.com","060105504");
insert into Depense(ladate,justificatif,montant,reparti,idColoc)values('1955/06/27 00:00:00',"Pièce d'identité",200.00,False,1);
insert into Depense(ladate,justificatif,montant,reparti,idColoc)values('1955/06/28 00:00:00',"Photo",100.00,False,2);

