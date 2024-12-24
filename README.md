# Application Colocation CROUS

Prerequisites :

To run this project, you need to install the connector/net (https://dev.mysql.com/downloads/file/?id=515908), for ADO.NET.

You must also add the following reference to the project :

In Visual Studio :

![img](image/f1.PNG)

Right-click on `Dao` and click on `Reference`.

Click on `parcourir` : 

![img](image/f2.PNG)

Select the following reference :

![img](image/f3.PNG)

Make sure to follow the directory structure correctly to avoid errors.

Rebuild the project.

## Contexte : 
The CROUS application helps students manage the expenses of a shared apartment :

```plantuml
@startuml Colocataire
left to right direction
:Etudiant:
package Colocataire{
    Etudiant--(Télécharge l'application Colocataire)
    Etudiant--(Installe l'application)
    Etudiant--(Gère ses dépenses)
    
}
@enduml
```
</br>


<br></br>

### Database Tables Used by the Application :

```sql
drop database if exists dbcrous;
create database dbcrous;
use dbcrous;
```
```sql
CREATE TABLE Colocataire (
	id int(11) unsigned not null auto_increment,
	nom VARCHAR(50),
	prenom VARCHAR(50),
	mail varchar(50),
	telephone varchar(20),
	primary key (id)
	);
```
```sql
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
```
## **Menu :**
---
Here is the main interface allowing access to the various features :

![FenetreMenu.jpg](image/FMENU.jpg)
```plantuml
@startuml Solder Periode
left to right direction
:colocataire:
package Menu{
    colocataire--(Gerer les colocataires)
    colocataire--(Gerer les dépenses)
    colocataire--(Solder une période)
    colocataire--(Réinitialiser l'application)
}
@enduml
```
<br></br>

## **Gerer les colocataires :**
---


Here is the interface allowing you to view the list of colocataires and to add, modify, or delete a colocataire :

![FGererColoc.PNG](image/FGererColoc.PNG)



```plantuml
@startuml Solder Periode
left to right direction
:colocataire:
package GérerColocataire{
    colocataire--(Consulter la liste des Colocataires)
    colocataire--(Ajouter Un Colocataire)
    colocataire--(Modifier Un Colocataire)
    colocataire--(Supprimer Un Colocataire)
    colocataire--(Réinitialiser les colocataires)
}
@enduml
```
</br>

### AJOUT COLOCATAIRE :

Here is the interface allowing you to view the list of colocataires and to add, modify, or delete a colocataire : 

![FAjoutColoc.PNG](image/FAjoutColoc.PNG)

If any of the entered information is incorrect, the page will not close until valid information is provided :

![FAjoutMauvaisColoc.PNG](image/FAjoutMauvaisColoc.PNG)



### MODIFICATION COLOCATAIRE :

You can also modify a colocataire's information by clicking on the "Modify" button. Be sure to select a colocataire before clicking "Modifier".

![FTutoModifColoc.PNG](image/FTutoModifColoc.PNG)

This will redirect you to a new window :

![FModifColoc.PNG](image/FModifColoc.PNG)

If any of the entered information is incorrect, the details cannot be validated :

![FModifMauvaiseColoc.PNG](image/FModifMauvaiseColoc.PNG)

</br>

### SUPPRESSION COLOCATAIRE :

You can delete a colocataire by selecting the colocataire and clicking on "Supprimer".

![FSupprimerColoc.PNG](image/FSupprimerColoc.PNG)

</br>

**Note :**  

For every action, make sure to click "Enregistrer"  to save your changes.

![FEnregistrerColoc.PNG](image/FEnregistrerColoc.PNG)


### RÉINITIALISER LES COLOCATAIRES :

You can reset all colocataires at once by clicking the "Réinitialiser" button :

![FColocReinitialiser.PNG](image/FColocReinitialiser.PNG)

<br></br>

## **Gérer les dépenses :**
---

Here is the interface to view and manage the expenses, allowing you to add, modify, or delete an expense :


![FGererDepense.PNG](image/FGererDepenses.PNG)

```plantuml
@startuml Enregister Une Dépense
left to right direction
:Colocataire:
package GérerDépense{
    Colocataire--(Consulter les dépenses)
    Colocataire--(Saisir une dépense)
    Colocataire--(Modifier une dépense)
    Colocataire--(Supprimer une dépense)
    Colocataire--(Réinitialiser les dépenses)
    (Saisir une dépense)<..(sélectionner un fichier):<<extends>>
    (Modifier une dépense)<..(sélectionner un fichier):<<extends>>
}
@enduml
```
<br></br>

### AJOUT DEPENSE :

Input controllers are present for all fields.

![FAjoutDepenses.PNG](image/FAjoutDepense.PNG)

<br></br>

### MODIFICATION DEPENSE :

In case of errors or updates, details like date, text, amount, or the supporting file can be modified.

![FModifDepense.PNG](image/FModifDepense.PNG)

<br></br>

### SUPPRESSION DEPENSE :

Simply select the expense and click the "Supprimer" button, similar to how you delete colocataires.
<br></br>

### REINITIALISER LES DEPENSES :

You can reset all expenses at once by clicking the "Réinitialiser" button :

![FDepenseReinitialiser.PNG](image/FDepenseReinitialiser.PNG)




### ENREGISTRER DEPENSE :

Click the "Enregistrer" button after each action.
![FEnregistrerColoc.PNG](image/FEnregistrerColoc.PNG)

<br></br>

## **Répartir les dépenses sur une période :**
---
This feature allows you to calculate what each colocataire owes the others based on the expenses incurred for the shared apartment.

![FSolderPeriode.PNG](image/FSolderPeriode.PNG)


```plantuml
@startuml SolderPeriode
left to right direction
:colocataire:
package SolderPériode{
colocataire--(Solder une période) :<<include>> 
(Solder une période)..>(Les dépenses sont définis comme étant répartis):<<include>> 
(Solder une période)..>(Lancer la répartition):<<include>>
(Les dépenses sont définis comme étant répartis)<...(Enregistrer la répartition dans un fichier):<<Exclude>>
}
@endumlD
```

Click on the "Lancer la Répartition" utton to be redirected to a new window :

![FRepartiDepense.PNG](image/FRepartirDepense.PNG)

On the left side, you'll see the expenses that haven't been distributed yet. For example, in the "Gerer Depenses" window, there were two expenses :

![FNbDepense.PNG](image/FNbDepense.PNG)

In the database, we can see that the "reparti" column is set to 0 (false) :

![BddRepartition.PNG](image/BddRepartition.PNG) 

<br></br>
By clicking on "Répartir"  the file explorer will open to save the distribution, allowing the student to store the distribution in a file.

![save.PNG](image/save.PNG)

The file content :

![repartion.PNG](image/repartion.PNG)

 On the right side of the table, you'll see the amount that each colocataire owes based on their contributions to the shared apartment.

![FRepartiFaite.PNG](image/FRepartiFaite.PNG) 


### Explication :  

Jean bought a chair worth €50, and Antoine bought a chair worth €70.
The total expenses for the shared apartment are €120.
Each colocataire should pay €60.
Since Antoine paid more than €60 and Jean paid less, Jean will owe Antoine €10 to balance the payments.
<br></br>

Once the distribution is done, these expenses will no longer appear in the table, and in the database, the "reparti" value will be set to 1 (True) :

![BddRepartitionFaite.PNG](image/BddRepartitionFaite.PNG)

You won't be able to distribute expenses until new expenses are added for the shared apartment :

![FSolderPeriode2.PNG](image/FSolderPeriode2.PNG)
</br>

Finally, you can reset the entire application, deleting all colocataires and expenses.

![FMENU](image/FMENU2.PNG)

## E5 Training :

To prepare for the year-end exam (E5), the professor asked me to add new features that allow a colocataire to sort expenses based on their chosen attribute and display the total amount of expenses.

```plantuml
@startuml SolderPeriode
left to right direction
:colocataire:
package Gererdépense+{
colocataire--(trier les dépenses) 
colocataire--(Afficher le montant total des dépenses)

}
@endumlD
```
Example sorting by amount :

![tri.PNG](image/tri.PNG)

