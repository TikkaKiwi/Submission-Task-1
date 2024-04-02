# Test Instructions

Command to run the User Registration Tests: "dotnet test --filter FullyQualifiedName~UserRegistrationService.Tests.UserRegistrationTests". This command runs every test method under the test class UserRegistrationTests that tests for valid or invalid user information when attempting to register a user. These tests include: Testing regestering a user with valid user information is accepted, testing regestering a user with different invalid user information is accepted, and testing if a registered user is succesfully added to the registeredUsers list.

Command to run the User Validation Tests: "dotnet test --filter FullyQualifiedName~UserRegistrationService.Tests.UserValidationTests".
This command runs every test method under the test class UserValidationTests that tests for specific valid or invalid user information. These tests include: Testing weather a users username, password or email is accepted when regestering a new user.

Command to run the User Uniqueness Tests: "dotnet test --filter FullyQualifiedName~UserRegistrationService.Tests.UserUniquenessTests". This command runs every test method under the test class UserUniquenessTests that tests if the user information is unique when compared to users already in the registeredUsers list. The tests include: Testign wether a duplicate username, email or both is accepted when registerring a new user.

# Reflektionsrapport

Utmaningar och hur jag övervann dem:
Det allra svåraste att förstå medan jag arbetade på projektet var hela konceptet med TDD (Test-Driven Development). Tanken att utveckla tester för kod och program som ännu inte skrivits var först svårt att greppa. Men efter att ha insett att testernas syfte är att kontrollera om koden uppfyller våra förväntningar blev allt klarare. Insikten att tester kan både "lyckas" och "misslyckas" och ändå anses vara godkända hjälpte mig att förstå TDD bättre.

Vad jag lärde mig:
Jag lärde mig att TDD är väldigt effektivt när man planerar alla tester noggrant innan man ens börjar skriva testkoden. Jag insåg att det ibland uppstår situationer där nya testfall dyker upp under processens gång, vilket kan bromsa programmeringshastigheten. Detta hände mig när jag hade färdigställt andra tester och kom på ytterligare tester som behövde implementeras.

Överväganden och antaganden:
En antagelse jag gjorde under utvecklingen var att "mer är bättre" när det kommer till antalet tester. Även om jag fortfarande är lite osäker på om detta alltid stämmer, känns det som en god strategi så länge testerna effektivt säkerställer att koden fungerar som avsett. För att hantera omfattningen av mina 16 tester försökte jag minska deras komplexitet genom att dela upp dem i tre olika kategorier (testklasser), vilket underlättade både organisationen och utförandet av testerna.