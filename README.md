# Application de facturation pour un salon de coiffure 
 

## 1. Introduction 

 ### 1.1 Contexte :  

Afin de simplifier la gestion des factures et des paiements dans un salon de coiffure, nous souhaitons développer une application permettant de simplifier la création de facture, le suivi des paiements et la gestion des clients. 

### 1.2 Objectif du projet :  

Créer une plateforme intuitive permettant aux employés du salon de générer des factures, d’appliquer des réductions et la TVA, de suivre les paiements, et d’archiver ou créer ou modifié les informations des clients. L’application offrira également un tableau de bord pour consulter les performances de vente.  

### 1.3 Portée du projet :  

L'application doit offrir une interface utilisateur conviviale pour la gestion des clients, la gestion des factures et des paiements, et l’affichage des performances de ventes. 

L'application ne gérera pas la gestion des stocks de produits capillaires ni la planification des rendez-vous, mais se concentrera exclusivement sur la facturation, les paiements et la gestion des clients. 

## 2. Description du Projet 

### 2.1 Aperçu de l'application :  

Une application de bureau permettant aux employés du salon de générer des factures, d’appliquer des réductions et la TVA, de suivre les paiements, et d’archiver ou créer ou modifié les informations des clients et de consulter le tableau de bord. 

### 2.2 Fonctionnalités clés : 

#### 2.2.1 Gestion des clients:  

- Création du profil du client : (nom, prénom, coordonnées, historique des prestations) 

- Archivage et suppression de clients (En cas d’erreur) 

- Consultation de l’historique des services et des paiements du client  

#### 2.2.2. Gestion des factures:  

- Création de factures en sélectionnant les services.  

- Ajout de réductions et calcul automatique de la TVA 

- Envoie par mail des factures au client 

#### 2.2.3. Gestion des paiements:  

- Enregistrement des paiements  

- Historique des transactions par client 

- Gestion des paiements en attente  

- Type de mode de paiement (espèces, carte, virement) 

- Relance automatique des paiements en retard par mail au client  

#### 2.2.4. Gestion de rôles 

Les rôles des employés du salon (coiffeur(se), propriétaire, admin) doivent être définis dans un système de gestion des permissions pour permettre des accès personnalisés et sécurisés à chaque fonctionnalité. 

#### 2.2.5. Gestion des services:  

- Création et modification des services proposés par le salon 

- Ajout des prix des prestations 

#### 2.2.6. Tableau de bord :  

L’affichage des revenus générés sur une période d’un mois, le suivi des paiements en attente et classement des services les plus populaires. 

### 2.3 Utilisateurs cibles :  

Les employés et propriétaires d’un salon de coiffure.  

## 3. Exigences techniques 

### 3.1 Environnement de développement : 

#### 3.1.1. Front-end :  

GUI avec WPF pour une expérience utilisateur riche sur les plateformes Windows. 

#### 3.1.2 Back-end :  

C# avec .NET Core (7 ou supérieur), Entity Framework Core, pour la gestion de la base de données relationnelle pour stocker les informations (par exemple, MySql ou SQL Server). 

### 3.2 Architecture de l'application :  

Modèle qui permet de séparer la logique de l'application, l'interface utilisateur et l'accès aux données.  

L'application utilisera l'architecture MVVM (Modèle-Vue-VueModèle) pour séparer clairement la logique métier, la gestion des données et la présentation des informations. 

Schématisez votre architecture. 

### 3.3 Exigences de performance :  

Temps de réponse de l'application inférieur à 2 secondes pour les interactions utilisateur, gestion efficace des données en temps réel pour le système de vote et d'approbation. 

Mentionner des exigences spécifiques en termes de concurrence : pour les fonctionnalités de vote et de suivi des projets (par exemple, combien d'utilisateurs simultanés l'application doit-elle supporter). 

## 4. Critères de Qualité 

### 4.1 Interface utilisateur :  

L'interface utilisateur doit être simple et intuitive, offrant un accès facile aux fonctionnalités pour chaque utilisateur et accessible sur des ordinateurs Windows. 

### 4.2 Sécurité :  

Authentification sécurisée des utilisateurs, protection des données personnelles et des informations sur les projets. 

Spécifier les méthodes d'authentification qui seront utilisées (OAuth, authentification par email et mot de passe, etc.), 

Testabilité :  

Inclusion de tests unitaires et d'intégration pour valider les fonctionnalités clés et la robustesse de l'application. 

## 5. Documentation 

Une documentation complète, documentation du code, comprenant un guide d'utilisation, une description de l'architecture, et des instructions de déploiement, devra être fournie. 

## 6. Gestion de projet 

L'utilisation d'une méthodologie de gestion de projet agile avec des itérations itératives sera nécessaire. Des réunions régulières seront prévues pour suivre l'avancement, résoudre les problèmes, et ajuster les fonctionnalités si nécessaire.
 
 

 
