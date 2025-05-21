
## 1. Introduction

### 1.1 Contexte  
Afin de simplifier la gestion des paiements et des clients dans un salon de coiffure, cette application a été développée pour centraliser la facturation, le suivi des paiements, et les informations des clients dans une interface simple et efficace.
### 1.1 Contexte  
Afin de simplifier la gestion des paiements et des clients dans un salon de coiffure, cette application a été développée pour centraliser la facturation, le suivi des paiements, et les informations des clients dans une interface simple et efficace.

### 1.2 Objectif  
- Créer des factures claires.
- Suivre les paiements effectués ou en attente.
- Gérer les informations des clients (ajout, modification).
- Générer un fichier PDF des factures.
- Envoyer les factures par e-mail.


### 1.3 Portée  
L’application **ne gère pas** :
- Les stocks de produits.
- La prise ou la gestion de rendez-vous.

---

## 2. Technologies utilisées 

| Catégorie               | Outils / Technologies |
|------------------------|------------------------|
| Langage principal       | C# avec .NET 8.0       |
| Interface utilisateur   | WPF (Windows Presentation Foundation) |
| Architecture logicielle | MVVM (via CommunityToolkit.Mvvm) |
| Base de données         | SQLite avec EF Core    |
| ORM                     | Entity Framework Core  |
| PDF                     | QuestPDF pour générer les factures |
| Envoi de mail           | SmtpClient (System.Net.Mail) |
| IDE                     | Visual Studio 2022     |
| Contrôle de version     | GitHub           |

---

## 3. Installation de l’application 

### Prérequis :
- Windows 10 ou plus
- Visual Studio 2022
- .NET 8 SDK

### Étapes :
```bash
git clone https://github.com/Ikasaidi/App_Facture.git
cd App_Facture
```

1. Ouvrir le fichier `SalonCoiffure.sln` avec Visual Studio.
2. Restaurer les packages NuGet si demandé.
3. Appuyer sur **F5** pour lancer l'application.

---

## 4. Déploiement 

### Version compilée :
- Compiler en mode `Release` depuis Visual Studio.
- L’exécutable se trouvera ici :  
  `SalonCoiffure/bin/Release/net8.0-windows/`

### Version autonome :
1. Cliquer sur `Build > Publish > Folder`
2. Choisir :
   - Target : `win-x64`
   - Mode : `Self-contained`
   - Configuration : `Release`
3. Cliquer sur Publish

---

## 5. Organisation du code 📁

```
SalonCoiffure/
│
├── Data/             → Configuration EF Core (DbContext)
├── Model/            → Classes métier (Client, Facture, Paiement…)
├── ViewModel/        → Logique de présentation (MVVM)
├── Views/            → Interfaces utilisateur (XAML)
├── images/           → Ressources visuelles
├── SalonCoiffure.sln → Fichier solution Visual Studio
├── SalonCoiffure.Tests → Test unitaires 
└── README.md
         
```

---

## 6. Liens utiles 🔗

-  Wiki du projet : https://github.com/Ikasaidi/App_Facture/wiki
-  Documentation MVVM Toolkit :  
  https://learn.microsoft.com/en-us/windows/communitytoolkit/mvvm/
-  Documentation QuestPDF :  
  https://www.questpdf.com/documentation.html
-  EF Core :  
  https://learn.microsoft.com/en-us/ef/core/
-  Envoi de mail C# :  
  https://learn.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient

---
