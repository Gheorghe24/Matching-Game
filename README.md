# C# Matching Game
One of my first projects in Highschool
-------------------------------------
The goal of the game is to form pairs of matching symbols until all available symbols are revealed.

First, we initialize 2 variables "firstclicked" and "secondclicked". We use the random function to choose the symbols at random. Thus, we select 8 pairs of characters, using the Webdings font, each selected character has a symbol / image.

AssignIconsToSquares
---------------------
This function randomly assigns a specific symbol to each square.

label_Click
-----------
The given function is activated when we click on a square, if the timer is active or if the symbol has already been revealed, we exit the function. When you click on a square for the first time, the image appears, then, selecting another square, the function asks if the varours of these symbols are equal. In this case, both images are saved and remain revealed

winner
--------
The winner function determines if all squares are revealed and displays the MessageBox with the message “Congratulations, you won! ”.

