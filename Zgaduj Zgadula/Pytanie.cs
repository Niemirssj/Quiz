using System;
using System.Collections.Generic;
using System.Text;

namespace Zgaduj_Zgadula
{
    using System;
    using System.Collections.Generic;

        public class Pytanie
        {
            public string Tresc { get; set; }  
            public List<string> Odpowiedzi { get; set; }  
            public int IndeksPrawidlowejOdpowiedzi { get;  set; }  
            public string Typ { get; set; }

        
            public Pytanie(string tresc, string odpowiedzA, string odpowiedzB, string odpowiedzC, string odpowiedzD, int indeksPrawidlowejOdpowiedzi, string typ)
            {
                Typ = typ;
                Tresc = tresc;
                Odpowiedzi = new List<string> { odpowiedzA, odpowiedzB, odpowiedzC, odpowiedzD };

            
                if (indeksPrawidlowejOdpowiedzi < 0 || indeksPrawidlowejOdpowiedzi >= Odpowiedzi.Count)
                {
                    throw new ArgumentException("Nieprawidłowy indeks prawidłowej odpowiedzi.");
                }

                IndeksPrawidlowejOdpowiedzi = indeksPrawidlowejOdpowiedzi;
            }

        
            public bool CzyOdpowiedzPoprawna(int indeksOdpowiedziUzytkownika)
            {
                return indeksOdpowiedziUzytkownika == IndeksPrawidlowejOdpowiedzi;
            }
        }

    // Klasy LAB z pytaniami
    public static class LAB1
    {
        public static List<Pytanie> Pytania = new List<Pytanie>
    {
        new Pytanie("Co to jest mechanizm polimorfizmu?",
                    "A. Ustalanie wersji metody na podstawie typu obiektu.",
                    "B. Mechanizm tworzenia dynamicznych zmiennych.",
                    "C. Proces dodawania nowych metod do klasy.",
                    "D. Metoda kompilacji kodu.",
                    0,
                    "LAB1"),

        new Pytanie("Podaj przykłady działania mechanizmu polimorfizmu.",
                    "A. Klasa bazowa z metodą wirtualną i klasa pochodna nadpisująca tę metodę.",
                    "B. Wykorzystanie zmiennych globalnych.",
                    "C. Zmiana wartości zmiennych lokalnych.",
                    "D. Użycie metod zewnętrznych bibliotek.",
                    0,
                    "LAB1"),

        new Pytanie("Jakie jest znaczenie metod wirtualnych i ich nadpisania?",
                    "A. Pozwalają na dynamiczne wywołanie metod w klasach pochodnych.",
                    "B. Zmieniają typ danych w czasie działania programu.",
                    "C. Umożliwiają utworzenie nowych klas.",
                    "D. Służą do optymalizacji pamięci.",
                    0,
                    "LAB1"),

        new Pytanie("Co to są listy inicjalizacyjne i jak je stosujemy?",
                    "A. Syntaktyka do inicjalizacji kolekcji obiektów w czasie tworzenia.",
                    "B. Narzędzia do zarządzania pamięcią.",
                    "C. Mechanizm do tworzenia dynamicznych zmiennych.",
                    "D. Metoda do ładowania danych z pliku.",
                    0,
                    "LAB1"),

        new Pytanie("W jaki sposób definiujemy dziedziczenie w C#?",
                    "A. Klasa bazowa i klasa pochodna z użyciem dwukropka (:).",
                    "B. Przez kopiowanie kodu klasy bazowej.",
                    "C. Poprzez implementację interfejsów.",
                    "D. Używając operatora '->'.",
                    0,
                    "LAB1"),

        new Pytanie("Czym są właściwości i jakie mają znaczenie?",
                    "A. Umożliwiają dostęp do prywatnych pól klasy w sposób kontrolowany.",
                    "B. Służą do przechowywania danych użytkownika.",
                    "C. Używane są do zarządzania pamięcią.",
                    "D. Zawierają metody statyczne.",
                    0,
                    "LAB1"),

        new Pytanie("Czym różni się metoda wirtualna od metody abstrakcyjnej?",
                    "A. Wirtualna ma ciało, abstrakcyjna nie.",
                    "B. Wirtualna jest implementowana, abstrakcyjna jest deklaratywna.",
                    "C. Abstrakcyjna nie może być nadpisana.",
                    "D. Wirtualna jest tylko dla klas statycznych.",
                    0,
                    "LAB1"),

        new Pytanie("Czym jest klasa bazowa i jakie ma zastosowanie?",
                    "A. Klasa, z której dziedziczą inne klasy, zawierająca wspólne dla nich metody i właściwości.",
                    "B. Klasa do przechowywania lokalnych zmiennych.",
                    "C. Klasa implementująca wszystkie interfejsy.",
                    "D. Klasa, która nie może być używana bezpośrednio.",
                    0,
                    "LAB1"),
    };
    }

