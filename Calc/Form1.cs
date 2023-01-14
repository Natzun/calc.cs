using Microsoft.VisualBasic.Logging;

namespace Calc {
    public partial class Form1 : Form {
        string valorPassado = "0";
        string operacao = null;
        bool dotLock = false;
        public Form1() {
            InitializeComponent();
        }

        // Buttons Begin
        private static void log(string msg) {
            System.Diagnostics.Debug.WriteLine(msg);
        }

        private void btn6_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btn5_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btn4_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btn7_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btn8_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btn9_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btnDIV_Click(object sender, EventArgs e) {
            if (operacao != null) {
                operacao = "/";
                displayFunction.Text = $"[{operacao}] {valorPassado}";
            } else {
                valorPassado = display.Text;
                operacao = "/";
                display.Text = "0";
                displayFunction.Text = $"[{operacao}] {valorPassado}";
            }
        }

        private void btnMUL_Click(object sender, EventArgs e) {
            if (operacao != null) {
                operacao = "*";
                displayFunction.Text = $"[{operacao}] {valorPassado}";
            } else {
                valorPassado = display.Text;
                operacao = "*";
                display.Text = "0";
                displayFunction.Text = $"[{operacao}] {valorPassado}";
            }
        }

        private void btn1_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btn2_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btn3_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btnMIN_Click(object sender, EventArgs e) {
            if (operacao != null) {
                operacao = "-";
                displayFunction.Text = $"[{operacao}] {valorPassado}";
            } else {
                valorPassado = display.Text;
                operacao = "-";
                display.Text = "0";
                displayFunction.Text = $"[{operacao}] {valorPassado}";
            }
        }

        private void btnML_Click(object sender, EventArgs e) {
            log("asdasdasdasdasdadsadasda");
        }

        private void btn0_Click(object sender, EventArgs e) {
            if (display.Text == "0") display.Text = (sender as Button).Text; else display.Text += (sender as Button).Text;
        }

        private void btnDT_Click(object sender, EventArgs e) {
            if (!dotLock) {
                display.Text += (sender as Button).Text;
                dotLock = true;
            }
        }

        private void btnPLUS_Click(object sender, EventArgs e) {
            if (operacao != null) {
                operacao = "+";
                displayFunction.Text = $"[{operacao}] {valorPassado}";
            } else {
                valorPassado = display.Text;
                operacao = "+";
                display.Text = "0";
                displayFunction.Text = $"[{operacao}] {valorPassado}";
            }
        }

        private void btnBK_Click(object sender, EventArgs e) {
        }

        private void btnEQ_Click(object sender, EventArgs e) {
            switch (operacao) {
                case "+":
                    display.Text = (float.Parse(valorPassado) + float.Parse(display.Text)).ToString();
                    break;

                case "-":
                    display.Text = (float.Parse(valorPassado) - float.Parse(display.Text)).ToString();
                    break;

                case "*":
                    display.Text = (float.Parse(valorPassado) * float.Parse(display.Text)).ToString();
                    break;

                case "/":
                    display.Text = (float.Parse(valorPassado) / float.Parse(display.Text)).ToString();
                    break;
            }
        }

        private void btnGIT_Click(object sender, EventArgs e) {
        }

        private void btnC_Click(object sender, EventArgs e) {
            display.Clear();
            displayFunction.Text = "";
            valorPassado = "0";
            operacao = null;
            dotLock = false;
        }

        // Buttons Final



        private void display_TextChanged(object sender, EventArgs e) {

        }
    }
}