# Description
Ce projet consiste à créer une base de données SQL Server avec une table `Patient` et une page web ASP.NET Core pour afficher la liste des patients dans une grille Devextreme.

# Instructions
1. Création du base de données SQL Server `Hopital`
```sql
CREATE DATABASE Hopital;
```
2. Création de la table `Patient`
```sql
USE Hopital;

CREATE TABLE Patient (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nom VARCHAR(50) NOT NULL,
    prenom VARCHAR(50) NOT NULL,
    date_naissance DATE NOT NULL
)
```
