namespace CalculatorProj
{
    public partial class Calculator : Form
    {

        private string Number;
        public string TheNumber { get { return Number; } set { Number = value; } }
        private string? Operator = null;
        public string? TheOperator { get {  return Operator; } set { Operator = value; } }
        public string input;
        public Calculator()
        {
            InitializeComponent();
            DisplayInput();
        }

        private void DisplayInput()
        {
            InputLabel.Text = input;
        }
        private void AddToNumber(char item)
        {
            switch (item)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    TheNumber += ' ';
                    input += item;
                    break;
                default:
                    TheNumber += item;
                    input += item;
                    break;
            }
            DisplayInput();
        }
        private void OneButton_Click(object sender, EventArgs e)
        {
            AddToNumber('1');
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            AddToNumber('2');
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            AddToNumber('3');
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            AddToNumber('4');
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            AddToNumber('5');
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            AddToNumber('6');
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            AddToNumber('7');
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            AddToNumber('8');
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            AddToNumber('9');
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            AddToNumber('0');
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddToNumber('+');
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            AddToNumber('-');
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            AddToNumber('*');
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            AddToNumber('/');
        }
    }
}
