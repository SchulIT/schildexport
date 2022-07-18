# SchildExport

[![NuGet version (SchulIT.SchildExport)](https://img.shields.io/nuget/v/SchulIT.SchildExport.svg?style=flat-square)](https://www.nuget.org/packages/SchulIT.SchildExport/)
[![Build Status](https://dev.azure.com/schulit/SchildExport/_apis/build/status/SchulIT.schildexport?branchName=master)](https://dev.azure.com/schulit/SchildExport/_build/latest?definitionId=1&branchName=master)
![.NET Standard 2.1](https://img.shields.io/badge/.NET%20Standard-2.1-brightgreen?style=flat-square)

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

## Unterstützte SchILD-Installationen

Es werden sowohl Access*, MySQL, MariaDB als auch Microsoft SQL-Datenbanken unterstützt.

## Installation

Die Installation erfolgt via NuGet.

## Datenbankanbindung

Abhängig davon, welches Datenbank-Backend man verwenden möchte, müssen weitere Pakete eingebunden und auf dem Zielsystem installiert werden.

### Access

Benötigties NuGet-Paket: `System.Data.Odbc`

Damit das Verbinden zu Access klappt, müssen die Architektur (x86 oder x64) von Office, der Redistributatble und von diesem Tool identisch sein. Beim 32-bit Office wird das x86 Redistributable und die [x86-Version](https://github.com/SchulIT/anonymization-tool/releases) benötigt. Analog wird das x64 Redistributable bzw. die [x64-Version](https://github.com/SchulIT/anonymization-tool/releases) benötigt.

* [Download für Office 2010](https://www.microsoft.com/de-DE/download/details.aspx?id=13255) (nicht getestet)
* [Download für Office 2013](https://www.microsoft.com/en-us/download/details.aspx?id=39358) (nicht getestet)
* [Download für Office 2016/2019/Office 365](https://www.microsoft.com/en-us/download/details.aspx?id=54920)

⚠️ Dieses Redistributable muss auch auf dem System installiert sein, welche die Anwendung ausführt, die dieses Bibliothek verwendet ⚠️

### Microsoft SQL

Benötigtes NuGet-Paket: `Microsoft.Data.SqlClient`

Auf dem Zielsystem muss kein zusätzliches Tool installiert werden.

### MySQL/MariaDB

Benötigtes NuGet-Paket: `MySqlConnector`

Auf dem Zielsystem muss kein zusätzliches Tool installiert werden.

## Verbindung zur SchILD-Datenbank

### Access

```csharp
var exporter = new Exporter();
exporter.Configure(ConnectionProvider.Access, "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=$path$;Pwd=******;", false);
```

❗ Dabei muss `$path$` durch den Pfad zur Datenbankdatei (bspw. `C:\SchILD-NRW\DB\ge_2018_19.mdb`) angepasst werden.

Das Standard-Passwort für die Access-Datenbank von SchILD muss [beim Hersteller](https://www.svws.nrw.de/) angefragt werden.


### Microsoft SQL

```csharp
var exporter = new Exporter();
exporter.Configure(ConnectionProvider.SqlServer, connectionString, false);
```

Die Verbindungszeichenfolge `connectionString` für die Verbindung zur SchILD-Datenbank lautet folgenermaßen:

```
Server=server\sqlexpress;Database=SchildNRW;Integrated Security=True
```

* `Server`: Hier wird der Pfad zur SQL-Server-Instanz (i.d.R. ist `server` der Computername, `sqlexpress` ist der Instanzname bei SQL Server Express)
* `Database`: Hier den gewünschten Datenbanknamen eintragen. Die Datenbank wird automatisch erstellt.
* `Integrated Security=True`: So wird der aktuelle Benutzername zur Verbindung. Alternativ lassen sich mit `User=$username%; Password=$password$` auch Benutzername und Passwort separat festlegen (anstelle von `Integrated Security=True`).

### MySQL/MariaDB

```csharp
var exporter = new Exporter();
exporter.Configure(ConnectionProvider.MySqlConnector, connectionString, false);
```

Die Verbindungszeichenfolge `connectionString` für die Verbindung zur SchILD-Datenbank lautet folgenermaßen:

```
Server=localhost;Database=schildnrw;User=username;Password=your_secret_password;
```

* `Server`: Servername des MySQL Servers
* `Database`: Name der Datenbank auf dem MySQL Server. Die Datenbank wird automatisch angelegt, falls sie nicht vorhanden sein sollte.
* `User`: Benutzername zum Verbinden
* `Password`: Das Password des Benutzers, der sich verbinden möchte.

## Daten abrufen

Anschließend können die entsprechenden Methoden genutzt werden, um Daten aus der Datenbank zu erhalten:

```csharp
var students = await exporter.GetStudentsAsync(); // optionale Parameter: int[] status, DateTime leaveDateThreshold
var privacyCategories = await exporter.GetPrivacyCategoriesAsync();
var studentPrivacies = await exporter.GetStudentPrivaciesAsync(students);
var teachers = await exporter.GetTeachersAsync();
var subjects = await exporter.GetSubjectsAsync();
var grades = await exporter.GetGradesAsync();
var schoolInfo = await exporter.GetSchoolInfoAsync());
var studyGroups = await exporter.GetStudyGroupsAsync(students, info.CurrentYear.Value, info.CurrentSection.Value);
var tuitions = await exporter.GetTuitionsAsync(students, info.CurrentYear.Value, info.CurrentSection.Value);
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