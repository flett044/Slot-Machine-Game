// Programmer:  Caleb Huyser
// Class:       CIS207-10228
// Date Due:    11/18/23
// Assignment:  Programming Assignment #3 
//
// Description:
// This program demonstrates array usage, file handling, error providers, beginning method usage, and loops. Players can add their
// names to a list for later play. The program generates ann array of 3 random numbers that are used to display images on the form. A loop searches the array
// for a match then calculates how much money a player wins based upon the amount they enter.
// The results of each players turn are saved in a list box. When the user is done the results of every games
// are saved in a comma deliminated text file. The report can then be read back onto the form. An avg amount of money for
// all players is calculsted along with total number of players and total amount won.
//*****************************************************************************

using HuyserCG3.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Array;
using System.IO;

namespace HuyserCG3
{
    public partial class SlotMachinesForm : Form
    {
        // Holds the random numbers generated in the GenerateRandom() method.
        private int[] randomNumbersArray = new int[3];

        // Holds the refernces to all image filed displayed on the form each spin
        private Image[] fruitImageArray = new Image[10] {
                                                        Resources.Apple,
                                                        Resources.Lime,
                                                        Resources.Lemon,
                                                        Resources.Orange,
                                                        Resources.Watermelon,
                                                        Resources.Banana,
                                                        Resources.Cherries,
                                                        Resources.Grapes,
                                                        Resources.Strawberry,
                                                        Resources.Pear
                                                        };

        // # of games won for each player
        private int numberOfGamesWonInt = 0;

        // # of games for each player
        int numberOfGamesInt = 0;

        // Total of winnings each game
        private decimal totalWinningsDecimal = 0.0m;

        // Total of winnings for each player (aka each turn)
        private decimal accumTotalWinningsDecimal = 0.0m;

        // # of games won for all players
        private int accumTotalWinsInt = 0;

        // Generates form object
        public SlotMachinesForm()
        {
            InitializeComponent();
        }

        private void SlotMachinesForm_Load(object sender, EventArgs e)
        {
            // Sets each picture box to Dollarsign image *****
            FruitPictureBox1.Image = Resources.Dollarsign;

            FruitPictureBox2.Image = Resources.Dollarsign;

            FruitPictureBox3.Image = Resources.Dollarsign;
            // ************************************************

            // Calls the ResetLabels() method to reset all labels on the form
            ResetLabels();

            // Disables the ReportFromFileButton
            ReportFromFileButton.Enabled = false;

            // Disables the WriteToFileButton
            WriteToFileButton.Enabled = false;

            // Disables the NewPlayerButton
            NewPlayerButton.Enabled = false;

            // Activates the form
            this.Activate();
        }

        /*
        * private bool ValidInput()
        * 
        * Summary:
        *   Checks input data on the form
        * Inputs:
        *   None
        * Outputs:
        *   True if data is good, false if data does not pass checks
        * Return:
        *   None
        *   
        */
        private bool ValidInput()
        {
            // 1st input - player name selected from combobox
            if (PlayersComboBox.SelectedIndex != -1)
            {
                // 2nd input - mmoney deposited is int
                if ((decimal.TryParse(AmountInsertedTextBox.Text, out decimal amountInserted)))
                {
                    // 2nd input - money deposited must be greater than zero
                    if (amountInserted > 0)
                    {
                        // Returns true if all input is good
                        return true;
                    }
                    else
                    {
                        // Calls set error method to set an error on Amount inserted text box
                        SetError(AmountInsertedTextBox, "Please Enter an Amount Greater than Zero!");

                        // Returns false if amount inserted is negitive
                        return false;
                    }
                }
                else
                {
                    // Calls set error method to set an error on Amount inserted text box
                    SetError(AmountInsertedTextBox, "Please Enter a Number!");

                    // Returns false if anything other than a number is entered in Amount inserted
                    return false;
                }
            }
            else
            {
                // Sets an error on player combo box if a player isnt picked
                SetError(PlayersComboBox, "Pick a Player Please!");

                // Returns false if no player is picked
                return false;
            }
        }

