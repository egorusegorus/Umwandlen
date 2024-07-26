using System.Diagnostics.Eventing.Reader;

namespace Umwandlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        bool[] RadioG1 = { false, false, false, false, false, false };
        bool[] RadioG2 = { false, false, false, false, false, false };
        double multiplikator = 0;
        double div = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string test1, test2;
            double helpvar = 0;

            test1 = textBox1.Text;
            test2 = textBox2.Text;

            if (test1.Equals(test2) && test1 != "")
            {

                label1.Text = "Ein Textfeld muss leer sein!";
            }
            else if (test1.Equals("") && test2.Equals(""))
            {
                label1.Text = "Ein Textfeld muss voll sein!";
            }
            else if (test1 != "" && test2 == "")
            {
                G1toArr();
                G2toArr();
                helpvar = Convert.ToDouble(test1);
                helpvar = helpvar / div;
                helpvar = helpvar * multiplikator;
                textBox2.Text = Convert.ToString(helpvar);
            }
            else if (test1 == "" && test2 != "")
            {

                G1toArr();
                G2toArr();
                helpvar = Convert.ToDouble(test2);
                helpvar = helpvar / multiplikator;
                helpvar = helpvar * div;
                textBox1.Text = Convert.ToString(helpvar);

            }

            if (RadioG1[0]==false&& RadioG1[1] == false && RadioG1[2] == false &&RadioG1[3] == false && RadioG1[4] == false && RadioG1[5] == false)
            {
                label1.Text = "Bitte Einheiten eingeben";
            }
            if (RadioG2[0] == false && RadioG2[1] == false && RadioG2[2] == false && RadioG2[3] == false && RadioG2[4] == false && RadioG2[5] == false)
            {
                label1.Text = "Bitte Einheiten eingeben";
            }
        }
        private void G2toArr()
        {
            if (radioButton12.Checked)
            {
                RadioG2[0] = true;
                RadioG2[1] = false;
                RadioG2[2] = false;
                RadioG2[3] = false;
                RadioG2[4] = false;
                RadioG2[5] = false;
                div = 1;
            }
            if (radioButton11.Checked)
            {
                RadioG2[0] = false;
                RadioG2[1] = true;
                RadioG2[2] = false;
                RadioG2[3] = false;
                RadioG2[4] = false;
                RadioG2[5] = false;
                div = 1024;
            }

            if (radioButton10.Checked)
            {
                RadioG2[0] = false;
                RadioG2[1] = false;
                RadioG2[2] = true;
                RadioG2[3] = false;
                RadioG2[4] = false;
                RadioG2[5] = false;
                div = 1024 * 1024;
            }
            if (radioButton9.Checked)
            {
                RadioG2[0] = false;
                RadioG2[1] = false;
                RadioG2[2] = false;
                RadioG2[3] = true;
                RadioG2[4] = false;
                RadioG2[5] = false;
                div = 1024 * 1024 * 1024;
            }
            if (radioButton8.Checked)
            {
                RadioG2[0] = false;
                RadioG2[1] = false;
                RadioG2[2] = false;
                RadioG2[3] = false;
                RadioG2[4] = true;
                RadioG2[5] = false;
                div = 1024.0 * 1024.0 * 1024.0 * 1024.0;
            }
            if (radioButton7.Checked)
            {
                RadioG2[0] = false;
                RadioG2[1] = false;
                RadioG2[2] = false;
                RadioG2[3] = false;
                RadioG2[4] = false;
                RadioG2[5] = true;
                div = 1024.0 * 1024.0 * 1024.0 * 1024.0 * 1024.0;
            }
        }
        private void G1toArr()
        {
            if (radioButton1.Checked)
            {
                RadioG1[0] = true;
                RadioG1[1] = false;
                RadioG1[2] = false;
                RadioG1[3] = false;
                RadioG1[4] = false;
                RadioG1[5] = false;
                multiplikator = 1;
            }
            if (radioButton2.Checked)
            {
                RadioG1[0] = false;
                RadioG1[1] = true;
                RadioG1[2] = false;
                RadioG1[3] = false;
                RadioG1[4] = false;
                RadioG1[5] = false;
                multiplikator = 1000;
            }

            if (radioButton3.Checked)
            {
                RadioG1[0] = false;
                RadioG1[1] = false;
                RadioG1[2] = true;
                RadioG1[3] = false;
                RadioG1[4] = false;
                RadioG1[5] = false;
                multiplikator = 1000000;
            }
            if (radioButton4.Checked)
            {
                RadioG1[0] = false;
                RadioG1[1] = false;
                RadioG1[2] = false;
                RadioG1[3] = true;
                RadioG1[4] = false;
                RadioG1[5] = false;
                multiplikator = 1000000000;
            }
            if (radioButton5.Checked)
            {
                RadioG1[0] = false;
                RadioG1[1] = false;
                RadioG1[2] = false;
                RadioG1[3] = false;
                RadioG1[4] = true;
                RadioG1[5] = false;
                multiplikator = 1000000000000;
            }
            if (radioButton6.Checked)
            {
                RadioG1[0] = false;
                RadioG1[1] = false;
                RadioG1[2] = false;
                RadioG1[3] = false;
                RadioG1[4] = false;
                RadioG1[5] = true;
                multiplikator = 1000000000000000;
            }
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