    public static class LAB2
    {
        public static List<Pytanie> Pytania = new List<Pytanie>
    {
        new Pytanie("Co to jest mechanizm polimorfizmu?",
                    "A. Ustalanie wersji metody na podstawie typu obiektu.",
                    "B. Mechanizm tworzenia dynamicznych zmiennych.",
                    "C. Proces dodawania nowych metod do klasy.",
                    "D. Metoda kompilacji kodu.",
                    0,
                    "LAB2"),

        new Pytanie("Jakie są różnice między metodami wirtualnymi i abstrakcyjnymi?",
                    "A. Metoda wirtualna ma ciało, a metoda abstrakcyjna nie.",
                    "B. Metoda abstrakcyjna jest opcjonalna, wirtualna jest obowiązkowa.",
                    "C. Metoda wirtualna nie może być nadpisana.",
                    "D. Metoda abstrakcyjna jest implementowana automatycznie.",
                    0,
                    "LAB2"),

        new Pytanie("Jaki jest cel korzystania z mechanizmu wyrzucania wyjątków?",
                    "A. Obsługa błędów w kontrolowany sposób.",
                    "B. Ukrywanie błędów przed użytkownikiem.",
                    "C. Poprawa wydajności programu.",
                    "D. Zmiana sposobu kompilacji kodu.",
                    0,
                    "LAB2"),

        new Pytanie("Jakie jest znaczenie słów kluczowych i bloków związanych z wyrzucaniem wyjątków?",
                    "A. try, catch, finally - do zarządzania wyjątkiem.",
                    "B. break, continue - do kontroli pętli.",
                    "C. public, private - do dostępu do danych.",
                    "D. async, await - do programowania asynchronicznego.",
                    0,
                    "LAB2"),

        new Pytanie("Dlaczego tworzymy własne klasy wyjątków?",
                    "A. Aby dostosować obsługę błędów do specyficznych potrzeb aplikacji.",
                    "B. Aby zwiększyć szybkość działania aplikacji.",
                    "C. Aby ukryć szczegóły implementacyjne kodu.",
                    "D. Aby rozszerzyć możliwości języka C#.",
                    0,
                    "LAB2"),

        new Pytanie("Co to jest obsługa wyjątków i na czym polega?",
                    "A. Proces przechwytywania błędów i reagowania na nie.",
                    "B. Proces kompilacji kodu.",
                    "C. Proces optymalizacji pamięci.",
                    "D. Proces debugowania kodu.",
                    0,
                    "LAB2"),

        new Pytanie("Czym jest instrukcja try-catch i jak działa?",
                    "A. Blok kodu służący do przechwytywania wyjątków i reagowania na nie.",
                    "B. Słowo kluczowe do deklarowania zmiennych.",
                    "C. Komenda do zakończenia pętli.",
                    "D. Słowo kluczowe do deklarowania metod.",
                    0,
                    "LAB2"),
    };
    }

