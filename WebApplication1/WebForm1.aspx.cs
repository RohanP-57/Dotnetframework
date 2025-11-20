using System;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double result = 0;
            string operation = DropDownList1.SelectedItem.Text;

            switch (operation)
            {
                case "Addition":
                    result = num1 + num2;
                    break;

                case "Subtraction":
                    result = num1 - num2;
                    break;

                case "Multiplication":
                    result = num1 * num2;
                    break;

                case "Division":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        LabelResult.Text = "Cannot divide by zero!";
                    return;
            }

            LabelResult.Text = "Result: " + result.ToString();
        }
    }
}
