# SchildExport

[![NuGet version (SchulIT.SchildExport)](https://img.shields.io/nuget/v/SchulIT.SchildExport.svg?style=flat-square)](https://www.nuget.org/packages/SchulIT.SchildExport/)
[![Build Status](https://dev.azure.com/schulit/SchildExport/_apis/build/status/SchulIT.schildexport?branchName=master)](https://dev.azure.com/schulit/SchildExport/_build/latest?definitionId=1&branchName=master)

Mithilfe dieser Bibliothek kann die Schild-Datenbank objekt-orientiert ausgelesen werden. Aktuell können folgende Dinge ausgelesen werden:

* Schulinfos
    * Id
    * Name
    * Aktuelles Schuljahr
    * Aktueller Abschnitt
* Schüler
    * Id
    * Vorname
    * Nachname
    * schulische E-Mail Adresse
    * Volljährigkeit
    * Geburtstag
    * Geschlecht
    * Klasse/Jgst
    * Status
    * Entlassdatum
* Lehrkräfte
    * Id
    * Vorname
    * Nachname
    * Titel
    * Geschlecht
    * dienstliche E-Mail Adresse
    * Fächer (Lehramtsbefähigungen)
    * Abschnittsdaten (Jahr, Abschnitt, Rechtsverhältnis)
    * Sichtbarkeit
* Klasse
    * Id
    * Name
    * Sichtbarkeit
    * Klassenleitung
    * stv. Klassenleitung
* Fächer
    * Id
    * Kürzel
    * Beschreibung
    * Sichtbarkeit
* Lerngruppen (Kurse + Klassen)
    * Id (nur bei Kursen)
    * Klassen/Jgst.
    * Art (Kurs oder Klasse)
    * Schüler inkl. Kursart (im Falle von Klassenunterricht ist die "Kursart" PUK)#
* Unterrichte (Kurs- und Klassenunterrichte)
    * Id (nur bei Kursen)
    * Fach
    * Lerngruppe
    * Lehrkraft
    * zusätzliche Lehrkräfte

Schild muss dazu mit einer SQL Server-Datenbank betrieben werden. Eine Erweiterung auf MySQL ist dank der Nutzung eines ORMs möglich, sobald sich jemand findet, der SchILD mit MySQL betreibt.

**Wichtig:** Access wird weder aktuell noch zukünftig unterstützt werden.

## Installation

Die Installation erfolgt via NuGet.

## Nutzung

```csharp
var exporter = new Exporter();
exporter.Configure("Server=localhost\SQLEXPRESS; Database=SchildNRW; User=Schild; Password=$3cr3t", false);
```

Alternativ kann auch eine andere gültige Verbindungszeichenfolge verwendet werden. Der zweite Parameter gibt an, ob die SQL Befehle auf der Konsole ausgegeben werden sollen (kann bspw. für Debug-Zwecke hilfreich sein).

Anschließend können die entsprechenden Methoden genutzt werden, um Daten aus der Datenbank zu erhalten:

```csharp
var students = await exporter.GetStudentsAsync(); // optionale Parameter: int[] status, DateTime leaveDateThreshold
var privacyCategories = await exporter.GetPrivacyCategoriesAsync();
var studentPrivacies = await exporter.GetStudentPrivaciesAsync();
var teachers = await exporter.GetTeachersAsync();
var subjects = await exporter.GetSubjectsAsync();
var grades = await exporter.GetGradesAsync();
var schoolInfo = await exporter.GetSchoolInfoAsync());
var studyGroups = await exporter.GetStudyGroupsAsync(info.CurrentYear.Value, info.CurrentSection.Value);
var tuitions = await exporter.GetTuitionsAsync(info.CurrentYear.Value, info.CurrentSection.Value);
```

## Sichtbarkeiten ausblenden

Einige Entitäten besitzen eine `Sichtbar`-Eigenschaft `IsVisible`. Diese lässt sich mittels LINQ recht einfach filtern:

```csharp
var onlyVisibleTeachers = teachers.WhereIsVisible();
var onlyVisibleGrades = grades.WhereIsVisible();
var onlyVisiblePrivacyCategories = privacyCategories.WhereIsVisible();
var tuitionsWithVisibleStudyGroups = tuitions.WhereStudyGroupIsVisible();
```

Bei geschachtelten Objekten lassen sich nicht sichtbare Referenzen folgendermaßen entfernen:
```csharp
var studyGroupsWithVisibleGrades = studyGroups.RemoveInvisibleGrades();
var teachersWithVisibleSubjects = teachers.RemoveInvisibleSubjects();
var gradesWithVisibleTeachers = grades.RemoveInvisibleTeachers();
var studentPrivaciesWithVisibleCategories = studentPrivacies.RemoveInvisiblePrivacyCategories();
var tuitionsWithVisibleTeachers = tuition.RemoveInvisibleTeachers();
```

# Projektstruktur

## Allgemeines
Als ORM kommt [LINQ to DB](https://linq2db.github.io/index.html) zum Einsatz.

* `Entities`: Hier befinden sich die DTOs mit den benötigten Spalten.
* `Data`: Hier befindet sich die Klasse `SchildNRWConnection`, welche zur Verbindung mit der Datenbank benötigt wird. 
* `Models`: Hier befinden sich die Klassen, welche die Bibliothek nach Außen zur Verfügung stellt.
* `Converter`: Hier befinden sich Converter, um aus den DTOs die Objekte aus `Models` zu erstellen. Dies ist nur für einfache Entitäten möglich. Für komplexere Entitäten wie bspw. Lerngruppen oder Unterrichte gibt es keine Converter.
* `Repository`: Hier befinden sich für die Repositories, welche die DTOs aus der Datenbank holen und mittels Converter in Modelle umgewandelt werden.

## Hinweis zu den Modellen

Um die Verschachtelungs-Hierarchie gering zu halten, werden an entsprechenden Stellen Objekte mit dem Suffix `Ref` verwendet. Diese enthalten in der Regel die ID und (falls vorhanden) Sichtbarkeit der Ziel-Entität. In einigen Fällen enthält sie noch weitere Informationen.

## Erweitern

Diese Bibliothek enthält erstmal nur die Daten, die wir für unsere Zwecke benötigen. Falls weitere Daten aus der SchILD-Datenbank ausgelesen werden sollen, kann diese Bibliothek entsprechend erweitert werden. Dazu werden im Folgenden die notwendigen Schritte aufgezeigt. Im Anschluss muss dann ein Pull Request eingereicht werden, sodass alle davon profitieren können.

### Weiteres Feld hinzufügen

Möchte man ein weiteres Feld (bspw. die private E-Mail Adresse eines Schülers) hinzufügen, geht man folgendermaßen vor:

1. Entsprechende DTO-Klasse in `Entities` anpassen.
2. Entsprechendes Model in `Models` anpassen.
3. Entsprechende Änderungen an `Converter` und/oder `Repository` vornehmen.

### Weitere Tabelle hinzufügen

Möchte man gar eine oder mehrere Tabellen auslesen und in ein objekt-orientiertes Format umwandeln, geht man folgendermaßen vor:

1. Entsprechende DTO-Klasse in `Entities` erstellen.
2. Tabelle in der Klasse `SchildNRWConnection` hinterlegen.
3. Entsprechendes Model in `Models` erstellen.
4. Entsprechenden `Converter` oder `Repository` erstellen.
5. `IExporter` um eine entsprechende Signatur erweitern.
6. `Exporter` um eine entsprechende Signatur erweitern.

## Mitmachen?

Immer gerne - einfach ein Issue öffnen oder noch besser: einen Pull Request einreichen!

## Lizenz

[MIT](./LICENSE.md)