    public static class LAB3
    {
        public static List<Pytanie> Pytania = new List<Pytanie>
    {
        new Pytanie("Co to jest polimorfizm i jakie są przykłady jego zastosowania?",
                    "A. Możliwość używania metod o tej samej nazwie w różnych klasach. Przykłady: dziedziczenie, interfejsy.",
                    "B. Zmienianie typu danych w czasie działania programu.",
                    "C. Dodawanie nowych metod do istniejących klas.",
                    "D. Optymalizacja kodu.",
                    0,
                    "LAB3"),

        new Pytanie("Co to jest interfejs i jak go definiujemy?",
                    "A. Zbiór abstrakcyjnych metod do implementacji w klasach. Definiujemy go za pomocą słowa kluczowego 'interface'.",
                    "B. Klasa z metodami statycznymi.",
                    "C. Typ danych.",
                    "D. Wbudowany moduł .NET.",
                    0,
                    "LAB3"),

        new Pytanie("Kiedy warto dodać nowy interfejs do projektu?",
                    "A. Kiedy potrzebujemy zdefiniować kontrakt dla różnych klas.",
                    "B. Kiedy chcemy zainicjalizować nowe obiekty.",
                    "C. Kiedy optymalizujemy pamięć.",
                    "D. Kiedy dodajemy nowe zmienne.",
                    0,
                    "LAB3"),

        new Pytanie("Co to jest baza wspólnego kodu?",
                    "A. Kod, który jest wspólny dla różnych klas i projektów, często umieszczony w interfejsach lub klasach bazowych.",
                    "B. Zbiór danych do obsługi błędów.",
                    "C. Narzędzie do tworzenia nowych klas.",
                    "D. Komponent do optymalizacji kodu.",
                    0,
                    "LAB3"),

        new Pytanie("Co nam daje zaimplementowanie interfejsu w klasie?",
                    "A. Możliwość użycia metod zdefiniowanych w interfejsie w klasie implementującej.",
                    "B. Zmienia typ danych klasy.",
                    "C. Dodaje nowe zmienne do klasy.",
                    "D. Umożliwia optymalizację pamięci.",
                    0,
                    "LAB3"),

        new Pytanie("Czym jest klasa abstrakcyjna i jakie ma zastosowanie?",
                    "A. Klasa, która nie może być instancjonowana, ale może zawierać metody z implementacją, oraz może być dziedziczona.",
                    "B. Klasa, która nie może mieć metod.",
                    "C. Klasa, której metody są zawsze publiczne.",
                    "D. Klasa z metodami statycznymi.",
                    0,
                    "LAB3"),

        new Pytanie("Jakie są różnice między klasą abstrakcyjną a interfejsem?",
                    "A. Klasa abstrakcyjna może mieć implementację metod, interfejs tylko deklaracje metod.",
                    "B. Klasa abstrakcyjna nie może mieć metod, interfejs może.",
                    "C. Interfejsy są zawsze publiczne, klasy abstrakcyjne są prywatne.",
                    "D. Interfejsy są używane tylko w metodach asynchronicznych.",
                    0,
                    "LAB3"),
    };
    }

