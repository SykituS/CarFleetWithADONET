# Zarządzanie flotą samochodową dla Firm
# Wstęp
    Program ma na celu umożliwienie łatwiejszego zarzadzania flotą pojazdów służbowych.

    W możliwości programu wchodzi:
        - Dodawanie i przetrzymywanie informacji o użytkownikach firmy
        - Dodawanie i przetrzymywanie informacji o pojazdach służbowych
        - Dodawanie i przetrzymywanie historii pracowników którzy korzystali z podanego pojazdu
        - Dodawanie i przetrzymywanie historii przebiegu pojazdu
        - Dodawanie i przetrzymywanie historii ubezpieczenia dla pojazdu
        - Dodawanie i przetrzymywanie historii przeglądów pojazdu
        - Dodawanie i zarządzanie dodatkowymi informacjami o pojeździe 
        - Dodawanie statusu pojazdu oraz przetrzymywanie historii
        
# Informacje wstępne odnośnie uruchomienia, działania

    Używany framework: .NET Framework 4.7.2

    uruchomienie programu:
        - Do działania aplikacji wymagane jest postawienie bazy danych MS SQL:
            W folderze DataBaseScripts znajdują się 2 skrypty:
                1 skrypt CreateCarFleetDBScript utworzy bazę danych CarFleet
                    Jeśli baza tworzy się niepoprawie wówczas można skorzystać z skryptu CarFleetDBScript znajdującego się w folderze Scripts
                2 skrypt CreateAdminUser wstawi dane do tabeli Persons i Users tworząc konto administratora o loginie: admin i haśle: admin
        - Projekt programu uruchamiamy z pliku CarFleet.sln
        - Jeśli wymagane jest modyfikacja connection stringa to możemy tego dokonać w CarFleetDomain -> Context 
        - Uruchomić program możemy albo z pozycji środowiska programistycznego klikając F5 (tryb debbugowania) lub Ctrl + F5 (tryb realase)
          lub też udając się do CarFleet -> bin -> Debug i uruchomiając plik CarFleet.exe
        - Po uruchomieniu aplikacji pojawia się panel logowania gdzie jako login podajemy admin i jako hasło admin
        
    Foldery:
        - Documentation: W tym folderze znajduje się dokumentacja programu
        - CreateCarFleetDBScript: Skrypty wymagane do poprawnego działania aplikacji
        - Scripts: Skrypty deweloperskie słuzące do generowania sztucznych danych, używać tylko w celach testowych
        - CarFleet: Folder zawierający głównie front end aplikacji
        - CarFleetDomain: Folder zawierający głównie back end aplikacji
