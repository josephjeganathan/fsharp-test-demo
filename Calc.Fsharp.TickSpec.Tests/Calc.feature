Feature: Adding two numbers


Scenario: Adding two positive numbers
  Given a calculator
   When 1 and 2 is added 
   Then result must be 3

Scenario: Adding two negative numbers
  Given a calculator
   When -1 and -2 is added 
   Then result must be -3

Scenario: Negative and positve numbers
  Given a calculator
   When 1 and -2 is added 
   Then result must be -1

Scenario Outline: Adding two numbers returns expected result
  Given a calculator
   When <x> and <y> is added
   Then result must be <expectedResult>

Examples:
| x | y |expectedResult|
| 1 | 2 |       3      |
| -1| -2|      -3      |
| 1 | -2|      -1      |
|100|200|      300     |
