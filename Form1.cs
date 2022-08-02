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
            //if else statement - if statemnt that displayes a mssages when if the user doesn't neter any value
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a value");
            }
            //else statement that takes a value string value from a user and conver it to a number.
            // the system then takes the value and calculate it to diffrent value
            else
            {
                float c = Convert.ToInt32(textBox1.Text);
                float f = ((c * 9) / 5) + 32;
                textBox2.Text = f.ToString();
            }

        }
    }
}