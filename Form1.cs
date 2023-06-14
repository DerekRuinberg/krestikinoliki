using System;
using System.Windows.Forms;

namespace KrestikiNoliki
{
    public partial class Form1 : Form
    {
        bool turnX = true;
        Button Sender;
        int q = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Sender = (Button)sender;
            if (Sender.Text == "")
            {
                if (turnX == true)
                {
                    Sender.Text = "X";
                }
                if (turnX == false)
                {
                    Sender.Text = "O";
                }
                turnX = !turnX;
                Win(Sender);
                q++;
            }
        }
        void Win(Button SenderW)
        {
            if(button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text) 
            {
               MessageBox.Show("Победили " + SenderW.Text);
               Application.Restart();       
            }
            if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                MessageBox.Show("Победили " + SenderW.Text);
                Application.Restart();
            }
            if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                MessageBox.Show("Победили " + SenderW.Text);
                Application.Restart();
            }
            if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                MessageBox.Show("Победили " + SenderW.Text);
                Application.Restart();
            }
            if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                MessageBox.Show("Победили " + SenderW.Text);
                Application.Restart();
            }
            if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                MessageBox.Show("Победили " + SenderW.Text);
                Application.Restart();
            }
            if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                MessageBox.Show("Победили " + SenderW.Text);
                Application.Restart();
            }
            if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                MessageBox.Show("Победили " + SenderW.Text);
                Application.Restart();
            }
            if (q == 8)
            {
                MessageBox.Show("Ничья!");
                Application.Restart();
            }

                
        }
    }
}
