
using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();

            btnMax.Click += btnMax_Click;
            btnPower.Click += btnPower_Click;
            btnIsPrime.Click += btnIsPrime_Click;
            btnFactorial.Click += btnFactorial_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // 1. MAX: İki sayıdan büyük olanı bulur.
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out double n1) ||
                !double.TryParse(txtNum2.Text, out double n2))
            {
                ShowError("Please enter valid numbers.");
                return;
            }

            double result = Max(n1, n2);
            lblResult.Text = "Result: " + result;
        }

        private double Max(double a, double b)
        {
            return Math.Max(a, b);
        }

        // 2. POWER: İlk sayının ikinci sayı kuvvetini hesaplar.
        private void btnPower_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out double n1) ||
                !double.TryParse(txtNum2.Text, out double n2))
            {
                ShowError("Please enter valid numbers.");
                return;
            }

            double result = Power(n1, n2);
            lblResult.Text = "Result: " + result;
        }

        private double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        // 3. ISPRIME: İlk sayının asal olup olmadığını kontrol eder.
        private void btnIsPrime_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum1.Text, out int n))
            {
                ShowError("Please enter a valid integer in the first box.");
                return;
            }

            bool result = IsPrime(n);

            lblResult.Text = result
                ? "Result: Prime"
                : "Result: Not prime";
        }

        private bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // 4. FACTORIAL: İlk sayının faktöriyelini hesaplar.
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum1.Text, out int n) ||
                n < 0 || n > 20)
            {
                ShowError("Enter an integer between 0 and 20.");
                return;
            }

            long result = Factorial(n);
            lblResult.Text = "Result: " + result;
        }

        private long Factorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        // Hatalı girişlerde uygulamanın kapanmasını önler.
        private void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Input Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