        /*
        * private void GenerateRandomArray()
        * 
        * Summary:
        *   Generates an array containing random numbers
        * Inputs:
        *   None
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void GenerateRandomArray()
        {
            // Min # used in random num generation
            const int MIN_NUMBER_INT = 0;

            // Max # used in random num generation
            const int MAX_NUMBER_INT = 10;

            // Creates random number object
            Random randomNumber = new Random();

            // Loops through each spot in the randomNumberarray
            for (int cv = 0; cv < randomNumbersArray.Length; ++cv)
            {
                // Generates a random number and assigns it at index cv in the array
                randomNumbersArray[cv] = randomNumber.Next(MIN_NUMBER_INT, MAX_NUMBER_INT);
            }
        }

        /*
        * private void Spin(Image[] imageArray, int[] randomArray)
        * 
        * Summary:
        *   Runs once per spin. Checks the random array then assigns images to the picture boxes on the form
        *   based on those values
        * Inputs:
        *   imageArray containing images of fruits to display on the form
        *   randomArray containing 3 random numbers
        * Outputs:
        *   None
        * Return:
        *   None - Void
        *   
        */
        private void Spin(Image[] imageArray, int[] randomArray)
        {
            // Array containing the pictures boxes on the form
            PictureBox[] pictureBoxes = new PictureBox[3] {
                                                            FruitPictureBox1,
                                                            FruitPictureBox2,
                                                            FruitPictureBox3
                                                           };
            // Control variable for do while loop
            int i = 0;

            // Loops through each pictures box on the form. Breaks when all picture boxes have been checked
            do
            {
                // Loops through random number array
                for (int cv = 0; cv < randomArray.Length; ++cv)
                {
                    // Switch statement tests each value in the random number array and assigns
                    // an image based on the number the number in the array.
                    // ex. if the value is 1 the image at position zero would be assigned to the 
                    // picture box on the form.
                    switch (randomArray[cv])
                    {
                        case 1:
                            pictureBoxes[i].Image = imageArray[1];
                            break;
                        case 2:
                            pictureBoxes[i].Image = imageArray[2];
                            break;
                        case 3:
                            pictureBoxes[i].Image = imageArray[3];
                            break;
                        case 4:
                            pictureBoxes[i].Image = imageArray[4];
                            break;
                        case 5:
                            pictureBoxes[i].Image = imageArray[5];
                            break;
                        case 6:
                            pictureBoxes[i].Image = imageArray[6];
                            break;
                        case 7:
                            pictureBoxes[i].Image = imageArray[7];
                            break;
                        case 8:
                            pictureBoxes[i].Image = imageArray[8];
                            break;
                        case 9:
                            pictureBoxes[i].Image = imageArray[9];
                            break;
                        case 10:
                            pictureBoxes[i].Image = imageArray[10];
                            break;
                        default:
                            break;
                    }
                    // Increments the do while loop control variable
                    ++i;
                }
            
            // Breaks loop when all picture boxes have been assigned an image
            } while (i < pictureBoxes.Length - 1);
        }

