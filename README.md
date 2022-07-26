# PokeDexMVC

This MVC App was created to fulfill the project requirements for the Code Kentucky C# Programming (2) course.

The app was created to allow my son to enter the name of a Pokemon and then view its opponent information. He is always very interested to know which Pokemon is strong or weak against another Pokemon.

To run this app, please view the package management console and 'add-migration init' and update database.

Launch the app by clicking 'Run'.

The landing page/home page will display a picture of Pikachu and the 'Gotta Catch Them All' phrase. The app is preloaded with seed data so when you click the "View Your Pokemon" link at the top, you will be directed to a display of the current pokemon stored in the database. On your first pass, this will only be Pikachu. From here, you can view the Pokemon's details by click the "Details" link. 

### Definitions/Data:  
    1.) Your current Pokemon's Primary Type 
    2.) Your Pokemon's secondary type 
    3.) Strongly Attacks: a list of the Pokemon that your current Pokemon will delivery high damage 
    4.) Weakly Attacks: a list of the Pokemon that your current Pokemon will deliver low damage
    5.) Weakly Defends: a list of the Pokemon that your current Pokemon can shield itself against with little success
    6.) Strongly Defends: a list of the Pokemon that your current Pokemon can shield itslef against with greater success (little or no damage)

Returning back to the list will display your Pokemon name again. To add more Pokemon, click "Create New". The only required information is the correct spelling of a known Pokemon.

Back on the "View Your Pokemon" you also have the option to edit or delete a Pokemon entry.

### Project requirements met:

#### Required:
    1.) There are at least 3 methods with at least one returning and usig a value. In the Pokemon class there are 4 methods which returns values called from the Pokemon Controller and displayed on the 'Details' page.
    2.) Create an instance of an object and fill it with data: I created a Pokemon instance and filled it with the name Pikachu and left the remaining entries       blank.
#### Features (3 Required):
    1.) One class inherits from another. The OpponentType class inherits from the PokemonType class.
    2.) This App connects to and reads in information from the PokeApi. This is defined in the PokemonClient.cs
    3.) This App is an MVC App built with EF. It reads and writes data to a database and displays the values in the app. Per Ernesto, this is a feature that would   fulfill a Features list requirement.
