using System.Data;

namespace CalculatorProj
{
    public partial class Calculator : Form
    {
        Dictionary<string, double> variables = new Dictionary<string, double>();

        private string expression = string.Empty;
        public Calculator()
        {
            InitializeComponent();
            DisplayInput();
        }

        private string ProcessExpression(string expression)
        {
            foreach (var variable in variables)
                expression = expression.Replace(variable.Key, variable.Value.ToString());

            return expression;
        }

        private void SetVariable(string variableName)
        {
            string variableValue = CalculateExpression();

            variables[variableName] = double.Parse(variableValue);

            expression = string.Empty;
        }

        private void DisplayInput()
        {
            InputLabel.Text = expression;
        }

        private void DisplayOutput(string output)
        {
            OutputLabel.Text = output;
        }

        private void AddToExpression(string item)
        {
            expression += item;
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

        private string CalculateExpression()
        {
            string processedExpression = ProcessExpression(expression);
            object result = new DataTable().Compute(expression, null);
            return Convert.ToString(result);
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            AddToExpression("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            AddToExpression("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            AddToExpression("3");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            AddToExpression("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            AddToExpression("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            AddToExpression("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            AddToExpression("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            AddToExpression("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            AddToExpression("9");
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            AddToExpression("0");
        }

        private void DPointButton_Click(object sender, EventArgs e)
        {
            AddToExpression(".");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddToExpression("+");
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            AddToExpression("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            AddToExpression("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            AddToExpression("/");
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            AddToExpression("%");
        }

        private void ExponentButton_Click(object sender, EventArgs e)
        {
            AddToExpression("^");
        }

        private void LeftBracketButton_Click(object sender, EventArgs e)
        {
            AddToExpression("(");
        }

        private void RightBracketButton_Click(object sender, EventArgs e)
        {
            AddToExpression(")");
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string result = CalculateExpression();
                DisplayOutput(result);
                InputLabel.Text = null;
                expression = "";
            }
            catch { Exception ex; DisplayOutput("ERR"); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            expression = expression[..^1];
            DisplayInput();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            expression = string.Empty;
            DisplayInput();
            DisplayOutput(null);
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VarA_Button_Click(object sender, EventArgs e)
        {
            if (expression != string.Empty) SetVariable("A");
            else AddToExpression("A");
            InputLabel.Text = null;
        }

        private void VarB_Button_Click(object sender, EventArgs e)
        {
            if (expression != string.Empty) SetVariable("B");
            else AddToExpression("B");
            InputLabel.Text = null;
        }

        private void VarC_Button_Click(object sender, EventArgs e)
        {
            if (expression != string.Empty) SetVariable("C");
            else AddToExpression("C");
            InputLabel.Text = null;
        }

        private void VarD_Button_Click(object sender, EventArgs e)
        {
            if (expression != string.Empty) SetVariable("D");
            else AddToExpression("D");
            InputLabel.Text = null;
        }

        private void VarE_Button_Click(object sender, EventArgs e)
        {
            if (expression != string.Empty) SetVariable("E");
            else AddToExpression("E");
            InputLabel.Text = null;
        }
    }
}
