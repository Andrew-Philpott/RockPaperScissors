# RockPaperScissors

#### RockPaperScissors Game 03.04.2020\_

#### By _**Andrew Philpott**_

## Description

This application is a console based RockPaperScissors game for 2 players or against a computer.

## Specs

- _Spec: The application should return "Draw" when the players choices match_

  - Input: "Rock" "Rock"
  - Output: "Draw"

- _Spec: The application should return -1 when a players choice isnt "Rock", "Scissors", or "Paper."_

  - Input: "Rck"
  - Output: -1

  - _Spec: The application should return 2 when a players choice is "Rock"._

  - Input: "Rock"
  - Output: 2

- _Spec: The application should return 1 when a players choice is "Scissors"._

  - Input: "Scissors"
  - Output: 1

- _Spec: The application should return 0 when a players choice is "Paper"._

  - Input: "Paper"
  - Output: 0

- _Spec: The application should return "Player 1" when player one's choice equals "Paper" and player two's choice equals "Rock"._

  - Input: Player one: "Paper" Player two: "Rock"
  - Output: "Player 1"

- _Spec: The application should return "Player 2" when player one's choice equals "Rock" and player two's choice equals "Paper"._

  - Input: Player one: "Rock" Player two: "Paper"
  - Output: "Player 2"

- _Spec: The application should return "Player 1" when player one's choice is greater than player two's choice and player one's choice doesn't equal "Rock" and player two's choice doesn't equal "Paper"._

  - Input: Player one: "Rock" Player two: "Scissors"
  - Output: "Player 1"

- _Spec: The application should return "Player 2" when player two's choice is greater than player one's choice and player two's choice doesn't equal "Rock" and player ones's choice doesn't equal "Paper"._
  - Input: Player one: "Scissors" Player Two: "Rock"
  - Output: "Player 2"

## Setup/Installation Requirements

- Clone this repository.
- \$dotnet restore in tests
- \$dotnet build in main project folder

## Known Bugs

- No known bugs

## Support and contact details

- Issues or concerns? Contact us at andrewphilpott92@gmail.com

## Technologies Used

- C#
- .NET Core 2.2

### License

Copyright (c) 2020 **_Andrew Philpott_**

_This software is licensed under the MIT license._
