namespace TicTacToeStart
{
    using System.Threading;
    public partial class Form1 : Form
    {

        //Assigning variables to use in the program
        int intXscore;                              //Track scores
        int intOscore;
        string strXsymbol = "X";                    //Symbols for the game.
        string strOsymbol = "O";
        bool blnOsTurn = true;                     //Keep track of computers turn.
        int turnNo = 1;                             //Sets turn number (so that the computer wont try to press a button with no buttons left)

        string WinCondition = "OOO";                //Concatenation required for win conditions.
        string WinCondition2 = "XXX";               
        Random random = new Random();

        public void WinConditions()                         //Checks win conditions in tictactoe.
        {
            if (blnOsTurn == false)                          //Checks who's turn it is, and then runs win conditions.
            {
                if (turnNo == 10)                                    //In case nobody wins after 10 turns
                {
                    if ((btnR1C1.Text + btnR1C2.Text + btnR1C3.Text == WinCondition) || //Horizontal win conditions for the player
                    (btnR2C1.Text + btnR2C2.Text + btnR2C3.Text == WinCondition) ||
                    (btnR3C1.Text + btnR3C2.Text + btnR3C3.Text == WinCondition) ||
                    (btnR1C1.Text + btnR2C1.Text + btnR3C1.Text == WinCondition) || //Vertical win conditions
                    (btnR1C2.Text + btnR2C2.Text + btnR3C2.Text == WinCondition) ||
                    (btnR1C3.Text + btnR2C3.Text + btnR3C3.Text == WinCondition) ||
                    (btnR1C1.Text + btnR2C2.Text + btnR3C3.Text == WinCondition) || //Diagonal win conditions
                    (btnR1C3.Text + btnR2C2.Text + btnR3C1.Text == WinCondition))
                    {
                        intOscore++;
                        MessageBox.Show("O Won!");              //Message box to show the winner.
                        
                        btnR1C1.Enabled = true;     //Re-enables all buttons.
                        btnR2C1.Enabled = true;
                        btnR3C1.Enabled = true;
                        btnR1C2.Enabled = true;
                        btnR2C2.Enabled = true;
                        btnR3C2.Enabled = true;
                        btnR1C3.Enabled = true;
                        btnR2C3.Enabled = true;
                        btnR3C3.Enabled = true;
                        btnR1C1.Text = "";     //Clears all buttons text.
                        btnR2C1.Text = "";
                        btnR3C1.Text = "";
                        btnR1C2.Text = "";
                        btnR2C2.Text = "";
                        btnR3C2.Text = "";
                        btnR1C3.Text = "";
                        btnR2C3.Text = "";
                        btnR3C3.Text = "";
                        lblOWins.Text = intOscore.ToString();
                        turnNo = 1;
                    }
                    else if ((btnR1C1.Text + btnR1C2.Text + btnR1C3.Text == WinCondition2) || //Horizontal win conditions for the computer
                    (btnR2C1.Text + btnR2C2.Text + btnR2C3.Text == WinCondition2) ||
                    (btnR3C1.Text + btnR3C2.Text + btnR3C3.Text == WinCondition2) ||
                    (btnR1C1.Text + btnR2C1.Text + btnR3C1.Text == WinCondition2) || //Vertical win conditions
                    (btnR1C2.Text + btnR2C2.Text + btnR3C2.Text == WinCondition2) ||
                    (btnR1C3.Text + btnR2C3.Text + btnR3C3.Text == WinCondition2) ||
                    (btnR1C1.Text + btnR2C2.Text + btnR3C3.Text == WinCondition2) || //Diagonal win conditions
                    (btnR1C3.Text + btnR2C2.Text + btnR3C1.Text == WinCondition2))
                    {
                        intXscore++;
                        MessageBox.Show("X Won!");
                        
                        btnR1C1.Enabled = true;     //Re-enables all buttons.
                        btnR2C1.Enabled = true;
                        btnR3C1.Enabled = true;
                        btnR1C2.Enabled = true;
                        btnR2C2.Enabled = true;
                        btnR3C2.Enabled = true;
                        btnR1C3.Enabled = true;
                        btnR2C3.Enabled = true;
                        btnR3C3.Enabled = true;
                        btnR1C1.Text = "";     //Clears all buttons text.
                        btnR2C1.Text = "";
                        btnR3C1.Text = "";
                        btnR1C2.Text = "";
                        btnR2C2.Text = "";
                        btnR3C2.Text = "";
                        btnR1C3.Text = "";
                        btnR2C3.Text = "";
                        btnR3C3.Text = "";
                        lblXWins.Text = intXscore.ToString();
                        turnNo = 1;
                    }
                    else
                    {
                        MessageBox.Show("Nobody won! It's a draw!");
                        
                        btnR1C1.Enabled = true;     //Re-enables all buttons.
                        btnR2C1.Enabled = true;
                        btnR3C1.Enabled = true;
                        btnR1C2.Enabled = true;
                        btnR2C2.Enabled = true;
                        btnR3C2.Enabled = true;
                        btnR1C3.Enabled = true;
                        btnR2C3.Enabled = true;
                        btnR3C3.Enabled = true;
                        btnR1C1.Text = "";     //Clears all buttons text.
                        btnR2C1.Text = "";
                        btnR3C1.Text = "";
                        btnR1C2.Text = "";
                        btnR2C2.Text = "";
                        btnR3C2.Text = "";
                        btnR1C3.Text = "";
                        btnR2C3.Text = "";
                        btnR3C3.Text = "";
                        turnNo = 1;
                    }
                }
                else if ((btnR1C1.Text + btnR1C2.Text + btnR1C3.Text == WinCondition) || //Horizontal win conditions for the player
                    (btnR2C1.Text + btnR2C2.Text + btnR2C3.Text == WinCondition) ||
                    (btnR3C1.Text + btnR3C2.Text + btnR3C3.Text == WinCondition) ||
                    (btnR1C1.Text + btnR2C1.Text + btnR3C1.Text == WinCondition) || //Vertical win conditions
                    (btnR1C2.Text + btnR2C2.Text + btnR3C2.Text == WinCondition) ||
                    (btnR1C3.Text + btnR2C3.Text + btnR3C3.Text == WinCondition) ||
                    (btnR1C1.Text + btnR2C2.Text + btnR3C3.Text == WinCondition) || //Diagonal win conditions
                    (btnR1C3.Text + btnR2C2.Text + btnR3C1.Text == WinCondition))
                {
                    intOscore++;
                    MessageBox.Show("O Won!");
                    
                    btnR1C1.Enabled = true;     //Re-enables all buttons.
                    btnR2C1.Enabled = true;
                    btnR3C1.Enabled = true;
                    btnR1C2.Enabled = true;
                    btnR2C2.Enabled = true;
                    btnR3C2.Enabled = true;
                    btnR1C3.Enabled = true;
                    btnR2C3.Enabled = true;
                    btnR3C3.Enabled = true;
                    btnR1C1.Text = "";     //Clears all buttons text.
                    btnR2C1.Text = "";
                    btnR3C1.Text = "";
                    btnR1C2.Text = "";
                    btnR2C2.Text = "";
                    btnR3C2.Text = "";
                    btnR1C3.Text = "";
                    btnR2C3.Text = "";
                    btnR3C3.Text = "";
                    lblOWins.Text = intOscore.ToString();
                    turnNo = 1;
                }
                
            }
            else if (blnOsTurn == true)
            {
                if (turnNo == 10)                                    //In case nobody wins after 10 turns
                {
                    if ((btnR1C1.Text + btnR1C2.Text + btnR1C3.Text == WinCondition) || //Horizontal win conditions for the player
                    (btnR2C1.Text + btnR2C2.Text + btnR2C3.Text == WinCondition) ||
                    (btnR3C1.Text + btnR3C2.Text + btnR3C3.Text == WinCondition) ||
                    (btnR1C1.Text + btnR2C1.Text + btnR3C1.Text == WinCondition) || //Vertical win conditions
                    (btnR1C2.Text + btnR2C2.Text + btnR3C2.Text == WinCondition) ||
                    (btnR1C3.Text + btnR2C3.Text + btnR3C3.Text == WinCondition) ||
                    (btnR1C1.Text + btnR2C2.Text + btnR3C3.Text == WinCondition) || //Diagonal win conditions
                    (btnR1C3.Text + btnR2C2.Text + btnR3C1.Text == WinCondition))
                    {
                        MessageBox.Show("O Won!");
                        
                        intOscore++;
                        btnR1C1.Enabled = true;     //Re-enables all buttons.
                        btnR2C1.Enabled = true;
                        btnR3C1.Enabled = true;
                        btnR1C2.Enabled = true;
                        btnR2C2.Enabled = true;
                        btnR3C2.Enabled = true;
                        btnR1C3.Enabled = true;
                        btnR2C3.Enabled = true;
                        btnR3C3.Enabled = true;
                        btnR1C1.Text = "";     //Clears all buttons text.
                        btnR2C1.Text = "";
                        btnR3C1.Text = "";
                        btnR1C2.Text = "";
                        btnR2C2.Text = "";
                        btnR3C2.Text = "";
                        btnR1C3.Text = "";
                        btnR2C3.Text = "";
                        btnR3C3.Text = "";
                        lblOWins.Text = intOscore.ToString();
                        turnNo = 1;
                    }
                    else if ((btnR1C1.Text + btnR1C2.Text + btnR1C3.Text == WinCondition2) || //Horizontal win conditions for the computer
                    (btnR2C1.Text + btnR2C2.Text + btnR2C3.Text == WinCondition2) ||
                    (btnR3C1.Text + btnR3C2.Text + btnR3C3.Text == WinCondition2) ||
                    (btnR1C1.Text + btnR2C1.Text + btnR3C1.Text == WinCondition2) || //Vertical win conditions
                    (btnR1C2.Text + btnR2C2.Text + btnR3C2.Text == WinCondition2) ||
                    (btnR1C3.Text + btnR2C3.Text + btnR3C3.Text == WinCondition2) ||
                    (btnR1C1.Text + btnR2C2.Text + btnR3C3.Text == WinCondition2) || //Diagonal win conditions
                    (btnR1C3.Text + btnR2C2.Text + btnR3C1.Text == WinCondition2))
                    {
                        intXscore++;
                        MessageBox.Show("X Won!");
                        
                        btnR1C1.Enabled = true;     //Re-enables all buttons.
                        btnR2C1.Enabled = true;
                        btnR3C1.Enabled = true;
                        btnR1C2.Enabled = true;
                        btnR2C2.Enabled = true;
                        btnR3C2.Enabled = true;
                        btnR1C3.Enabled = true;
                        btnR2C3.Enabled = true;
                        btnR3C3.Enabled = true;
                        btnR1C1.Text = "";     //Clears all buttons text.
                        btnR2C1.Text = "";
                        btnR3C1.Text = "";
                        btnR1C2.Text = "";
                        btnR2C2.Text = "";
                        btnR3C2.Text = "";
                        btnR1C3.Text = "";
                        btnR2C3.Text = "";
                        btnR3C3.Text = "";
                        lblXWins.Text = intXscore.ToString();
                        turnNo = 1;
                    }
                    else
                    {
                        MessageBox.Show("Nobody won! It's a draw!");
                        
                        btnR1C1.Enabled = true;     //Re-enables all buttons.
                        btnR2C1.Enabled = true;
                        btnR3C1.Enabled = true;
                        btnR1C2.Enabled = true;
                        btnR2C2.Enabled = true;
                        btnR3C2.Enabled = true;
                        btnR1C3.Enabled = true;
                        btnR2C3.Enabled = true;
                        btnR3C3.Enabled = true;
                        btnR1C1.Text = "";     //Clears all buttons text.
                        btnR2C1.Text = "";
                        btnR3C1.Text = "";
                        btnR1C2.Text = "";
                        btnR2C2.Text = "";
                        btnR3C2.Text = "";
                        btnR1C3.Text = "";
                        btnR2C3.Text = "";
                        btnR3C3.Text = "";
                        turnNo = 1;
                    }
                }
                else if ((btnR1C1.Text + btnR1C2.Text + btnR1C3.Text == WinCondition2) || //Horizontal win conditions for the computer
                    (btnR2C1.Text + btnR2C2.Text + btnR2C3.Text == WinCondition2) ||
                    (btnR3C1.Text + btnR3C2.Text + btnR3C3.Text == WinCondition2) ||
                    (btnR1C1.Text + btnR2C1.Text + btnR3C1.Text == WinCondition2) || //Vertical win conditions
                    (btnR1C2.Text + btnR2C2.Text + btnR3C2.Text == WinCondition2) ||
                    (btnR1C3.Text + btnR2C3.Text + btnR3C3.Text == WinCondition2) ||
                    (btnR1C1.Text + btnR2C2.Text + btnR3C3.Text == WinCondition2) || //Diagonal win conditions
                    (btnR1C3.Text + btnR2C2.Text + btnR3C1.Text == WinCondition2))
                {
                    intXscore++;
                    Thread.Sleep(200);
                    MessageBox.Show("X Won!");
                   
                    btnR1C1.Enabled = true;     //Re-enables all buttons.
                    btnR2C1.Enabled = true;
                    btnR3C1.Enabled = true;
                    btnR1C2.Enabled = true;
                    btnR2C2.Enabled = true;
                    btnR3C2.Enabled = true;
                    btnR1C3.Enabled = true;
                    btnR2C3.Enabled = true;
                    btnR3C3.Enabled = true;
                    btnR1C1.Text = "";     //Clears all buttons text.
                    btnR2C1.Text = "";
                    btnR3C1.Text = "";
                    btnR1C2.Text = "";
                    btnR2C2.Text = "";
                    btnR3C2.Text = "";
                    btnR1C3.Text = "";
                    btnR2C3.Text = "";
                    btnR3C3.Text = "";
                    lblXWins.Text = intXscore.ToString();
                    turnNo = 1;
                }
                
            }
            
        }

