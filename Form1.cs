namespace CS311_Project2_KEL
{
    public partial class Form1 : Form
    {
        const int dieSides = 6;
        int roll;
        Random randOne = new Random();
        float balance = 100;

        public Form1()
        {
            InitializeComponent();
        }

        /*This method randomly rolls two dice. Outcome of dice depends on certain
         * roll combinations. */
        private void calculate_score()
        {
            /*Instantiate dice */
            int die1 = 0;
            int die2 = 0;

            /*Creates a float data type to store the user's bet. */
            float playerBet = float.Parse(txtBet.Text);
            
            die1 = randOne.Next(dieSides) + 1;
            die2 = randOne.Next(dieSides) + 1;
            
            /*Roll to store random dice rolls. */
            roll = die1 + die2;

            lblDieOne.Text = "Die One roll is: " + die1;
            lblDieTwo.Text = "Die Two roll is: " + die2;

            /*Statements to determine result of dice rolls (win, lose, or point) */
            if (roll == 7 || roll == 11)
            {
                lblOutcome.Text = "Outcome: You won!";
                this.balance = this.balance + playerBet;
                lblBalance.Text = "Balance: " + this.balance.ToString("C");
            }
            else if (roll == 2 || roll == 3 || roll == 12)
            {
                lblOutcome.Text = "Outcome: You lost!";
                this.balance = this.balance - playerBet;
                lblBalance.Text = "Balance: " + this.balance.ToString("C");
            }
            else
            {
                lblOutcome.Text = "Outcome: Point is " + roll;
                lblBalance.Text = "Balance: " + this.balance.ToString("C"); 
            }

            /*Statement to determine if player has enough money to keep playing. */
            if (playerBet > this.balance || this.balance - playerBet < 0)
            {
                MessageBox.Show("You don't have enough money! Unable to roll again.");
            }
            

        }//end calculate_score

        /* Click action calls calculate_score method to play the game. */
        private void btnRoll_Click(object sender, EventArgs e)
        {
            calculate_score();
        }
    }//end class

}//end namespace