    public static class LAB4
    {
        public static List<Pytanie> Pytania = new List<Pytanie>
    {
        new Pytanie("Co to jest enkapsulacja?",
                    "A. Ukrywanie szczegółów implementacji klasy i udostępnianie tylko niezbędnych metod.",
                    "B. Proces kompilacji kodu.",
                    "C. Metoda dodawania nowych klas.",
                    "D. Proces optymalizacji pamięci.",
                    0,
                    "LAB4"),

        new Pytanie("Jakie są zasady tworzenia właściwości w klasie?",
                    "A. Deklaracja pól prywatnych i udostępnianie ich przez publiczne właściwości.",
                    "B. Deklaracja wszystkich właściwości jako publiczne.",
                    "C. Tworzenie metod do zarządzania zmiennymi globalnymi.",
                    "D. Tworzenie metod statycznych do inicjalizacji obiektów.",
                    0,
                    "LAB4"),

        new Pytanie("Czym są właściwości autoimplementowane i kiedy ich używamy?",
                    "A. Właściwości, które automatycznie tworzą prywatne pole do przechowywania wartości.",
                    "B. Właściwości, które są zawsze prywatne.",
                    "C. Właściwości, które nie mogą być modyfikowane.",
                    "D. Właściwości używane tylko w interfejsach.",
                    0,
                    "LAB4"),

        new Pytanie("Co to jest dostęp do pól w klasie?",
                    "A. Mechanizm umożliwiający odczyt i zapis wartości pól klasy przez metody.",
                    "B. Proces kompilacji kodu.",
                    "C. Proces optymalizacji pamięci.",
                    "D. Proces tworzenia nowych metod.",
                    0,
                    "LAB4"),

        new Pytanie("Jakie są różnice między modyfikatorami dostępu publicznym, prywatnym i chronionym?",
                    "A. Publiczny: dostęp z każdego miejsca; Prywatny: dostęp tylko w obrębie klasy; Chroniony: dostęp w obrębie klasy i klas pochodnych.",
                    "B. Publiczny: dostęp tylko w obrębie klasy; Prywatny: dostęp z każdego miejsca; Chroniony: dostęp tylko w obrębie pakietu.",
                    "C. Publiczny: dostęp z klasy bazowej; Prywatny: dostęp tylko z zewnątrz; Chroniony: dostęp z każdego miejsca.",
                    "D. Publiczny: dostęp tylko w obrębie metody; Prywatny: dostęp z klasy pochodnej; Chroniony: dostęp tylko z zewnątrz.",
                    0,
                    "LAB4"),

        new Pytanie("Co to jest konstruktor i jakie ma zastosowanie?",
                    "A. Metoda wywoływana przy tworzeniu obiektu, służąca do inicjalizacji obiektu.",
                    "B. Metoda używana do usuwania obiektów.",
                    "C. Metoda statyczna do zarządzania pamięcią.",
                    "D. Metoda do obsługi wyjątków.",
                    0,
                    "LAB4"),

        new Pytanie("Jakie są różnice między konstruktorem domyślnym a parametryzowanym?",
                    "A. Konstruktor domyślny nie przyjmuje żadnych parametrów, parametryzowany przyjmuje.",
                    "B. Konstruktor domyślny jest używany tylko w klasach abstrakcyjnych.",
                    "C. Konstruktor parametryzowany nie może być przeciążany.",
                    "D. Konstruktor domyślny wymaga definicji pól prywatnych.",
                    0,
                    "LAB4"),
    };
    }

    public static class LAB5
    {
        public static List<Pytanie> Pytania = new List<Pytanie>
    {
        new Pytanie("Czym jest dziedziczenie i jakie ma zastosowanie?",
                    "A. Mechanizm umożliwiający tworzenie nowych klas na podstawie istniejących, dziedzicząc ich właściwości i metody.",
                    "B. Proces dodawania nowych metod do klasy.",
                    "C. Proces tworzenia zmiennych globalnych.",
                    "D. Proces zarządzania pamięcią.",
                    0,
                    "LAB5"),

        new Pytanie("Co to jest klasa pochodna i jakie są jej właściwości?",
                    "A. Klasa, która dziedziczy właściwości i metody z klasy bazowej, może nadpisywać metody bazowe.",
                    "B. Klasa, która nie może dziedziczyć żadnych właściwości.",
                    "C. Klasa, która dziedziczy tylko metody statyczne.",
                    "D. Klasa, która nie może być używana jako baza dla innych klas.",
                    0,
                    "LAB5"),

        new Pytanie("Czym są metody przesłonięte i jakie mają zastosowanie?",
                    "A. Metody w klasie pochodnej, które nadpisują metody klasy bazowej.",
                    "B. Metody, które nie mogą być wywoływane z zewnątrz klasy.",
                    "C. Metody używane tylko w klasach abstrakcyjnych.",
                    "D. Metody do optymalizacji kodu.",
                    0,
                    "LAB5"),

        new Pytanie("Co to jest zasada podstawienia Liskov?",
                    "A. Zasada, która mówi, że obiekty klasy bazowej powinny być wymienialne na obiekty klasy pochodnej bez wpływu na poprawność programu.",
                    "B. Zasada, która mówi, że metody muszą być zawsze publiczne.",
                    "C. Zasada, która mówi, że klasy pochodne muszą być zawsze abstrakcyjne.",
                    "D. Zasada, która mówi, że metody muszą być zawsze prywatne.",
                    0,
                    "LAB5"),

        new Pytanie("Jakie są różnice między dziedziczeniem a kompozycją?",
                    "A. Dziedziczenie pozwala na rozszerzenie funkcjonalności klasy, kompozycja na używanie obiektów innych klas w ramach jednej klasy.",
                    "B. Dziedziczenie używa tylko metod, kompozycja tylko zmiennych.",
                    "C. Dziedziczenie jest wykorzystywane tylko w interfejsach, kompozycja w klasach.",
                    "D. Dziedziczenie i kompozycja są tym samym.",
                    0,
                    "LAB5"),

        new Pytanie("Co to jest zasada pojedynczej odpowiedzialności?",
                    "A. Zasada, która mówi, że klasa powinna mieć tylko jedną odpowiedzialność lub powód do zmiany.",
                    "B. Zasada, która mówi, że klasy powinny być jak najbardziej rozbudowane.",
                    "C. Zasada, która mówi, że każda klasa powinna mieć więcej niż jedną metodę.",
                    "D. Zasada, która mówi, że klasy powinny być dziedziczone z interfejsów.",
                    0,
                    "LAB5"),

        new Pytanie("Czym jest interfejs i jakie ma zastosowanie?",
                    "A. Zbiór abstrakcyjnych metod i właściwości, które mogą być zaimplementowane przez klasy.",
                    "B. Klasa zawierająca tylko metody statyczne.",
                    "C. Typ danych do przechowywania obiektów.",
                    "D. Metoda do optymalizacji kodu.",
                    0,
                    "LAB5"),
    };
    }

