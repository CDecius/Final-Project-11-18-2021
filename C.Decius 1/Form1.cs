using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.Decius_1
{
    public partial class Form1 : Form
    {
        int num1, num2;
        Image[] smile = new Image[5];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            string str = textBox1.Text;
            if (int.TryParse(str, out result))
            {
                MessageBox.Show("This is a valid integer");

            }
            else
            {
                MessageBox.Show("This is NOT an integer, please try again");
            }
            try
            {
                result = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("CATCH - not a valid integer");
            }
            if (result > 10 || result < 1)
            {
                MessageBox.Show("Please enter a number between 1-10");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int randomNumber;
            Random random = new Random();
            randomNumber = random.Next(1, 365);
            textBox2.Text = randomNumber.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
       
    
        private void button3_Click(object sender, EventArgs e)
        {
            smile[0] = Image.FromFile("smile1.jpg");
            smile[1] = Image.FromFile("smile2.jpg");
            smile[2] = Image.FromFile("smile3.jpg");
            smile[3] = Image.FromFile("smile4.jpg");
            smile[4] = Image.FromFile("smile5.jpg");
            int randomNumber;
            Random random = new Random();
            randomNumber = random.Next(0, 4);
            pictureBox1.Image = smile[randomNumber];
            int i = 0;
            while (i < randomNumber)
            {
                MessageBox.Show("Smile, everything is going to be ok");
                // Set the PictureBox image property to this image.
                // ... Then, adjust its height and width properties.
                pictureBox1.Image = smile[i];
                i++;
            }



        }
   
    }
    
}
