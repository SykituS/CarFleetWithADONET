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
        - Dodawanie statusu pojazdu oraz przetrzymywanie hisotrii
        
# Instalacja programu

    Aby program mógł prawidłowo funkcjonować wymagane jest wykonanie nastepujących kroków:
        - Postawienie bazy danych dla programu w technologii MS SQL - Program przychodzi z gotowym plikiem dla bazy danych, wystarczy go odpalić w odpowiednim środowisku
        - Modyfikacja Connection Stringa aby nawiązać połączenie z bazą ->
        - Uruchomienie skryptu "CreateStarterUser" w postawionej przez nas bazie, skrypt utworzy wówczas podstawowego użytkownika admin o haśle admin który umożliwi nam na zalogowanie się do aplikacji.
        - Uruchomienie programu z pliku .exe:
            - Jeśli wykonaliśmy poprawnie poprzednie kroki wówczas możemy zalogować się do programu podając dane 
            użytkownik: admin
            hasło: admin
            Po poprawnym zalogowaniu się proszę o udanie się do sekcji "Employee list" i o modyfikację hasła (więcej informacji jak to zrobić znajduje się w dokumentacji)
