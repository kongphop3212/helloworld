namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // get input form textbox
            string input = textBoxC.Text;
           
            // convert to f
            // f = c × 9/5 + 32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            // show input to textbox
            textBoxF.Text = f.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}