    public static class LAB6
    {
        public static List<Pytanie> Pytania = new List<Pytanie>
    {
        new Pytanie("Co to jest wyjątek i jak go obsługujemy?",
                    "A. Wyjątek to błąd w trakcie działania programu, który obsługujemy za pomocą bloków try-catch.",
                    "B. Wyjątek to problem z kompilacją kodu.",
                    "C. Wyjątek to sposób optymalizacji pamięci.",
                    "D. Wyjątek to sposób tworzenia nowych klas.",
                    0,
                    "LAB6"),

        new Pytanie("Jakie są podstawowe elementy obsługi wyjątków?",
                    "A. Bloki try, catch, finally, throw.",
                    "B. Bloki if, else, switch, break.",
                    "C. Bloki for, while, foreach.",
                    "D. Bloki using, dispose.",
                    0,
                    "LAB6"),

        new Pytanie("Co to jest blok finally i jakie ma zastosowanie?",
                    "A. Blok w obsłudze wyjątków, który wykonuje się niezależnie od tego, czy wyjątek został rzucony czy nie.",
                    "B. Blok, który wykonuje się tylko wtedy, gdy wyjątek został rzucony.",
                    "C. Blok, który wykonuje się tylko w przypadku braku błędów.",
                    "D. Blok, który jest używany do tworzenia nowych metod.",
                    0,
                    "LAB6"),

        new Pytanie("Jakie są różnice między wyjątkiem sprawdzanym a niesprawdzanym?",
                    "A. Wyjątek sprawdzany musi być zadeklarowany w sygnaturze metody lub obsłużony, wyjątek niesprawdzany nie.",
                    "B. Wyjątek sprawdzany jest zawsze obsługiwany przez blok finally.",
                    "C. Wyjątek niesprawdzany nie może być obsługiwany przez blok catch.",
                    "D. Wyjątek sprawdzany jest tylko w czasie kompilacji, niesprawdzany tylko w czasie działania.",
                    0,
                    "LAB6"),

        new Pytanie("Co to jest klasa wyjątku i jak ją tworzymy?",
                    "A. Klasa, która dziedziczy po klasie Exception, służąca do definiowania własnych wyjątków.",
                    "B. Klasa, która dziedziczy po klasie Error.",
                    "C. Klasa, która zawiera metody do obsługi błędów kompilacji.",
                    "D. Klasa używana do zarządzania pamięcią.",
                    0,
                    "LAB6"),

        new Pytanie("Jakie są najlepsze praktyki przy obsłudze wyjątków?",
                    "A. Unikanie obsługi wyjątków w kodzie produkcyjnym, logowanie wyjątków, precyzyjne rzutowanie wyjątków.",
                    "B. Zawsze rzucanie wyjątków w każdym bloku try.",
                    "C. Rzucanie wyjątków tylko w przypadku błędów kompilacji.",
                    "D. Ignorowanie wyjątków, które nie są krytyczne.",
                    0,
                    "LAB6"),

        new Pytanie("Co to jest ładowanie dynamiczne?",
                    "A. Mechanizm, który pozwala na załadowanie i używanie typów w czasie działania programu.",
                    "B. Mechanizm, który pozwala na załadowanie kodu tylko w czasie kompilacji.",
                    "C. Mechanizm, który optymalizuje kod w czasie kompilacji.",
                    "D. Mechanizm, który optymalizuje zarządzanie pamięcią.",
                    0,
                    "LAB6"),
    };
    }