        public void ComputerAi()
        {
            int buttonIndex = random.Next(0, 9);            //Figures out which button the computer wants to press using a random number.
            WinConditions();
            
            
                switch (buttonIndex)
                {
                    case 0:
                        if (btnR1C1.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR1C1.PerformClick();
                            
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;

                    case 1:
                        if (btnR2C1.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR2C1.PerformClick();
                           
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;

                    case 2:
                        if (btnR3C1.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR3C1.PerformClick();
                            
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;

                    case 3:
                        if (btnR1C2.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR1C2.PerformClick();
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;

                    case 4:
                        if (btnR2C2.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR2C2.PerformClick();
                          
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;

                    case 5:
                        if (btnR3C2.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR3C2.PerformClick();
                            
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;

                    case 6:
                        if (btnR1C3.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR1C3.PerformClick();
                            
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;

                    case 7:
                        if (btnR2C3.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR2C3.PerformClick();
                           
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;

                    case 8:
                        if (btnR3C3.Enabled == true)
                        {
                        Thread.Sleep(200);
                        btnR3C3.PerformClick();
                        }
                        else
                        {
                            ComputerAi();
                        }
                        break;
                }

            
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnR1C1_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)                              //Decides what code to run based on the button thats disabled.
            {

                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        if (btnR1C1.Enabled == false)
                        {
                            ComputerAi();               //if the button it already disabled look for a different button
                        }
                        else if (btnR1C1.Enabled == true)
                        {
                            btnR1C1.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR1C1.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR1C1.Text = strOsymbol.ToString();
                        btnR1C1.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR1C1.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR1C1.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR1C1.Text = strOsymbol.ToString();
                        btnR1C1.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }
        }

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnR1C2_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)
            {

                switch (blnOsTurn)                                  //checks who's turn it is.
                {
                    case false:
                        if (btnR1C2.Enabled == false)
                        {
                            ComputerAi();                 //if the button it already disabled look for a different button
                        }
                        else if (btnR1C2.Enabled == true)
                        {
                            btnR1C2.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR1C2.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;
                        }
                        break;

                    case true:
                        btnR1C2.Text = strOsymbol.ToString();
                        btnR1C2.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR1C2.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR1C2.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR1C2.Text = strOsymbol.ToString();
                        btnR1C2.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }

        }

        private void btnR1C3_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)
            {

                switch (blnOsTurn)                                  //checks who's turn it is.
                {
                    case false:
                        if (btnR1C3.Enabled == false)
                        {
                            ComputerAi();                 //if the button it already disabled look for a different button
                        }
                        else if (btnR1C3.Enabled == true)
                        {
                            btnR1C3.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR1C3.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;
                        }
                        break;

                    case true:
                        btnR1C3.Text = strOsymbol.ToString();
                        btnR1C3.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR1C3.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR1C3.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR1C3.Text = strOsymbol.ToString();
                        btnR1C3.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }
        }

        private void btnR2C1_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)
            {

                switch (blnOsTurn)                                  //checks who's turn it is.
                {
                    case false:
                        if (btnR2C1.Enabled == false)
                        {
                            ComputerAi();               //if the button it already disabled look for a different button
                        }
                        else if (btnR2C1.Enabled == true)
                        {
                            btnR2C1.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR2C1.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;
                        }
                        break;

                    case true:
                        btnR2C1.Text = strOsymbol.ToString();
                        btnR2C1.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR2C1.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR2C1.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR2C1.Text = strOsymbol.ToString();
                        btnR2C1.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }
        }

        private void btnR2C2_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)
            {

                switch (blnOsTurn)                                  //checks who's turn it is.
                {
                    case false:
                        if (btnR2C2.Enabled == false)
                        {
                            ComputerAi();                 //if the button it already disabled look for a different button
                        }
                        else if (btnR2C2.Enabled == true)
                        {
                            btnR2C2.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR2C2.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;
                        }
                        break;

                    case true:
                        btnR2C2.Text = strOsymbol.ToString();
                        btnR2C2.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR2C2.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR2C2.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR2C2.Text = strOsymbol.ToString();
                        btnR2C2.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }
        }

        private void btnR2C3_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)
            {

                switch (blnOsTurn)                                  //checks who's turn it is.
                {
                    case false:
                        if (btnR2C3.Enabled == false)
                        {
                            ComputerAi();                //if the button it already disabled look for a different button
                        }
                        else if (btnR2C3.Enabled == true)
                        {
                            btnR2C3.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR2C3.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;
                        }
                        break;

                    case true:
                        btnR2C3.Text = strOsymbol.ToString();
                        btnR2C3.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR2C3.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR2C3.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR2C3.Text = strOsymbol.ToString();
                        btnR2C3.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }
        }

        private void btnR3C1_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)
            {
                switch (blnOsTurn)                                  //checks who's turn it is.
                {
                    case false:
                        if (btnR3C1.Enabled == false)
                        {
                            ComputerAi();                //if the button it already disabled look for a different button
                        }
                        else if (btnR3C1.Enabled == true)
                        {
                            btnR3C1.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR3C1.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;
                        }
                        break;

                    case true:
                        btnR3C1.Text = strOsymbol.ToString();
                        btnR3C1.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR3C1.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR3C1.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR3C1.Text = strOsymbol.ToString();
                        btnR3C1.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }
        }

        private void btnR3C2_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)
            {

                switch (blnOsTurn)                                  //checks who's turn it is.
                {
                    case false:
                        if (btnR3C2.Enabled == false)
                        {
                            ComputerAi();              //if the button it already disabled look for a different button
                        }
                        else if (btnR3C2.Enabled == true)
                        {
                            btnR3C2.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR3C2.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;
                        }
                        break;

                    case true:
                        btnR3C2.Text = strOsymbol.ToString();
                        btnR3C2.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR3C2.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR3C2.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR3C2.Text = strOsymbol.ToString();
                        btnR3C2.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }
        }

        private void btnR3C3_Click(object sender, EventArgs e)
        {
            if (btnVSCPU.Enabled == false)
            {
                switch (blnOsTurn)                                  //checks who's turn it is.
                {
                    case false:
                        if (btnR3C3.Enabled == false)
                        {
                            ComputerAi();               //if the button it already disabled look for a different button
                        }
                        else if (btnR3C3.Enabled == true)
                        {
                            btnR3C3.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR3C3.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;
                        }
                        break;

                    case true:
                        btnR3C3.Text = strOsymbol.ToString();
                        btnR3C3.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        ComputerAi();
                        break;
                }
                WinConditions();
            }
            else if (btn2Player.Enabled == false)                       
            {
                switch (blnOsTurn)                                      //checks who's turn it is.
                {
                    case false:
                        {
                            btnR3C3.Text = strXsymbol.ToString();       //Sets the text value to whoevers turn it is.
                            btnR3C3.Enabled = false;                    //Disables the button from the game.
                            blnOsTurn = true;                     //Swaps turn to the human.
                            turnNo++;                                   //Increments the turn number.
                        }
                        break;

                    case true:
                        btnR3C3.Text = strOsymbol.ToString();
                        btnR3C3.Enabled = false;
                        blnOsTurn = false;
                        turnNo++;
                        break;
                }
                WinConditions();
            }
            else
            {
                MessageBox.Show("Please Select a game mode!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            intXscore = 0;                              //Reset scores
            intOscore = 0;
            turnNo = 1;
            btnR1C1.Enabled = true;     //Re-enables all buttons.
            btnR2C1.Enabled = true;
            btnR3C1.Enabled = true;
            btnR1C2.Enabled = true;
            btnR2C2.Enabled = true;
            btnR3C2.Enabled = true;
            btnR1C3.Enabled = true;
            btnR2C3.Enabled = true;
            btnR3C3.Enabled = true;
            btnR1C1.Text = "";     //Clears all buttons text.
            btnR2C1.Text = "";
            btnR3C1.Text = "";
            btnR1C2.Text = "";
            btnR2C2.Text = "";
            btnR3C2.Text = "";
            btnR1C3.Text = "";
            btnR2C3.Text = "";
            btnR3C3.Text = "";
            lblOWins.Text = intOscore.ToString();
            lblXWins.Text = intXscore.ToString();
        }

        private void btnVSCPU_Click(object sender, EventArgs e)
        {
            btnVSCPU.Enabled = false;
            btn2Player.Enabled = true;
            btnReset.PerformClick();                    //Resets game state
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            btnVSCPU.Enabled = true;
            btn2Player.Enabled = false;
            btnReset.PerformClick();                    //Resets game state
        }
    }
}