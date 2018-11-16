FØR LEVERING: 
- [ ] Fjern sjekkpunkter 
- [ ] Legg pdf af dette dokumentet i rot 
- [ ] Sjekk at løsning kjører som en Visual Studion Solution 
- [ ] Legg ved en .exe-fil 

# Dokumentasjon 
- [Dokumentasjon](#dokumentasjon)
    - [Introduksjon](#introduksjon)
    - [Prosessen](#prosessen)
        - [Planlegging](#planlegging)
        - [Parprogrammering](#parprogrammering)
        - [Samarbeid](#samarbeid)
        - [prioriteringer](#prioriteringer)
    - [GRASP](#grasp)
        - [Controller](#controller)
        - [Creator](#creator)
        - [High cohesion](#high-cohesion)
        - [Information expert](#information-expert)
        - [Low coupling](#low-coupling)
        - [Polymorphism](#polymorphism)
        - [Protected variations](#protected-variations)
        - [Pure fabrication](#pure-fabrication)
    - [Diagrammer](#diagrammer)
        - [Klassediagram](#klassediagram)
        - [Sekvensdiagram](#sekvensdiagram)
        - [Bruksdiagram ("Use case")- [ ] Hva modelleres?](#bruksdiagram-%22use-case%22----hva-modelleres)
    - [Design patterns](#design-patterns)
        - [Factory](#factory)
        - [Decorator](#decorator)
        - [Singleton](#singleton)
        - [Composite](#composite)
        - [Facade](#facade)
        - [Flyweight](#flyweight)
        - [MVP](#mvp)
    - [Trådsikkerhet](#tr%C3%A5dsikkerhet)
    - [Enhetstesting](#enhetstesting)
    - [Om C# og vår kode](#om-c-og-v%C3%A5r-kode)
        - [Operatoroverlasting](#operatoroverlasting)
        - [Regions](#regions)
        - [Properties](#properties)
        - [Kommentarer](#kommentarer)
        - [Konvensjoner](#konvensjoner)

## Introduksjon 
Vår oppgave har vært å simulere et loppemarked. 
Noen av menneskene på markedet er selgere og noen er kunder. Selgerene legger ut varer for salg. I det en vare legges ut for salg, forsøker samtlige kunder å kjøpe varen. Hver kunde har en reaksjonstid som varierer litt for hver gang. 
Flere selgere kan legge ut varer samtidig. 

Dersom en kunde forsøker å kjøpe en vare de ikke har råd til, vil de forsøke å prute. Dersom prutingen lykkes, får de varen til en pris de har råd til. 

Markedet vil (naturlig nok) tape aktivitet så fort kundene går tom for penger. 

## Prosessen 
### Planlegging 
Vi startet prosessen vår med å kladde notater på et digitalt notatark. Vi ønsket å fokusere på å få med design patterns og snakket fort om hvor hvilke patterns kunne høre hjemme. Vi repeterte også deler av pensum for å vite hva vi skulle tenke på når vi fortsatte. Vi bestemte oss også tidlig for å bruke samme IDE for at vi skulle ha like referanserammer dersom problemer skulle oppstå. I og med at to på gruppen bruker Mac, landet vi på [Jetbrains' Rider](https://www.jetbrains.com/rider/) ganske fort. HVORFOR IKKE VS FOR MAC? 
### Parprogrammering 
- [ ] Hvor har det blitt benyttet 
- [ ] Reflekter over resultatet 
### Samarbeid 
- [ ] Hvor vi har jobbet 
- [ ] Bruk av Git 
### prioriteringer 
- [ ] Få frem at det kommer detaljer lenger ned 
- [ ] Vise kunnskap i faget 
- [ ] 

## GRASP 
- [X] Generelt om GRASP 
- [X] Hvilke vi har hatt fokus på
GRASP (General Responsability Assignment Software Patterns) er en rekke prinsipper for objektorientert programmering. De handler om hvordan ansvarsområder i et program skal delegeres. Etterstreber man disse prinsippene, er ideen er at de vil gi kode som er lett å jobbe med, vedlikeholde og endre over tid dersom man følger dem. 

I vår oppgave har vi hatt særlig fokus på Low coupling, High Cohesion, Pure Fabrication og Polymorphism. Underpunktene som følger vil ta for seg hvert prinsipp.
### Controller
- [ ] Hva går det ut på? 
- [ ] Hvordan har vi brukt det? 
- [ ] Hva ga det oss?  
### Creator 
- [ ] Hva går det ut på? 
- [ ] Hvordan har vi brukt det? 
- [ ] Hva ga det oss?  
### High cohesion 
- [ ] Hva går det ut på? 
- [ ] Hvordan har vi brukt det? 
- [ ] Hva ga det oss?  
### Information expert 
- [ ] Hva går det ut på? 
- [ ] Hvordan har vi brukt det? 
- [ ] Hva ga det oss?  
### Low coupling 
- [ ] Hva går det ut på? 
- [ ] Hvordan har vi brukt det? 
- [ ] Hva ga det oss?  
### Polymorphism 
- [ ] Hva går det ut på? 
- [ ] Hvordan har vi brukt det? 
- [ ] Hva ga det oss?  
### Protected variations 
- [ ] Hva går det ut på? 
- [ ] Hvordan har vi brukt det? 
- [ ] Hva ga det oss?  
### Pure fabrication 
- [ ] Hva går det ut på? 
- [ ] Hvordan har vi brukt det? 
- [ ] Hva ga det oss?  

## Diagrammer 
### Klassediagram 
![Klassediagram]()
- [ ] Hva modelleres? 
- [ ] Hva gir diagrammet oss? 
- [ ] Forskjellige koblinger 
### Sekvensdiagram 
- [ ] Hva modelleres? 
- [ ] Hva gir diagrammet oss? 
- [ ] Forskjellige koblinger 
- [ ] Opt vs alt og hvorfor det som er valgt, er valgt 
- [ ] Nevn annen syntaks som synkron/asynkron
### Bruksdiagram ("Use case")- [ ] Hva modelleres? 
- [ ] Hva gir diagrammet oss? 
- [ ] Forskjellige koblinger 


## Design patterns 
- [ ] Generelt om design patterns 
- [ ] Hvilke vi har hatt fokus på
### Factory 
- [ ] Hva gjør det? 
- [ ] Hvor bruker vi dem?
- [ ] Hva oppnår de der de brukes? (GRASP?)
### Decorator 
- [ ] Hva gjør det? 
- [ ] Hvor bruker vi dem?
- [ ] Hva oppnår de der de brukes? (GRASP?)
### Singleton 
- [ ] Hva gjør det? 
- [ ] Hvor bruker vi dem?
- [ ] Hva oppnår de der de brukes? (GRASP?)
### Composite 
- [ ] Hva gjør det? 
- [ ] Hvor bruker vi dem?
- [ ] Hva oppnår de der de brukes? (GRASP?)
### Facade 
- [ ] Hva gjør det? 
- [ ] Hvor bruker vi dem?
- [ ] Hva oppnår de der de brukes? (GRASP?)
### Flyweight
- [ ] Hva gjør det? 
- [ ] Hvor bruker vi dem?
- [ ] Hva oppnår de der de brukes? (GRASP?)
### MVP 
- [ ] Hva gjør det? 
- [ ] Hvor bruker vi dem?
- [ ] Hva oppnår de der de brukes? (GRASP?)

## Trådsikkerhet 
- [ ] Kort om multithreading generelt 
- [ ] Hva oppstår ved kode som ikke er trådsikker 
- [ ] Trådsikkerhet i Random og vår implementasjon 
- [ ] Et konkret eksempel på bruk av random som ikke ville vært sikker (særlig dersom vår viser seg å være det)
- [ ] Trådsikkerhet i vår kode 

## Enhetstesting 
- [ ] Kort om hva det er 
- [ ] Hvor vi har brukt det 
- [ ] Hva man oppnår med enhetstester 
- [ ] Kort om TDD 

## Om C# og vår kode
### Operatoroverlasting 
Operatoroverlasning er en mulighet C# gir, som lar programmereren omdefinere hva vanlige operatorer (+, -, /, *, <, >, osv.) betyr mellom to typer. Har man en vektor-klasse, kan man for eksempel bestemme hva to instanser addert (+) med hverandre skal være. Vi har ikke funnet et naturlig sted for dette i vår løsning. Vi har allikevel tatt det med i Wallet-klassen for å demonstrere muligheten. 
### Regions 
Regioner er en måte å dele opp koden. Regionene legger ikke på funksjonalitet, men kan gjøre det mer oversiktelig for programmereren å gå gjennom den. Vi har anvendt regioner flere steder, blant annet i Simulation-klassen og i ItemFactory. 
### Properties 
### Kommentarer
### Konvensjoner 
Vi har etterstrebet å følge navnkonvensjoner som gjelder i C#. Det være seg blant annet "_"-prefiks på private klassevariable, stor forbokstav på metodenavn o.l. Her har vi fått mye støttet fra IDE-et vi brukte. Der hvor den har foreslått endringer, har vi stort sett gjennomført dem. Disse endringene inkluderer ternary-operatorer, null-propagation og bruk av "var"-nøkkelordet. 


