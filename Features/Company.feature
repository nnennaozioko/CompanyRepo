Feature: As a student I want to register successfully

  @test
  Scenario Outline: CountryConatct
    Given I navigate to the "https://www.w3schools.com/html/html_tables.asp"
    Then HTML Table is display
    When I enter the <company>
    And I enter <contact>
    And I enter the <country>
    Then the <compay> <contact> <country> is displayed
    
    Examples: 
    | Company                      | contact         | country   |
    | Alfreds Futterkiste          | Francisco chang | Germany   |
    | Centro comercial Moctezuma   | Francisco chang | Mexico    |
    | Ernst Handel                 | Roland Mendel   | Australia |
    | Island Trading               | Helen Bennet    | UK        |
    | Laughing Bacchus Winecellars | Yoshi Tannamuri | Canada    |
    
    

     
  