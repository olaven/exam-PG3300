# eksamen-PG3300
Exam in Software Design, at Kristiania University College

## Todos 
- [ ] Use case for salesman (i det eksisterende, vise generalisering)
- [ ] Klassediagram -> Alle patterns 
- [X] Sekvensdiagram for factory 
- [ ] Gå over alle klasser og se om klassediagrammet matcher implementasjon 
- [ ] Multithreaded løsning (trådsikker!)
- [ ] Implementering 
    - [ ] Operator overlasting 
    - [ ] c#-style kommentar-doc
    - [X] Properties 
    - [X] "java-style" felter også, for å vise at vi kan det
    - [X] Ha flere projects i en solution 
    - [X] Bruke c# regions 
    - [X] To namespaces
    - [ ] Unit testing med NUnit
    * C# sin Random funksjonalitet er i seg selv ikke trådsikker, løsninger på dette kan googles.
    * Det er greit å benytte Sleepfor å simulere at deler av løsningen tar tid/få tiden til å gå. (Ikke der vi har brukt det så langt)
    * Der hvor noe er med kun for å være med, må det nevnes BÅDE i kode og i dokumentasjon 
- [ ] Dokumentasjon
    - [ ] Simulering av folks interagering med et marked, ikke en simulering av et marked 
    - [ ] Gå igjennom at det ikke finnes variabler som ikke blir brukt. Endre så i klassediagram om det skjer en endring!
    - [ ] Patterns dokumenteres 
        - [ ] Factory -> Itemfactory 
        - [ ] Decorator -> ItemDecorator (Vi har ac, ikke interface -> hvorfor!)
        - [ ] Singleoton -> Market 
        - [ ] Composite -> ?? Kanskje person sayhi? 
        - [ ] Facade -> Act (?) 
        - [ ] Flyweight -> ?? 
        - [ ] MVP -> ?? 
    - [ ] Skriv om regions 
    - [ ] Skriv om kommentar-doc 
    - [ ] Skriv om operator-overlsting - ha med for å ha det med 
    - [ ] Skriv om events (delegation?? slå opp term)
    - [ ] Skriv om Unit testing 
        - [ ] Hva det er 
        - [ ] Hvor vi har brukt det 
        - [ ] Hvorfor det brukes 
    - [ ] Skriv om multithreadingen, og hva som kunne skjedd om den ikke var trådsikker
    - [ ] Skriv om diagrammene (med bilde)
        - [ ] Use case 
        - [ ] Class diagram 
            - [ ] Forskjellige koblinger 
        - [ ] Sequence diagram 
            - [ ] Opt vs alt og hvorfor det som er valgt, er valgt 
            - [ ] Nevn annen syntaks som synkron/asynkron
            - [ ] Nevn referanser dersom ikke brukt 
    - [ ] Composition vs aggregation med eksempler til class diagram 
    - [ ] Forklar alle patterns
        - [ ] Hva gjør de 
        - [ ] Hvor bruker vi dem 
        - [ ] Hva oppnår de der de brukes (GRASP?)
    - [ ] Skriv om GRASP 
        - [ ] Hva er de? 
        - [ ] Hvorfor bruke dem? 
        - [ ] Hvor brukes 
            - [ ] Controller -> Kanskje releveant? 
            - [ ] Creator -> Mange eksempler, trekk frem 2
            - [ ] High Cohesion -> Mange eksempler, trekk frem 2
            - [ ] Information Expert -> Mange eksempler, trekk frem  2
            - [ ] Low coupling -> generelt 
            - [ ] Polymorphism -> Person (item?)
            - [ ] Protected variations -> Interface for Item 
            - [ ] Pure fabrication -> Kanskje factory? 

Dag 1: 

Vi startet dagen i dag med å gå igjennom UML. Da gikk vi dere å diskutere hva som skal være med i ett USE CASE diagram før vi gjorde noe annet. Vi brukte godt med tid, men kom fram til et godt resultat som muligens kan endres.
