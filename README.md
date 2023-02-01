# SchildExport

[![NuGet version (SchulIT.SchildExport)](https://img.shields.io/nuget/v/SchulIT.SchildExport.svg?style=flat-square)](https://www.nuget.org/packages/SchulIT.SchildExport/)
[![Build Status](https://dev.azure.com/schulit/SchildExport/_apis/build/status/SchulIT.schildexport?branchName=master)](https://dev.azure.com/schulit/SchildExport/_build/latest?definitionId=1&branchName=master)
![.NET Standard 2.1](https://img.shields.io/badge/.NET%20Standard-2.1-brightgreen?style=flat-square)
![SchILD 3.x](https://img.shields.io/badge/SchILD%20-3.x-red?style=flat-square)

⚠️ Diese Version ist nur mit SchILD ab Version 3 kompatibel - für SchILD Version 2 bitte Version 1 dieser Bibliothek verwenden ⚠️

---

Mithilfe dieser Bibliothek kann die SchILD3-Datenbank objekt-orientiert ausgelesen werden. Aktuell können folgende Dinge ausgelesen werden:

* Schulinfos
    * Id
    * Name (Bezeichnung 1-3)
    * Aktueller Schuljahresabschnitt
* Schuljahresabschnitte
    * Id
    * Jahr
    * Abschnitt
* Fächer
    * Id
    * Kürzel
    * Beschreibung
    * Sichtbarkeit
* Datenschutzkategorien
    * Id
    * Bezeichnung
    * Beschreibung
    * Sichtbarkeit
    * Zielgruppe
* Lernplattformen
    * Id
    * Bezeichnung
    * Benutzernamensuffixe für Lehrkräfte, Schülerinnen und Schüler, Eltern
* Schülerinnen und Schüler (in Abhängigkeit vom Schuljahresabschnitt)
    * Id
    * Vorname
    * Nachname
    * schulische E-Mail Adresse
    * Geburtstag
    * Geschlecht
    * Klasse/Jgst
    * Status
    * Datenschutz-Zustimmungen
    * Lernplattform-Zustimmungen
    * Lernplattform-Zugangsdaten
* Lehrkräfte (in Abhängigkeit vom Schuljahresabschnitt)
    * Id
    * Vorname
    * Nachname
    * Kürzel
    * Titel
    * Geschlecht
    * Amtsbezeichnung
    * dienstliche E-Mail Adresse
    * Geburtstag
    * Fächer (Lehramtsbefähigungen)
    * Sichtbarkeit
* Klassen (in Abhängigkeit vom Schuljahresabschnitt)
    * Id
    * Name
    * Sichtbarkeit
    * Klassenleitung
    * stv. Klassenleitung
* Klassen (in Abhängigkeit vom Schuljahresabschnitt)
    * Id
    * Bezeichnung
    * Name
    * Sichtbarkeit
    * Klassenleitung (mit Reihenfolge; laut SchILD 3 wird jedoch nicht zwischen primärer Klassenleitung und Vertretung unterschieden)
* Kurse (in Abhängigkeit vom Schuljahresabschnitt)
    * Id
    * Bezeichnung
    * Fach
    * Lehrkraft
    * Weitere Lehrkräfte (ohne Stundenanteile)
    * Schülerinnen und Schüler (ohne Kursart wie bspw. GKS, GKM, ...)
    * Sichtbarkeit

## Schreibender Zugriff

Grundsätzlich soll durch diese Bibliothek kein schreibender Zugriff auf die Datenbank erfolgen. Es ist jedoch möglich, Lerngruppen anzulegen und (allerdings aktuell nur für Schülerinnen und Schüler) initiale Zugangsdaten für Schülerinnen und Schüler anzulegen.

## Installation

```
dotnet add package SchulIT.SchildExport
```

oder natürlich über die GUI.

## Konfiguration

Es werden zwei Klassen zur Verfügung gestellt, jeweils für lesenden und schreibenden Zugriff.

### Lesender Zugriff

```
var reader = new SvwsDatabaseReader();
reader.Configure("localhost", 3306, "svws", "svwsadmin", "*******", false);
```

### Schreibender Zugriff

```
var writer = new SvwsDatabaseWriter();
writer.Configure("localhost", 3306, "svws", "svwsdmin", "*******", false);
```

## Daten abrufen

Bitte den dokumentierten Quelltext im Projekt `SchildExport.Console` anschauen.

## Erweitern

Diese Bibliothek enthält erstmal nur die Daten, die wir für unsere Zwecke benötigen. Falls weitere Daten aus der SchILD-Datenbank ausgelesen werden sollen, kann diese Bibliothek entsprechend erweitert werden. Dazu werden im Folgenden die notwendigen Schritte aufgezeigt. Im Anschluss muss dann ein Pull Request eingereicht werden, sodass alle davon profitieren können.

## Mitmachen?

Immer gerne - einfach ein Issue öffnen oder noch besser: einen Pull Request einreichen!

## Lizenz

[MIT](./LICENSE.md)