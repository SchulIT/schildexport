# SchildExport

[![NuGet version (SchulIT.SchildExport)](https://img.shields.io/nuget/v/SchulIT.SchildExport.svg?style=flat-square)](https://www.nuget.org/packages/SchulIT.SchildExport/)
[![Build Status](https://dev.azure.com/schulit/SchildExport/_apis/build/status/SchulIT.schildexport?branchName=master)](https://dev.azure.com/schulit/SchildExport/_build/latest?definitionId=1&branchName=master)

Mithilfe dieser Bibliothek kann die Schild-Datenbank ausgelesen werden. Aktuell können folgende Dinge ausgelesen werden:

* Schüler (Id, Vorname, Nachname, Geschlecht, E-Mail Adresse, Geburtstag, Klasse)
* Klassen (Id, Name, Klassenlehrer, stv. Klassenlehrer)
* Lehrer (Id, Kürzel, Vorname, Nachname, Titel, Geschlecht, E-Mail Adresse)
* Fächer (Id, Abkürzung, Beschreibung)
* Lehrbefähigungen der Lehrer (Lehrer, Liste von Fächern)
* Eltern (Id, Schüler, Art, Vorname, Nachname, E-Mail Adresse)

Schild muss dazu mit einer MSSQL- oder MySQL-Datenbank betrieben werden. Access-Datenbanken werden nicht unterstützt. **Wichtig:** Bisher wurde nur mit einer MSSQL-Datenbank getestet.

## Installation

Die Installation erfolgt via NuGet.

## Nutzung

```csharp
var exporter = new Exporter();
exporter.Configure(DatabaseType.MSSQL, "Server=localhost\SQLEXPRESS; Database=SchildNRW; User=Schild; Password=$3cr3t");
```

Zum Erstellen der Verbindungszeichenfolge kann auch der `ConnectionStringBuilder` genutzt werden:

```csharp
var connectionString = (new ConnectionStringBuilder())
    .SetServer(@"localhost\SQLEXPRESS")
    .SetDatabase("SchildNRW")
    .SetUsername("Schild")
    .SetPassword("$3cr3t")
    .GetConnectionString();
```

Die Angaben zum Benutzernamen und Password sind optional. Server und Datenbank sind erforderlich.

Anschließend können die entsprechenden Methoden genutzt werden, um Daten aus der Datenbank zu erhalten:

```csharp
var students = await exporter.GetStudentsAsync();
```

### Auszulesende Felder erweitern/ändern

Es ist möglich, eigene Converter zu schreiben, um eine Tabellenzeile aus der Datenbank in ein Datenobjekt umzuwandeln. So es ist möglich, (a) weitere Felder
auszulesen oder (b) andere Felder auszulesen (bspw. DienstEmail statt Email bei Lehrern):

#### Beispiel 1: Dienstliche E-Mail abfragen

Schritt 1: Eigenen Converter schreiben:

```csharp
public class CustomKLehrerTeacherConverter : KLehrerTeacherConverter
{
    public new Teacher Convert(KLehrer source)
    {
        return new Teacher
        {
            Id = source.Id,
            Abbreviation = source.Kuerzel,
            Firstname = source.Vorname,
            Lastname = source.Nachname,
            Title = source.Titel,
            Gender = genderConverter.Convert(source.Geschlecht),
            Email = source.EmailDienstlich
        };
    }
}
```

Schritt 2: Abfrage anpassen:

```csharp
var teachers = exporter.GetTeachersAsync(new CustomKLehrerTeacherConverter());
```

#### Beispiel 2: weitere Felder abfragen

Schritt 1: eigenes Model anlegen (**wichtig:** das Model muss von der Basisklasse erben)

```csharp
public class CustomStudent : Student
{
    public string ExternalId { get; set; }
}
```

Schritt 2: eigenen Converter anlegen (am einfachsten ist es, vom Standard-Converter zu erben)

```csharp
public class CustomSchuelerStudentConverter : SchuelerStudentConverter
{
    public override Student Convert(Schueler source)
    {
        return new CustomStudent
        {
            Id = source.Id,
            Firstname = source.Vorname,
            Lastname = source.Name,
            Email = source.Email,
            Birthday = source.Geburtsdatum,
            Gender = GenderConverter.Convert(source.Geschlecht?.ToString()),
            Grade = Grades.FirstOrDefault(x => x.Name == x.Name),
            ExternalId = source.Idext
        };
    }
}
```

Schritt 3: Abfrage anpassen

```csharp
var students = await schildExport.GetStudentsAsync(new CustomSchuelerStudentConverter(), new VersetzungGradeConverter(), new KLehrerNullConverter()));
```

Unter Umständen muss man weitere Converter dabei angeben. Dann einfach die Standard-Konverter (oder einen eigenen, falls vorhanden) angeben. Die Standard-Converter befinden sich im Namespace `SchulIT.SchildExport.Converter`.

## Lizenz

[MIT](./LICENSE.md)