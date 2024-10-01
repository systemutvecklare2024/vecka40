# Inl�mningsuppgift

Skapa en abstrakt basklass som heter furniture. Denna klass ska ha f�ljande properties:

boolean Wood
boolean Steel
boolean Fabric
TypeOfFurniture TypeOfFurniture
string Name

*********************************************

Skapa en klass som �rver av furniture som heter Table
L�gg till properties f�r 

double AreaOfTable
�verrid ToString.

Den ska returnera �Bordet {Name} har ytan {AreaOfTable}�
Implementera IComparable baserat p� AreaOfTable

*********************************************

Skapa en klass som �rver av furniture som heter Lamp

L�gg till properties f�r 

double Current
�verrid ToString.

Den ska returnera �Lampan {Name} drar {Current} amp�
Implementera IComparable baserat p� Current

*********************************************

TypeOfFurniture v�rdena ska vara

Bord
Stol
Taklampa
Bordslampa
Skrivbord

*********************************************

Skapa exempel data till 2 listor (tables och lamps) och sortera med .sort p� listorna.
Loopa genom dessa och k�r ToString() till consolen.