        /*
        * private decimal CalculatePayout()
        * 
        * Summary:
        *   Checks the random array for matches than calculates the amount won for that spin, counts how many
        *   spins where winners
        * Inputs:
        *   None
        * Outputs:
        *   None
        * Return:
        *   spinTotalWinningsDeimal - contains the total amount won for the spin
        *   
        */
        private decimal CalculatePayout()
        {
            // Value to multiply the amount entered if no images match
            const int MATCH_ZERO_FRUITS_INT = 0;

            // Value to mutliply the amount entered if 2 images match
            const int MATCH_TWO_FRUITS_INT = 2;

            // Value to multiply the amount entered if 3 images match
            const int MATCH_THREE_FRUITS_INT = 3;

            // Holds the total amount won per spin
            decimal spinTotalWinningsDecimal = 0.0m;

            // Holds the amount of matching numbers found in the random array
            // ex 3 matches countMatchInt would be 3
            int countMatchInt = 0;

            // Loops throught the random number arrray checking for a match
            // Compares first value to second then third and so on
            for (int i = 0; i < randomNumbersArray.Length - 1; ++i)
            {
                // Loops throught the random number arrray checking for a match
                for (int j = i + 1; j < randomNumbersArray.Length; ++j)
                {
                    // Increments the countMatchInt if a match is found in the array
                    if (randomNumbersArray[i] == randomNumbersArray[j])
                    {
                        countMatchInt++;
                    }
                }
            }

            // Checks the countMatchInt to determine how much to multiply the amount entered by
            switch (countMatchInt)
            {
                // Zero matches
                case 0:

                    // Calculates total wins for the spin
                    spinTotalWinningsDecimal = Convert.ToInt32(AmountInsertedTextBox.Text) * MATCH_ZERO_FRUITS_INT;

                    break;

                // Two numbers match
                case 1:

                    // Calculates total wins for the spin
                    spinTotalWinningsDecimal = Convert.ToInt32(AmountInsertedTextBox.Text) * MATCH_TWO_FRUITS_INT;

                    // Increments number of games won for later display on form
                    numberOfGamesWonInt++;

                    break;
                
                // All numbers match
                case 3:

                    // Calculates total wins for the spin
                    spinTotalWinningsDecimal = Convert.ToInt32(AmountInsertedTextBox.Text) * MATCH_THREE_FRUITS_INT;

                    // Increments number of games won for later display on form
                    numberOfGamesWonInt++;

                    break;
            }

            // Totals the amount won per round to a running total for each layer
            totalWinningsDecimal += spinTotalWinningsDecimal;

            // Returns total winnings for the spin
            return spinTotalWinningsDecimal;
        }

