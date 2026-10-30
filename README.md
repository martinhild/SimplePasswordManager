# 🔐 SimplePasswordManager

Ein einfacher, lokal laufender Passwortmanager in C# (.NET 6) mit WinForms und SQLite
(Datenbankanbindung mit Entity Framework Core, GUI-Entwicklung, Verschlüsselung)

---

📄 **[ 👉 Zur Projektdokumentation (PDF)](docs/Dokumentation/Dokumentation_SimplePasswordManager.pdf)**
  


---

## ✨ Features

- 💬 **Login mit Masterpasswort**
- 🖥️ **Benutzeroberfläche – intuitive GUI für Passwortverwaltung
- 🧠 **Passwortgenerator** mit einstellbarer Länge und Zeichenauswahl (Zahlen, Sonderzeichen, Groß-/Kleinbuchstaben)
- ✅ **Passwortvalidierung** und Eingabekontrolle
- 🔒 **AES-256-Verschlüsselung**
- 💾 **Lokale Speicherung mit SQLite** (via Entity Framework Core)
- 🧪 **Unit-Tests mit xUnit**

---

## 📸 Vorschau

![Screenshot der Anwendung](docs/screenshots/screenshot_1.png)


## 📷 Mockup

Entwurf der Anwendung:

![Mockup](docs/mockup/mockup.jpg)

---

## 🧩 Klassendiagramm

UML-Diagramm der wichtigsten Klassenstrukturen:

![Klassendiagramm](docs/UML/class_diagram.png)

---

## 🚀 Technologien

| Komponente           | Beschreibung                                                |
|----------------------|-------------------------------------------------------------|
| **C# (.NET 6)**       | Programmiersprache                |
| **WinForms**          | GUI-Framework für klassische Windows-Desktopanwendungen     |
| **SQLite**            | Leichtgewichtiges, dateibasiertes Datenbanksystem           |
| **Entity Framework Core** | ORM für Datenbankzugriff mit LINQ & DbContext         |
| **xUnit**             | Test-Framework für Unit-Tests                               |
| **AES / PBKDF2**      | Industriestandard für Verschlüsselung und Schlüsselableitung |

---

