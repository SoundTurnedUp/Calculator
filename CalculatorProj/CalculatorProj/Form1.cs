using System.Data;
using System.Linq.Expressions;

namespace CalculatorProj
{
    public partial class Calculator : Form
    {

        private string Number;
        public Calculator()
        {
            InitializeComponent();
            DisplayInput();
        }

        private void DisplayInput()
        {
            InputLabel.Text = Number;
        }
        private void DisplayOutput(string output)
        {
            OutputLabel.Text = output;
        }
        private void AddToNumber(char item)
        {
            Number += item;
            DisplayInput();
        }
        static bool ValidateInput(string input)
        {
            if (input != null)
            {
                int brackets = 0;
                foreach (char c in input)
                {
                    if (c == '(') brackets++;
                    if (c == ')') brackets--;
                    if (brackets < 0) return false;
                }
                return brackets == 0;
            }
            return false;
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
        private void DPointButton_Click(object sender, EventArgs e)
        {
            AddToNumber('.');
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

        private void LeftBracketButton_Click(object sender, EventArgs e)
        {
            AddToNumber('(');
        }

        private void RightBracketButton_Click(object sender, EventArgs e)
        {
            AddToNumber(')');
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput(Number))
                {
                    object result = new DataTable().Compute(Number, null);
                    InputLabel.Text = null;
                    Number = "";
                    DisplayOutput(Convert.ToString(result));
                }
            }
            catch { Exception ex; }
        }


        private void OffButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Number = Number[..^1];
            DisplayInput();
        }
    }
}
