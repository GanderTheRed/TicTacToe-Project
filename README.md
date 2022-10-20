# ITEC140-A05

## Mark Breakdown
- Variable Declarations [3]
- Comments [1]
- Game Functionality [5]
- Score Functionality [5] 
- Winner Functionality [10]
- Reset Functionality [2.5]
- Score Display [2.5] 
- Make git commits as you complete the assignment minimum 4 [4 marks]
- (Optional) Make the symbol the user can use to represent X's and O's customizable [No marks]
- (Optional) Find a way to have the computer make a move [No marks] 

# Class Level Variables (Fields):

- int intXscore
- int intOscore
- string strXsymbol
- string strOsymbol
- bool blnOsTurn

# Buttons to represent the Game Board:

- btnR1C1
- btnR1C2
- btnR1C3
- btnR2C1
- btnR2C2
- btnR2C3
- btnR3C1
- btnR3C2
- btnR3C3

As each button is clicked, you should display the symbol in that button, and set it's enabled property to false.

![image](https://user-images.githubusercontent.com/6656242/196521943-9f4d75f2-d0f2-48c7-8e7f-9e1b5fc311be.png)

Here is an image with added labels to show you how the rows and columns are indexed, please do not add these labels in your project:

![image](https://user-images.githubusercontent.com/6656242/196522667-66e0f035-2a20-4539-ac61-26e0e3e1b866.png)

# Logic to check for a winner:

You will need to check and see if any 3 buttons in a row or column have the same symbol, if they do, a winner has been found, increment the winners score.
Diagonals that are all the same also indicate a winner, check for this and increment the winners score if they are the same.

Once a winner is found, and you have incremented the score, reset the board so another game can be played.

![image](https://user-images.githubusercontent.com/6656242/196524253-6a5922e4-452f-4566-b261-bfd82f428ca2.png)

## Hand-In
Please download the finished code from Github and upload it to Blackboard before the due date.

 
## Expectations
This assignment should be completed individually, please ask your instructor for clarification where needed.  Receiving help or feedback from classmates is okay, but do not share or copy any materials that will be added to the assignment submission.  Help your classmates learn to program but, do not share code/files.  Any code that you find on the internet can be referenced in comments, where necessary.
