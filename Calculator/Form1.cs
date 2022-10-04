using Microsoft.VisualBasic;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operation;
        string number1;
        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "1";
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "2";
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "3";
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + "9";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (txt_result.Text != "")
            {
                number1 = txt_result.Text;
            }
            operation = "plus";
            txt_result.Clear();
            txt_result.Focus();
        }
        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (txt_result.Text != "")
            {
                number1 = txt_result.Text;
            }
            operation = "minus";
            txt_result.Clear();
            txt_result.Focus();
        }
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (txt_result.Text != "")
            {
                number1 = txt_result.Text;
            }
            operation = "multiply";
            txt_result.Clear();
            txt_result.Focus();
        }
        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (txt_result.Text != "")
            {
                number1 = txt_result.Text;
            }
            operation = "divide";
            txt_result.Clear();
            txt_result.Focus();
        }
        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "plus":
                        txt_result.Text = Convert.ToString(float.Parse(number1) + float.Parse(txt_result.Text));
                        break;
                    case "minus":
                        txt_result.Text = Convert.ToString(float.Parse(number1) - float.Parse(txt_result.Text));
                        break;
                    case "multiply":
                        txt_result.Text = Convert.ToString(float.Parse(number1) * float.Parse(txt_result.Text));
                        break;
                    case "divide":
                        if (float.Parse(txt_result.Text) == 0)
                        {
                            MessageBox.Show("Undefined");
                        }
                        else
                        {
                            txt_result.Text = Convert.ToString(float.Parse(number1) / float.Parse(txt_result.Text));

                        }
                        break;
                    default:
                        break;
                }
                number1 = "0";
                operation = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_result.Text = "";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
            number1 = "0";
            operation = "";
        }



        private void btn_dec_Click(object sender, EventArgs e)
        {
            try
            {
                bool isBinary = CheckBinary(txt_result.Text);
                if (isBinary == true)
                {
                    txt_result.Text = Convert.ToString(Convert.ToString(Convert.ToInt32(txt_result.Text, 2).ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_result.Text = "";
            }
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            try
            {
                txt_result.Text = decimalToLatLong(decimal.Parse(txt_result.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_result.Text = "";
            }
        }

        private void btn_bin_Click(object sender, EventArgs e)
        {
            try
            {
                txt_result.Text = Convert.ToString(Convert.ToString(Convert.ToInt64(txt_result.Text), 2));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_result.Text = "";
            }
        }


        static bool CheckBinary(string str)
        {
            foreach (char c in str)
            {
                if (c != '0' && c != '1')
                    return false;
            }

            return true;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        string decimalToLatLong(decimal dec)
        {
            int d = (int)dec;
            int m = (int)((dec - d) * 60);
            decimal s = ((((dec - d) * 60) - m) * 60);

            return d + "° " + m + "' " + s + "\"";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (!txt_result.Text.Contains('.'))
            {
                txt_result.Text = txt_result.Text + ".";
            }
        }
    }
}