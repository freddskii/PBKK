namespace CalculatorApp;

public partial class Form1 : Form
{
    double firstNumber = 0;
    double secondNumber = 0;
    double result = 0;
    string operation = "";

    public Form1()
    {
        InitializeComponent();
        this.KeyPreview = true;
        this.KeyDown += Form1_KeyDown;
    }

    private void NumberButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (txtDisplay.Text == "0")
            txtDisplay.Text = button.Text;
        else
            txtDisplay.Text += button.Text;
    }

    private void OperatorButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (!string.IsNullOrWhiteSpace(txtDisplay.Text))
        {
            firstNumber = double.Parse(txtDisplay.Text);
        }
        operation = button.Text;
        lblOperation.Text = firstNumber.ToString() + " " + operation;
        txtDisplay.Clear();
    }

    private void btnEquals_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtDisplay.Text))
                return;

            secondNumber = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "−":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                case "/":
                    if (secondNumber == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    result = firstNumber / secondNumber;
                    break;
                default:
                    result = secondNumber;
                    break;
            }
            lblOperation.Text = firstNumber.ToString() + " " + operation + " " + secondNumber.ToString() + " =";
            txtDisplay.Text = result.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        firstNumber = 0;
        secondNumber = 0;
        result = 0;
        operation = "";
        txtDisplay.Text = "0";
        lblOperation.Text = "";
    }

    private void btnDecimal_Click(object sender, EventArgs e)
    {
        if (!txtDisplay.Text.Contains("."))
            txtDisplay.Text += ".";
    }

    private void Form1_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
        {
            string digit = ((int)(e.KeyCode - Keys.D0)).ToString();
            SimulateNumberClick(digit);
            e.Handled = true;
        }
        else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
        {
            string digit = ((int)(e.KeyCode - Keys.NumPad0)).ToString();
            SimulateNumberClick(digit);
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Add || (e.KeyCode == Keys.Oemplus && e.Shift))
        {
            btnPlus.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
        {
            btnMinus.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Multiply)
        {
            btnMultiply.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
        {
            btnDivide.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Oemplus)
        {
            btnEquals.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
        {
            btnDecimal.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
        {
            btnClear.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Back)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
            e.Handled = true;
        }
    }

    private void SimulateNumberClick(string digit)
    {
        switch (digit)
        {
            case "0": btn0.PerformClick(); break;
            case "1": btn1.PerformClick(); break;
            case "2": btn2.PerformClick(); break;
            case "3": btn3.PerformClick(); break;
            case "4": btn4.PerformClick(); break;
            case "5": btn5.PerformClick(); break;
            case "6": btn6.PerformClick(); break;
            case "7": btn7.PerformClick(); break;
            case "8": btn8.PerformClick(); break;
            case "9": btn9.PerformClick(); break;
        }
    }
}