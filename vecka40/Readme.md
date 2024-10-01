# Inlämningsuppgift

Skapa en abstrakt basklass som heter furniture. Denna klass ska ha följande properties:

boolean Wood
boolean Steel
boolean Fabric
TypeOfFurniture TypeOfFurniture
string Name

*********************************************

Skapa en klass som ärver av furniture som heter Table
Lägg till properties för 

double AreaOfTable
Överrid ToString.

Den ska returnera “Bordet {Name} har ytan {AreaOfTable}”
Implementera IComparable baserat på AreaOfTable

*********************************************

Skapa en klass som ärver av furniture som heter Lamp

Lägg till properties för 

double Current
Överrid ToString.

Den ska returnera “Lampan {Name} drar {Current} amp”
Implementera IComparable baserat på Current

*********************************************

TypeOfFurniture värdena ska vara

Bord
Stol
Taklampa
Bordslampa
Skrivbord

*********************************************

Skapa exempel data till 2 listor (tables och lamps) och sortera med .sort på listorna.
Loopa genom dessa och kör ToString() till consolen.