        /*
        * private void AccumulateWinnings()
        * 
        * Summary:
        *   Accumulates the amount won per spin and the number of winning spins to a total of each for all players
        * Inputs:
        *   None
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void AccumulateWinnings()
        {
            // Accumulates total winnings per player to a running total for all players
            accumTotalWinningsDecimal += totalWinningsDecimal;

            // Accumulates total # of wins per player to a running total of all wins for all players
            accumTotalWinsInt += numberOfGamesWonInt;
        }

        /*
        * private void DisplayPrize()
        * 
        * Summary:
        *   Displays the total amount won per spin and total number of games won per player
        * Inputs:
        *   None
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void DisplayPrize()
        {
            // Displays the payout for each turn on the PrizeAmountLabel
            PrizeAmountLabel.Text = CalculatePayout().ToString("C");

            // Displays the # of wins on the form for each player
            NumOfWinsLabel.Text = numberOfGamesWonInt.ToString();
        }

        /*
        * private void DisplayWinners()
        * 
        * Summary:
        *   Adds the total amount won per player and winning player name to the list box on form
        * Inputs:
        *   None
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void DisplayWinners()
        {
            // Adds the player name and their total amount won to the Winners list box on the form
            WinningsListBox.Items.Add(PlayersComboBox.SelectedItem + " " + totalWinningsDecimal.ToString("C"));
        }

        /*
        * private void WriteToFile(string path, string fileName)
        * 
        * Summary:
        *   Writes the contents of Winnings list box to a text file
        * Inputs:
        *   path - a string containing the path to save the file
        *   filename - a string containg the name the file should be saved as
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void WriteToFile(string path, string fileName)
        {
            // Creates streamWriter object
            StreamWriter outputFile;

            // Enables report from file button
            ReportFromFileButton.Enabled = true;

            // Try block tests for exceptions when writing to file
            try
            {
                // Specifies initial directory for file write
                SlotMachineSaveFileDialog.InitialDirectory = path;

                // Default file extension in save dialog
                SlotMachineSaveFileDialog.DefaultExt = "*.txt";

                // Name of file to write
                SlotMachineSaveFileDialog.FileName = fileName;

                // Filters all files out of save dialog that arnt text files
                SlotMachineSaveFileDialog.Filter = "textfile(*.txt)|*.txt";

                // Tests if user clicked yes on save file dialog
                if (SlotMachineSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Creates the text file for writing
                    outputFile = File.CreateText(SlotMachineSaveFileDialog.FileName);

                    // Holds the entire string from the winners list box
                    string winnerString = "";

                    // Holds the player name
                    string winnerNameString = "";

                    // Holds the winning amount
                    string winningAmountString = "";

                    // Index of the space character in the winners list box
                    int spaceIndexInt = 0;

                    // Loops through each item in the list box
                    for (int i = 0; i < WinningsListBox.Items.Count; ++i)
                    {
                        // Assigns the winners list box entry to a string variable
                        winnerString = WinningsListBox.Items[i].ToString();

                        // Takes an index of the space character in the winnerString
                        spaceIndexInt = winnerString.IndexOf(' ');

                        // Takes a substring containing the winners name
                        winnerNameString = winnerString.Substring(0, spaceIndexInt);

                        // Takes a substring containing the winning amount, removes the space and dollar sign
                        winningAmountString = winnerString.Substring(spaceIndexInt + 2);

                        // Writes to the output file while concatenating a comma between the winners name and prize amount
                        outputFile.WriteLine(winnerNameString + "," + winningAmountString);
                    }

                    // Cloes the output file
                    outputFile.Close();

                    // Clears winner list box
                    WinningsListBox.Items.Clear();

                    // Shows a message box if succesfully written file
                    MessageBox.Show("Winners Succesfully Written to File", "FILE WRITE COMPLETE");
                }
                else
                {
                    // Calls set error method and sets an error on the write to file button if cancel button clicked
                    SetError(WriteToFileButton, "Cancel button clicked, No file saved");
                }
            }
            // Catches exceptions relating to file writing
            catch (Exception ex)
            {
                // Shows an error message if file could not be written 
                MessageBox.Show("File error " + ex.Message, "FILE ERROR");
            }
        }

        /*
        * private void ReadFile(string path)
        * 
        * Summary:
        *   Reads a text file containing a list of winners and amount won per player, then outputs that data
        *   to the form
        * Inputs:
        *   path - a string containing the path to saved the file
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void ReadFile(string path)
        {
            // Creates a StreamReader object
            StreamReader readerFile;

            // Disables write to file button
            WriteToFileButton.Enabled = false;

            // Disables report from file button
            ReportFromFileButton.Enabled = false;

            // Holds the entire winner string containg name and prize amount
            string winnerString = "";

            // Holds the name of the player
            string winnerNameString = "";

            // Holds the amount won by the player
            string winningAmountString = "";

            // Holds the index of the comma 
            int commaIndexInt = 0;

            // Holds the amount of players that have won
            int numOfWinsInt = 0;
            
            // Holds the total number of players
            int numOfPlayersInt = 0;

            // Holds the total amount won by all players
            decimal totalAmountWonDecimal = 0.0m;

            // Holds the avg amount won by players
            decimal avgAmountWonDecimal = 0.0m;

            // Try blocks checks for exceptions during file read
            try
            {
                // Resets the output label
                ReportLabel.ResetText();

                // Sets the path where the file to be read is
                SlotMachineOpenFileDialog.InitialDirectory = path;

                // Adds a .txt extension to the file being read
                SlotMachineOpenFileDialog.DefaultExt = "*.txt";

                // Filters for only text files in open file dialog
                SlotMachineOpenFileDialog.Filter = "textfile(*.txt)|*.txt";

                // Checks if user selects selected yes when opening file
                if (SlotMachineOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Creates a file to read
                    readerFile = File.OpenText(SlotMachineOpenFileDialog.FileName);

                    // Writes initial headings for output on form
                    ReportLabel.Text = "Slot Winners Report by Caleb on " + DateTime.Now.ToShortDateString()
                                       + Environment.NewLine + Environment.NewLine +
                                       "Name" + "Winnings".PadLeft(57) + Environment.NewLine +
                                       " ".PadLeft(40, '*') + Environment.NewLine + Environment.NewLine;

                    // Reads each line in the file until end of file
                    while (!readerFile.EndOfStream)
                    {
                        // Assigns each line to a winnerString variable for later processing
                        winnerString = readerFile.ReadLine();

                        // Assigns an index number to the comma character in winner string
                        commaIndexInt = winnerString.IndexOf(",");

                        // Creates a substring containing the winners name then assigns it to winnerNameString
                        winnerNameString = winnerString.Substring(0, commaIndexInt);

                        // Creates a substring containing the amount won and assigns it to the winningAmountString
                        winningAmountString = winnerString.Substring(commaIndexInt + 1);

                            // Converts winning amount to a decimal then checks if its greater than zero
                            // Greater than zero means a player won
                            if (Convert.ToDecimal(winningAmountString) > 0)
                            {
                                // Converts winningAmountString to a decimal then assigns it to totalAmountWonDecimal
                                totalAmountWonDecimal += Convert.ToDecimal(winningAmountString);

                                // Counts how many players have won
                                numOfWinsInt++;
                            }

                        // Concatenates a dollar sign to the winning amount for later output on form
                        winningAmountString = "$" + winningAmountString;

                        // Outputs the winners name and the amount won on the form
                        ReportLabel.Text += winnerNameString.PadRight(12) + winningAmountString.PadLeft(27) +
                                            Environment.NewLine;

                        // Counts the number of players in the file
                        numOfPlayersInt++;
                    }

                    // Closes the file
                    readerFile.Close();

                    // Try block checks for avg calculation exceptions
                    try
                    {
                        // Calculates the average amount won for players than won 
                        avgAmountWonDecimal = totalAmountWonDecimal / numOfWinsInt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error during average calculation " + e.Message, "AVG CALC ERROR");
                    }

                    // Outputs the number of players, total amount won for all players, and the avg amount won on the form
                    ReportLabel.Text += Environment.NewLine + " ".PadLeft(40, '*') + Environment.NewLine +
                                        "Total # of Players:" + numOfPlayersInt.ToString().PadLeft(20) + Environment.NewLine +
                                        "Total # of Wins:" + totalAmountWonDecimal.ToString("c").PadLeft(23) + Environment.NewLine +
                                        "Average Amount Won:" + avgAmountWonDecimal.ToString("c").PadLeft(20);
                }
            }
            // Catches exceptions relating to reading the file
            catch (Exception ex)
            {
                // Shows an error box containing the exception raised during file read
                MessageBox.Show("File error " + ex.Message, "FILE ERROR");
            }

        }

        /*
        * private bool SearchPlayers()
        * 
        * Summary:
        *   Searches through combo box containing the players names. Checks if the name enetered in the combo box is 
        *   a duplicate
        * Inputs:
        *   None
        * Outputs:
        *   None
        * Return:
        *   Returns true if a duplicate is found
        *   Returns false if no duplicate is found
        *   
        */
        private bool SearchPlayers()
        {
            // Index variable for searching the Players combo box
            int indexInt = 0;

            // Increments through each item in the players combo box
            while (indexInt < PlayersComboBox.Items.Count)
            {
                // Checks if the name at index int is the same as the name entered in the combo box
                if (PlayersComboBox.Text.Trim().ToUpper() == PlayersComboBox.Items[indexInt].ToString().ToUpper())
                {
                    // Returns true if a match is found
                    return true;
                }

                // Increments the index int
                indexInt++;
            }

            // Returns false if no match found
            return false;
        }

