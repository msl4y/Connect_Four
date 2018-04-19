# Connect_Four
Final project for CS 438

Connect 4 is a game in which players try to win by getting 4 of their colored pieces in a row. 

This game is made using c# forms and graphics.Paint.
On launch, a user is directed to the main menu of the game. From here the user can choose 1 of 4 options.

The first option for the user is to play human vs human. This allows 2 friends to take turns clicking on the 
  screen to play against each other. The user then chooses the size of the board from a newly launched form. 
  After the user chooses their choice of gameboard, then the game is launched. To start the game, a user needs to
  clicks the start game button at the top of the game. This allows users to start placing moves.

The second option for the user is to play human vs computer. This allows a user to play against an AI when they want
  to play by themselves. After this choice is selected, an additional form is created, which allows users to select
  an AI program. This is a user created program, that is explained in more depth below. Then the user chooses the 
  size of the gameboard. After this option, the game board is displayed. Finally, the user clicks the start game button
  to begin the game. *Note: Human always goes first*
  
The third option allows the user to select a computer vs computer mode. From here the user will be asked to choose 
  the programs for both AI. After the user chooses the difficulties, they choose the size of the gameboard, 
  the game launches, the user clicks the start game button, and the AI start playing against each other. 
  
The fourth option simply closes the game.

AI Functionality:
  The AI for this game are created in other programs. A user can make another program, but this program requires a
  gameComm.cs file. This file reads the board.txt (which is produced by the interface), runs an algorithm that is created
  by a student, and prints the move to move.txt. 
    The AI program must have gameComm.cs to read the board and print the move, and an AI.cs to contain the algorithm for
    the AI.
  2 sample AI are provided:
    1. One is an easy opponent. This is random AI. This AI produces a move in a valid spot in a 
       random column. The move is purely random. 
    2. The other is a greedy algorithm. This one is an AI that looks for the most pieces in a row.
  

Other specs of the game include:
  While a game is going, the user can click the display console button to see the previous moves of each player, as 
  well as being able to debug the program.
  
  The time limit for each move can be set from a dropdown menu.