    public static class LAB7
    {
        public static List<Pytanie> Pytania = new List<Pytanie>
    {
        new Pytanie("Co to jest analiza statyczna kodu?",
                    "A. Proces analizowania kodu bez jego wykonywania, w celu wykrycia błędów i problemów.",
                    "B. Proces wykonywania kodu w czasie rzeczywistym.",
                    "C. Proces kompilacji kodu.",
                    "D. Proces testowania kodu w różnych środowiskach.",
                    0,
                    "LAB7"),

        new Pytanie("Co to jest analiza dynamiczna kodu?",
                    "A. Proces analizowania kodu w czasie rzeczywistym podczas jego wykonywania.",
                    "B. Proces analizy kodu przed kompilacją.",
                    "C. Proces tworzenia dokumentacji kodu.",
                    "D. Proces kompilacji kodu.",
                    0,
                    "LAB7"),

        new Pytanie("Co to jest profilowanie kodu?",
                    "A. Proces mierzenia wydajności kodu i identyfikacji wąskich gardeł.",
                    "B. Proces pisania testów jednostkowych.",
                    "C. Proces tworzenia dokumentacji kodu.",
                    "D. Proces optymalizacji pamięci.",
                    0,
                    "LAB7"),

        new Pytanie("Jakie narzędzia służą do analizy statycznej kodu?",
                    "A. Narzędzia takie jak SonarQube, ESLint, StyleCop.",
                    "B. Narzędzia takie jak JUnit, NUnit, MSTest.",
                    "C. Narzędzia takie jak Git, SVN, Mercurial.",
                    "D. Narzędzia takie jak Docker, Kubernetes.",
                    0,
                    "LAB7"),

        new Pytanie("Jakie narzędzia służą do analizy dynamicznej kodu?",
                    "A. Narzędzia takie jak Dynatrace, New Relic, AppDynamics.",
                    "B. Narzędzia takie jak SonarQube, ESLint, StyleCop.",
                    "C. Narzędzia takie jak Git, SVN, Mercurial.",
                    "D. Narzędzia takie jak Docker, Kubernetes.",
                    0,
                    "LAB7"),

        new Pytanie("Co to jest testowanie jednostkowe?",
                    "A. Proces testowania pojedynczych jednostek kodu w celu zapewnienia ich poprawności.",
                    "B. Proces testowania całego systemu jako całości.",
                    "C. Proces testowania kodu w czasie rzeczywistym.",
                    "D. Proces analizy kodu przed kompilacją.",
                    0,
                    "LAB7"),

        new Pytanie("Jakie narzędzia służą do testowania jednostkowego?",
                    "A. Narzędzia takie jak JUnit, NUnit, MSTest.",
                    "B. Narzędzia takie jak SonarQube, ESLint, StyleCop.",
                    "C. Narzędzia takie jak Git, SVN, Mercurial.",
                    "D. Narzędzia takie jak Docker, Kubernetes.",
                    0,
                    "LAB7"),
    };
    }