        /*
        *         private void SetError(Control c, string e)
        * 
        * Summary:
        *   Sets an error on the input control and dispays an error message from the input string
        * Inputs:
        *   Control c - a control 
        *   string e -  the error message to display next to the form
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void SetError(Control c, string e)
        {
            // Sets an error on the control and string received on method call 
            SlotMachineErrorProvider.SetError(c, e);

            // Selects all in the control received on method call
            c.Select();

            // Focuses the control received in method call
            c.Focus();
        }

        /*
        * private void ClearError(Control c)
        * 
        * Summary:
        *   Clears the error on the control input when method called
        * Inputs:
        *   Control c - a control 
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void ClearError(Control c)
        {
            // Sets an empty error on the control received in method call
            // AKA clears the error
            SlotMachineErrorProvider.SetError(c, string.Empty);
        }

        /*
        * private void ResetLabels()
        * 
        * Summary:
        *   Clears all labels on the form
        * Inputs:
        *   None
        * Outputs:
        *   None
        * Return:
        *   None - void
        *   
        */
        private void ResetLabels()
        {
            // Sets prize amount label to an empty string
            PrizeAmountLabel.Text = string.Empty;

            // Sets number of wins label to an empty string
            NumOfWinsLabel.Text = string.Empty;

            // Sets game over label to an empty string
            GameOverLabel.Text = string.Empty;

            // Sets the report label to an empty string
            ReportLabel.Text = string.Empty;
        }

