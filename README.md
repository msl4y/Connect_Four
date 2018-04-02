# Connect_Four
Final project for CS 438

Connect 4 is a game in which players try to win by getting 4 of their colored pieces in a row. 

This game is made using c# forms and graphics.Paint.
On launch, a user is directed to the main menu of the game. From here the user can choose 1 of 4 options.

-The first option for the user is to play human vs human. This allows 2 friends to take turns clicking on the 
  screen to play against each other. The user then chooses the size of the board from a newly launched form. 
  After the user chooses their choice of gameboard, the game is launched and users can start playing.

-The second option for the user is to play human vs computer. This allows a user to play against an AI when they want
  to play by themselves. After this choice is selected, an additional form is created, which allows users to select
  the difficulty of the AI. Easy uses a Random placement method, where the AI plays a piece in a random, valid spot.
  The hard difficulty uses Greedy Algorithm, in which the AI will play in the spot that gives them the most pieces in a row.
  After choosing the difficulty of the AI, the user chooses the size of the gameboard, and the game launches. Now the user
  can click to place their move, and the AI plays after. *Note: Human player is always first player.
  
-The third option allows the user to select a computer vs computer mode. From here the user will be asked to choose 
  the difficulties of both AI *(difficulty algorithms are the same as stated before)* After the user chooses the difficulties,
  they choose the size of the gameboard, the game launches, and the AI start playing against each other. 
  
-The fourth option simply closes the game.

Other specs of the game include:
  While a game is going, the user can click the display console button to see the previous moves of each player.
  The time limit for each move can be set from a dropdown menu.
