namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //A butten click action that, on click it show the calculated value to the user
        private void button1_Click(object sender, EventArgs e)
        {
            //try mothod to allow user try a function and send an exception if they netr invalid value
            try
            {
                //if else statement - if statemnt that displayes a mssages when if the user doesn't neter any value
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a value");
                }
                //else statement that takes a value string value from a user and conver it to a number.
                // the system then takes the value and calculate it to diffrent value
                else
                {
                    // Int cecuse to accept intige valuse form the user
                    int c = Convert.ToInt32(textBox1.Text);

                    // Double function to calculate the calculate the value of celcicius to Farenhite
                    double f = ((c * 9) / 5) + 32;

                    //Display the calulated value of farenhite
                    textBox2.Text = f.ToString();


                    //A doube defineing if there are more than 3 decimals to dispay only 3 or o=round it to three numbers
                    double output = Math.Round(f, 3);
                }
            }

            //Catch exception to catch the cepetion if user enetr invalid value
            catch (Exception)
            {
                MessageBox.Show("you have enterd invalid value, please enter a number");
            }

        }
    }
}