        /*
        * private void SpinButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Called when spin button clicked on form. Checks if input is valid then continues through a players turn.
        *     When turns are gone displays a game over message and results of the game
        *     
        */
        private void SpinButton_Click(object sender, EventArgs e)
        {
            // Disables ability to change the number of games selected during a turn
            NumOfGamesNumericUpDown.Enabled = false;

            // Disables the ability to change the players name during a turn
            PlayersComboBox.Enabled = false;

            // Disables the add player button during a turn
            AddPlayerButton.Enabled = false;

            // Disables the remove player button during a turn
            RemovePlayerButton.Enabled = false;

            // Enables new player button after one spin is complete
            NewPlayerButton.Enabled = true;

            // Checks if input is valid before contining spin
            if (ValidInput())
            {
                // Checks if player has an turns left
                if (numberOfGamesInt <= NumOfGamesNumericUpDown.Value - 1)
                {
                    // Calls generate random array
                    GenerateRandomArray();

                    // Passes array containing fruit images and random numbers to spin method
                    Spin(fruitImageArray, randomNumbersArray);

                    // Displays prize amount after a spin
                    DisplayPrize();

                    // Accumulates an amount won during a spin
                    AccumulateWinnings();

                    // Counts number of spins
                    numberOfGamesInt++;
                }
                else
                {
                    // Outputs game over text when spins run out
                    GameOverLabel.Text = "Games Are Played... Write To Report File or Choose New Player to Play Again";

                    // Disables spin button
                    SpinButton.Enabled = false;

                    // Displays the total amount won
                    DisplayWinners();

                    // Enables the write to file button
                    WriteToFileButton.Enabled = true;
                }
            }
        }

        /*
        * private void NewPlayerButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Called when new player button is seleted on the form. Resets all variables related to totals, sets form back 
        *     to state when loaded
        *     
        */
        private void NewPlayerButton_Click(object sender, EventArgs e)
        {
            // Zeros the total winnings
            totalWinningsDecimal = 0;

            // Zeros # of games won
            numberOfGamesWonInt = 0;

            // Zeros # of games
            numberOfGamesInt = 0;

            // Enables spin button
            SpinButton.Enabled = true;

            // Enables Player combo box
            PlayersComboBox.Enabled = true;

            // Enables add player button
            AddPlayerButton.Enabled = true;

            // Enables remove player button
            RemovePlayerButton.Enabled = true;

            // Assigns default images to picture boxes on form ***
            FruitPictureBox1.Image = Resources.Dollarsign;

            FruitPictureBox2.Image = Resources.Dollarsign;

            FruitPictureBox3.Image = Resources.Dollarsign;

            // ****************************************************

            // Clears amount inserted for new player
            AmountInsertedTextBox.Clear();

            // Resets all labels on the form
            ResetLabels();

            // Disables new player button
            NewPlayerButton.Enabled = false;
        }