    public static class LAB8
    {
        public static List<Pytanie> Pytania = new List<Pytanie>
    {
        new Pytanie("Co to jest algorytm sortowania i jakie są jego przykłady?",
                    "A. Proces uporządkowania danych według określonego porządku; przykłady to sortowanie bąbelkowe, szybkie sortowanie, sortowanie przez wstawianie.",
                    "B. Proces kompresji danych.",
                    "C. Proces wyszukiwania danych w bazie danych.",
                    "D. Proces konwersji danych do formatu JSON.",
                    0,
                    "LAB8"),

        new Pytanie("Co to jest algorytm wyszukiwania i jakie są jego przykłady?",
                    "A. Proces znajdowania elementu w zbiorze danych; przykłady to wyszukiwanie binarne, wyszukiwanie liniowe.",
                    "B. Proces kompresji danych.",
                    "C. Proces sortowania danych.",
                    "D. Proces konwersji danych do formatu XML.",
                    0,
                    "LAB8"),

        new Pytanie("Co to jest analiza złożoności czasowej i przestrzennej algorytmów?",
                    "A. Ocena, jak algorytm wpływa na czas wykonywania i zużycie pamięci w zależności od rozmiaru danych wejściowych.",
                    "B. Ocena, jak algorytm kompresuje dane.",
                    "C. Ocena, jak algorytm konwertuje dane.",
                    "D. Ocena, jak algorytm jest zintegrowany z systemem operacyjnym.",
                    0,
                    "LAB8"),

        new Pytanie("Co to jest złożoność czasowa algorytmu?",
                    "A. Miara czasu wykonywania algorytmu w zależności od rozmiaru danych wejściowych.",
                    "B. Miara pamięci używanej przez algorytm.",
                    "C. Miara złożoności kodu źródłowego.",
                    "D. Miara liczby metod w algorytmie.",
                    0,
                    "LAB8"),

        new Pytanie("Co to jest złożoność przestrzenna algorytmu?",
                    "A. Miara pamięci używanej przez algorytm w zależności od rozmiaru danych wejściowych.",
                    "B. Miara czasu wykonywania algorytmu.",
                    "C. Miara liczby zmiennych w algorytmie.",
                    "D. Miara liczby operacji w algorytmie.",
                    0,
                    "LAB8"),

        new Pytanie("Jakie są różnice między algorytmem sortowania bąbelkowego a szybkim sortowaniem?",
                    "A. Sortowanie bąbelkowe jest prostsze, ale mniej wydajne; szybkie sortowanie jest bardziej złożone, ale bardziej efektywne.",
                    "B. Sortowanie bąbelkowe jest bardziej wydajne niż szybkie sortowanie.",
                    "C. Szybkie sortowanie jest bardziej złożone niż sortowanie przez wstawianie.",
                    "D. Szybkie sortowanie jest bardziej złożone, ale mniej wydajne niż sortowanie bąbelkowe.",
                    0,
                    "LAB8"),

        new Pytanie("Co to jest algorytm sortowania przez wstawianie i jak działa?",
                    "A. Algorytm, który sortuje dane przez wstawianie każdego elementu w odpowiednie miejsce w posortowanej części tablicy.",
                    "B. Algorytm, który sortuje dane przez dzielenie tablicy na mniejsze części.",
                    "C. Algorytm, który sortuje dane przez porównywanie każdego elementu z każdym innym.",
                    "D. Algorytm, który sortuje dane przez wymienianie miejscami elementów.",
                    0,
                    "LAB8"),
    };
    }
        public static class egzamin
        {
            public static List<Pytanie> Pytania = new List<Pytanie>
{
    new Pytanie(
        "Co to jest .NET?",
        "Wielojęzyczna platforma programistyczna.",
        "System operacyjny.",
        "Język programowania.",
        "Baza danych.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Co jest wynikiem kompilacji programu napisanego na platformie .NET?",
        "Pakiet w postaci pliku .dll lub .exe.",
        "Plik tekstowy.",
        "Dokument HTML.",
        "Obrazek.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Jakie rodzaje typów możemy definiować w języku C#?",
        "Klasy, interfejsy, delegaty, struktury, enumeracje, rekordy.",
        "Tylko klasy.",
        "Tylko interfejsy.",
        "Tylko delegaty.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Na czym polega obsługa wyjątków?",
        "Na przekazaniu informacji o błędzie do kodu wywołującego.",
        "Na ignorowaniu błędów.",
        "Na tworzeniu kopii zapasowych.",
        "Na testowaniu kodu.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Na czym polega polimorfizm?",
        "Na ustaleniu wersji metody na podstawie typu obiektu.",
        "Na tworzeniu wielu obiektów.",
        "Na dziedziczeniu klas.",
        "Na kompilacji kodu.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Czym się różni metoda wirtualna od metody abstrakcyjnej?",
        "Metoda wirtualna ma implementację, a abstrakcyjna nie.",
        "Obie są takie same.",
        "Metoda wirtualna nie ma implementacji.",
        "Metoda abstrakcyjna jest zawsze publiczna.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Co to jest klasa abstrakcyjna?",
        "Klasa, której instancji nie można tworzyć.",
        "Klasa, która nie ma pól.",
        "Klasa, która jest finalna.",
        "Klasa, która nie może dziedziczyć.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Co to jest interfejs?",
        "Zbiór abstrakcyjnych składowych, które mogą być implementowane.",
        "Typ, którego instancji nie można tworzyć.",
        "Typ, który nie ma właściwości.",
        "Typ, który nie ma metod.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Po co w klasie implementować interfejs?",
        "Aby skorzystać z gotowej funkcjonalności.",
        "Aby zwiększyć złożoność kodu.",
        "Aby ograniczyć funkcjonalność.",
        "Aby uniknąć dziedziczenia.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Z czego lepiej skorzystać do zaimplementowania warstwy abstrakcji?",
        "Z interfejsu, gdy nie chcemy definiować gotowych składowych.",
        "Z klasy bazowej, aby dziedziczyć wszystkie metody.",
        "Z klas, aby zwiększyć złożoność.",
        "Z obiektów, aby uniknąć typowania.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Na czym polega generyczność?",
        "Na tworzeniu szablonów dla typów i metod.",
        "Na definiowaniu tylko jednego typu.",
        "Na używaniu typów statycznych.",
        "Na tworzeniu klas niegenerycznych.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Co to są delegaty?",
        "Silnie typowane wskaźniki do metod.",
        "Wskaźniki do obiektów.",
        "Typy dynamiczne.",
        "Typy kolekcji.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Co to są metody rozszerzeniowe?",
        "Statyczne metody wywoływane na obiektach wskazanego typu.",
        "Metody wywoływane tylko na statycznych klasach.",
        "Metody, które nie mają argumentów.",
        "Metody, które nie mogą być publiczne.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Do czego używamy słówka var?",
        "Do niejawnego typowania zmiennych lokalnych.",
        "Do definiowania zmiennych statycznych.",
        "Do typowania globalnego.",
        "Do deklaracji interfejsów.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Do czego wykorzystujemy właściwości?",
        "Do kontroli dostępu do prywatnych pól w klasie.",
        "Do definiowania klas.",
        "Do pisania metod.",
        "Do tworzenia interfejsów.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Na czym polega refleksja?",
        "Na pozyskiwaniu informacji o typach w czasie działania programu.",
        "Na kompilacji kodu.",
        "Na tworzeniu obiektów.",
        "Na definiowaniu metod.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Na czym polega serializacja?",
        "Na przekształceniu stanu obiektu do postaci serii bajtów.",
        "Na tworzeniu obiektów.",
        "Na kopiowaniu obiektów.",
        "Na przechowywaniu danych w plikach.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    ),
    new Pytanie(
        "Co to jest ADO.NET?",
        "API do łatwego korzystania z systemów bazodanowych.",
        "Typ bazy danych.",
        "Język programowania.",
        "Metoda kompilacji.",
        0, // Odpowiedź A jest prawidłowa
        "egzamin"
    )
};
        }
    

}
