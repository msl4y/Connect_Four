# Connect_Four
Final project for CS 438

Connect 4 is a game in which players try to win by getting 4 of their colored pieces in a row. 

This game is made using c# forms and graphics.Paint.

On launch, a user is directed to the main menu of the game. From here the user can choose 1 of 4 options:
- The first option for the user is to play human vs human. This allows 2 friends to take turns clicking on the 
  screen to play against each other. The user then chooses the size of the board from a newly launched form. 
  After the user chooses their choice of game board size, the game is launched. To start game play, the user must click the start game button.

- The second option for the user is to play human vs computer. This allows a user to play against an AI when they want
  to play by themselves. After this choice is selected, an additional form is created, which allows users to select
  the AI program. The user should click "Choose AI", then a file explorer is launched, where the user can choose a .exe *Note: The .exe MUST have a gameComm.cs file inside of it*. The .exe file is a program that a user can write and use to make and test their own AI algorithm. After choosing the program for the AI, the user chooses the size of the gameboard, and the game launches. Now the user can click to place their move, and the AI plays after. To start game play, the user must click the start game button. *Note: Human player is always first player.*
  
- The third option allows the user to select a computer vs computer mode. From here the user will be asked to pick 
  the program for both AI *(choice is the same logic as in Human Vs Computer)* After the user chooses the difficulties,
  they choose the size of the gameboard, the game launches, and the AI start playing against each other. To start game play, the user must click the start game button.
  
- The fourth option simply closes the game.

Other specs of the game include:
  - While a game is going, the user can click the display console button to see the previous moves of each player.
  - The time limit for each move can be set from a dropdown menu.