        /*
        * private void PlayersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        * 
        * Summary:
        *     Called when a player is selected from the players combo box. Clears any error if present on the control
        *     
        */
        private void PlayersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clears the errors on player combo box
            ClearError(PlayersComboBox);
        }

        /*
        * private void AmountInsertedTextBox_TextChanged(object sender, EventArgs e)
        * 
        * Summary:
        *     Called when text is typed in the text box. Clears any error if present on the control
        *     
        */
        private void AmountInsertedTextBox_TextChanged(object sender, EventArgs e)
        {
            // Clears error on amount inserted textbox
            ClearError(AmountInsertedTextBox);
        }

        /*
        * private void AddPlayerButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Called on add player button click. Clears an error if present on the control.
        *     Adds a players name to the players combo box if it is not already in it
        *     
        */
        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            // Clears error on add player button
            ClearError(AddPlayerButton);

            // Checks if data is entered in players combo box
            if (PlayersComboBox.Text != string.Empty)
            {
                // If data entered doesnt match data already in combo box continue
                if (!SearchPlayers())
                {
                    // Inserts new name at positon zero in combo box
                    PlayersComboBox.Items.Insert(0, PlayersComboBox.Text.Trim());

                    // Resets the text entered in combo box
                    PlayersComboBox.ResetText();
                }
                else
                {
                    // Sets an error if a duplicate is found in the combo box
                    SetError(PlayersComboBox, "Duplicate Name - Try Again!");
                }
            }
            else
            {
                // Sets an error if a name isnt entered before clicking add player
                SetError(AddPlayerButton, "Enter a Name before Clicking Add Player!");
            }
        }

        /*
        * private void RemovePlayerButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Called on remove player button click. Clears an error if present on the control
        *     then removes the players name selected in the combo box
        *     
        */
        private void RemovePlayerButton_Click(object sender, EventArgs e)
        {
            // Clears error on Remove player button
            ClearError(RemovePlayerButton);

            // Checks if a player is seleted in combo box
            if (PlayersComboBox.SelectedIndex > -1)
            {
                // Removes the item selected in the combo box
                PlayersComboBox.Items.RemoveAt(PlayersComboBox.SelectedIndex);
            }
            else
            {
                // If a player isnt selected in the combo box shows an error
                SetError(RemovePlayerButton, "Select a Player before Clicking Remove!");
            }
        }

        /*
        * private void WriteToFileButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Called on write to file button click. Clears an error if present on the control
        *     then calls write to file method
        *     
        */
        private void WriteToFileButton_Click(object sender, EventArgs e)
        {
            // Clears the error on Write to file button
            ClearError(WriteToFileButton);

            // Calls write to file method with directory for output and file name passed
            WriteToFile(Environment.CurrentDirectory, "Winners");
        }

        /*
        * private void ReportFromFileButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Runs on report from file button click. Clears an error if present on the control
        *     thenm calls read file method
        *     
        */
        private void ReportFromFileButton_Click(object sender, EventArgs e)
        {
            // Clears the error on report from file button
            ClearError(ReportFromFileButton);

            // Calls the read file method with directory to read from passed
            ReadFile(Environment.CurrentDirectory);
        }

        /*
        * private void TestButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Called on test button click. Assigns test values to each input on the form
        *     
        */
        private void TestButton_Click(object sender, EventArgs e)
        {
            // Sets the default player to player at index 1
            PlayersComboBox.SelectedIndex = 1;

            // Sets default amount of games to 3
            NumOfGamesNumericUpDown.Value = 3;

            // Sets default amount entered to $100
            AmountInsertedTextBox.Text = "100";
        }

        /*
        * private void ExitButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Called on exit button click. Closes the form
        *     
        */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }
    }
}