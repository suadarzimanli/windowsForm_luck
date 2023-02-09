using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        // out ile ref farki -- ref kullandigimizda deger atamamiz gerekiyor amma out kullanirsak boyle bir zorunluluk yok

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            string message = Play(out number1, out number2);
            MessageBox.Show(message);
            lblNumber1.Text = number1.ToString();
            lblNumber2.Text = number2.ToString();
        }

        Random random = new Random();

        public string Play(out int number1, out int number2)
        {
            string message;
            number1 = random.Next(1, 7);
            number2 = random.Next(1, 7);

            if (number1 == number2)
            {
                message = "You won!";

            }
            else
            {
                message = "You lost!";
            }

            return message;
        }
    }
}
